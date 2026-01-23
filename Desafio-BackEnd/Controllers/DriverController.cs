using Microsoft.AspNetCore.Mvc;

namespace Desafio_BackEnd.Controllers
{
    [ApiController]
    [Route("/entregadores")]
    public class DriverController
    {

        [HttpPost]
        public void SignupDriverController([FromBody] object driver)
        {
            // Implementation for signing up a driver
        }

        [HttpPost("{id}/cnh")]
        public void SendDriverCnhController(int id)
        {
            // Implementation for sending driver's CNH
        }
    }
}
