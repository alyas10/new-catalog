---
order: 0.5
title: Задание 2
---

Разработайте WPF-приложение «Убегающая кнопка»: при наведении курсора мыши на кнопку она смещается на некоторое расстояние от курсора. Событие наведения курсора мыши – MouseEnter.

Подсказка : Используйте контейнер **Canvas** для определения координат кнопки по свойствам **Canvas.Left** и **Canvas.Top**. Подвяжите для данных свойств анимацию:

```
<Storyboard>
 <!-- Анимация для свойства Canvas.Left -->
 <DoubleAnimation Storyboard.TargetProperty="(Canvas.Left)"
…
 <!-- Анимация для свойства Canvas.Top -->
…
```

Для изменения положения кнопки получите текущие координаты:

```
double currentX = Canvas.GetLeft(<Название кнопки>);
double currentY = Canvas.GetTop(<Название кнопки>);
Задайте новое положение кнопки:
double newX =
double newY =
Ограничьте область перемещения кнопки:
// Ограничиваем область перемещения кнопки
newX = Math.Max(0, Math.Min(newX, this.ActualWidth - Button.ActualWidth));
newY = Math.Max(0, Math.Min(newY, this.ActualHeight - Button.ActualHeight));
Задайте новые координаты через свойства Canvas.SetLeft и Canvas.SetTop
```