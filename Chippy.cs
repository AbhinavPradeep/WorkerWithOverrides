namespace Work
{
    public class Chippy : Worker
    {
        public override void Work(string Cost, string Name)
        {
            Name = "ChippyCho";
            Cost = "$25";

            System.Console.WriteLine($"{Name} is now working for you at {Cost} per hour");
        }
    }
}