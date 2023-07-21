
namespace Array{
    class Program{
     static void Main(){
        int num = 4;
        if(num % 2==0)
        {
            Console.WriteLine("num is even");

        }
        else
        {
            Console.WriteLine("num is odd");
        }
        bool iseven = false;
         iseven =num%2==0? true:false;
            Console.WriteLine("num is even="+iseven);

            int a= 3;
            int b= 4;
            var m= a>b?  a:b;
            Console.WriteLine("max is"+m);

            
    
    
     }
    }
}