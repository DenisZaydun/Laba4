using System;

namespace task4
{
    class Pro : Parser
    {
        public void Instruction() //6
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("У Вас Pro версія");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Інструкція: ");
            Console.WriteLine("Введіть математичний приклад, який складається з двух чисел і знаком дії між цими числами.");
            Console.WriteLine("Приклад може бути введений частинами.");
            Console.WriteLine("Пробіли та знаки рівності ігноруються.");
            Console.WriteLine();
            Console.WriteLine("Можливі операції над числами: \nДодавання (+), \nВіднімання (-), \nМноження (*), \nДілення (/).");
            Console.WriteLine("Кількість доступних введеннь прикладів без перезапуску програми: НЕОБМЕЖЕНО");
            Console.WriteLine();
        }

        public new void Calculate()
        {
            switch (operat)
            {
                case '+':
                    result = leftOperand + rightOperand;
                    break;
                case '-':
                    result = leftOperand - rightOperand;
                    break;
                case '*':
                    result = leftOperand * rightOperand;
                    break;
                case '/':
                    result = leftOperand / rightOperand;
                    break;
            }
        }

        public Pro()
        {
            Instruction();
            do
            {
                Console.Write("\n↓↓↓\n");
                Parse();
                Calculate();
                CalcResult();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\n\t--Натисніть \"Enter\" для продовження, або \"Esc\", щоб завершити--");
                Console.ResetColor();
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
