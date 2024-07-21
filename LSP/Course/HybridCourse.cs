using LSP.Students;

namespace LSP.Course
{
    public class HybridCourse : Course
    {
        public override string GetCourseDetails()
        {
            return $"Curso Hibrido: {Title}, ID: {CourseId}\n";
        }

        public override void Subscribe(Student std)
        {
            //Codigo para suscribirte a un curso hibrido
            Console.WriteLine("El estudiante se ha suscrito a un curso hibrido.");
        }
    }
}
