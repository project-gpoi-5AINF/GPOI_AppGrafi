namespace GPOI_AppGrafi.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Grade grado { get; set; }
        public int idReparto { get; set; }

        User() 
        {
            this.email = null;
            this.password = null;
            this.grado = 0;
        }

        User(string email, string password, Grade grado)
        {
            this.email = email;
            this.password = password;
            this.grado = grado;
        }


    }
}
