using Hospital;

using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Patient Id : ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Patient Name : ");
        String name = Console.ReadLine();

        Console.Write("Enter Bed Type : ");
        int bed = int.Parse(Console.ReadLine());

        Console.Write("Enter No Of Days : ");
        int day = int.Parse(Console.ReadLine());

        Patient p = new Patient(id, name, bed, day);
        double bill1 = p.GetBillAmount();
        Console.Write("Patient Total Bill= : {0:0.00} ", bill1);

        InHousePatient hp = new InHousePatient(id, name, bed, day);
        double bill2 = hp.GetBillAmount();
        Console.Write("\nIn House Patient Total Bill= : {0:0.00} ", bill2);
    }
}