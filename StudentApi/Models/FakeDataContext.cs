namespace StudentApi.Models;

public class FakeDataContext
{
    private static List<Student> students;
    public FakeDataContext()
    {
        students = new List<Student>
        {
            new Student { Id = 1, Name = "Ali" },
            new Student { Id = 2, Name = "Veli" },
            new Student { Id = 3, Name = "Deli" }
        };
    }
    public async Task Add(Student student)
    {
        students.Add(student);
        await Task.CompletedTask;
    }
    public async Task<IEnumerable<Student>> GetAll() => await Task.FromResult(students);

    public Task<Student> GetById(int id)
    {
        var student = students.FirstOrDefault(x => x.Id == id);
        return Task.FromResult(student);
    }

    public async Task Update(Student newStudent)
    {
        var studentId = newStudent.Id;
        students.RemoveAll(x => x.Id == studentId);
        students.Add(newStudent);
        await Task.CompletedTask;
    }
}
