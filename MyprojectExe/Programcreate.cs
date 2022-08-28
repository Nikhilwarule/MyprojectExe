using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Text.Json;



namespace MyprojectExe      //Binary serialization
{
    [Serializable]
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }

    }
    class Programcreate
    {
        static void BinarySerializationWrite(Student stud)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\My c#project\TestFolder\BinaryFile.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, stud);
                Console.WriteLine("Binary data added");
                fs.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void BinarySerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\My c#project\TestFolder\BinaryFile.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                Student stud = (Student)bf.Deserialize(fs);

                Console.WriteLine(stud.RollNo);
                Console.WriteLine(stud.Name);
                Console.WriteLine(stud.Percentage);
                fs.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Main(string[] args)
        {
            //Student stud = new Student { RollNo = 101, Name = "Suraj", Percentage = 89.44 };
            //BinarySerializationWrite(stud);
            BinarySerializationRead();

        }


    }
    class XML_Serialization  //xml serialization
    {
        static void XmlSerializationWrite(Student stud)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\My c#project\TestFolder\XmlFile.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Student));
                xs.Serialize(fs, stud);
                Console.WriteLine("Xml data added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void XmlSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\My c#project\TestFolder\XmlFile.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Student));
                Student stud = (Student)xs.Deserialize(fs);
                Console.WriteLine(stud.RollNo);
                Console.WriteLine(stud.Name);
                Console.WriteLine(stud.Percentage);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void Main(string[] args)
        {
            // Student stud = new Student { RollNo = 101, Name = "Suraj", Percentage = 89.44 };
            // XmlSerializationWrite(stud);
            XmlSerializationRead();
        }
    }

    class Json_serialization    //Json Serialization
    {
        static void JsonSerializationWrite(Student stud)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\My c#project\TestFolder\JsonFile.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<Student>(fs, stud);
                Console.WriteLine("Json data added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void JsonSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\My c#project\TestFolder\JsonFile.json", FileMode.Open, FileAccess.Read);
                Student stud = JsonSerializer.Deserialize<Student>(fs);
                Console.WriteLine(stud.RollNo);
                Console.WriteLine(stud.Name);
                Console.WriteLine(stud.Percentage);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void Main(string[] args)
        {
            // Student stud = new Student { RollNo = 101, Name = "Suraj", Percentage = 89.44 };
            // JsonSerializationWrite(stud);
            JsonSerializationRead();
        }

    }
    class Soap_Serialization
    {
        static void SoapSerializationWrite(Student stud)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\My c#project\TestFolder\SoapFile.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, stud);
                Console.WriteLine("Soap data added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void SoapSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\My c#project\TestFolder\SoapFile.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                Student stud = (Student)sf.Deserialize(fs);
                Console.WriteLine(stud.RollNo);
                Console.WriteLine(stud.Name);
                Console.WriteLine(stud.Percentage);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void Main(string[] args)
        {
           // Student stud = new Student { RollNo = 101, Name = "Suraj", Percentage = 89.44 };
            //SoapSerializationWrite(stud);
            SoapSerializationRead();
        }
    }

}
