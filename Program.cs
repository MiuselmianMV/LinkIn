using System;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LinkIn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            Ex3();
        }

        public static void Ex1()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~Ex1~~~~~~~~~~~~~~~~~~~~~~~");

            List<int> ints = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };

            Console.Write("Whole massive: ");
            ints.ForEach(n => Console.Write(n + " "));
            Console.WriteLine();

            Console.Write("Even numbers: ");
            var evenNums = ints.Where(n => n % 2 == 0)
                                .ToList();
            evenNums.ForEach(n => Console.Write(n + " "));
            Console.WriteLine();

            Console.Write("Odd numbers: ");
            var oddNums = ints.Where(n => n % 2 != 0)
                                .ToList();
            oddNums.ForEach(n => Console.Write(n + " "));
            Console.WriteLine();

            Console.Write("Enter number: ");
            int.TryParse(Console.ReadLine(), out int num);

            var selectedNums = ints.Where(n => n > num)
                                    .ToList();

            selectedNums.ForEach(n => Console.Write(n + " "));
            Console.WriteLine();

            Console.Write("Enter start of range: ");
            int.TryParse(Console.ReadLine(), out int start);

            Console.Write("Enter end of range: ");
            int.TryParse(Console.ReadLine(), out int end);


            var selectedRangeNums = ints.Where(n => n > start && n < end)
                                        .ToList();

            Console.Write($"Numbers in range from {start} to {end}: ");
            selectedRangeNums.ForEach(n => Console.Write(n + " "));

            Console.WriteLine();


            var ascBiggerThanSeven = ints.Where(n => n % 7 == 0)
                                            .OrderBy(it => it)
                                            .ToList();

            ascBiggerThanSeven.ForEach(n => Console.Write(n + " "));
            Console.WriteLine();


            var descBiggerThanEight = ints.Where(n => n % 8 == 0)
                                            .OrderByDescending(it => it)
                                            .ToList();

            descBiggerThanEight.ForEach(n =>  Console.Write(n + " "));

            Console.WriteLine();
        }

        public static void Ex2()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~Ex2~~~~~~~~~~~~~~~~~~~~~~~");
            List<string> cities = new List<string> { "New York", "Missisipi", "Kaawerqweq", "Aasdfadfk", "Maewerm", "Stockgholm", "Nasdfqwerk"};

            Console.Write("Whole massive: ");
            cities.ForEach(n => Console.Write(n + " "));
            Console.WriteLine();


            Console.Write("Enter length of the city name: ");
            int.TryParse(Console.ReadLine(), out int len);

            var selectedLength = cities.Where(c => c.Length == len)
                                        .ToList();
            Console.Write("Selected cities: ");
            selectedLength.ForEach(c => Console.Write(c + ", "));
            Console.WriteLine();

            var startsWithA = cities.Where(c => c.ToLower().StartsWith("a"))
                                     .ToList();

            Console.Write("Selected cities that start with A: ");
            startsWithA.ForEach(c => Console.Write(c + ", "));
            Console.WriteLine();

            var endsWithM = cities.Where(c => c.ToLower().EndsWith("m"))
                         .ToList();
            Console.Write("Selected cities that end with N: ");
            endsWithM.ForEach(c => Console.Write(c + ", "));
            Console.WriteLine();

            var difficultConditionCities = cities.Where(c => c.ToLower().StartsWith("n") 
                                                             && c.ToLower().EndsWith("k"))
                                                  .ToList();
            Console.Write("Selected cities that start with N and end with K: ");
            difficultConditionCities.ForEach(c => Console.Write(c + ", "));
            Console.WriteLine();

            var startsWithNe = cities.Where(c => c.ToLower().StartsWith("ne"))
                                     .OrderBy(c => c)
                                     .ToList();

            Console.Write("Selected cities that start with Ne: ");
            startsWithNe.ForEach(c => Console.Write(c + ", "));
            Console.WriteLine();
        }

//         Отримати весь масив студентів.
// Отримати список студентів з ім'ям Boris.
// Отримати список студентів з прізвищем, яке починається з
//Bro.
// Отримати список студентів, старших 19 років.
// Отримати список студентів, старших 20 років і молодших 23
//років.
// Отримати список студентів, які навчаються в MIT.
// Отримати список студентів, які навчаються в Oxford, і вік
//яких старше 18 років.Результат відсортуйте за віком, за
//спаданням.
        public static void Ex3()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~Ex3~~~~~~~~~~~~~~~~~~~~~~~");

            List<Student> students = new List<Student> { new Student ("Boris", "Orewqqw", 34, "MIT"), 
                new Student ("Max", "Broewr", 19, "Oxford"),
                new Student ("Lex", "Hera", 59, "Oxford"),
                new Student ("Tom", "Srewqr", 39, "Oxford"),
                new Student ("Boris", "Bro", 22, "MIT")
            };

            Console.WriteLine("All students: ");
            students.ForEach(s => s.Show());
            Console.WriteLine();

            Console.WriteLine("Students whose name is Boris: ");
            var studsBorises = students.Where(s => s.Name.ToLower() == "boris")
                                       .ToList();
            studsBorises.ForEach(s => s.Show());
            Console.WriteLine();

            Console.WriteLine("Students whose surname starts with Bro: ");
            var studsSurnameStartWithBro = students.Where(s => s.Surname.ToLower().StartsWith("bro"))
                           .ToList();
            studsSurnameStartWithBro.ForEach(s => s.Show());
            Console.WriteLine();

            Console.WriteLine("Students who are elder than 19: ");
            var studsElderNineteen = students.Where(s => s.Age > 19)
                           .ToList();
            studsElderNineteen.ForEach(s => s.Show());
            Console.WriteLine();

            Console.WriteLine("Students who are elder than 20 and younger than 23: ");
            var studsAgeInRange = students.Where(s=>s.Age > 20 && s.Age < 23)
                                          .ToList();
            studsAgeInRange.ForEach(s => s.Show());
            Console.WriteLine();

            Console.WriteLine("Students from MIT: ");
            var studsFromMIT = students.Where(s => s.School.ToLower() == "mit")
                                          .ToList();
            studsFromMIT.ForEach(s => s.Show());
            Console.WriteLine();

            Console.WriteLine("Students from oxford, who are elder than 18: ");
            var studs = students.Where(s => s.Age > 18 && s.School.ToLower() == "oxford")
                                .OrderByDescending(s => s.Age)
                                .ToList();
            studs.ForEach(s => s.Show());
            Console.WriteLine();
        }
    }
}
