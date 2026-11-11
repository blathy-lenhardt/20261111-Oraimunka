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
            Console.WriteLine();

            // 2. feladat: Készítsen programot, amely beolvas egy N számot, és kiszámolja a faktoriálisát (Pl. 3! = 3 × 2 × 1 = 6)!
            Console.WriteLine("2. feladat");
            int n, factorial = 1;
            Console.Write("Adjon meg egy egész számot: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("{0}! = {1}", n, factorial);

            // 3. feladat: Kérjen be számokat a felhasználótól mindaddig, amíg a 0-át nem üti be.
            //  A végén adja össze az összes addig megadott számot, és írja ki a végösszeget!
            Console.WriteLine("3. feladat");
            int sum = 0, num3;
            do
            {
                Console.Write("Adjon meg egy számot: ");
                num3 = Convert.ToInt32(Console.ReadLine());
                sum += num3;
            }
            while (num3 != 0);
            Console.WriteLine("A megadott számok összege: {0}", sum);
        }
    }
}
