namespace Shop;
class CurvedBanner : Banner
{
    private float radius;
    // public float Radius { get; set; }

    public CurvedBanner(double height, double width, float radius)
    {
        base.height = height;
        base.width = width;
        this.radius = radius;
    }

    public override double GetArea()
    {
        return base.GetArea()- 0.86f * radius * radius;
    }
}


