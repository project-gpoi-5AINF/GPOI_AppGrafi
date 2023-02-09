using GPOI_AppGrafi.Models;
using Microsoft.AspNetCore.Mvc;
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
            string name = node.name;
            int id = node.id;

            var query = @"CREATE ($name:Node {id = $id}, {name = $name})";

            await using var session = _driver.AsyncSession(configBuilder => configBuilder.WithDatabase("ProgettoGpoi"));
            try
            {
                var writeResults = await session.ExecuteWriteAsync(async tx =>
                {
                    var result = await tx.RunAsync(query, new { node });
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
            string name1 = node1.name;
            string name2 = node2.name;
            int id1 = node1.id;
            int id2 = node2.id;

            var query = @"
            MERGE ($name1:Node {id : $id1},{name : $name1})
            MERGE ($name2:Node {id : $id2},{name : $name2})
            MERGE ($name1)-[:KNOWS]->($name2)
            RETURN $name1, $name2";

            await using var session = _driver.AsyncSession(configBuilder => configBuilder.WithDatabase("ProgettoGpoi"));
            try
            {
                var writeResults = await session.ExecuteWriteAsync(async tx =>
                {
                    var result = await tx.RunAsync(query, new { node1, node2 });
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
            string name = node.name;
            int id = node.id;

            var query = @"
            MATCH ($name:Node {id : $id}, {name : $name})
            DELETE $name";

            await using var session = _driver.AsyncSession(configBuilder => configBuilder.WithDatabase("ProgettoGpoi"));
            try
            {
                var writeResults = await session.ExecuteWriteAsync(async tx =>
                {
                    var result = await tx.RunAsync(query, new { node });
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
