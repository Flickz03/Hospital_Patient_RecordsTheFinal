
using System;
using System.Windows.Forms;

namespace Hospital_Patient_Records
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Database.Initialize();
            Application.Run(new Form1());
        }
    }
}
