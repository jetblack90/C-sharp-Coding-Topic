namespace _25._Classes
{
    internal class Data
    {
        private static void Main()
        {
            Person person = new Person();

            person.SetName("John");
            person.SetAge(25);

            Student student = new Student();
            student.SetName("Jane");
            student.SetAge(20);
            student.SetStudentId("S12345");

            Console.WriteLine("Person: " + person.GetName() + ", " + person.GetAge());
            Console.Write("Student: " + student.GetName() + ", " + student.GetAge() + ", ");
            Console.WriteLine(student.GetStudentId());
        }
    }
}