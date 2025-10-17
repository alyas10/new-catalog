---
order: 4
title: Задача 4. Обработка и поиск в тексте
---

**Задание:** Пользователь вводит произвольный текст (предложение или несколько предложений). Программа должна обработать текст и вывести результат согласно варианту.

**Шаблон для ввода текста**

```
string text = "";
        bool validInput = false;

        while (!validInput)
        {
            Console.WriteLine("Введите текст для обработки:");
            Console.WriteLine("(текст должен содержать хотя бы 2 слова)");
            Console.Write("> ");
            
            text = Console.ReadLine();
            
            // Проверка ввода
            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Ошибка: Вы ввели пустую строку. Попробуйте снова.\n");
                continue;
            }
            string[] input_words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            if (input_words.Length < 2)
            {
                Console.WriteLine("Ошибка: Текст должен содержать хотя бы 2 слова. Попробуйте снова.\n");
                continue;
            }
            
            validInput = true;
        }
       Console.WriteLine("Введенный текст:");
       Console.WriteLine(text);
       string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int totalCharacters = 0;
        
        foreach (string word in words)
        {
            totalCharacters += word.Length;
        }
     
        Console.WriteLine($"\nСтатистика текста:");
        Console.WriteLine($"- Количество слов: {words.Length}");
        Console.WriteLine($"- Общее количество символов: {text.Length}");
```

| **Вариант** | **Условие для обработки текста**                                          | **Рекомендуемые методы**                                           |
|-------------|---------------------------------------------------------------------------|--------------------------------------------------------------------|
| 1           | Найти и вывести все слова, которые начинаются на гласную букву.           | `Split()`, `StartsWith()`, `ToLower()`, `Length`                   |
| 2           | Найти и вывести самое длинное слово в тексте.                             | `Split()`, `Length`, цикл `for`                                    |
| 3           | Определить, есть ли в тексте слова-палиндромы.                            | `Split()`, `ToLower()`, `Length`, цикл `for`                       |
| 4           | Посчитать, сколько раз в тексте встречается заданное пользователем слово. | `Split()`, `ToLower()`, `Equals()` или `==`                        |
| 5           | Вывести все слова, заканчивающиеся на "тся" или "ться".                   | `Split()`, `EndsWith()`, `Length`                                  |
| 6           | Заменить все вхождения слова "не" на "НЕ".                                | `Replace()`, `Split()`                                             |
| 7           | Вывести все слова, содержащие удвоенные согласные.                        | `Split()`, `Length`, цикл `for`, `char.IsLetter()`                 |
| 8           | Удалить из текста все слова короче 4 символов и вывести результат.        | `Split()`, `Length`, цикл `for`                                    |
| 9           | Найти и вывести все слова, которые являются числом.                       | `Split()`, `char.IsDigit()`, `Length`                              |
| 10          | Вывести все вопросительные предложения из текста.                         | `Split()` с разделителем '.', '?', '!', `EndsWith()`, `Contains()` |
| 11          | Посчитать среднюю длину слова в тексте.                                   | `Split()`, `Length`, цикл `for`                                    |
| 12          | Вывести все слова, в которых буквы идут в алфавитном порядке.             | `Split()`, `ToLower()`, `Length`, цикл `for`, сравнение символов   |