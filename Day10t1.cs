using System;
    class task1day10

    {
        
          public task1day10()
            {
                Console.WriteLine("Enter your name and age  :");
                string name = Console.ReadLine();
                int age = Convert.ToInt32 (Console.ReadLine());
                Console.WriteLine("Your name is:"+name);
                Console.WriteLine("Your age is:"+age);
            }
           public task1day10(string name,int age)
        { 
           Console.WriteLine("Your name is:"+name);
                Console.WriteLine("Your age is:"+age);
        }
        public static void Main()
        {
            task1day10 obj = new task1day10();
            Console.WriteLine("Enter your name and age :");
            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            task1day10 obj1 = new task1day10(name, age);
                    }
     }
