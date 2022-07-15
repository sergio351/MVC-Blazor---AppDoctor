using BlazorCRUD.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCRUD.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        public static List<Area> areas = new List<Area> { 
        new Area{Id=1, Name="Odontology"},
        new Area{Id=2, Name="Surgery"}
        };

        public static List<Doctor> doctors = new List<Doctor>
        {
            new Doctor{
                Id=1,
                FirstName="Jorge",
                LastName="Perez",
                Email="sdfs@gmail.com",
                Phone="1234223",
                Address="Mar del plata",
                Area=areas[0],
            },
             new Doctor{
                Id=2,
                FirstName="Sergio",
                LastName="Perez",
                Email="sdfs@gmail.com",
                Phone="234324234",
                Address="NY",
                Area=areas[1],
            },
        };

        [HttpGet]
        public async Task<ActionResult<List<Doctor>>> GetDoctors()
        {
            return Ok(doctors);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<List<Doctor>>> GetDoctor(int id)
        {
            var doctor = doctors.FirstOrDefault(d=> d.Id== id);
            if (doctor == null)
            {
                return NotFound("doctor no exist ");

            }
            return Ok(doctor);
        }
    }
}
