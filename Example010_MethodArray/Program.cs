int[] array = { 12, 2, 33, 4, 51, 67, 70, 87, 87, 9 };

int n = array.Length;
int find = 87;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1;
    index++;

}