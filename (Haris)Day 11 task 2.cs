public static void Main()

            {
                FileStream fs = new FileStream
                        ("T:\\softura\\Employee.txt" ,
                        FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryWriter bw = new BinaryWriter(fs);
           BinaryWriter bw1= new BinaryWriter(fs);
            BinaryWriter bw2= new BinaryWriter(fs);
            BinaryWriter bw3= new BinaryWriter(fs);
            bw.Write("AZWVS");
            bw1.Write("MANI");
            bw2.Write("23");
            bw2.Write("Male");
            bw.Flush();
                fs.Close();
                FileStream fs1 = new FileStream(@"T:\softura\Employee.txt", FileMode.Open, FileAccess.ReadWrite);
            BinaryReader br = new BinaryReader(fs1);
            BinaryReader br1= new BinaryReader(fs1);
            BinaryReader br2=new BinaryReader(fs1);
            BinaryReader br3= new BinaryReader(fs1);
            string str = br.ReadString();
            string str1= br1.ReadString();
            string str2 = br2.ReadString();
            string str3 = br3.ReadString();
            Console.WriteLine(str);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            fs1.Close();
                Console.Read();
            }


        }
    }