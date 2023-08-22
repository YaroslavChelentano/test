namespace VariablesAndIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 5;
            var name = "Oleg";
            var damage = 50;
            var isInHead = damage == 100;
            if (isInHead)
            {
                Console.WriteLine("Head");
            }
            else
            {
                Console.WriteLine("Body");
            }
        }
    }
}
