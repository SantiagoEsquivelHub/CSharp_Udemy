partial class Program
{
    static void AbstractClassExample()
    {
        HomeAppliance myWasher = new WashingMachine { Brand = "Samsumg" };
        HomeAppliance myMicrowave = new Microwave { Brand = "DG" };

        myWasher.ShowBrand();
        myWasher.TurnOn();
        myMicrowave.ShowBrand();
        myMicrowave.TurnOn();
    }
}

abstract class HomeAppliance
{
    public string? Brand { get; set; }
    public abstract void TurnOn();
    public void ShowBrand()
    {
        WriteLine($"The brand of appliance is {Brand}");
    }
}

class WashingMachine : HomeAppliance
{
    public override void TurnOn()
    {
        WriteLine("The washing machine has started its wash cycle");
    }
}

class Microwave : HomeAppliance
{
    public override void TurnOn()
    {
        WriteLine("The microwave is heating the food");
    }
}