namespace GPOI_AppGrafi.Models
{
    public class Node
    {
        public int Id { get; set; } 
        public string? Desc { get; set; }
        public string? Name { get; set; }
        public List<Node>? Nodes { get; set; }
        public List<User>? Users { get; set; }
        public Tipologia? Tipo { get; set; }

        Node() // costruttore di default
        {
            this.Id = 0;
            this.Desc = null;
            this.Name = null;
            this.Nodes = null;
            this.Users = null;
            this.Tipo = null;
        }

        Node(int id, string desc, string name, List<Node> nodes, List<User> users, Tipologia tipo)
        {
            this.Id = id;
            this.Desc = desc;
            this.Name = name;
            this.Nodes = nodes;
            this.Users = users;
            this.Tipo = tipo;
        }
    }
}
