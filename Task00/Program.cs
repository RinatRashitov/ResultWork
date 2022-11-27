/*Задача. Из массива заданного пользователем формирует массив из строк длина которых меньше либо равна 3 символа */
int getIntNumberFromUser(string userInformation)
{
    int result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 && userLine != "0")
        {
            Console.WriteLine($"Введите целое число, Вы ввели: {userLine}");
        }
        else
        {
            break;
        }
    }
    return result;
}

string getStringFromUser(string userInformation)
{
    string result = "";
    Console.Write(userInformation);
    result = Console.ReadLine();
    return result;
}

int numN = getIntNumberFromUser("Введите длину массива ");
string[] UserArray = new string[numN];
string[] UserArrayResult = new string[0];
for (int i = 0; i < numN; i++)
{
    UserArray[i] = getStringFromUser("Введите значение массива № " + i + " ");
}

for (int i = 0; i < numN; i++)
{
    if (UserArray[i].Length <= 3)
    {
        Array.Resize(ref UserArrayResult, UserArrayResult.Length + 1);
        UserArrayResult[UserArrayResult.Length - 1] = UserArray[i];
    }
}

Console.Write("Результат отбора [");
for (int i = 0; i < UserArrayResult.Length; i++)
{
    Console.Write(UserArrayResult[i]);
    if (i < UserArrayResult.Length)
    {
        Console.Write(", ");
    }
}
Console.Write("]");