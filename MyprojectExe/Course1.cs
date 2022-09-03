using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace MyprojectExe
{
    [Serializable]
    internal class Course1
    {
        public int cid { get; set; }
        public string cname { get; set; }
        public int fees { get; set; }
        public int duration { get; set; }


    }
    public class sercourse
    {
        static void JsonSerializationWrite(Course1 ct)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\My c#project\TestFolder\JsonFile.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<Course1>(fs, ct);
                Console.WriteLine("json  data added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
       /* static void JsonSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\My c#project\TestFolder\JsonFile.json", FileMode.Open, FileAccess.Read);
                Course1 ct = JsonSerializer.Deserialize<Course1>(fs);
                Console.WriteLine(ct.cid);
                Console.WriteLine(ct.cname);
                Console.WriteLine(ct.fees);
                Console.WriteLine(ct.duration);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }*/
        static void Main(string[] args)
        {
            Course1 csd = new Course1 { cid = 101, cname = "CSHARP", fees = 5000, duration = 5 };

            JsonSerializationWrite(csd);
           // JsonSerializationRead();


        }
    }

}