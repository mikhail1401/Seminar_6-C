// Arrays Массивы

Console.WriteLine("Task 42");
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

 System.Console.WriteLine("Enter a number: ");
 int num = Convert.ToInt32(Console.ReadLine());

 string result = "";

 while (num>0)
 {
    result = num%2 + result;    // (int + str) automatically converts to (str + str)
    num = num/2;
 }

System.Console.WriteLine(result);


System.Console.WriteLine("\nTask 40");
// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

System.Console.WriteLine("Type a size of the 1st side of the triangle: ");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Type a size of the 2nd side of the triangle: ");
int num2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Type a size of the 3rd side of the triangle: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1<num2+num3 && num2<num1+num3  && num3<num1+num2)
{
    System.Console.WriteLine("Yes, the triangle can exist");
}
else
{
    System.Console.WriteLine("No, the triangle cannot exist");
}


System.Console.WriteLine("\nTask 44");
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

System.Console.WriteLine("Enter a Fibonacci number: ");
int numFib = Convert.ToInt32(Console.ReadLine());

int firstNum = 0;
int secondNum = 1;

if (numFib<=0) System.Console.WriteLine("You need to enter a positive number");
else if (numFib==1) System.Console.WriteLine(firstNum);
else if (numFib==2)
{
    System.Console.WriteLine(firstNum);
    System.Console.WriteLine(secondNum);
}
else
{
    System.Console.WriteLine(firstNum);
    System.Console.WriteLine(secondNum);
    for (int i=2; i<numFib; i++)
    {
        int nextNum = firstNum + secondNum;
        System.Console.WriteLine(nextNum);

        firstNum = secondNum;
        secondNum = nextNum;
    }
}


System.Console.WriteLine("\nTask 39");
// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] array = new int[] {1, 2, 3, 4, 5};

void ReversArray()
{
    for (int i=0; i<array.Length; i++)
    {   
        int temp = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = temp;
    }
}

void PrintArray()
{
    for (int i=0; i<array.Length; i++)
    {
        System.Console.Write(array[i]+ " ");
    }
}

ReversArray();
PrintArray();