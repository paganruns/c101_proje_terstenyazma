class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir şeyler yazınız.");
            string metin = Console.ReadLine();
            string[] Metin = metin.Split(' ');

            foreach (string item in Metin)
            {
                for (int i = item.Length - 1; i >= 0; i--)
                {
                    Console.Write(item[i]);
                }
                Console.Write(" ");
            }
    }
}