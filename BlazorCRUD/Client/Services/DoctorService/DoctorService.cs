using System.Net.Http.Json;

namespace BlazorCRUD.Client.Services.DoctorService
{
    public class DoctorService : IDoctorService
    {
        private readonly HttpClient _http;

        public DoctorService(HttpClient http)//INYECTAMOS EL CLIENTE
        {
            _http = http;
        }
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
        public List<Area> Areas { get;set; } = new List<Area>();

        public Task GetAreas()
        {
            throw new NotImplementedException();
        }

        public Task<Doctor> GetDoctor(int id)
        {
            throw new NotImplementedException();
        }

        public async Task GetDoctors()
        {
            var result = await _http.GetFromJsonAsync<List<Doctor>>("api/doctor");
            if(result != null)
            {
                Doctors= result;
            }
        
        }

        Task IDoctorService.GetDoctor(int id)
        {
            throw new NotImplementedException();
        }
    }
}
