using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Common : Parser
    {
        public void Instruction()  
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("У Вас безкоштовна версія");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Інструкція: ");
            Console.WriteLine();
            Console.WriteLine("Введіть математичний приклад, який складається з двух чисел і знаком дії між цими числами.");
            Console.WriteLine("Приклад може бути введений частинами.");
            Console.WriteLine("Пробіли та знаки рівності ігноруються.");
            Console.WriteLine();
            Console.WriteLine("Можливі операції над числами: \nДодавання (+), \nВіднімання (-).");
            Console.WriteLine("Кількість доступних введеннь прикладів без перезапуску програми: 1");
            Console.WriteLine();
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
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Операція не доступна для безкоштовної версії");
                    Console.ResetColor();
                    stop = true;
                    break;
            }
        }

        public Common()
        {
            Instruction();
            Console.Write("\n↓↓↓\n");
            Parse();
            Calculate();
            CalcResult();
        }
    }
}
