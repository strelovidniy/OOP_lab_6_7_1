using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab_6_7_1
{
    interface IOutput
    {
        void WriteTable();

        Student[][] Twins();

        void WriteTwins(Student[][] twins);
    }
}
