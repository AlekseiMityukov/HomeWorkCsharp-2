namespace HomeWorkC__2
{
    internal class Student: SchoolEmployee
    {
        internal int ClassNumber { get; set; }

        internal string parents_number;
        internal string ParentsNumber 
        { 
            get { return parents_number; }
            set 
            {
                bool CorrectDigit = value.All(char.IsDigit);
                if (value[0] == '7' && value.Length == 11 && CorrectDigit)
                {
                    parents_number = value;
                }
                else 
                {
                    Console.WriteLine("Номер введен не верно");
                }
              
            }
        }

    }
}
