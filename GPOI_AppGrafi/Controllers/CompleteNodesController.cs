using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GPOI_AppGrafi.Data;
using GPOI_AppGrafi.Models;
using GPOI_AppGrafi.Controllers;

namespace GPOI_AppGrafi.Controllers
{
    public class CompleteNodesController : Controller
    {
        private readonly GPOI_AppGrafiContext _context;

        public CompleteNodesController(GPOI_AppGrafiContext context)
        {
            _context = context;
        }

        /*
        public IActionResult ModificaNodo(int id, string name, string descr, int parentId)
        {
            var updateNode = _context.NodeSQL.FromSql("UPDATE dbo.Node SET Name = {name} AND Descr = {descr} WHERE " +
                "id = {id}");

            var updateEdge = "UPDATE dbo.Edges SET nodoTermine = {parentId} WHERE " +
                "id = {id}";

            Neo4jController neo4j = new Neo4jController();
            Node node = new Node(id, name, descr);
            neo4j.Edit(id, node);
        }
        */
    }
}
