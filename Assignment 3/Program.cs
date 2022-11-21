using Shop;
using System;
class BannerTest
{
    public static double bannerPrice(Banner info, int copies)
    {
        double rate = copies < 5 ? 10 : 12;
        return rate * copies * info.GetArea();
    }

    public static void Main(string[] args)
    {
        // int height = int.Parse(args[0]);
        // int width = int.Parse(args[1]);

        Console.Write(" Enter Height : ");
        double height = double.Parse(Console.ReadLine());

        Console.Write(" Enter width : ");
        double width = double.Parse(Console.ReadLine());

        Banner b = new Banner(height, width);
        double area1 = b.GetArea();
        Console.Write(" Area of Simple Banner : " + area1);

        //Console.Write("\n Enter Radius Of Curved Banner : ");
        //float radius = float.Parse(Console.ReadLine());

        CurvedBanner cb = new CurvedBanner(height, width, 0.85f);
        double area2 = cb.GetArea();
        Console.Write("\n Area of Curved Banner : " + area2);

        Console.Write("\n Enter No of Copies Of Banner : ");
        int copies = Convert.ToInt32(Console.ReadLine());

        double price1 = bannerPrice(b, copies);
        Console.Write(" Total Price Of Banner = {0:0.00} " , price1);

        double price2 = bannerPrice(cb, copies);
        Console.Write("\n Total Price Of Curved Banner = {0:0.00} " , price2);
    }
}
