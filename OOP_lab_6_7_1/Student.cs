using System;

namespace OOP_lab_6_7_1
{
    class Student
    {
        private string _surename;
        private string _place;
        private DateTime _birthday;
        
        public string Surename
        {
            get => _surename;
            set => _surename = value;
        }
        public DateTime Birthday
        {
            get => _birthday;
            set => _birthday = value;
        }

        public string Place
        {
            get => _place;

            set => _place = value;
        }

        public Student()
        {
            Surename = "Не вказано";
            Place = "Не вказано";
            Birthday = DateTime.Parse("01.01.01");
        }
    }
}
