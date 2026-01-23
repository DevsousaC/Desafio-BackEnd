using System.ComponentModel.DataAnnotations;

namespace Desafio_BackEnd.Models
{
    public class Driver
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public DateTime Borned_In { get; set; }
        public string Cnh_Number { get; set; }
        public string Cnh_Image_Url { get; set; }

        public Driver(int id, string name, string cnpj, DateTime borned_in, string cnh_number)
        {
            Id = id;
            Name = name;
            Cnpj = cnpj;
            Borned_In = borned_in;
            Cnh_Number = cnh_number;
        }
    }
}
