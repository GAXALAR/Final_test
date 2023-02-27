Console.WriteLine("Введите текст: ");
string textByUser = Console.ReadLine();
string [] textAsArray = textByUser.Split(' ');


void ArrayRes ( string [] textAsArray )
{
    for (int i = 0; i < textAsArray.Length; i++)
    {
        if (textAsArray[i].Length <= 3)
        {
            Console.Write ($"{textAsArray[i]} ");
        }
    }
}

Console.WriteLine ("Слова/значения не больше 3-х символов: ");
ArrayRes(textAsArray);