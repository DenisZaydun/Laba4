using System.Diagnostics;

namespace task2
{
    class A
    {
        public B[] Args; //Конструктор класса А принимает аргументы типа базового класса "Б"

        public A(B one, B two)  //Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
        {
            Args = new[] {one, two};
        }

        public A(B one, B two, B three)
        {
            Args = new[] {one, two, three};
        }

        public void PrintPropertiesToDebug()    //Выведите в дебаг информацию свойств производных класов.
        {
            Debug.WriteLine("Arguments properties:");

            foreach (var Argums in Args)
            {
                Argums.PropertiesInfo();
            }
        }
    }
}