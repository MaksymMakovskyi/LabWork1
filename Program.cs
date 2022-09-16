using System;

namespace LabWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A action1 = new A(1.943f, 14.43f); //об'єкт класу А: "action1"
            action1.C = 0; //присвоєння значення властивості "С"
            float c1 = action1.C; //витягування значення властивості "С" і присвоєння його в змінну "с1"
            //виведення значення властивості "c" в консоль
            Console.WriteLine($"Результат обчислення: {c1}");

            A action2 = new A(-23.46f, 17.16f);
            action2.C = 0;
            float c2 = action2.C;
            Console.WriteLine($"Результат обчислення: {c2}");

            A action3 = new A(149.147f, -96.478f);
            action3.C = 0;
            //виведення значення властивості "С" в консоль
            //також можна реалізувати за доромогою метода
            action3.ResultOfAction();
        }
    }
}
