using GPOI_AppGrafi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Editing;
using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace GPOI_AppGrafi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Neo4jController : IDisposable
    {
        private readonly IDriver _driver;
        public Neo4jController()
        {
            _driver = GraphDatabase.Driver("neo4j+s://a7478851.databases.neo4j.io", AuthTokens.Basic("neo4j", "LwPccV4DygL2L8XFtxUsjn_0RCA88wGMh2857QfWHHc"));//user and password
        }
        
        public async Task CreateNode(Node node)
        { 
            var query = @"CREATE (node:Node {id:$id, name:$name}) RETURN node";

            await using var session = _driver.AsyncSession(configBuilder => configBuilder.WithDatabase("neo4j"));
            try
            {
                var writeResults = await session.ExecuteWriteAsync(async tx =>
                {
                    string id = node.id.ToString();
                    string name = node.name;
                    var result = await tx.RunAsync(query, new { id, name });
                    return await result.ToListAsync();
                });
            }
            catch (Neo4jException ex)
            {
                Console.WriteLine($"{query} - {ex}");
                throw;
            }
        }
        public async Task CreateRelationship(Node node1, Node node2)
        {

            var query = @"MERGE ("+node1.name+ ":Node {id:$id1, name:$name1})" +
            "MERGE ("+node2.name+":Node {id:$id2, name:$name2})" +
            "MERGE ("+node1.name+ ")-[r:KNOWS]->("+node1.name+")" +
            "RETURN "+node1.name+ ", "+node1.name+"";

            await using var session = _driver.AsyncSession(configBuilder => configBuilder.WithDatabase("neo4j"));
            try
            {
                var writeResults = await session.ExecuteWriteAsync(async tx =>
                {
                    string id1 = node1.id.ToString();
                    string id2 = node2.id.ToString();
                    string name1 = node1.name;
                    string name2 = node2.name;

                    var result = await tx.RunAsync(query, new { id1, id2, name1, name2 });
                    return await result.ToListAsync();
                });
            }
            catch (Neo4jException ex)
            {
                Console.WriteLine($"{query} - {ex}");
                throw;
            }
        }
        
        public async Task DeleteNode(Node node)
        {
            

            var query = @"MATCH ("+node.name+":Node {id : $id, name : $name}) DELETE "+ node.name+"";

            await using var session = _driver.AsyncSession(configBuilder => configBuilder.WithDatabase("neo4j"));
            try
            {
                var writeResults = await session.ExecuteWriteAsync(async tx =>
                {
                    string name = node.name;
                    int id = node.id;
                    var result = await tx.RunAsync(query, new { id, name });
                    return await result.ToListAsync();
                });
            }
            catch (Neo4jException ex)
            {
                Console.WriteLine($"{query} - {ex}");
                throw;
            }
        }

        public void Dispose()
        {
            _driver.Dispose();
        }
    }
}
