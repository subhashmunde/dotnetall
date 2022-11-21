namespace Hospital;

class Patient
{
    private int id;
    private string name;
    private int bed;
    private int day;

    public int Id { get; set; }
    public string Name { get; set; }
    public int Bed { get; set; }
    public int Day { get; set; }

    public Patient(int pid, String pname, int pbed, int pday)
    {
        id = pid;
        name = pname;
        bed = pbed;
        day = pday;
    }

    public Patient() : this(12,"Suraj",2,12)
        {
        }

    public int GetPricePerDay()
    {
        int bt;
        switch (bed)
        {

            case 1:
                bt = 500;
                break;

            case 2:
                bt = 350;
                break;

            default:
                bt = 200;
                break;
        }
        return bt;
    }

    public virtual double GetBillAmount()
    {
        double amount;
        amount = day * GetPricePerDay();
        return amount;
    }
}