﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarOrnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char cevap;
            do
            {
                int sayi;
                do
                {
                    Console.WriteLine("3 haneli bir sayı giriniz.");
                    sayi = int.Parse(Console.ReadLine());

                } while (sayi < 100 || sayi > 999);
                Console.WriteLine("tuttuğun sayıyı tersten düşün.");
                Console.ReadLine();
                Console.WriteLine("büyük olan sayıdan küçük sayıyı çıkar.");
                Console.ReadLine();
                Console.WriteLine("sonucun son rakamı ne?");
                int sonRakam = int.Parse(Console.ReadLine());
                switch (sonRakam)
                {
                    case 1:
                        Console.WriteLine("işleminin sonucu 891.");
                        break;
                    case 2:
                        Console.WriteLine("işlemin sonucu 792.");
                        break;
                    case 3:
                        Console.WriteLine("işlemin sonucu 693.");
                        break;
                    case 4:
                        Console.WriteLine("işlemin sonucu 594.");
                        break;
                    case 5:
                        Console.WriteLine("işlemin sonucu 495.");
                        break;
                    case 6:
                        Console.WriteLine("işlemin sonucu 396.");
                        break;
                    case 7:
                        Console.WriteLine("işlemin sonucu 297.");
                        break;
                    case 8:
                        Console.WriteLine("işlemin sonucu 198.");
                        break;
                    case 9:
                        Console.WriteLine("işlemin sonucu 099.");
                        break;
                    case 0:
                        Console.WriteLine("işlemin sonucu 000.");
                        break;
                    default:
                        Console.WriteLine("Son rakamı doğru girdiğinden emin ol.");
                        break;
                }
                Console.WriteLine("yeniden denemek ister misin? Cevabın evet ise e'yi tuşla.");
                cevap = Convert.ToChar(Console.ReadLine());
            } while (cevap=='e');
            Console.ReadKey();

            
        }
    }
}
