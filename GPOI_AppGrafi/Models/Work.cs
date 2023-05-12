namespace GPOI_AppGrafi.Models
{
    public class Work
    {
        public int Id { get; set; }
        public User Utente { get; set; }
        public NodeSQL Nodo { get; set; }
        public string Descr { get; set; }
        
        public Work(int id, User utente, NodeSQL nodo)
        {
            this.Id = id;
            this.Utente= utente;
            this.Nodo= nodo;
        }

        public Work() { }
    }
}
