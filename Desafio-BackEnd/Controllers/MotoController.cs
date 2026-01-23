using Microsoft.AspNetCore.Mvc;

namespace Desafio_BackEnd.Controllers
{

    [ApiController]
    [Route("/motos")]
    public class MotoController
    {

        [HttpPost]
        public void SignupMoto([FromBody] Motorcycle moto)
        {
            // Implementation for signing up a motorcycle

        }

        [HttpGet("{id}")]
        public void ReturnMotorcycleById(int id)
        {
            // Implementation for returning a motorcycle by ID
        }

        [HttpGet]
        public void ReturnAllMotorcycles()
        {
            // Implementation for returning all motorcycles
        }

        [HttpPut("{id}")]
        public void UpdateMotorcyclePlate(int id, [FromBody] Motorcycle moto)
        {
            // Implementation for updating a motorcycle
        }


    }
}
