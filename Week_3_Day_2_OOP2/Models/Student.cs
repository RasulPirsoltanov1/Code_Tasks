using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Day_2_OOP2.Models
{
    public  class Student
    {
        List<Student> students = new List<Student>();

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        string _fullname;
        public string Fullname
        {
            get
            {
                _fullname = Name + "." + Surname;
                return _fullname;
            }
        }
        public DateTime BrithDate { get; set; }
        string? _email;
        public string Email
        {
            get
            {
                try
                {
                    var x = Name.ToLower() + "." + Surname.ToLower() + "@code.az";
                    if (students.FirstOrDefault(x => x.Email == _email) == null)
                    {
                        _email = x;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return _email;
            }
            set
            {
                try
                {
                    var x = Name.ToLower() + "." + Surname.ToLower() + "@code.az";
                    if (students.FirstOrDefault(x => x.Email == _email) == null)
                    {
                        _email = x;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void Create(string name, string surname)
        {
            Student student = new Student();
            student.Name = name;
            student.Id = students.Count + 1;
            student.Surname = surname;
            student.BrithDate = DateTime.UtcNow;
            students.Add(student);

        }
        public void Show()
        {
            foreach (var item in students)
            {
                Console.WriteLine(item.Id + " " + item.Fullname + " "+item.Email);
            }
        }
        public void Update(int id,Student student)
        {
            try
            {
                var studentDb = students.FirstOrDefault(x => x.Id == id);
                if (student != null)
                {
                    studentDb.Name = student.Name;
                    studentDb.Surname = student.Surname;
                }
                else
                {
                    throw new Exception("user not found!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Delete(int id)
        {
            try
            {
                var studentDb = students.FirstOrDefault(x => x.Id == id);
                if (studentDb != null)
                {
                   students.Remove(studentDb);
                }
                else
                {
                    throw new Exception("user not found!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
