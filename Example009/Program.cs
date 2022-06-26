int[] array = {11, 21, 35, 9, 51, 64, 11, 5, 9};

int n = array.Length;
int index = 0;
int find=9;

while (index<n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
index++;
}