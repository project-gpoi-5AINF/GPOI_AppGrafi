namespace GPOI_AppGrafi.Models
{
    public class Node
    {
        public int id { get; set; } 
        public string name { get; set; }
        
        public Node node { get; set; }
        public List<User> users { get; set; }

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

            

    }
}
