namespace BlazorCRUD.Client.Services.DoctorService
{
    public interface IDoctorService
    {
        List<Doctor>  Doctors { get; set; }
        List<Area> Areas { get; set; }
        Task GetAreas();
        Task GetDoctors();
        Task GetDoctor(int id);
    }
}
