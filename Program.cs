
namespace thirdHomework
{

    //  ОСНОВНОЕ ЗАДАНИЕ

    /*internal class MainTask
    {
        static void Main()
        {
            string text = "This page allows you to generate random text strings using true randomness, which for many purposes is better than the pseudo-random number algorithms ...";
            CountOfSymbols(text);
        }

        static void CountOfSymbols(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    int count = text.Length - text.Replace(text[i].ToString(), "").Length;
                    Console.WriteLine($"Символ {text[i]} - встречается в строке {count} раз(а).");
                    text = text.Replace(text[i--].ToString(), "");
                }
            }
        }
    }*/

    /*internal class AdditionalTask1
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            char[] array = (number.ToString()).ToCharArray();

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        (array[i], array[j]) = (array[j], array[i]);
                    }
                }
            }
            int biggestNumber = int.Parse(array);
            Console.WriteLine(biggestNumber);
        }
    }*/

    /*internal class AdditionalTask3
    {
        static void Main()
        {
            string text = "текст";

            Random random = new Random();

            text = text.ToLower();
            string textMonkey = String.Empty;
            int countOfTries = 0;
            for (int i = 0; i < text.Length;)
            {
                int letter = random.Next(1072, 1104);


                if (letter != text[i])
                {
                    countOfTries++;
                    continue;
                }
                textMonkey += (char)letter;
                i++;
            }
            Console.WriteLine($"Изначальный текст: {text}");
            Console.WriteLine($"Текст написанный обезъяной: {textMonkey}");
            Console.WriteLine($"Количество попыток: {countOfTries}");
        }
    }*/
}