using System;

namespace LabWork1
{
    internal class A
    {
        //всі змінні оголошені в класі
        float a;
        float b;
        private float c;

        public float C
        {
            //повернення значення властивості в метод Main
            get { return c; }
            //присвоєння властивості результату виконання дій над полями
            set { c = (a += b) - 0.01f; }
        }

        public A(float a, float b) //конструктор
        {
            this.a = a;
            this.b = b;
        }

        public void ResultOfAction()
        {
            //виведення значення властивості в консоль
            Console.WriteLine($"Результат обчислення: {c}");
        }
    }
}
