class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a Number = ");
        int no = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Your Have Enter No is: "+no);
        Console.WriteLine();


        // Even No check 
        bool number=MathUtil.isEven(no);
        if (number==true)
            Console.WriteLine("The number "+no+" is even");
        else
            Console.WriteLine("Entered number is Not Even");


        //Odd No check
        bool number1=MathUtil.isOdd(no);
        if (number1==true)
            Console.WriteLine("Entered number is not odd");
        else
            Console.WriteLine("The number "+no+" is odd");


        //Prime No check
        bool number2=MathUtil.isPrime(no);
        if (number2==true)
            Console.WriteLine("The number "+no+" is prime");
        else
            Console.WriteLine("Entered number is not prime");
            

        //count no
        int number3=MathUtil.count(no);	
        Console.WriteLine("Entered No "+no+" of cout is = "+number3);

        //Reverse no
        int number4=MathUtil.reverse(no);	
        Console.WriteLine("Entered No "+no+" Reverse is = "+number4);
        Console.WriteLine("-------------------------------------");
    }
}