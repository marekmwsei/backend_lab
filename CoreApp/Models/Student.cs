using System.ComponentModel.DataAnnotations;

namespace CoreApp.Models;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly BirthDate { get; set; }
    public string Email { get; set; }
    public List<StudyYearField> StudyYearFields { get; set; }
}