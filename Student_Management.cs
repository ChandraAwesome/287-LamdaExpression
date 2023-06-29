using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student_Management
    {
        public static void StudentsDataBasedonAgeUsingLinq(List<Student_Details> studentrecords)
        {                           //this is a object type//
            var studentsByAge = from Student_Details in studentrecords where Student_Details.Age >= 12 && Student_Details.Age <= 18 select Student_Details;
            var StudentByAgeusingLamda = studentrecords.FindAll(age => age.Age >= 12 && age.Age <= 18);

            foreach(var list in studentsByAge) 
            {
                Console.WriteLine($"ID= {list.ID} Name= {list.Name} PhoneNumber= {list.PhoneNumber} Address= {list.Address} Age= {list.Age}");
            }

        }


        public static void StudentsDataSortedinDecendingOrderBasedonAge(List<Student_Details> studentrecords) 
        {
            var SortedStudentbyAge = from student in studentrecords orderby student.Age descending select student;

            foreach (var list in SortedStudentbyAge)
            {
                Console.WriteLine($"Name= {list.Name}  Age= {list.Age}");
            }


        public static void StudentsDataFetching(List<Student_Details> studentrecords)
        {
            var SortedStudentbyAge = (from student in studentrecords orderby student.ID  select student).Take(3);

            foreach (var list in SortedStudentbyAge)
            {
                Console.WriteLine($"Name= {list.Name}  Age= {list.ID}");
            }
        }

    }
