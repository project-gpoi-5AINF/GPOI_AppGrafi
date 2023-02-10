namespace GPOI_AppGrafi.Models
{
    public class Node
    {
        private int v1;
        private string v2;
        private object value;

        public int id { get; set; } 
        public string? name { get; set; }
        
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
            this.v1 = v1;
            this.v2 = v2;
            this.value = value;
        }
    }
}
