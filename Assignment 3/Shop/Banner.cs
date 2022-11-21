namespace Shop;
    class Banner
    {
        public double height;
        public double width;
        public double Height { get; set; }
        public double Width { get; set; }

        public Banner(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public Banner()
        {
            height = 10;
            width = 20;
        }

        public virtual double GetArea()
        {
            return height * width;
        }
    }



