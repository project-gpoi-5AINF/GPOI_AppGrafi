namespace GPOI_AppGrafi.Models
{
    public class NodeSQL
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }

        //Tipologia è un'enumerazione, è un tipo
        //di dato supportato da MySQL
        public Tipologia? Tipo { get; set; }

        public NodeSQL() { }

        public NodeSQL(int id, string name, string descr, Tipologia tipo) {
            this.Id = id;
            this.Name = name;
            this.Descr = descr;
            this.Tipo = tipo;
        }
    }
}