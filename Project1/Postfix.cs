using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Postfix
    {
        public Queue<string> inputQueue = new Queue<string>();
        public Stack<string> numberStack = new Stack<string>();
        public Stack<string> operatorStack = new Stack<string>();


        public void InsertValue(string input)
        {
            if(input == "*" || input == "/")
            {
                operatorStack.Push(input);
            }
            else if(input == "+" || input == "-")
            {
                if (operatorStack.Count != 0)
                {
                    while (operatorStack.Count > 0 && operatorStack.Peek() != "(")
                    {
                        inputQueue.Enqueue(operatorStack.Pop());
                    }
                }
                operatorStack.Push(input);
            }
            else if(input == "(")
            {
                operatorStack.Push(input);
            }
            else if(input == ")")
            {
                while (operatorStack.Peek() != "(" && operatorStack.Count > 0)
                {
                    inputQueue.Enqueue(operatorStack.Pop());
                }

                operatorStack.Pop();
                //return 괄호 까지의 계산값
            }
            else if(input == "=")
            {
                while(operatorStack.Count != 0)
                {
                    inputQueue.Enqueue(operatorStack.Pop());
                }
                //return 계산값
            }
            else
            {
                inputQueue.Enqueue(input);
                //return input;
            }
        }

        public string Calculate()
        {
            while(inputQueue.Count != 0)
            {
                string item = inputQueue.Dequeue();

                if(item == "+" || item == "-" || item == "*" || item == "/")
                {
                    int num1 = int.Parse(operatorStack.Pop());
                    int num2 = int.Parse(operatorStack.Pop());

                    if (item == "+") operatorStack.Push((num2 + num1).ToString());
                    if (item == "-") operatorStack.Push((num2 - num1).ToString());
                    if (item == "*") operatorStack.Push((num2 * num1).ToString());
                    if (item == "/") operatorStack.Push((num2 / num1).ToString());
                }
                else
                {
                    operatorStack.Push(item);
                }
            }

            string result = operatorStack.Pop();
            inputQueue.Enqueue(result);
            return result;
        }

        public void Clear()
        {
            inputQueue.Clear();
            operatorStack.Clear();
        }

        public string Print()
        {
            string output = string.Empty;
            foreach(string str in inputQueue)
            {
                output += str;
            }

            return output;
        }
    }
}
