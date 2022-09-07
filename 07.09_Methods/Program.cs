﻿//  Группы методов.


//  1 Группа методов. 

// void Method1()
// {
//     Console.WriteLine("Метод void");
// }
// Method1();



// 2 Группа методов. 

// void Method2(string msg)   //принимают аргументы
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");


// void Method21(string msg, int count) 
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("Текст", 2);
// Method21(msg: "еще текст", count: 2);
// Method21(count: 2, msg: "новый текст");



// 3 Группа методов.(что-то возвращают НО ничего не принимают)

// int Method3()  // никакие аргументы он не принимает
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);



// 4 Группа методов. (методы которые чтото принимают И чтото возвращают)

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(9, "z, ");
// Console.WriteLine(res);



////////////////////////////////////////////////////////////////////


// Циклы. 

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for(int i=0; i<count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(9, "z, ");
// Console.WriteLine(res);


//////////////

// таблица умножения, с циклом - "for"
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


//////////////

// Работа с текстом по замене символов. 
// обращаться к символам в строке, можем по индексу
// string text = "Сегодня мы углубимся в тему "
//             + "и выделим 4 основных группы методов, "
//             + "а также будем использовать их на практике. "
//             + "И познакомимся с новыми языковыми конструкциями, "
//             + "в частности, циклом.";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');

// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);
// Console.WriteLine();


////////////////////////////////////////////////////////////////////
// Работа с массивами.
// Упорядочивание данных внутри массива.


// сортировка от min к max

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
            Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length ; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        for
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
