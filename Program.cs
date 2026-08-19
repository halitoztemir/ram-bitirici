using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Kac MB RAM harcansin?: ");
        if (int.TryParse(Console.ReadLine(), out int megabytes) && megabytes > 0)
        {
            try
            {
                List<byte[]> ramTuketici = new List<byte[]>();
                for (int i = 0; i < megabytes; i++)
                {
                    byte[] buffer = new byte[1024 * 1024];
                    for (int j = 0; j < buffer.Length; j += 4096) 
                    {
                        buffer[j] = 1;
                    }
                    ramTuketici.Add(buffer);
                }
                Console.WriteLine($"\n[BASARILI] Su anda yaklasik {megabytes} MB RAM tuketiliyor.");
                Console.WriteLine("RAM'i serbest birakmak ve kapatmak icin ENTER'a basin...");
                Console.ReadLine();
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("\n[HATA] Sisteminizde bu kadar serbest RAM yok!");
            }
        }
        else
        {
            Console.WriteLine("Gecerli bir sayi girin.");
        }
    }
}
