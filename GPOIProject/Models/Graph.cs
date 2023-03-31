namespace GPOIProject.Models
{
    public class Graph
    {
        public List<Node> nodes = new List<Node>();

        public void aggiungiNodo(Node node) {
            nodes.Add(node);
        }

        public void rimuoviNodo(Node node)
        {
            nodes.Remove(node);
        }

        public void rimuoviNodo(int index)
        {
            nodes.RemoveAt(index);
        }

        public void modificaNodo(Node node1, Node nodeModifica)
        {
            node1 = nodeModifica;
        }



        public Graph() { }

    }
}
