using System.Reflection.Metadata;

namespace chapter04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //04-16
            {
                Console.WriteLine("16번 문제, 짝수출력");
                for (int i = 1; i < 100; i++)
                {
                    if (i % 2 != 0)
                    {
                        continue;
                    }
                    Console.WriteLine(i);
                }
            }

            {
                Console.WriteLine("17번 문제, 0~10 반복문");
                var start = 0;
                while (start <= 10)
                {
                    Console.WriteLine(start);
                    ++start;
                }
            }

            {
                Console.WriteLine("18번 문제, 1~10 홀수 출력");
                var start = 1;
                do
                {
                    if (start % 2 != 0)
                    {
                        Console.WriteLine(start);
                    }
                    ++start;
                }
                while (start <= 10);
            }

            {
                Console.WriteLine("19번 문제, 트리만들기");
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10 - i - 1; j++)
                        Console.Write(' ');

                    for (int j = 0; j < (2 * i) + 1; j++)
                        Console.Write('*');

                    Console.Write('\n');
                }
            }

            {
                Console.WriteLine("20번 문제,큰수와 작은수 출력");
                {
                    int[] inputArray = new int[5];

                    for (int i = 0; i < inputArray.Length; i++)
                    {
                        Console.Write("숫자를 입력해주세요");
                        int input = int.Parse(Console.ReadLine());

                        inputArray[i] = input;
                    }

                    int maxvalue = int.MaxValue;
                    for (int i = 0; i < inputArray.Length; i++)
                    {
                        if (inputArray[i] > maxvalue)
                            maxvalue = inputArray[i];
                    }

                    int minvalue = int.MinValue;
                    for (int i = 0; i < inputArray.Length; i++)
                    {
                        if (inputArray[i] < minvalue)
                            minvalue = inputArray[i];
                    }
                    Console.WriteLine($"가장 큰 수 : {maxvalue}");
                    Console.WriteLine($"가장 작은 수 : {minvalue}");
                }
            }

        }
    }
}