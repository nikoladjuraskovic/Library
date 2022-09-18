using System.ComponentModel.DataAnnotations;

namespace Library.Data
{
    public class User
    { //Neiskorisceno zad sada
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
