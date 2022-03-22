using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp2
{
    [Serializable]
    class employee
    {
        public String name = "Haris";
        public int salery = 1500000;
        public int year_of_experiance = 2, age = 19, empId = 39290031;

    }
    class serialization
    {
        public void seritofile()
        {
            employee emp = new employee();
            FileStream fs = new FileStream("Employee.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter f = new BinaryFormatter();
            f.Serialize(fs, emp);
            fs.Close(); ;
        }
        public void serioutfile()
        {
            FileStream fs1 = new FileStream("Employee.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter r = new BinaryFormatter();
            employee emp1 = (employee)r.Deserialize(fs1);
            Console.WriteLine(emp1.name);
            Console.WriteLine(emp1.salery);
            Console.WriteLine(emp1.year_of_experiance);
            
        }
        public static void Main()
        {
            serialization sere = new serialization();
            sere.seritofile();
            sere.serioutfile();
        }
    }
}