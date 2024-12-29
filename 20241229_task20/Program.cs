namespace _20241229_task20
{
    internal class Program
    {
        /*
         Создать структуру «Student», содержащую поля: id, имя, фамилия, средний балл. 
        Определить студентов с баллом выше среднего. 
        Пользователь вводит данные о количестве студентов, их фамилии, имена и балл для каждого. 
        Программа должна определить средний балл и вывести фамилии и имена студентов, 
        чей балл выше среднего. Реализовать метод для сортировки по фамилии, используя интерфейс IComparable.
         */
        static void Main(string[] args)
        {
            Student[] students = 
            {
                new Student(true),
                new Student(true),
                new Student(true),
                new Student(true),
                new Student(true)                
            };

            Console.Clear();

            Console.WriteLine("--------------All students--------------");
            PrintArray(students);

            int avg = FindAvgGrade(students);

            int count = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Grade >= avg)
                {
                    count++;
                }
            }

            Student[] goodStudents = new Student[count];

            int j = 0;
            for (int i = 0;i < students.Length; i++)
            {
                if (students[i].Grade >= avg)
                {
                    goodStudents[j] = students[i];
                    j++;
                }
            }

            Array.Sort(goodStudents);

            Console.WriteLine("--------------All students with good grades--------------");
            PrintArray(goodStudents);

            Console.ReadKey();
        }

        static void PrintArray(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
        }

        static int FindAvgGrade(Student[] students)
        {
            int sum = 0;
            for (int i = 0; i < students.Length; i++)
            {
                sum += students[i].Grade;
            }

            Console.WriteLine($"\n--------------avg grade is {sum / students.Length}--------------\n");
            return sum / students.Length;
        }

        public struct Student : IComparable
        {
            public Guid Id { get; set; }
            public string FirstName { get; set; }
            public string FamilyName { get; set; }
            public int Grade { get; set; }

            public Student()
            {
                
            }

            public Student(bool b)
            {
                Id = Guid.NewGuid();
                try
                {
                    Console.WriteLine("\nEnter student's first name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter student's family name:");
                    string family = Console.ReadLine();
                    Console.WriteLine("Enter student's grade:");
                    int grade = Convert.ToInt32(Console.ReadLine());

                    FirstName = name;
                    FamilyName = family;
                    Grade = grade;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            public override string ToString()
            {
                return $"{FamilyName} {FirstName} grade {Grade}, ID: {Id}";
            }

            public int CompareTo(object? obj)
            {
                Student s = (Student)obj;
                return this.FamilyName.CompareTo(s.FamilyName);

            }

            /*
             public int CompareTo(object o)
        {
            Person p = o as Person;
            if (p != null)
            {
                return this.Name.CompareTo(p.Name);
            }
            else
            {
                throw new Exception("Невозможно сравнить два объекта");
            }
        }
             */
        }
    }
}
