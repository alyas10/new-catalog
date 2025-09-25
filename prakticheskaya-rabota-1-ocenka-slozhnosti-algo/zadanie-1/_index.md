---
order: 1
title: "Задание 1.\_Оптимизация сортировки пузырьком"
---

**Теория**

Алгоритм сортировки пузырьком основан на многократном проходе по массиву. На каждом проходе сравниваются соседние элементы, и если они находятся в неправильном порядке (например, предыдущий элемент больше следующего при сортировке по возрастанию), то они меняются местами.

В своей базовой версии алгоритм делает `N-1` проходов по массиву из `N` элементов, даже если массив уже упорядочен. Это приводит к неоптимальному времени работы.

Однако алгоритм можно улучшить, если отслеживать, были ли совершены обмены во время прохода по массиву. Если на каком-то проходе не было ни одного обмена, это означает, что массив уже отсортирован, и дальнейшие проходы не нужны. Для этого вводится специальный флаг (например, переменная `flag` типа `bool`).

![](./zadanie-1.gif){width=277px height=257px}

**Пример неоптимизированной реализации**

```csharp
private static readonly Random random = new Random();

private static void BubbleSort(int[] array)
{
//Итоговая сложность O(N^2)
    for (int i = 0; i < array.Length; i++) //O(N)
        for (int j = 0; j < array.Length - 1; j++)//O(N)
            if (array[j] > array[j + 1])
            {
                int t = array[j + 1];
                array[j + 1] = array[j];
                array[j] = t;
            }
}

public static void Main()
{
    int[] array = GenerateArray(10);
    BubbleSort(array);
    foreach (int e in array)
        Console.WriteLine(e);
}

private static int[] GenerateArray(int length)
{
    var array = new int[length];
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next();
    return array;
}
```

**Задание**

Модифицируйте приведённый выше метод `BubbleSort`, введя переменную `flag` типа `bool` для отслеживания факта обмена элементов во внутреннем цикле. Если на очередном проходе не было ни одного обмена, алгоритм должен завершить работу досрочно.

**Требования к решению:**

1. Измените только код метода `BubbleSort`.

2. Используйте флаг `flag` для проверки необходимости продолжения сортировки.

3. Основная логика программы (методы `Main` и `GenerateArray`) должна остаться без изменений.

**Шаблон для решения:**

```csharp
using System;

public class Program
{
    private static readonly Random random = new Random();
    
    // Модифицируйте этот метод
    private static void BubbleSort(int[] array)
    {
        // Ваш код здесь
    }

    // Не изменяйте код ниже
    public static void Main()
    {
        int[] array = GenerateArray(10);
        BubbleSort(array);
        foreach (int e in array)
            Console.WriteLine(e);
    }

    private static int[] GenerateArray(int length)
    {
        var array = new int[length];
        for (int i = 0; i < array.Length; i++)
            array[i] = random.Next();
        return array;
    }
}
```