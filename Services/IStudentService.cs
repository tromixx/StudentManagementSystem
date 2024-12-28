namespace StudentManagementSystem.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllStudentsAsync();
        Task AddStudent(Student student);  // Ensure this method is present
    }
}
