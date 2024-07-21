using LSP.Course;
using LSP.Students;

class Program
{
    static void Main(string[] args)
    {
        List<Course> courses = new List<Course>
        {
            new OnlineCourse { CourseId = 1, Title = "C# Avanzado" },
            new OfflineCourse { CourseId = 2, Title = "Base de datos avanzada" },
            new HybridCourse { CourseId = 3, Title = "Probabilidad y estadistica" }
        };

        Student student = new Student { Name = "Angel Miguel de la Rosa" };

        foreach (var course in courses)
        {
            course.Subscribe(student);
            Console.WriteLine(course.GetCourseDetails());
        }
    }
}
