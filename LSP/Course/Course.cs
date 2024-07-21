using LSP.Students;

namespace LSP.Course
{
    public abstract class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public abstract void Subscribe(Student std);

        //Nuevo metodo para obtener los detalles del curso
        public abstract string GetCourseDetails();
    }
}
