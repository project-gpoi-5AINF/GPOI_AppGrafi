namespace GPOI_AppGrafi.Models
{
    public class Node
    {
        private int? v1 { get; set; }
        private string? v2 { get; set; }
        private object? value { get; set; }

        public int id { get; set; } 
        public string name { get; set; }
        
        public Node? node { get; set; }
        public List<User>? users { get; set; }

        Node() // costruttore di default
        {
            this.id = 0;
            this.name = null;
            this.node = null;
        }

        Node(int id, string name, Node node)
        {
            this.id = id;
            this.name = name;
            this.node = node;
        }

        public Node(int v1, string v2, object value)
        {
            this.id = v1;
            this.name = v2;
            this.node = (Node) value;
        }
    }
}
