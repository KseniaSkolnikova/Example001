int[] array = {1,22,31,41,15,16,71,81};

int n = array.Length; // длина массива

int find = 81;

int index = 0;

while ( index < n )
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // если в масиве несколько одинаковых чисел, то эта команда остановит после первого найденного числа(если не ввести break то выведутся индексы всех этих чисел)
    }
    index ++; // аналогично:index = index + 1;
}
