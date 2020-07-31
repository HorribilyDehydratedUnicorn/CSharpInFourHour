using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter decimal number: ");
            int dec = Convert.ToInt32(Console.ReadLine());
            string hex = "";
            Worker(dec);
            int Worker(int dec)
            {
                string basse = "0123456789ABCDEF";
                int rem;
                if (dec % 16 > 0)
                    {
                        rem = dec % 16;
                        hex = hex.Insert(hex.Length, basse[rem].ToString());
                        dec = dec - 16 * (dec / 16);
                        return rem;
                    }
                rem = dec % 16;
                return rem;
            }
            Console.WriteLine(hex);
        }
    }
}
