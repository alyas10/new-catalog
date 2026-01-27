---
order: 2
title: Задание 2
---

## Вариант 1: Автомобили (на основе List\<T>)

### Часть 1: Реализация CollectionType\<T>

Создайте обобщенный класс `CarCollection<T>` на основе `List<T>` для управления коллекцией автомобилей.

**Требования:**

-  Конструкторы (пустой, с параметром capacity)

-  Методы: `Add(T item)`, `Remove(T item)`, `RemoveAt(int index)`, `Clear()`

-  Индексатор `[int index]` для доступа к элементам

-  Свойства: `Count`, `IsEmpty`

-  Перегруженный оператор `+` для объединения коллекций

-  Обработка исключений (IndexOutOfRangeException, ArgumentNullException)

**Структура класса Car:**

```
Car: Id (int), Model (string), Year (int), Price (double), Color (string)
```

### Часть 2: LINQ запросы

Создайте коллекцию из 10+ автомобилей, используя класс `CarCollection<T>`. Выполните запросы:

1. `Where (Year > 2015) + OrderByDescending (Price) + Select (Model + Price) + Take (5)` -- найти топ-5 дорогих автомобилей после 2015 года

2. `GroupBy (Color) + Where (Count > 2) + Select (Color + Count + AvgPrice) + OrderByDescending (AvgPrice)` -- цвета автомобилей с количеством ≥ 2, средняя цена

3. `Where (Price < 1000000) + OrderBy (Year) + Skip (2) + Take (4) + FirstOrDefault` -- дешевые авто (пропустить 2, взять 4)

4. `Any (Year < 2010) + All (Price > 100000) + Select (Model) + Distinct` -- есть ли авто до 2010, все ли дорогие

5. `OrderBy (Model) + ThenBy (Year) + Select (new {Model, Year, Price}) + ToList` -- сортировка по модели и году выпуска

### Часть 3: Массив CarCollection

Создайте массив из 3 объектов `CarCollection<Car>` разного размера (5, 8, 5 элементов).

**Запросы:**

-  Найти количество коллекций размером ровно 5

-  Найти коллекцию с максимальным количеством элементов

-  Найти коллекцию с минимальным суммарным стоимостью автомобилей

## Вариант 2: Студенты (на основе Stack\<T>)

### Часть 1: Реализация CollectionType\<T>

Создайте класс `StudentStack<T>` на основе `Stack<T>` для управления стеком студентов.

**Требования:**

-  Конструкторы (пустой, с параметром capacity)

-  Методы: `Push(T item)`, `Pop()`, `Peek()`, `Clear()`

-  Индексатор для получения элемента по индексу (0 = верхушка стека)

-  Свойства: `Count`, `IsEmpty`

-  Перегруженный оператор `-` для удаления элемента

-  Обработка исключений (InvalidOperationException для пустого стека)

**Структура класса Student:**

```
Student: Id (int), Name (string), Group (string), GPA (double), Course (int)
```

### Часть 2: LINQ запросы

Создайте стек из 10+ студентов , используя класс `StudentStack<T>`. Выполните запросы:

1. `Where (GPA > 4.0) + OrderByDescending (GPA) + Select (Name + GPA) + Take (5)` -- отличники с сортировкой

2. `GroupBy (Course) + Select (Course + Count + AvgGPA) + Where (AvgGPA > 3.5) + OrderBy (Course)` -- курсы с хорошей средней оценкой

3. `Where (Group.StartsWith("БИ")) + OrderBy (Name) + Skip (1) + Take (3)` -- студенты группы БИ

4. `All (GPA >= 3.0) + Any (Course == 2) + Select (Name) + FirstOrDefault` -- все ли хорошисты, есть ли 2-й курс

5. `OrderByDescending (GPA) + ThenBy (Name) + Select (new {Name, GPA, Course}) + Distinct` -- сортировка по GPA и имени

### Часть 3: Массив StudentStack

Создайте массив из 3 объектов `StudentStack<Student>` размерами (6, 4, 6 элементов).

**Запросы:**

-  Найти количество стеков размером ровно 6

-  Найти стек с максимальным среднимGPA

-  Найти стек с минимальным количеством элементов

## Вариант 3: Товары магазина (на основе Queue\<T>)

### Часть 1: Реализация CollectionType\<T>

Создайте класс `ProductQueue<T>` на основе `Queue<T>` для управления очередью товаров.

**Требования:**

-  Конструкторы (пустой, с параметром capacity)

-  Методы: `Enqueue(T item)`, `Dequeue()`, `Peek()`, `Clear()`

-  Индексатор для получения элемента по индексу (0 = первый в очереди)

-  Свойства: `Count`, `IsEmpty`, `TotalValue`

-  Перегруженный оператор `*` для умножения количества элементов

-  Обработка исключений (InvalidOperationException)

**Структура класса Product:**

`Product: Id (int), Name (string), Category (string), Price (double), Quantity (int)`

### Часть 2: LINQ запросы

Создайте очередь из 10+ товаров, используя `ProductQueue<T>` . Выполните запросы:

