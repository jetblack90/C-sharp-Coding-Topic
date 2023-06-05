namespace _25._Classes
{
    public class Student : Person
    {
        private string studentId;

        public string GetStudentId()
        {
            return studentId;
        }

        public void SetStudentId(string newStudentId)
        {
            studentId = newStudentId;
        }
    }
}