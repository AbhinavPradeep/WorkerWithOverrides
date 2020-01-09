namespace Work
{
    public class Plumby : Worker
    {

        public override void Work(string Cost, string Name)
        {
            Name = "PlumbyPoe";
            Cost = "$25";

            System.Console.WriteLine($"{Name} is now working for you at {Cost} per hour");
        }
    }
}