namespace GPOI_AppGrafi.Models
{
    //La classe Edge è la tabella che avremo
    //su MySQL in cui collegheremo un nodo con un altro
    public class Edge
    {
        public int Id { get; set; }
        public Node NodoOrigine { get; set; }
        public Node NodoTermine { get; set; }

        public string Descr { get; set; }
        public Edge() { }


    }
}