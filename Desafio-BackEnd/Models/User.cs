using System.ComponentModel.DataAnnotations;

namespace Desafio_BackEnd.Models
{
    public class User
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O usuario deve ter um nome")]
        public string Name { get; set; }

        public User() { }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
