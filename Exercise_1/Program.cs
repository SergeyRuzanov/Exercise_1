using System.IO;
using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string interlocutorName = "";
            string boyName = "Fedya";
            string pathInput = Environment.CurrentDirectory + "\\INPUT.txt";
            string pathOutput = Environment.CurrentDirectory + "\\OUTPUT.txt";

            try
            {
                using (StreamReader sr = new StreamReader(pathInput))
                {
                    interlocutorName = GetInterlocutorName(sr.ReadLine());
                    using (StreamWriter sw = new StreamWriter(pathOutput, false))
                    {
                        int replicaNumber = 1;
                        string strInput;
                        while (!(strInput = sr.ReadLine()).EndsWith($"{interlocutorName} signed off"))
                        {
                            string strOutput = "";

                            if (replicaNumber / 2 == 0)
                                strOutput = TransformToIndirect(strInput, boyName);
                            else
                                strOutput = TransformToIndirect(strInput, interlocutorName);

                            sw.WriteLine(strOutput);
                            replicaNumber++;
                        }
                    }
                }
                Console.WriteLine("Преобразование выполнено успешно.");
            }
            catch (FileNotFoundException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Файл {pathInput} не найден!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Во время преобразования произошла ошибка. Проверьте входные данные.");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ReadLine();
        }

        static string GetInterlocutorName(string firstString)
        {
            string str = "";
            int i = 10;
            while (firstString[i] != ' ')
            {
                str += firstString[i];
                i++;
            }
            return str;
        }

        static string TransformToIndirect(string str, string name)
        {
            int lastIndex = str.Length - 1;
            if (str[lastIndex] == '.' || (str[lastIndex] != '!' && str[lastIndex] != '?'))
            {
                str.TrimEnd('.');
                str += ',';
            }
            str = str.Substring(10);
            str = str.Insert(0, "\"");
            str += "\"";
            str += $" --- skazal {name}.";
            return str;
        }
    }
}
