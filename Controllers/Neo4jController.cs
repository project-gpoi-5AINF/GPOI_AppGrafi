using GPOI_AppGrafi.Models;
using Microsoft.AspNetCore.Mvc;
using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

            var query = @"CREATE ($node.name:Person {id = $id} {name = $name})";

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

        }

        public void Dispose()
        {
            _driver.Dispose();
        }
    }
}
