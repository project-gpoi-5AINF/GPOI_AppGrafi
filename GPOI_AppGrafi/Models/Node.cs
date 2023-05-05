namespace GPOI_AppGrafi.Models
{
    //Questa classe Node sarà quella che useremo su Neo4J
    public class Node
    {
        public int Id { get; set; }
        public string? Desc { get; set; }
        public string? Name { get; set; }

        public Node() // costruttore di default
        {
            this.Id = 0;
            this.Desc = null;
            this.Name = null;
        }

        public Node(int id, string desc, string name)
        {
            this.Id = id;
            this.Desc = desc;
            this.Name = name;
        }
    }
}