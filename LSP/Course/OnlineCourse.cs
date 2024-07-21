using LSP.Students;

namespace LSP.Course
{
    public class OnlineCourse : Course
    {
        public override string GetCourseDetails()
        {
           return $"Curso en Linea: {Title}, ID: {CourseId}\n";
        }

        public override void Subscribe(Student std)
        {
            //Codigo para suscribirte a un curso en linea
            Console.WriteLine("El estudiante se ha suscrito a un curso en linea.");
        }
    }
}
