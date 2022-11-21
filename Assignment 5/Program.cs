using bank;

class Program
{
    public static double compute(Loan l)
    {
        return l.EMI();
    }

    public static void Main(String[] args)
    {

        Console.Write(" Enter principle : ");
        double principle = double.Parse(Console.ReadLine());

        Console.Write(" Enter period : ");
        double period = double.Parse(Console.ReadLine());


        var a = new Personal(principle, period);
        var b = new Home(principle, period);

        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine(" Personal Loan EMI = {0:0.00} ", Program.compute(a));
        Console.WriteLine(" EMI for Personal Loan with GST = {0:0.00}\n ", a.GST(Program.compute(a)));
        Console.WriteLine(" Home Loan EMI = {0:0.00} ", Program.compute(b));
        Console.WriteLine(" EMI for Home Loan with discount = {0:0.00} ", b.Discountable(Program.compute(b)));
        Console.WriteLine("------------------------------------------------------");
    }
}

