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

        
        public void ModificaNodo(int id, string name, string descr, Node parent, string edgeDescr,
            Tipologia tipo, List<User> users)
        {

            NodeSQLsController SQL = new NodeSQLsController(_context);
            NodeSQL nodeSQL = new NodeSQL(id, name, descr, tipo);
            SQL.Edit(id, nodeSQL);

            Neo4jController neo4j = new Neo4jController();
            Node node = new Node(id, name, descr);
            neo4j.UpdateNode(node);

            Edge edge = new Edge(id, parent, node, edgeDescr);
            EdgesController edgesController = new EdgesController(_context);
            edgesController.Edit(id, edge);

            foreach(User user in users)
            {
                Work work = new Work(id, user, nodeSQL);
                WorkController workController = new WorkController(_context);
                workController.Create(work);
            }
        }
        
    }
}
