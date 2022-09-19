int[] array = { 1, 24, 43, 4, 58, 58, 6, 75, 78, };

int n = array.Length;
int find = 58;

int index = 0;     // Элементы в массиве начинаются с 0

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}
