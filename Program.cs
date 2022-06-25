/* PROGRAM THAT TAKES AND SORTS USER INPUT */

Console.Write("Enter amount of numbers to be sorted: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    Console.Write("Enter number " + (i + 1) + ": ");
    array[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (array[j] > array[i])
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}

Console.Write("Sorted array: ");
for (int i = 0; i < size; i++)
    Console.Write(array[i] + " ");
