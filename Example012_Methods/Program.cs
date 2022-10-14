// Группы методов.
// ВИД 1

void Method1()
{
    Console.WriteLine("автор ..");
}
// вызываем метод
Method1();



// ВИД 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");



// ПРИМЕР С ДВУМЯ АРГУМЕНТАМИ
void Method44(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method44(msg: "Текст", count: 4); // можно и не по порядку перечислять




// ВИД 3
int Metod3()                   // не принимает никакие аргументы
{
    return DataTime.Now.Year; // обязательное использование оператора return
}
int year = Metod3();          // вызываем метод, в левой части используем идентификатор переменной (year) и через оператор присваивания (=) кладём нужное значение
Console.WriteLine(year);




// ВИД 4
string Metod4(int count, string text)   // возвращаем строку!
{
    int i = 0;
    string result = String.Empty;   // ложим конечный результат. изначально пустая строка!
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Metod4(10, "z"); // текст z повторяем 10 раз
Console.WriteLine(res);



// ЦИКЛ FOR
string Metod4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)  // вначале ключевое слово, затем инициализация счётчика, после проверка условия и инкремент (увеличение счётчика).
    {
        result = result + text;
    }
    return result;
}
string res = Metod4(10, "z");
Console.WriteLine(res);


// ЦИКЛ В ЦИКЛЕ
for (int i = 2; i <= 10; i++)     // таблица умножения
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");     // интерпаляция строк
    }
    Console.WriteLine();    // вывод. переход на новую строку
}




//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";


// вспомогтельный функционал
// string s = "qwerty"   
//             012345    
// s[3] // r - третий символ

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{NewValue}";
        else result = result + $"{text[i]}";
    }
    return result;   // возвращаем результат
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);




// УПОРЯДОЧИТЬ МАССИВ 1,3,6,7,4,8,2,5,9

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PtintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{ array[i]}");
    }
    Console.WriteLine();
}
    void selectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);



// ИТОГИ 

// бывают ЦИКЛЫ в ЦИКЛАХ

// ВИДЫ МЕТОДОВ:
// 1. ничего не принимают, ничего не возвращают
// 2. что-то принимают, ничего не возвращают
// 3. ничего не принимают, что-то возвращают
// 4. что-то принимают, что-то возвращают


// когда ничего не принимают 2 группы, и они обязательно характеризуются ключевым словом void в самом своём описании. 
// И 2 группы методов, которые какой-то результат могут возвращать. 
// Помним, что у методов, скорее всего, будут входные аргументы. 
// Также первые 2 ничего не возвращают. Они характеризуются ключевым словом void. 
// Оставшиеся 2 группы обязательно должны возвращать результаты и характеризуются типом данных, значение которого будет возвращаться.