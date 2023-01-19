namespace CS322_DZ11_Jovan_Spasic_4026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs k1 = new Kurs("CS322", 15, 10);
            Kurs k2 = new Kurs("IT381", 15, 7);

            Console.WriteLine(k1.CompareTo(k2));
        }
    }
}