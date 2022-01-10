using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Products.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Tovar[] tovari = JsonSerializer.Deserialize<Tovar[]>(jsonString);
            Tovar maxTovar = tovari[0];
            foreach (Tovar s in tovari)
            {
                if (s.Cena>maxTovar.Cena)
                {
                    maxTovar = s;
                }
            }
            Console.WriteLine("Самый дорогой товар {0}. Код самого дорогого товара {1}. Стоимость {2} рублей.", maxTovar.Name, maxTovar.Kod, maxTovar.Cena);
            Console.WriteLine("Для вывхода из программы нажмите любую клавишу");
            Console.ReadKey();
    }
    }
}
