using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace Lab16._1
{
    class Program
    {
        static void Arr(ref Товар товар)
        {
            Console.WriteLine("Код товара:");
            товар.КодТовара = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Наименование товара:");
            товар.НазваниеТовара = Console.ReadLine();
            Console.WriteLine("Цена товара:");
            товар.ЦенаТовара = Convert.ToDouble(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите параметры 5-ти товаров");
            Товар[] товар = new Товар[5];
            Товар товар1 = new Товар();
            Товар товар2 = new Товар();
            Товар товар3 = new Товар();
            Товар товар4 = new Товар();
            Товар товар5 = new Товар();
            Console.WriteLine("Введите параметры товара 1");
            Arr(ref товар1);
            товар[0] = товар1;
            Console.WriteLine("Введите параметры товара 2");
            Arr(ref товар2);
            товар[1] = товар2;
            Console.WriteLine("Введите параметры товара 3");
            Arr(ref товар3);
            товар[2] = товар3;
            Console.WriteLine("Введите параметры товара 4");
            Arr(ref товар4);
            товар[3] = товар4;
            Console.WriteLine("Введите параметры товара 5");
            Arr(ref товар5);
            товар[4] = товар5;

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic)
            };
            string jsonString = JsonSerializer.Serialize(товар, options);
            Console.WriteLine(jsonString);
            string path = "C:/Users/Professional/Desktop/ИТМО_учеба/Lab16.1/Products.json";

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(jsonString);
            }
            Console.ReadKey();
        }
    }
    class Товар
    {
        public uint КодТовара { get; set; }
        public string НазваниеТовара { get; set; }
        public double ЦенаТовара { get; set; }
    }
}
