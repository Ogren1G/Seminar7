Console.WriteLine("Введите номер строки");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [3,4];
FillArray(numbers);

if (rows > numbers.GetLength(0) || cols > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {rows} строки и {cols} столбца равно {numbers[rows-1,cols-1]}");
}

PrintArray(numbers);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-10, 10);
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}
