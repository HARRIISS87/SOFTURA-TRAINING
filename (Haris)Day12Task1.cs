using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Task_10
{
    class Day12Task1
    {
        public static void Main()
        {
            Queue q = new Queue();
            q.Enqueue("Ice cream");
            q.Enqueue("Falooda");
            q.Enqueue("LCappuchino");
            q.Enqueue("Gulab jamuns");
            FileStream fs = new FileStream("Restaurant.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryWriter br = new BinaryWriter(fs);
            foreach (string cal in q)
            {
                br.Write("\n" + cal);
            }
            br.Flush();
            fs.Close();

        }
    }
}
