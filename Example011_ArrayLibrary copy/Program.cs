void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int tochka = -2;
    while (index < count)
    {
        if (collection[index] == find)
        {
            tochka = index;
            break;
        }
        index++;
    }
    return tochka;

}


int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4444); // здесь число 4444 надо заменить на 4, тогда будет отображаться существующее число массива 4
Console.WriteLine(pos);