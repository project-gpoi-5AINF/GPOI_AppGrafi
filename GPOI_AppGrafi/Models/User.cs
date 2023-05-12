namespace GPOI_AppGrafi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        User()
        {
            this.Email = null;
            this.Password = null;
        }

        User(int id, string email, string password)
        {
            this.Id = id;
            this.Email = email;
            this.Password = password;
        }


    }
}