using System;


namespace Test_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Последовательность символов: \n{0}\n", Properties.Resources.Input);
            Console.WriteLine("Введите символ для поиска самой длинной непрерывной цепочки");
            char SearchChar = (char)Console.ReadLine()[0];

            int MaxSequence = Properties.Resources.Input.GetLenghtOfMaxSubsequence(SearchChar);

            if (MaxSequence == 0)
            {
                string output = "Непрерывной последовательности из символов '" + SearchChar + "' нет!";
                System.IO.File.WriteAllText("../../Resouces/Output.txt", output);
                Console.WriteLine(output);
            }
            else
            {
                string output = "Длина непрерывной последовательности из символов '" + SearchChar + "' : "+ MaxSequence + " знаков \n"+ new string(SearchChar, MaxSequence);
               System.IO.File.WriteAllText("../../Resouces/Output.txt", output);
                Console.WriteLine(output);
            }
        }
    }
}
