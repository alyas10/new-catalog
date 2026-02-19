---
order: 21
title: Практическая работа №21 Разработка игрового приложения.
---

**Цель работы:** разработать игровое приложение на языке C#.

### Пример задачи:

Разработайте игру, которая заключается в следующем. На форме размещены пять кнопок (Button). При нажатии на кнопку какие то кнопки становятся видимыми, а какие то невидимыми. Цель игры скрыть все кнопки. Алгоритм решения:

1. Создайте список для кнопок, например: private `List<Button> buttons;`

2. В методе инициализации (например, InitializeGame) создайте кнопки в цикле и добавьте их в список: `For… { Button button = new Button();` // Настройте свойства кнопки: размер, текст и т.д. `buttons.Add(button);` // Добавьте кнопку в список }

3. Создайте переменную для генерации случайных чисел, чтобы случайным образом скрывать или показывать кнопки: private Random random = new Random();

4. В методе, который отвечает за видимость кнопок (например, `ToggleButtonVisibility)`, используйте цикл для перебора всех кнопок и задавайте их видимость случайным образом:                                        foreach (Button button in buttons)

   \{

   if (button.Visible)

   \{

   // Случайно определяйте, скрыть или показать кнопку

   button.Visible = random.Next(2) == 0; // 50% шанс скрыть

   }

   }

5. . Создайте метод, который проверяет, все ли кнопки скрыты. Если да, то выводите сообщение о победе и сбрасывайте игру. В методе сброса (например, ResetGame) делайте все кнопки видимыми, чтобы начать новую игру. Пример вывода сообщения:                                                 `MessageBox.Show("Поздравляем! Вы скрыли все кнопки!");`

### Пример кода для Windows Forms:

```
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace Igra
{
 public partial class Form1 : Form
 {
 private Random random;
 private List<Button> buttons;
 public Form1()
 {
 InitializeComponent();
 InitializeGame();
 }
 private void InitializeGame()
 {
 random = new Random();
 buttons = new List<Button>();
 // Создание и настройка кнопок
 for (int i = 0; i < 5; i++)
 {
 Button button = new Button
 {
 Size = new Size(100, 50),
 Location = new Point(10 + (110 * i), 10), // По горизонтали
 Text = $"Кнопка {i + 1}",
 Visible = true // Все кнопки изначально видимы
 };
 // Добавляем обработчик события нажатия
 button.Click += Button_Click;
 // Добавляем кнопку в список и на форму
 buttons.Add(button);
 Controls.Add(button);
 }
 }
 private void Button_Click(object sender, EventArgs e)
 {
 // Скрываем кнопку, на которую нажали
 Button clickedButton = sender as Button;
 clickedButton.Visible = false;
 // Меняем видимость других кнопок
 ToggleButtonVisibility();
 }
rivate void ToggleButtonVisibility()
 {
 // Случайным образом меняем видимость кнопок
 foreach (Button button in buttons)
 {
 if (button.Visible) // Если кнопка все еще видима
 {
 // Случайно определяем, скрыть кнопку или показать
button.Visible = random.Next(2) == 0; // 50% шанс скрыть
 }
 }
 // Проверяем, все ли кнопки скрыты
 if (AllButtonsHidden())
 {
 MessageBox.Show("Поздравляем! Вы скрыли все кнопки!");
 ResetGame();
 }
 }
 private bool AllButtonsHidden()
 {
 // Проверяем, все ли кнопки скрыты
 foreach (Button button in buttons)
 {
 if (button.Visible)
 return false; // Если хоть одна кнопка видима, возвращаем false
 }
 return true;
 }
 private void ResetGame()
 {
 // Сбрасываем игру, показываем все кнопки
 foreach (Button button in buttons)
 {
 button.Visible = true;
 }
 }
 }
}
```

### Пример кода для WPF:

В файле MainWindow.xaml:

```
<Grid Name="MainGrid">

</Grid>
```

В файле MainWindow.xaml.cs

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace WpfApp3
{
 /// <summary>
 /// Логика взаимодействия для MainWindow.xaml
 /// </summary>
 using System;
 using System.Collections.Generic;
 using System.Windows;
 using System.Windows.Controls;
 public partial class MainWindow : Window
 {
 private Random random;
 private List<Button> buttons;
 public MainWindow()
 {
 InitializeComponent();
 InitializeGame();
 }
 private void InitializeGame()
 {
 random = new Random();
 buttons = new List<Button>();
 // Создание и настройка кнопок
 for (int i = 0; i < 5; i++)
 {
 Button button = new Button
 {
 Width = 100,
Height = 50,
Margin = new Thickness(10 + (200 * i), 10, 0, 0), // По горизонтали
 Content = $"Кнопка {i + 1}",
 Visibility = Visibility.Visible // Все кнопки изначально видимы
 };
 // Добавляем обработчик события нажатия
 button.Click += Button_Click;
 // Добавляем кнопку в список и на панель
 buttons.Add(button);
 MainGrid.Children.Add(button); // Предполагается, что у вас есть Grid с именем
MainGrid
 }
 }
 private void Button_Click(object sender, RoutedEventArgs e)
 {
 // Скрываем кнопку, на которую нажали
 Button clickedButton = sender as Button;
 clickedButton.Visibility = Visibility.Hidden;
 // Меняем видимость других кнопок
 ToggleButtonVisibility();
 }
 private void ToggleButtonVisibility()
 {
 // Случайным образом меняем видимость кнопок
 foreach (Button button in buttons)
 {
 if (button.Visibility == Visibility.Visible) // Если кнопка все еще видима
 {
 // Случайно определяем, скрыть кнопку или показать
button.Visibility = random.Next(2) == 0 ? Visibility.Hidden :
Visibility.Visible; // 50% шанс скрыть
 }
 }
 // Проверяем, все ли кнопки скрыты
 if (AllButtonsHidden())
 {
 MessageBox.Show("Поздравляем! Вы скрыли все кнопки!");
 ResetGame();
 }
 }
 private bool AllButtonsHidden()
 {
 // Проверяем, все ли кнопки скрыты
 foreach (Button button in buttons)
 {
 if (button.Visibility == Visibility.Visible)
 return false; // Если хоть одна кнопка видима, возвращаем false
 }
 return true;
 }
 private void ResetGame()
 {
 // Сбрасываем игру, показываем все кнопки
 foreach (Button button in buttons)
 {
 button.Visibility = Visibility.Visible;
 }
 }
 }
```

## Требования к отчету

**Структура отчета:**

1. **Титульный лист**

2. **Цель работы**

3. **Условие задания**

4. **Код программы**

5. **Скриншоты тестирования программы**

6. **Вывод по цели работы**

## Примечания

-  **Оценка 5 (отлично)**:

Выполнены полностью все задания или выполнено полностью альтернативное задание.

-  **Оценка 4 (хорошо)**:

Выполнены полностью любые 3 задания.

-  **Оценка 3 (удовлетворительно)**:

Выполнены полностью любые 2 задания.