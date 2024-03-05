using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Podpis();

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine(" Меню выбора:");
                Console.WriteLine("1.  Задание 1");
                Console.WriteLine("2.  Задание 2");
                Console.WriteLine("3.  Задание 3");
                Console.WriteLine("4.  Задание 4 и 5");
                Console.WriteLine("6.  Задание 6");
                Console.WriteLine("7.  Задание 7");
                Console.WriteLine("8.  Задание 8");
                Console.WriteLine("9.  Задание 9 и 12");
                Console.WriteLine("10. Задание 10");
                Console.WriteLine("11. Задание 11");
                Console.WriteLine("00. Выход");
                Console.WriteLine();
                Console.Write("Выберите пункт меню: ");

                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Введите номер выбранного пункта.");
                    Console.ReadLine();
                    continue;
                }

                Console.Clear();

                switch (choice)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 6:
                        Task6();
                        break;
                    case 7:
                        Task7();
                        break;
                    case 8:
                        Task8();
                        break;
                    case 9:
                        Task9();
                        break;
                    case 10:
                        Task10();
                        break;
                    case 11:
                        Task11();
                        break;
                    case 00:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Выбран неверный пункт меню.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine();
                    Console.WriteLine("Нажмите любую клавишу, чтобы продолжить...");
                    Console.ReadKey();
                }
            }
        }


        static void Podpis()
        {
            string[] welcomeFrames = new string[]
            {
        @"   _   _   _   _   _   _   _   _   _   _   _    ",
        @"  / \ / \ / \ / \ / \ / \ / \ / \ / \ / \ / \   ",
        @" ( Н | а | д | р | а | л | и | е | в | ! )   ",
        @"  \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/   "
            };

            Console.CursorVisible = false;
            Console.Clear();

            int centerX = Console.WindowWidth / 2;
            int centerY = Console.WindowHeight / 2 - welcomeFrames.Length / 2;

            foreach (string frame in welcomeFrames)
            {
                Console.SetCursorPosition(centerX - frame.Length / 2, centerY++);
                Console.WriteLine(frame);
                Thread.Sleep(100);
            }

            Thread.Sleep(2000);

            Console.CursorVisible = true;
        }

        //////////////////////////////////////////////////////////////////////
        ///                                                                ///
        ///                        Задание 1                               ///
        //////////////////////////////////////////////////////////////////////


        static void Task1()
        {
            Console.WriteLine("Задание 1.\n");
            Console.WriteLine("Это строка?\n\"Да!\"");
        }

        //////////////////////////////////////////////////////////////////////
        ///                                                                ///
        ///                        Задание 2                               ///
        //////////////////////////////////////////////////////////////////////


        static void Task2()
        {
            Console.WriteLine("Задание 2.\n");

            Console.WriteLine("Введите символ:");
            char myChar = Console.ReadKey().KeyChar;

            Console.WriteLine($"\nВведенный символ: {myChar}");
            Console.WriteLine($"ASCII-код символа: {(int)myChar}");
            Console.WriteLine($"Следующий символ: {(char)((int)myChar + 1)}");
            Console.WriteLine($"Предыдущий символ: {(char)((int)myChar - 1)}");
        }

        //////////////////////////////////////////////////////////////////////
        ///                                                                ///
        ///                        Задание 3                               ///
        //////////////////////////////////////////////////////////////////////


        static void Task3()
        {
            Console.WriteLine("Задание 3.\n");

            Console.WriteLine("Пожалуйста, выберите способ ввода переменных:\n1. Вручную\n2. Случайные значения");

            Console.Write("Ваш выбор: ");
            int choice = int.Parse(Console.ReadLine());

            double var1, var2, var3, var4;

            if (choice == 1)
            {
                Console.WriteLine("Пожалуйста, введите значения переменных в формате от 0 до 1. Пример - 0.24.");

                Console.Write("Введите значение переменной 1: ");
                double.TryParse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out var1);

                Console.Write("Введите значение переменной 2: ");
                double.TryParse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out var2);

                Console.Write("Введите значение переменной 3: ");
                double.TryParse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out var3);

                Console.Write("Введите значение переменной 4: ");
                double.TryParse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out var4);
            }
            else if (choice == 2)
            {
                var random = new Random();
                var1 = random.NextDouble();
                var2 = random.NextDouble();
                var3 = random.NextDouble();
                var4 = random.NextDouble();
            }
            else
            {
                Console.WriteLine("Неверный выбор!");
                return;
            }

            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Green;


            int consoleWidth = Console.WindowWidth / 2;
            int consoleHeight = Console.WindowHeight;

            Console.SetWindowSize(consoleWidth, consoleHeight);


            int centerX = consoleWidth / 2;
            int centerY = consoleHeight / 2;

            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Текущая дата: {DateTime.Now.ToShortDateString()}");

            Console.ResetColor();

            Console.SetCursorPosition(centerX - 4, centerY - 1);
            Console.WriteLine($"{var1,6:P1}\t\t{var2:P0}");

            Console.SetCursorPosition(centerX - 4, centerY);

            if (var1 <= 1 && var2 <= 1 && var3 <= 1 && var4 <= 1)
            {
                Console.WriteLine($"\t{var3:P0}\t\t{var4:P2}");
            }
            else
            {
                Console.WriteLine("Неверный формат! \nПожалуйста, введите значения переменных в формате от 0 до 1. Пример - 0.24.");
            }
        }


        //////////////////////////////////////////////////////////////////////
        ///                                                                ///
        ///                        Задание 4                               ///
        //////////////////////////////////////////////////////////////////////

        static void Task4()
        {

            Console.WriteLine("Задание 4 и 5.\n");
            try
            {
                Console.Write("Введите размерность массива: ");
                int size = int.Parse(Console.ReadLine());

                int[] array = new int[size];

                Console.WriteLine("Выберите тип заполнения массива:\n1. Случайные числа\n2. Ручной ввод");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Введите минимальное значение диапазона случайных чисел:");
                    int min = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите максимальное значение диапазона случайных чисел:");
                    int max = int.Parse(Console.ReadLine());

                    Console.WriteLine("Заполнение массива случайными числами:");

                    Random random = new Random();

                    for (int i = 0; i < size; i++)
                    {
                        array[i] = random.Next(min, max + 1);
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Введите элементы массива:");

                    for (int i = 0; i < size; i++)
                    {
                        Console.Write($"Элемент {i + 1}: ");
                        array[i] = int.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный выбор типа заполнения!");
                    return;
                }

                Console.WriteLine("Массив:");

                Console.WriteLine("Индекс\tЗначение");

                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"{i}\t{array[i]}");
                }

                Console.Write("Введите индекс элемента: ");
                int index = int.Parse(Console.ReadLine());

                int element = array[index];

                Console.WriteLine($"Значение элемента с индексом {index}: {element}");
            }
            catch (Exception ex)
            {
                Task5.HandleException(ex);
            }
        }

        //////////////////////////////////////////////////////////////////////
        ///                                                                ///
        ///                        Задание 5                               ///
        //////////////////////////////////////////////////////////////////////

        class Task5
        {
            public static void HandleException(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                if (ex is IndexOutOfRangeException)
                {
                    Console.WriteLine("Индекс выходит за пределы массива!");
                }
                else if (ex is FormatException)
                {
                    Console.WriteLine("Введенный индекс не является целым числом!");
                }
                else
                {
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                }
                Console.ResetColor();
            }
        }



        //////////////////////////////////////////////////////////////////////
        ///                                                                ///
        ///                        Задание 6                               ///
        //////////////////////////////////////////////////////////////////////

        static void Task6()
        {
            Console.WriteLine("Задание 6.\n");

            Console.Write("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(-10, 10);
            }

            Console.WriteLine("Массив:");
            Console.WriteLine("Индекс\tЗначение");
            for (int i = 0; i < size; i++)
            {
                if (array[i] == FindSmallestPositive(array))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{i}\t{array[i]}");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"{i}\t{array[i]}");
                }
            }

            int minPositive = FindSmallestPositive(array);

            if (minPositive != int.MaxValue)
            {
                Console.WriteLine("Наименьший положительный элемент: " + minPositive);
            }
            else
            {
                Console.WriteLine("В массиве нет положительных элементов.");
            }
        }

        //метод для задания 6
        static int FindSmallestPositive(int[] array)
        {
            int minPositive = int.MaxValue;
            foreach (int element in array)
            {
                if (element > 0 && element < minPositive)
                {
                    minPositive = element;
                }
            }
            return minPositive;
        }

        //////////////////////////////////////////////////////////////////////
        ///                                                                ///
        ///                        Задание 7                               ///
        //////////////////////////////////////////////////////////////////////

        static void Task7()
        {
            Console.WriteLine("Задание 7.\n");

            try
            {
                Console.Write("Введите количество строк: ");
                int rows = int.Parse(Console.ReadLine());

                Console.Write("Введите количество столбцов: ");
                int columns = int.Parse(Console.ReadLine());

                int[,] matrix = GenerateMatrix(rows, columns);
                PrintMatrix(matrix);

                int[] rowProducts = GetRowMult(matrix);
                Console.WriteLine("Произведения элементов каждой строки:");
                foreach (var product in rowProducts)
                {
                    Console.WriteLine(product);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }

        /*
         
         Методы для задания 7
         
         */

        static int[,] GenerateMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(1, 20);
                }
            }

            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            Console.WriteLine("Матрица:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int[] GetRowMult(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[] rowProducts = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                int product = 1;
                for (int j = 0; j < columns; j++)
                {
                    product *= matrix[i, j];
                }
                rowProducts[i] = product;
            }

            return rowProducts;
        }
        /*
         
         Методы для задания 7  КОНЕЦ.
         
         */


        //////////////////////////////////////////////////////////////////////
        ///                                                                ///
        ///                        Задание 8                               ///
        //////////////////////////////////////////////////////////////////////

        class Date
        {
            private int day;
            private int month;
            private int year;

            public Date(int day, int month, int year)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }

            public Date AddDays(int n)
            {
                DateTime dateTime = new DateTime(year, month, day);
                DateTime newDateTime = dateTime.AddDays(n);
                return new Date(newDateTime.Day, newDateTime.Month, newDateTime.Year);
            }

            public static List<Date> FindDatesOfYear(Date[] dates, int year)
            {
                List<Date> datesOfYear = new List<Date>();
                foreach (Date date in dates)
                {
                    if (date.year == year)
                    {
                        datesOfYear.Add(date);
                    }
                }
                return datesOfYear;
            }

            public override string ToString()
            {
                return $"{day}.{month}.{year}";
            }
        }


        static void Task8()
        {
            Console.WriteLine("Задание 8.\n");

            DateTime startDate = new DateTime(2022, 1, 1);
            DateTime endDate = new DateTime(2022, 12, 31);

            Console.Write("Введите количество случайных дат: ");
            int numberOfDates = int.Parse(Console.ReadLine());

            List<DateTime> dates = GenerateRandomDates(startDate, endDate, numberOfDates);

            Console.WriteLine("Исходные даты:");
            foreach (DateTime date in dates)
            {
                Console.WriteLine(date.ToShortDateString());
            }

            int n = 7;
            DateTime futureDate = dates[0].AddDays(n);
            Console.WriteLine($"\nДата, {n} дней вперед от {dates[0].ToShortDateString()}: {futureDate.ToShortDateString()}");

            int year = 2022;
            List<DateTime> datesOfYear = dates.FindAll(d => d.Year == year);
            Console.WriteLine($"\nДаты заданного года ({year}):");
            foreach (DateTime date in datesOfYear)
            {
                Console.WriteLine(date.ToShortDateString());
            }

            Console.Write("\nВведите индекс даты для удаления: ");
            int indexToRemove = int.Parse(Console.ReadLine());
            if (indexToRemove >= 0 && indexToRemove < dates.Count)
            {
                DateTime dateToRemove = dates[indexToRemove];
                dates.Remove(dateToRemove);

                Console.WriteLine($"\nИсходные даты после удаления {dateToRemove.ToShortDateString()}:");
                foreach (DateTime date in dates)
                {
                    Console.WriteLine(date.ToShortDateString());
                }
            }
            else
            {
                Console.WriteLine("Неверный индекс даты.");
            }
        }

        static List<DateTime> GenerateRandomDates(DateTime startDate, DateTime endDate, int count)
        {
            List<DateTime> dates = new List<DateTime>();
            Random random = new Random();
            TimeSpan range = endDate - startDate;

            for (int i = 0; i < count; i++)
            {
                int randomDays = random.Next(range.Days);
                DateTime randomDate = startDate.AddDays(randomDays);
                dates.Add(randomDate);
            }

            return dates;
        }



        //////////////////////////////////////////////////////////////////////
        ///                                                                ///
        ///                        Задание 9                               ///
        //////////////////////////////////////////////////////////////////////

        class Student
        {

            private string fio;
            private int day;
            private int month;
            private int year;

            public string FIO
            {
                get { return fio; }
                set { fio = value; }
            }

            public int Day
            {
                get { return day; }
                set { day = value; }
            }

            public int Month
            {
                get { return month; }
                set { month = value; }
            }

            public int Year
            {
                get { return year; }
                set { year = value; }
            }

            public Student()
            {
                fio = "";
                day = 0;
                month = 0;
                year = 0;
            }

            public Student(string fio, int day, int month, int year)
            {
                this.fio = fio;
                this.day = day;
                this.month = month;
                this.year = year;
            }

            public static Student InputStudent()
            {
                Console.WriteLine("Введите ФИО студента:");
                string fio = Console.ReadLine();

                Console.WriteLine("Введите день рождения:");
                int day = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите месяц рождения:");
                int month = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите год рождения:");
                int year = int.Parse(Console.ReadLine());

                return new Student(fio, day, month, year);
            }

            public void DisplayStudent()
            {
                Console.WriteLine($"ФИО: {fio}");
                Console.WriteLine($"Дата рождения: {day}.{month}.{year}");
            }

            public static int CalculateAgeDifference(Student student1, Student student2)
            {
                DateTime date1 = new DateTime(student1.year, student1.month, student1.day);
                DateTime date2 = new DateTime(student2.year, student2.month, student2.day);

                TimeSpan difference = date1 - date2;

                return Math.Abs(difference.Days);
            }

            public static void SearchStudentsByYear(Student[] students, int year)
            {
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i].year == year)
                    {
                        students[i].DisplayStudent();
                    }
                }
            }

            public static Student[] RemoveStudentByFIO(Student[] students, string fio)
            {
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i].fio == fio)
                    {
                        Student[] newStudents = new Student[students.Length - 1];
                        Array.Copy(students, 0, newStudents, 0, i);
                        Array.Copy(students, i + 1, newStudents, i, students.Length - i - 1);
                        return newStudents;
                    }
                }

                return students;
            }
        }

        static void Task9()
        {
            Console.WriteLine("Задание 9.\n");

            const int maxSize = 20;
            Student[] students = new Student[maxSize];
            int size = 0;

            int choice;
            do
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Начальное формирование массива");
                Console.WriteLine("2. Добавление студента в массив");
                Console.WriteLine("3. Вывод массива студентов на экран");
                Console.WriteLine("4. Вычисление разницы в возрасте для двух студентов");
                Console.WriteLine("5. Поиск всех студентов заданного года рождения");
                Console.WriteLine("6. Удаление студента с заданной фамилией");
                // Добавленные пункты меню
                Console.WriteLine("7. Начальное формирование массива на основе данных из текстового файла");
                Console.WriteLine("8. Запись массива студентов в текстовый файл");
                Console.WriteLine("0. Выход");
                Console.WriteLine();

                Console.Write("Введите номер операции: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Введите количество студентов: ");
                        int n = int.Parse(Console.ReadLine());
                        if (n > maxSize)
                            n = maxSize;

                        Console.WriteLine("Введите информацию о студентах:");
                        for (int i = 0; i < n; i++)
                        {
                            students[i] = Student.InputStudent();
                        }

                        size = n;
                        break;

                    case 2:
                        if (size < maxSize)
                        {
                            students[size] = Student.InputStudent();
                            size++;
                            Console.WriteLine("Студент добавлен в массив.");
                        }
                        else
                        {
                            Console.WriteLine("Массив студентов заполнен.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Массив студентов:");
                        for (int i = 0; i < size; i++)
                        {
                            students[i].DisplayStudent();
                            Console.WriteLine();
                        }
                        break;

                    case 4:
                        if (size >= 2)
                        {
                            Console.WriteLine("Введите номера студентов:");
                            Console.Write("Первый студент: ");
                            int student1Index = int.Parse(Console.ReadLine()) - 1;

                            Console.Write("Второй студент: ");
                            int student2Index = int.Parse(Console.ReadLine()) - 1;

                            if (student1Index >= 0 && student1Index < size && student2Index >= 0 && student2Index < size)
                            {
                                int ageDifference = Student.CalculateAgeDifference(students[student1Index], students[student2Index]);
                                Console.WriteLine($"Разница в возрасте: {ageDifference} дней.");
                            }
                            else
                            {
                                Console.WriteLine("Некорректные номера студентов.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Массив студентов содержит менее двух студентов.");
                        }
                        break;

                    case 5:
                        Console.Write("Введите год рождения: ");
                        int year = int.Parse(Console.ReadLine());
                        Student.SearchStudentsByYear(students, year);
                        break;

                    case 6:
                        Console.Write("Введите фамилию студента: ");
                        string fio = Console.ReadLine();
                        students = Student.RemoveStudentByFIO(students, fio);
                        size = students.Length;
                        break;

                    // Добавленные операции
                    case 7:
                        students = ReadStudentsFromFile("students.txt");
                        size = students.Length;
                        break;

                    case 8:
                        WriteStudentsToFile(students, "students.txt");
                        break;

                    case 0:
                        Console.WriteLine("Выход из программы.");
                        break;

                    default:
                        Console.WriteLine("Некорректный номер операции.");
                        break;
                }

                Console.WriteLine();
            } while (choice != 0);
        }

        static Student[] ReadStudentsFromFile(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            Student[] students = new Student[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(';');
                string fio = data[0];
                int day = int.Parse(data[1]);
                int month = int.Parse(data[2]);
                int year = int.Parse(data[3]);

                students[i] = new Student(fio, day, month, year);
            }

            return students;
        }

        static void WriteStudentsToFile(Student[] students, string fileName)
        {
            string[] lines = new string[students.Length];

            for (int i = 0; i < students.Length; i++)
            {
                string line = $"{students[i].FIO};{students[i].Day};{students[i].Month};{students[i].Year}";
                lines[i] = line;
            }

            File.WriteAllLines(fileName, lines);
        }


        //////////////////////////////////////////////////////////////////////
        ///                                                                ///
        ///                        Задание 10                              ///
        //////////////////////////////////////////////////////////////////////

        public abstract class CStr
        {
            protected string str;

            public CStr()
            {
                str = "";
            }

            public CStr(string s)
            {
                str = s;
            }
        }

        public class CStr_ID : CStr
        {
            public CStr_ID() : base()
            {
            }

            public CStr_ID(string s) : base(s)
            {
                if (!IsValidIdentifier(s))
                {
                    str = "";
                }
            }

            public CStr_ID(char c) : base(c.ToString())
            {
                if (!IsValidIdentifier(c.ToString()))
                {
                    str = "";
                }
            }

            public bool IsValidIdentifier(string s)
            {
                foreach (char c in s)
                {
                    if (!(Char.IsLetterOrDigit(c) || c == '_'))
                    {
                        return false;
                    }
                }

                return true;
            }

            public static bool operator >(CStr_ID str1, CStr_ID str2)
            {
                int minLength = Math.Min(str1.str.Length, str2.str.Length);

                for (int i = 0; i < minLength; i++)
                {
                    if (str1.str[i] > str2.str[i])
                    {
                        return true;
                    }
                    else if (str1.str[i] < str2.str[i])
                    {
                        return false;
                    }
                }

                return str1.str.Length > str2.str.Length;
            }

            public static bool operator <(CStr_ID str1, CStr_ID str2)
            {
                return str2 > str1;
            }

            public string Value
            {
                get { return str; }
                set
                {
                    if (!IsValidIdentifier(value))
                    {
                        str = "";
                    }
                    else
                    {
                        str = value;
                    }
                }
            }
        }


        public static void Task10()
        {
            Console.WriteLine("Задание 10.\n");

            CStr_ID s1 = new CStr_ID("abc");
            CStr_ID s2 = new CStr_ID("def456");
            CStr_ID s3 = new CStr_ID("abc123");
            CStr_ID s4 = new CStr_ID("ghi789");

            Console.WriteLine("s1 > s2: " + (s1 > s2));
            Console.WriteLine("s2 > s3: " + (s2 > s3));
            Console.WriteLine("s1 < s2: " + (s1 < s2));
            Console.WriteLine("s2 < s3: " + (s2 < s3));
            Console.WriteLine("s1 > s4: " + (s1 > s4));
            Console.WriteLine("s4 > s1: " + (s4 > s1));
        }


        //////////////////////////////////////////////////////////////////////
        ///                                                                ///
        ///                        Задание 11                              ///
        //////////////////////////////////////////////////////////////////////


        class Student11 : IComparable<Student11>, IComparer<Student11>
        {
            private string fio11;
            private int day11;
            private int month11;
            private int year11;

            public string FIO11
            {
                get { return fio11; }
                set { fio11 = value; }
            }

            public int Day11
            {
                get { return day11; }
                set { day11 = value; }
            }

            public int Month11
            {
                get { return month11; }
                set { month11 = value; }
            }

            public int Year11
            {
                get { return year11; }
                set { year11 = value; }
            }

            public Student11()
            {
                fio11 = "";
                day11 = 0;
                month11 = 0;
                year11 = 0;
            }

            public Student11(string fio, int day, int month, int year)
            {
                this.fio11 = fio;
                this.day11 = day;
                this.month11 = month;
                this.year11 = year;
            }

            public static Student11 InputStudent()
            {
                Console.WriteLine("Введите ФИО студента:");
                string fio = Console.ReadLine();

                Console.WriteLine("Введите день рождения:");
                int day = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите месяц рождения:");
                int month = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите год рождения:");
                int year = int.Parse(Console.ReadLine());

                return new Student11(fio, day, month, year);
            }

            public void DisplayStudent()
            {
                Console.WriteLine($"ФИО: {fio11}");
                Console.WriteLine($"Дата рождения: {day11}.{month11}.{year11}");
            }

            public static int CalculateAgeDifference(Student11 student1, Student11 student2)
            {
                DateTime date1 = new DateTime(student1.year11, student1.month11, student1.day11);
                DateTime date2 = new DateTime(student2.year11, student2.month11, student2.day11);

                TimeSpan difference = date1 - date2;

                return Math.Abs(difference.Days);
            }

            public static void SearchStudentsByYear(Student11[] students, int year)
            {
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i].year11 == year) 
                    {
                        students[i].DisplayStudent();
                    }
                }
            }

            public static Student11[] RemoveStudentByFIO(Student11[] students, string fio)
            {
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i].fio11 == fio)
                    {
                        Student11[] newStudents = new Student11[students.Length - 1];
                        Array.Copy(students, 0, newStudents, 0, i);
                        Array.Copy(students, i + 1, newStudents, i, students.Length - i - 1);
                        return newStudents;
                    }
                }

                return students;
            }

            public int CompareTo(Student11 other)
            {
                // Сравнение по ФИО
                return string.Compare(FIO11, other.FIO11);
            }

            public int Compare(Student11 x, Student11 y)
            {
                // Сравнение по ФИО
                return string.Compare(x.FIO11, y.FIO11);
            }
        }



        static void Task11()
        {
            Console.WriteLine("Задание 11.\n");

            while (true)
            {
                Console.Clear(); 

                Console.WriteLine("Выберите пункт меню:");
                Console.WriteLine("1. Отобразить массив студентов до сортировки");
                Console.WriteLine("2. Отсортировать массив студентов по ФИО");
                Console.WriteLine("3. Отсортировать массив студентов по дате рождения");
                Console.WriteLine("4. Найти студентов по году рождения");
                Console.WriteLine("5. Выход");

                Console.Write("Введите номер пункта: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayStudentsBeforeSorting();
                        break;
                    case 2:
                        SortStudentsByName();
                        break;
                    case 3:
                        SortStudentsByDateOfBirth();
                        break;
                    case 4:
                        SearchStudentsByYear();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Неверный номер пункта меню. Попробуйте снова.");
                        break;
                }

                Console.WriteLine("Нажмите Enter, чтобы продолжить...");
                Console.ReadLine();
            }
        }

        static void DisplayStudentsBeforeSorting()
        {
            Console.Clear(); 

            Student11[] students = new Student11[7];

            Random random = new Random();

            for (int i = 0; i < students.Length; i++)
            {
                int day = random.Next(1, 29);
                int month = random.Next(1, 13);
                int year = random.Next(1990, 2005);

                students[i] = new Student11($"Student{i + 1}", day, month, year);
            }

            Console.WriteLine("Массив студентов до сортировки:");
            foreach (Student11 student in students)
            {
                student.DisplayStudent();
                Console.WriteLine();
            }
        }

        static void SortStudentsByName()
        {
            Console.Clear(); 

            Student11[] students = new Student11[7];

            Random random = new Random();

            for (int i = 0; i < students.Length; i++)
            {
                int day = random.Next(1, 29);
                int month = random.Next(1, 13);
                int year = random.Next(1990, 2005);

                students[i] = new Student11($"Student{i + 1}", day, month, year);
            }

            Array.Sort(students);

            Console.WriteLine("Массив студентов после сортировки по ФИО:");
            foreach (Student11 student in students)
            {
                student.DisplayStudent();
                Console.WriteLine();
            }
        }

        static void SortStudentsByDateOfBirth()
        {
            Console.Clear(); 

            Student11[] students = new Student11[7];

            Random random = new Random();

            for (int i = 0; i < students.Length; i++)
            {
                int day = random.Next(1, 29);
                int month = random.Next(1, 13);
                int year = random.Next(1990, 2005);

                students[i] = new Student11($"Student{i + 1}", day, month, year);
            }

            Array.Sort(students, new Student11());

            Console.WriteLine("Массив студентов после сортировки по дате рождения:");
            foreach (Student11 student in students)
            {
                student.DisplayStudent();
                Console.WriteLine();
            }
        }

        static void SearchStudentsByYear()
        {
            Console.Clear(); 

            Student11[] students = new Student11[7];

            Random random = new Random();

            for (int i = 0; i < students.Length; i++)
            {
                int day = random.Next(1, 29);
                int month = random.Next(1, 13);
                int year = random.Next(1990, 2024);

                students[i] = new Student11($"Student{i + 1}", day, month, year);
            }

            Console.WriteLine("Введите год рождения для поиска студентов:");
            int searchYear = int.Parse(Console.ReadLine());

            Console.WriteLine($"Студенты с годом рождения {searchYear}:");
            Student11.SearchStudentsByYear(students, searchYear);
        }










//конец программы

    }
       
}

