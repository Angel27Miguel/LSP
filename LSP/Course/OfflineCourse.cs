using LSP.Students;

namespace LSP.Course
{
    public class OfflineCourse : Course
    {
        public override string GetCourseDetails()
        {
            return $"Curso Presencial: {Title}, ID: {CourseId}\n";
        }

        public override void Subscribe(Student std)
        {
            //Codigo para suscribirte a un curso fuera de linea
            Console.WriteLine("El estudiante se ha suscrito a un curso presencial.");
        }
    }
}
