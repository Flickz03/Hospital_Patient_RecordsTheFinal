
using SQLite;
using System;
using System.IO;

namespace Hospital_Patient_Records
{
    public static class Database
    {
        public static SQLiteConnection Conn;

        public static void Initialize()
        {
            string path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "hospital_patient_records.db");

            Conn = new SQLiteConnection(path);
            Conn.CreateTable<Patient>();
        }
    }
}
