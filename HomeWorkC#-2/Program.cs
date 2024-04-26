namespace HomeWorkC__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolEmployee employee1 = new SchoolEmployee();
            employee1.Name = "Дмитрий";
            employee1.Female = "Иванович";
            employee1.Surname = "Иванов";
            employee1.Age = 10;
            Student student1 = new Student();
            student1.Name = "Дмитрий";
            student1.Female = "Иванович";
            student1.Surname = "Иванов";
            student1.Age = 10;
            student1.ClassNumber = 5;
            student1.ParentsNumber = "79544997940";
            SchoolTeacher teacher1 = new SchoolTeacher();
            HeadTeacher headTeacher1 = new HeadTeacher();
            SchollCleaner cleaner1 = new SchollCleaner();

            SchoolEmployee[] schoolEmployees = { employee1, student1, teacher1, headTeacher1, cleaner1};
            foreach (var item in schoolEmployees) 
            {
                Work(item);
            }
        }

        internal static void Work(SchoolEmployee schoolEmployee)
        {
            switch (schoolEmployee)
            {
                case HeadTeacher:
                    Console.WriteLine("Руководит");
                    break;
                case SchoolTeacher:
                    Console.WriteLine("Обучает");
                    break;
                case Student:
                    Console.WriteLine("Учится");
                    break;
                case SchollCleaner:
                    Console.WriteLine("Поддерживает порядок");
                    break;
            }
        }

    }
}
