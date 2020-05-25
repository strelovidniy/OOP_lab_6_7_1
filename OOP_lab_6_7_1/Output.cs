using System;

namespace OOP_lab_6_7_1
{
    class Output : IOutput
    {
        private bool isTwins = false;

        public void Write()
        {
            WriteTable();
            WriteTwins(Twins());
        }

        public void WriteTable()
        {
            Console.WriteLine("\n{0,-20}{1, -20}{2, -20}", "Прiзвище", "Дата народження", "Мiсце народження");

            for (int i = 0; i < Program.group.Length; ++i)
            {
                for (int j = 0; j < Program.group.Length - 1; ++j)
                {
                    if (Program.group[j].Birthday > Program.group[j + 1].Birthday)
                    {
                        string tempStr;
                        DateTime tempDate;

                        tempStr = Program.group[j].Surename;
                        Program.group[j].Surename = Program.group[j + 1].Surename;
                        Program.group[j + 1].Surename = tempStr;

                        tempDate = Program.group[j].Birthday;
                        Program.group[j].Birthday = Program.group[j + 1].Birthday;
                        Program.group[j + 1].Birthday = tempDate;

                        tempStr = Program.group[j].Place;
                        Program.group[j].Place = Program.group[j + 1].Place;
                        Program.group[j + 1].Place = tempStr;
                    }
                }
            }

            for (int i = 0; i < Program.group.Length; ++i)
            {
                Console.WriteLine("{0,-20}{1, -20}{2, -20}", Program.group[i].Surename, Program.group[i].Birthday.ToShortDateString(), Program.group[i].Place);
            }
        }

        public Student[][] Twins()
        {
            Student[][] twins = new Student[367][];

            int[] days = new int[367];

            for (int i = 0; i < 367; ++i)
            {
                days[i] = 0;
            }

            for (int i = 0; i < Program.group.Length; ++i)
            {
                ++days[Program.group[i].Birthday.DayOfYear];
            }

            for (int i = 0; i < 367; ++i)
            {
                twins[i] = new Student[days[i]];

                int index = 0;

                for (int j = 0; j < Program.group.Length; ++j)
                {
                    if (Program.group[j].Birthday.DayOfYear == i)
                    {
                        twins[i][index] = Program.group[j];

                        if (index > 0)
                        {
                            isTwins = true;
                        }

                        ++index;
                    }
                }
            }

            return twins;
        }

        public void WriteTwins(Student[][] twins)
        {
            if (isTwins)
            {
                Console.WriteLine("\nБлизнята:");
                Console.WriteLine("{0,-20}{1, -20}{2, -20}", "Прiзвище", "Дата народження", "Мiсце народження\n");

                for (int i = 0; i < twins.Length; ++i)
                {
                    if (twins[i].Length > 1)
                    {
                        for (int j = 0; j < twins[i].Length; ++j)
                        {
                            Console.WriteLine("{0,-20}{1, -20}{2, -20}", twins[i][j].Surename, twins[i][j].Birthday.ToShortDateString(), twins[i][j].Place);
                        }

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