1. `Where (Price > 50) + OrderBy (Price) + Select (Name + Price + Quantity) + Take (8)` -- дорогие товары

2. `GroupBy (Category) + Select (Category + Count + SumQuantity) + OrderByDescending (SumQuantity)` -- категории и остатки

3. `Where (Quantity < 5) + Select (Name + Quantity) + OrderBy (Quantity) + FirstOrDefault` -- товары на исходе

4. `Any (Price < 10) + All (Quantity > 0) + SelectMany (Category) + Distinct` -- есть ли дешевые, все ли в наличии

5. `OrderByDescending (Price * Quantity) + ThenBy (Name) + Select (new {Name, TotalValue = Price * Quantity}) + Take (7)` -- товары по стоимости запаса

### Часть 3: Массив ProductQueue

Создайте массив из 3 объектов `ProductQueue<Product>` размерами (7, 5, 7 элементов).

**Запросы:**

-  Найти количество очередей размером ровно 7

-  Найти очередь с максимальной общей стоимостью товаров

-  Найти очередь с минимальным средним количеством товара

## Вариант 4: Сотрудники (на основе ArrayList)

### Часть 1: Реализация CollectionType\<T>

Создайте класс `EmployeeCollection` на основе `ArrayList` для управления сотрудниками.

**Требования:**

-  Конструкторы (пустой, с параметром capacity)

-  Методы: `Add(object item)`, `Remove(object item)`, `RemoveAt(int index)`, `Clear()`

-  Индексатор `[int index]`

-  Свойства: `Count`, `IsEmpty`, `Capacity`

-  Перегруженный оператор `==` для сравнения размеров коллекций `EmployeeCollection`

-  Обработка исключений (типобезопасность(`InvalidCastException`), выход за границы(`IndexOutOfRangeException`))

**Структура класса Employee:**

```
Employee: Id (int), Name (string), Department (string), Salary (double), Experience (int)
```

### Часть 2: LINQ запросы

Создайте коллекцию из 10+ сотрудников, используя `EmployeeCollection`. Выполните запросы:

1. `Where (Salary > 50000) + OrderByDescending (Salary) + ThenBy (Experience) + Select (Name + Salary)` -- высокооплачиваемые

2. `GroupBy (Department) + Select (Department + Count + AvgSalary) + OrderByDescending (AvgSalary) + Take (5)` -- отделы и зарплаты

3. `Where (Experience > 5) + OrderBy (Name) + Skip (1) + Take (3) + Distinct` -- опытные сотрудники

4. `All (Salary >= 30000) + Any (Department == "IT") + Select (Name) + FirstOrDefault` -- все ли получают ≥30000

5. `OrderByDescending (Experience) + ThenBy (Department) + Select (new {Name, Department, Years = Experience})` -- сортировка по опыту

### Часть 3: Массив EmployeeCollection

Создайте массив из 3 объектов `EmployeeCollection` размерами (6, 9, 6 элементов).

**Запросы:**

-  Найти количество коллекций размером ровно 6

-  Найти коллекцию с максимальной средней зарплатой

-  Найти коллекцию с минимальным опытом работников

## Вариант 5: Книги (на основе List\<T>)

### Часть 1: Реализация CollectionType\<T>

Создайте класс `BookLibrary<T>` на основе `List<T>` для управления библиотекой книг.

**Требования:**

-  Конструкторы (пустой, с параметром initialCapacity)

-  Методы: `Add(T item)`, `Remove(T item)`, `FindByTitle(string title)`, `Clear()`

-  Индексатор `[int index]` и `[string title]`

-  Свойства: `Count`, `TotalPages`

-  Перегруженный оператор `+` для добавления книги

-  Обработка исключений (KeyNotFoundException, ArgumentException)

**Структура класса Book:**

`Book: ISBN (string), Title (string), Author (string), Genre (string), Pages (int), Year (int)`

### Часть 2: LINQ запросы

Создайте коллекцию из 10+ книг, используя `BookLibrary<T>`. Выполните запросы:

1. `Where (Year > 2010) + OrderByDescending (Year) + Select (Title + Author + Year) + Take (6)` -- новые книги

2. `GroupBy (Author) + Where (Count > 1) + Select (Author + Count + AvgPages) + OrderByDescending (Count)` -- авторы с несколькими книгами

3. `Where (Pages > 300 && Genre == "Фантастика") + OrderBy (Pages) + Skip (1) + Take (4)` -- толстая фантастика

4. `All (Pages > 100) + Any (Genre == "Детектив") + SelectMany (Author) + Distinct` -- все ли > 100 страниц

5. `OrderBy (Title) + ThenBy (Author) + Select (new {Title, Author, Genre, Pages})` -- алфавитная сортировка

### Часть 3: Массив BookLibrary

Создайте массив из 3 объектов `BookLibrary<Book>` размерами (8, 5, 8 элементов).

**Запросы:**

-  Найти количество библиотек размером ровно 8

-  Найти библиотеку с максимальным количеством страниц всего

-  Найти библиотеку с минимальным среднимколичеством страниц