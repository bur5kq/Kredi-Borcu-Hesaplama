
using System;

namespace krediborcu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kredi Borcu Hesaplama Programı");
            Console.Write("Top Kredi Limitin Ne Kadar = ");
            int kredilimiti = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Toplam Kredi Borcun Ne Kadar = ");
            double krediborcu = Convert.ToDouble(Console.ReadLine());
            double kullanılabilenlimit = (kredilimiti - krediborcu);
            Console.WriteLine();
            Console.Write("Ne Kadar Ödeme Yapacaksın = ");
            double yapılacaködeme = Convert.ToDouble(Console.ReadLine());
            double kalanborc = (krediborcu-yapılacaködeme);
            Console.WriteLine();
            Console.WriteLine("Sonuç:");
            Console.WriteLine("Kredi Limiti " + kredilimiti);
            Console.WriteLine("Kredi Borcu " + krediborcu);
            Console.WriteLine("Kullanılabilen Limit " + kullanılabilenlimit);
            Console.WriteLine("Bu Ay yapacağın ödeme " + yapılacaködeme);

            Console.Write("Asgari Borcun "+ krediborcu/5);
            if (krediborcu / 5 < yapılacaködeme) 
            {
                Console.WriteLine(" Bu Ay Asgari Ödeme Kalmamıştır"); 
            }

            else
            {
                double kalanödeme = (krediborcu / 5 - yapılacaködeme);
                Console.WriteLine(" Bu Ay " + kalanödeme + " Kadar Ödemen Kalmıştır");
            }
            Console.WriteLine("Kalan Borcunuz " + kalanborc);
            
        }
    }
}