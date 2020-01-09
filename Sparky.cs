namespace Work
{
    public class Sparky : Worker
    {
        public override void Work(string Cost, string Name)
        {
            Name = "SparkySoe";
            Cost = "$25";

            System.Console.WriteLine($"{Name} is now working for you at {Cost} per hour");
        }
    }
}