namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            List<Student_Details> students = new List<Student_Details>()
            {
                new Student_Details() { ID = 1, Name = "Ajay", PhoneNumber = 7997282200, Address = "Andhra Pradesh-Vizag", Age = 21 },
                new Student_Details() { ID = 2, Name = "Chandra", PhoneNumber = 7997282809, Address = "Andhra Pradesh-Visakhapatnam", Age = 18 },
                new Student_Details() { ID = 3, Name = "Chandu", PhoneNumber = 7997282109, Address = "Andhra Pradesh-Narsipatnam", Age = 12 },
                new Student_Details() { ID = 4, Name = "Chandamama", PhoneNumber = 7987282109, Address = "Andhra Pradesh-Visakhapatnam", Age = 24 }
            };
            // TO DISPLAY ELEMENTS
            foreach (var list in students)
            {
                Console.WriteLine($"ID= {list.ID} Name= {list.Name} PhoneNumber= {list.PhoneNumber} Address= {list.Address} Age= {list.Age}");
            }
            // FILTER WITH AGE
            Console.WriteLine("--------------------------Filter with Age--------------------------------");

            Student_Management.StudentsDataBasedonAgeUsingLinq(students);
            Console.WriteLine("---------------------------DataFetching------------------------------");
            Student_Management.StudentsDataFetching(students);
            Console.WriteLine("---------------------------SortedinDecendingOrder------------------------------");
            Student_Management.StudentsDataSortedinDecendingOrderBasedonAge(students);
            Console.WriteLine("---------------------------SearchByName------------------------------");
            Student_Management.SearchStudentDatawithName(students);



        }

    }
}