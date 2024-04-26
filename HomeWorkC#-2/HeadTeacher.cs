namespace HomeWorkC__2
{
    internal class HeadTeacher: SchoolEmployee
    {
        internal string Email { get; set; }

        internal string number;
        internal string Number 
        { 
            get { return number; }
            set 
            {
                bool CorrectDigit = value.All(char.IsDigit);
                if (value[0] == '7' && value.Length == 11 && CorrectDigit)
                {
                    number = value;
                }
                else
                {
                    Console.WriteLine("Номер введен не верно");
                }
            }
        }

        internal int ExperienceWork { get; set; }
    }
}
