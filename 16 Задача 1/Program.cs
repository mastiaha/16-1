using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace _16_Задача_1
{
   
        class Program
        {
            static void Main(string[] args)
            {
                const int n = 5;
                Tovar[] tovari = new Tovar[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Введите код товара");
                    int kod = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите название товара");
                    string name = Console.ReadLine();
                    Console.WriteLine("Введите стоимость товара");
                    double cena = Convert.ToDouble(Console.ReadLine());
                    tovari[i] = new Tovar() { Kod = kod, Name = name, Cena = cena };
                }

                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                    WriteIndented = true
                };
                string jsonString = JsonSerializer.Serialize(tovari, options);

                using (StreamWriter sw = new StreamWriter("../../../Products.json"))
                {
                    sw.WriteLine(jsonString);
                }
            Console.ReadKey();
            }
        }
    
}
