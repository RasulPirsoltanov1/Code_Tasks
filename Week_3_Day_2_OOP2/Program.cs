
namespace Week_3_Day_2_OOP2
{
    using Models;

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Create("Rasul","Pirsoltanov");
            student.Create("xxxx","xxxxx");
            student.Create("ccc","xccxxcccxx");
            student.Create("gggg","ggggg");
            student.Create("fffff","fffff");
            student.Show();

        }

       
    }
}