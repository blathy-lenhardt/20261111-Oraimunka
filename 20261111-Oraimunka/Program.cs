namespace _20261111_Oraimunka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat: Kérjen be a felhasználótól egy egész számot, és írja ki a szorzótábláját 1-től 10-ig
            //  (pl. 5 * 1 = 5, 5 * 2 = 10, ..., 5 * 10 = 50)!
            Console.WriteLine("1. feladat");
            int num;
            Console.Write("Adjon meg egy egész számot: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
            }
        }
    }
}
