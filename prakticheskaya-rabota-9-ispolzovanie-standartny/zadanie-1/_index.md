---
order: 0.3
title: Задание 1. Стандартный интерфейс IComparable
---

Измените метод CompareTo в классе DemoPoint так, чтобы метод Sort сортировал массив точек по убыванию расстояния между точкой и началом координат.

:::info 

Обратите внимание на то, что во время реализации метода CompareTo в качестве параметра передавалась ссылка на объект типа object. Напомним, что класс object является корневым классом для всех остальных в С#. Поэтому он может ссылаться на объект любого типа. Но чтобы потом получить доступ к членам объекта произвольного класса, нужно выполнить приведение типов.

:::

```
// класс DemoPoint реализует стандартный интерфейс IComparable
class DemoPoint:IComparable
{
protected int x;
protected int y;
public DemoPoint ( int x, int y)
{
this.x=x; this.y=y;

}
public void Show()
{
Console.WriteLine("точка на плоскости: ({0}, {1})",x, y);
}
public double Dlina()
{
return Math.Sqrt(x*x+y*y);
}
//реализация метода CompareTo
public int CompareTo (object obj)
{
DemoPoint b=(DemoPoint) obj; //преобразуем к типу DemoPoint
//определяем критерии сравнения текущего объекта с параметром в
// зависимости от удаленности точки от начала координат
if (this.Dlina()==b.Dlina()) return 0;
else if (this.Dlina()>b.Dlina()) return 1;
else return -1;
}
}

class Program
{
static void Main()
{
//создаем массив ссылок
DemoPoint []a =new DemoPoint[4];
a[0]=new DemoPoint(5,-1);
a[1]=new DemoPoint(-3, 3);
a[2]=new DemoPoint(3,4);
a[3]= new DemoPoint(0,1);
//сортируем массив точек, при этом в качестве критерия сортировки будет
//использоваться собственная реализация метода CompareTo
Array.Sort(a);
Console.WriteLine();
foreach (DemoPoint x in a)
{
x.Show();
Console.WriteLine("Dlina={0:f2} ",x.Dlina());
}
}
}
```