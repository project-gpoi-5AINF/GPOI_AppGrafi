namespace GPOIProject.Models
{
    public class User
    {
        public string email { get; set; }
        public string password { get; set; }
        public Tipologia grado { get; set; }

        User() 
        {
            this.email = null;
            this.password = null;
            this.grado = 0;
        }

        User(string email, string password, Tipologia grado)
        {
            this.email = email;
            this.password = password;
            this.grado = grado;
        }


    }
}
