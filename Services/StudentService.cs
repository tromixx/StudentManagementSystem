using Microsoft.EntityFrameworkCore;

namespace StudentManagementSystem.Services
{
    public class StudentService : IStudentService
    {
        private readonly AppDbContext _context;

        public StudentService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task AddStudent(Student student)
        {
            if (student != null)
            {
                // Add the student to the context and save the changes
                await _context.Students.AddAsync(student);
                await _context.SaveChangesAsync();
            }
        }
    }
}
