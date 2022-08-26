// Двумерный массивы [,]


// // String.Empty - инициализация для строк
// string[,] table = new string [2,5];
// table[1,2] = "слово";
// for (int rows  = 0; rows < 2; rows++)
// {
//     for (int collums = 0; collums < 5; collums++)
//     {
//         Console.WriteLine ($"-{table[rows,collums]}-");
//     }
// }

// печать массива
void PrintArray (int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
}
}
// Заполнение массива псевдослучайными числами

void FillArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
         matr [i,j] = new Random().Next(1,10);   
        }
    }
}

int[,] matrix = new int [3,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);