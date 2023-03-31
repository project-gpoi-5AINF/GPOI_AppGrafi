namespace GPOI_AppGrafi.Models
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }

        //La proprietà Nodo sarà una foreign key su MySQL
        //, faremo sì che un utente sarà collegato ad un nodo
        public Node? Nodo { get; set; }
        User()
        {
            this.Email = null;
            this.Password = null;
            this.Nodo = null;
        }

        User(string email, string password, Node? node)
        {
            this.Email = email;
            this.Password = password;
            this.Nodo = node;
        }


    }
}