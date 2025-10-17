---
order: 3
title: Задача 3. Сравнение линейного и бинарного поиска в двумерном массиве
---

**Задание:** Создайте двумерный массив размером 3×3, заполненный целыми числами. Реализуйте и сравните **линейный поиск** и **бинарный поиск** для нахождения заданного элемента.

**Обязательные требования:**

1. Реализовать функцию `LinearSearch2D` для линейного поиска

2. Реализовать функцию `BinarySearch2D` для бинарного поиска в отсортированном массиве

3. Использовать `Stopwatch` для измерения времени выполнения обоих алгоритмов

4. Вывести для каждого алгоритма: результат поиска, количество итераций, время выполнения

5. Провести сравнительный анализ эффективности алгоритмов

**Теоретический вопрос:**

-  Определить временную сложность каждого алгоритма для массива размером n×m

-  Объяснить, как количество итераций связано с размером массива

-  Определить пространственную сложность алгоритмов

**Шаблон решения**

```
// Линейный поиск в двумерном массиве
    static ((int row, int col) coordinates, int iterations) LinearSearch2D(int[,] array, int target)
    {
        int iterations = 0;
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                iterations++;
                if (array[i, j] == target)
                {
                    return ((i, j), iterations);
                }
            }
        }
        return ((-1, -1), iterations);
    }
    // Бинарный поиск в отсортированном двумерном массиве (работаем как с одномерным)
    static ((int row, int col) coordinates, int iterations) BinarySearch2D(int[,] array, int target)
    {
        int iterations = 0;
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        int totalElements = rows * cols;
        
        int left = 0;
        int right = totalElements - 1;
        
        while (left <= right)
        {
            iterations++;
            int mid = (left + right) / 2;
            
            // Преобразуем одномерный индекс в двумерные координаты
            int midRow = mid / cols;
            int midCol = mid % cols;
            int midValue = array[midRow, midCol];
            
            if (midValue == target)
            {
                return ((midRow, midCol), iterations);
            }
            else if (midValue < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        
        return ((-1, -1), iterations);
    }
    // Преобразование двумерного массива в одномерный для сортировки
    static int[,] Sort2DArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        int totalElements = rows * cols;
        
        // Преобразуем в одномерный массив
        int[] flatArray = new int[totalElements];
        int index = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                flatArray[index++] = array[i, j];
            }
        }
        
        // Сортируем
        Array.Sort(flatArray);
        
        // Преобразуем обратно в двумерный
        int[,] sortedArray = new int[rows, cols];
        index = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sortedArray[i, j] = flatArray[index++];
            }
        }
        
        return sortedArray;
    }
```

-  **Варианты заданий:**

   | **Вариант** | **Условие для поиска**                                            |
   |-------------|-------------------------------------------------------------------|
   | 1           | Найти максимальный элемент в массиве                              |
   | 2           | Найти минимальный положительный элемент                           |
   | 3           | Найти элемент, значение которого равно заданному числу            |
   | 4           | Найти первый элемент, кратный 5                                   |
   | 5           | Найти элемент, который является точным квадратом                  |
   | 6           | Найти элемент, сумма цифр которого равна 7                        |
   | 7           | Найти последний чётный элемент                                    |
   | 8           | Найти элемент, находящийся ближе всего к числу 50                 |
   | 9           | Найти элемент, который делится на 3 и на 4 одновременно           |
   | 10          | Найти элемент, значение которого равно произведению его координат |
   | 11          | Найти элемент, являющийся простым числом                          |
   | 12          | Найти элемент, модуль которого больше 30 и меньше 70              |


