using System.Runtime.Serialization.Formatters.Binary;
using Modul8_Task4;

DirectoryInfo dr;

string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
string students = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Students";



if (!Directory.Exists(students))
    dr = Directory.CreateDirectory(students);
else
    dr = new DirectoryInfo(students);

Student[] sts = new Student[8];


BinaryFormatter formatter = new BinaryFormatter();

using (var fs = new FileStream(@"C:\Users\мвидео\Desktop\Students.dat", FileMode.OpenOrCreate))
{
    try
    {
        Console.WriteLine(formatter.Deserialize(fs).ToString());
    }
    catch(Exception e)
    {
        Console.WriteLine(e);
        throw;
    }

    Console.WriteLine("Object has deserialated");
}