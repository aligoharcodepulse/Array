using System;
namespace Array
{
    class Program
    {
        static void Main()
        {
            
            int[] marks = {0,1,2,3,4,5,6,7,8,9 };
            int i = 0;

            foreach(var j in marks)
            {
                Console.WriteLine(j);

            }
        
            while( i<10)
            {
                Console.WriteLine(marks[i]);
                i++;

            } 

                int x =0;
                x = ++x;
                Console.WriteLine(x);
                int y =0;
                y =++y;
                Console.WriteLine(y); 

                var Name = 12;
                Console.WriteLine(Name);
                


        
            


        }



    }




}