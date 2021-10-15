using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Parser
    {
        private string input;
        private char[] arrInput;

        public decimal leftOperand;
        public decimal rightOperand;
        public char operat;
        public decimal result;

        public bool stop = false;
        private int countOperat = 0;

        private void Input()
        {
            input = Console.ReadLine();
            input = input
                .Replace(" ", "")
                .Replace(",", ".")
                .Replace("=", "");
            arrInput = input.ToCharArray();

            CountAllOperat();
        }

        public void CountAllOperat()
        {
            foreach (var t in arrInput)
            {
                if (t == '-' || t == '+' || t == '*' || t == '/')
                {
                    countOperat++;
                }
            }
        }
        private static decimal ParseDecimal(string s)
        {
            return decimal.Parse(
                s,
                System.Globalization.NumberStyles.Number,
                System.Globalization.CultureInfo.InvariantCulture
            );
        }

        private bool OperatorFind()
        {
            if (arrInput.Length != 0)
            {
                for (int i = 0; i < arrInput.Length; i++)
                {
                    if (arrInput[i] == '+' || arrInput[i] == '-' || arrInput[i] == '*' || arrInput[i] == '/')
                    {
                        operat = arrInput[i];
                        return true;
                    }
                }
            }

            return false;
        }

        private void ParseLeftOperand()
        {
            string firstOperand = "";
            OperatorFind();

            if (arrInput.Length != 0)
            {
                for (int i = 0; i < arrInput.Length; i++)
                {
                    if (arrInput[i] == operat)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            firstOperand += arrInput[j];
                        }
                    }
                }

                if (OperatorFind() == false)
                {
                    for (int i = 0; i < arrInput.Length; i++)
                    {
                        firstOperand += arrInput[i];
                    }
                }
            }

            if (firstOperand != "")
            {
                try
                {
                    leftOperand = ParseDecimal(firstOperand);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Перше число введено не правильно");
                    stop = true;
                }
            }
        }

        private void ParseRightOperand()
        {
            string secondOperand = "";
            bool o = false;
            if (OperatorFind() == false)  // если знак операции еще не введен
            {
                Input();
                OperatorFind();
                for (int i = 0; i < arrInput.Length; i++)
                {
                    if (arrInput[i] == operat)
                    {
                        o = true;
                    }
                }
                if (OperatorFind() == true && o == true)
                {
                    for (int i = 0; i < arrInput.Length; i++)
                    {
                        if (arrInput[i] == operat)
                        {
                            for (int j = i + 1; j < arrInput.Length; j++)
                            {
                                secondOperand += arrInput[j];
                            }
                        }
                    }
                }

                if (secondOperand == "" && OperatorFind() == true)
                {
                    Input();
                    for (int i = 0; i < arrInput.Length; i++)
                    {
                        secondOperand += arrInput[i];
                    }
                }
            }
            else if (OperatorFind() == true)
            {
                for (int i = 0; i < arrInput.Length; i++)
                {
                    if (arrInput[i] == operat)
                    {
                        o = true;
                    }
                }

                if (o == true)
                {
                    for (int i = 0; i < arrInput.Length; i++)
                    {
                        if (arrInput[i] == operat)
                        {
                            for (int j = i + 1; j < arrInput.Length; j++)
                            {
                                secondOperand += arrInput[j];
                            }
                        }
                    }
                }

                if (secondOperand == "")
                {
                    Input();
                    for (int i = 0; i < arrInput.Length; i++)
                    {
                        secondOperand += arrInput[i];
                    }
                }
            }


            if (secondOperand != "")
            {
                try
                {
                    rightOperand = ParseDecimal(secondOperand);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Друге число введено не правильно");
                    stop = true;
                }
            }

        }

        public void Parse()
        {
            Input();
            ParseLeftOperand();
            ParseRightOperand();
        }

        public void CalcResult()
        {
            if (countOperat > 1)
            {
                Console.WriteLine("Більше одного знака дії.");
                stop = true;
            }

            if (stop == false)
            {
                Calculate();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{leftOperand} {operat} {rightOperand} = {result}");
                Console.ResetColor();

                countOperat = 0;
            }
        }

        public void Calculate(){} 
    }
}
