using System;

namespace OOP_lab_6_7_1
{
    class Input : IInput
    {
        public void Read()
        {
            ReadTable();
        }

        public void ReadTable()
        {
            Console.Write("Введiть данi про студентiв групи.\nКiлькiсть студентiв: ");

            for (int i = 0; i < Program.group.Length; ++i)
            {
                Program.group[i] = new Student();

                Console.WriteLine("Студент №{0}:", i + 1);

                Console.Write("Прiзвище: ");
                Program.group[i].Surename = Console.ReadLine();

                Retry:
                {
                    Console.Write("Дата народження: ");

                    if (DateTime.TryParse(Console.ReadLine(), out DateTime tempDate))
                    {
                        Program.group[i].Birthday = tempDate;
                    }
                    else
                    { 
                        Console.WriteLine("Неправильний формат!");
                        goto Retry;
                    }
                }

                Console.Write("Мiсце народження: ");
                Program.group[i].Place = Console.ReadLine();
            }
        }
    }
}
