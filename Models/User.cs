namespace GPOI_AppGrafi.Models
{
    public class User
    {
        public string email { get; set; }
        public string password { get; set; }
        public Grade grado { get; set; }

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
