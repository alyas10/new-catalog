---
order: 0.5
title: Задание 2. Метод CompareTo
---

Используя собственную реализацию метода CompareTo можно перегрузить операции отношения. Напомним, что операции отношения должны перегружаться парами: \< и >, \<= и >=, == и !=.

Перегрузите в классе DemoPoint следущие пары операций:

1. \> и \<, так чтобы при сравнении двух объектов возвращалось значение true, если первая точка расположена дальше от начала координат, чем вторая, иначе false.

2. \>= и \<=, так чтобы при сравнении двух объектов возвращалось значение true если первая точка расположена не ближе к началу координат, чем вторая, иначе false.

В следующем примере для класса DemoPoint перегрузим операции == и != таким образом, чтобы при сравнении двух объектов возвращалось значение true, если точки находятся на равном удалении от начала координат, в противном случае - false.

```
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

public int CompareTo (object obj)

{

DemoPoint b=(DemoPoint) obj;

if (this.Dlina()==b.Dlina()) return 0;

else if (this.Dlina()>b.Dlina()) return 1;

else return -1;

}

public static bool operator ==(DemoPoint a, DemoPoint b)

{

return (a.CompareTo(b)==0);

}

public static bool operator !=(DemoPoint a, DemoPoint b)

{

return (a.CompareTo(b)!=0);

}

}


class Program

{

static void Main()

{

DemoPoint a =new DemoPoint(-3,0);

DemoPoint b=new DemoPoint(0,3);

if (a==b) Console.WriteLine("равно удалены от начала координат");

else Console.WriteLine("не равно удалены от начала координат");

}

}
```