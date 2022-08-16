// Вид 1

// void Method1()
// {
//     Console.WriteLine("Aouthor...");
// }

// //Method1();

// // Вид 2

// void Method2 (string msg)
// {
//     Console.WriteLine(msg);
// }

// Method2("Текст сообщения");

// Вид 3

// int Method3()
// {
//     return DataTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(yaer);

// Вид 4

// Вариант 1

// string Method4 (int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10,"asdf");
// Console.WriteLine(res);

// Вариант 2 цикл
// for (int i = 0; i < 10; i++)

// string Method4 (int count, string c)
// {

//     string result = String.Empty;
//     for (int i = 0; i <count; i++)

//     {
//         result = result + c;
//     }
//     return result;
// }

// string res = Method4(10,"asdf");
// Console.WriteLine(res);

// Вывод таблицы умножения на экран

// for (int i = 2; i<=10; i++)
// {
//     for (int j = 2; j<=10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

// =====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

// var text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// // string s "qwerty"
// //           0123
// // s[3]  // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;

//     int length = text.Length;
//     for(int i = 0; i< length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";


//     }
//     return result;
// }

// string newText = Replace(text, ' ', '-');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'с','С');
// Console.WriteLine(newText);
// Console.WriteLine();

// Сортровка массива

// int [] arr = {3, 5, 6, 1, 7, 3, 9 , 7};
// void PrintArray(int [] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//         Console.WriteLine();
// }

// void SelectionSourt (int [] array)
// {
//    for (int i = 0; i < array.Length - 1; i++) 
//    {
//     int minPosition = i;
//      for (int j = i + 1; j < array.Length; j++)
//      {
//         if(array[j] < array[minPosition]) 
//         {
//             minPosition = j;
//         }
//      }

//     int temporary = array[i];
//     array[i] = array[minPosition];
//     array[minPosition] = temporary;

//    }
// }


// PrintArray(arr);
// SelectionSourt(arr);
// PrintArray(arr);