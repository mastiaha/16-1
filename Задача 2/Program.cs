using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Tovar.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Tovar[] tovari = JsonSerializer.Deserialise<Tovar[]>(jsonString);
        }
    }
}
