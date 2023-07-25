namespace SyntaxSugarExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Explicit typing
            int number = 10;
            string name = "Seth";
            int num;

            //Inferred typing
            var otherNumber = 20;
            var otherName = "John";

            //Inline IF (Ternary)
            var age = 3;
            
            Console.WriteLine((age >= 18) ? "You are an adult" : (age < 5) ? "You are a baby" : "You are a minor");


            //Concatenation vs String interpoloation
            string middleName = "S";
            Console.WriteLine("Seth" + middleName + "Bowman");
            Console.WriteLine($"Seth {middleName} Bowman");
        }
    }
}