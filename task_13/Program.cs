using System;

namespace task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("москва", 30, 12, 5);  //создаем экземпляр класса
            building.Print();
            Console.WriteLine();
            MultiBuilding multiBuilding = new MultiBuilding("спб", 48, 15, 12,3);   //создаем экземпляр класса
            multiBuilding.Print();
            Console.ReadKey();
        }
        class Building
        {
            public string Adress { get; set; }  //адрес
            public double Length { get; set; }  //длина здания
            public double Width { get; set; }   //ширина здания
            public double Height { get; set; }  //высота здания
            public Building(string a, double l, double w, double h) //конструктор класса
            {
                Adress = a;
                Length = l;
                Width = w;
                Height = h;
            }
            public void Print()
            {
                Console.WriteLine("Адрес здания: {0}", Adress);
                Console.WriteLine("Длина здания: {0}", Length);
                Console.WriteLine("Ширана здания: {0}", Width);
                Console.WriteLine("Высота здания: {0}", Height);
            }
        }
        sealed class MultiBuilding : Building   //класс наследник
        {
            public int Floors { get; set; } //поле этажность
            public MultiBuilding(string a, double l, double w, double h, int f) //конструктор класса наследника
            : base(a, l, w, h)
            {
                Floors = f;
            }
            public new void Print() //переопределяем метод базового класса
            {
                base.Print();   //вызываем метод базового класса
                Console.WriteLine("Этажность здания: {0}", Floors);
            }
        }
    }
}