---
order: 9
title: Практическая работа №9. Использование стандартных интерфейсов.
---

**Цель работы:** изучить способы использования стандартных интерфейсов.

## Интерфейс IComparable

В библиотеке классов .Net определено множество стандартных интерфейсов, задающих желаемую функциональность объектов. Например, интерфейс IComparable задает метод сравнения объектов по принципу больше и меньше, что позволяет переопределить соответствующие операции в рамках класса, наследующего интерфейс IComparable. Реализация интерфейсов IEnumerable и IEnumerator дает возможность просматривать содержимое объекта с помощью оператора foreach.

Можно создавать собственные классы, реализующие стандартные интерфейсы, что позволит использовать объекты этих классов стандартными способами.

Более подробно рассмотрим стандартный интерфейс IComparable.

Интерфейс IComparable определен в пространстве имен System и содержит единственный метод CompareTo, возвращающий результат сравнения двух объектов - текущего и переданного ему в качестве параметра:

```
public interface IComparable
{
    int CompareTo(object? o);
}
```

Метод `CompareTo` предназначен для сравнения текущего объекта с объектом, который передается в качестве параметра `object? o`. На выходе он возвращает целое число, которое может иметь одно из трех значений:

-  Меньше нуля. Значит, текущий объект должен находиться перед объектом, который передается в качестве параметра

-  Равен нулю. Значит, оба объекта равны

-  Больше нуля. Значит, текущий объект должен находиться после объекта, передаваемого в качестве параметра

Например, имеется класс Person:

```
class Person : IComparable
{
    public string Name { get;}
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name; Age = age;
    }
    public int CompareTo(object? o)
    {
        if(o is Person person) return Name.CompareTo(person.Name);
        else throw new ArgumentException("Некорректное значение параметра");
    }
}
```

Здесь в качестве критерия сравнения выбрано свойство Name объекта Person. Поэтому при сравнении здесь фактически идет сравнение значения свойства Name текущего объекта и свойства Name объекта, переданного через параметр. Если вдруг объект не удастся привести к типу Person, то выбрасывается исключение.

Применение:

```
var tom = new Person("Tom", 37);
var bob = new Person("Bob", 41);
var sam = new Person("Sam", 25);
 
Person[] people = { tom, bob, sam};
Array.Sort(people);
 
foreach (Person person in people)
{
    Console.WriteLine($"{person.Name} - {person.Age}");
}
```

И в данном случае мы получим следующий консольный вывод:

![](./_index.png){width=161px height=133px}

Интерфейс IComparable имеет обобщенную версию, поэтому мы могли бы сократить и упростить его применение в классе Person:

```
class Person : IComparable<Person>
{
    public string Name { get;}
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name; Age = age;
    }
    public int CompareTo(Person? person)
    {
        if(person is null) throw new ArgumentException("Некорректное значение параметра");
        return Name.CompareTo(person.Name);
    }
}
```

Аналогичным образом мы можем сравнивать по возрасту:

```
class Person : IComparable<Person>
{
    public string Name { get;}
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name; Age = age;
    }
    public int CompareTo(Person? person)
    {
        if(person is null) throw new ArgumentException("Некорректное значение параметра");
        return Age - person.Age;
    }
}
```