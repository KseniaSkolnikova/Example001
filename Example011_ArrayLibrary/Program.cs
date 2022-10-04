void FillArray(int[] collection) // в качестве аргумента какая-то коллекция
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next (1, 10); // обращаемся к аргументу collection на позицию Index и положить туда новое случайное целое число из диапазона 1-10
        // index = index + 1;
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
//следом рассматриваем метод отличный от Void, который возвращает позицию, то есть индекс числа
int IndexOf(int[] collection, int find) // называем его IndexOf, в качестве аргумента будет приходит массив collection и какой то элемент fund
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // сохраненнная позиция элемента, если задать найти несуществующий элемент, позиция вернет -1, а не 0 - ячейку, в которой находится первый элемент массива по умолчанию
    while (index < count)
    {
        if (collection[index] == find) // если индекс коллекции совпал с элементом, то нужно куда то сохранить позицию
        {
            position = index;
            break; // команда для того, чтобы вывод показал первый индекс искомой 4-ки
        }
        index ++;
    }
    return position;
}

int[] array = new int[10]; //создай новый массив в котором будет 10 элементов

// void - это метод, который ничего не возвращает. в данном случае, мы тогда не должны использовать оператор return

FillArray(array); // метод заполнения массива числами
PrintArray(array); // метод печати массива на экран/консоль
Console.WriteLine(); // здесь выведем пустую строчку

int pos = IndexOf(array, 4); // определим переменную pos и в нее положим результат работы метода IndexOf, в качестве аргумента будет передаваться массив и например будем искать 4-ку
Console.WriteLine(pos); // после того, как метод отработает, покажем pos
