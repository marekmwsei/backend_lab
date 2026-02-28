using CoreApp.Models;
using CoreApp.Infrastructure;

namespace Infrastructure;

public class MemoryStudentRepository
{
    public Task<Student?> AddAsync(Student entity)
    {
        throw new NotImplementedException();
    } 
    
    public Task<Student?> FindByIdAsync(int id)
    {
        return new Student()
        {
            Id = 1,
            FirstName = "Adam",
            LastName = "Nowak",
            BirthDate = new DateOnly(2000, 1, 1),
            Email = "adam@wsei.edu.pl",
            StudyYearFields = new List<StudyYearField>()
            {
                StudyField = new StudyYearField() { Id = 100, Title = "Informatyka" },
                StudyYear = new StudyYear() { Id = 1000, Name = "2025/2026 Niestacjonarne", AcademicYear = DateOnly.Parse("2025-09-01") }
            }
        };
    }
}