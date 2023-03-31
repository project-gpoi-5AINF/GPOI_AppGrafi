namespace GPOI_AppGrafi.Models
{
    public class Node
    {
        public int Id { get; set; } 
        public string? Desc { get; set; }
        public string? Name { get; set; }

        //Campo per il nodo bloccante?

        Node() // costruttore di default
        {
            this.Id = 0;
            this.Desc = null;
            this.Name = null;
        }

        Node(int id, string desc, string name)
        {
            this.Id = id;
            this.Desc = desc;
            this.Name = name;
        }
    }
}
