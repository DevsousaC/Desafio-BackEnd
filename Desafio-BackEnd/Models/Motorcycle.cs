namespace Desafio_BackEnd.Models
{
    public class Motorcycle
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Plate { get; set; }

        public Motorcycle(int id, string model, int year, string plate)
        {
            Id = id;
            Model = model;
            Year = year;
            Plate = plate;
        }

    }
}
