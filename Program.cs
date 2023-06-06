string[] CreateStringArray(int size)
{
    string[] array = new string[size];

    for(int i = 0; i < size; i++)
        array[i] = Console.ReadLine();

    return array;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

string[] StringLessThreeCharacters(string[] array)
{
    string[] newArray = new string[array.Length];
    newArray[0] = "В массиве нет строк, длина которых меньше, либо равна 3";
    for(int i = 0; i < array.Length; i++)
    {
        int quantity = array[i].Length;
        if(quantity <= 3)
        {
            int count = 0;
            newArray[count] = array[i];
            count++;
        }
    }
    return newArray;
}

Console.Write("Введите колличество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] myArray = CreateStringArray(size);
Console.WriteLine("Массив введенный пользователем");
ShowArray(myArray);
string[] newArray = StringLessThreeCharacters(myArray);
Console.Write("Массив строки которого меньше или равны 3 символам -> ");
ShowArray(newArray);
