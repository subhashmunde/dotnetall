namespace Hospital;

class InHousePatient : Patient
{
    private double discount;

    public InHousePatient(int id, String name, int bed, int day) : base(id, name, bed, day)
    {
        //    base.Id= id;
        //    base.Name=name;
        //    base.Bed=bed;
        //    base.Day=day;
    }

    public override double GetBillAmount()
    {
        double bill = base.GetBillAmount();
        discount = bill >= 5000 ? 5.0 : 0;
		
		return bill-bill * discount /100;
    }
}
