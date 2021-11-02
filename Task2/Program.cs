using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Товар[] arr = new Товар[5];
            Товар товар = new Товар();
            string path = "C:/Users/Professional/Desktop/ИТМО_учеба/Lab16.1/Products.json";
            string jsonString1 = File.ReadAllText(path);
            arr = JsonSerializer.Deserialize<Товар[]>(jsonString1);

            Array.Sort(arr);//Сортируем массив объектов класса "Товар" по полю "Цена товара" по убыванию.//
                            //И выводим последнюю строку массива в которой будет товар с максимальной ценой!
            Console.WriteLine(arr[4].КодТовара + " " + arr[4].НазваниеТовара + " " + arr[4].ЦенаТовара);
            Console.ReadKey();
        }
    }
    class Товар : IComparable<Товар>
    {
        public uint КодТовара { get; set; }
        public string НазваниеТовара { get; set; }
        public double ЦенаТовара { get; set; }
        public Товар()
        {
            this.КодТовара = КодТовара;
            this.НазваниеТовара = НазваниеТовара;
            this.ЦенаТовара = ЦенаТовара;
        }

        public int CompareTo(Товар т)
        {
            return this.ЦенаТовара.CompareTo(т.ЦенаТовара);
        }
    }
}
