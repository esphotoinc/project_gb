// 1. Вычисление факториала 

// //  1. Функцию, которая будет принимать число, факториал которого нужно вычислить

// double Factorial (int n) // используем тип "double", позволяет хранить большие типы данных
// {
//     //  определение факториала 1! = 1; 0! = 1
//     if(n == 1) return 1;
//     else return n * Factorial (n - 1);
// }

// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine ($"{i}! = {Factorial(i)}");
// }


// 2. Вычисление числа Фибанначи

// // формула 
// // f(1) = 1
// // f(2) = 1
// // f(n) = f(n-1)+f(n-2)

// double Fibonnaci (int n)
// {
//     if (n == 1 || n == 2 ) return 1;
//     else return Fibonnaci(n-1) + Fibonnaci(n-2);
// }

// for (int i = 1; i < 50; i++)
// {
//     Console.WriteLine ($"f{i} = {Fibonnaci(i)}");
// }