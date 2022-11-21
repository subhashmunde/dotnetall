class MathUtil{

	public static bool isEven(int a)
	{
		if (a % 2 == 0)
			return true;
		return false;
	}

    	public static bool isOdd(int a)
	{
		if (a % 2 == 0)
			return true;	
		return false;
	}

	public static bool isPrime(int a)
	{
        int m;
        if (a==1)
            return false;
        if (a==2 || a==3)
            return true;
        if ( ( a % 2) == 0)
            return false;

        for (m=3; m * m <=a; m+=2)	
        {	
            if((m % a) == 0)
            return false;
        }
            return true;	
	}



	public static int count(int a)
	{
	    int count = 0;
    	while (a != 0) 
		{
      		a = a/10;
      		++count;
    	}
	    return count;
	}


	public static int reverse(int a)
	{    
		int rem=0 ;
		int reverse = 0;
		while(a != 0)
		{
			rem = a % 10;
			reverse = reverse * 10 + rem;
			a = a /10;
		}
		return reverse;	
	}

}