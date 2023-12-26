string[] arr1;
System.Console.WriteLine("Введите значения строк через пробел для формирования первоначального массива: ");
string inputStrings = Console.ReadLine()!;
arr1 = inputStrings !.Split(' ');

string[] arr2 = new string[arr1.Length];

FillSecondArray(arr1, arr2);
PrintArray(arr2);

void FillSecondArray(string[] arr1, string[] arr2)
{
    int i = 0;
    for (int j = 0; j < arr1.Length; j++)
    {
        if (arr1[j].Length <= 3)
            {
                arr2[i] = arr1[j];
                i++;
            }
    }
}

void PrintArray(string[] array)
{
    System.Console.WriteLine("Вывод массива из строк, длина которых меньше либо равна 3 символам: ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}