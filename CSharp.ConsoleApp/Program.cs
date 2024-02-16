namespace CSharp.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{input[i]} → {(int)input[i]}");
            }
        }
    }
}