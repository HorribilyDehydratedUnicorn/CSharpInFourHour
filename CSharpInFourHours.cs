using System;

namespace C_
{
    class Program
    {
        static string DecToHex(double decIn)
        {
            string basse = "0123456789abcd";
            string hex = System.String.Empty;
            for (int i = 4; i >= 0; i--)
            {
                if ((decIn / Math.Pow(16, i)) >= 1)
                {
                    hex = hex.Insert(, Convert.ToString(basse[(int)(decIn / Math.Pow(16, i)) - 1]));
                    decIn = decIn - (int)Math.Pow(16, i) * (decIn / (int)Math.Pow(16, i));
                }
            }
            return hex;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter decimal number: ");
            double dec = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(DecToHex(dec));
        }
    }
}
