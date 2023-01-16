int[] array = { 1, 12, 35, 49, 53, 62, 7, 885, 12 };

int n = array.Length;
int find = 12;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}