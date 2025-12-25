---
order: 1
title: Задания
---

## **Общая схема выполнения всех вариантов:**

**Задание 1: Базовый класс сущности**

-  Создать базовый класс для моделируемой сущности (например, `Car`, `Book`, `Student`, `Employee` и т.д.)

-  Реализовать необходимые поля (private и public), свойства (get/set), конструкторы

-  Добавить методы для работы с объектом (`GetInfo()`, `Update()`, и т.п.)

-  Создать несколько экземпляров класса разными способами

**Задание 2: Наследование и полиморфизм**

-  Разработать абстрактный базовый класс с абстрактными членами

-  Создать производный класс с дополнительной специализацией

-  Продемонстрировать разницу между переопределением (`override`) и скрытием (`new`) методов

**Задание 3: Интерфейсы и обработка ошибок**

-  Заменить абстрактный класс на интерфейс(ы) с соответствующей функциональностью

-  Реализовать иерархию интерфейсов с явной реализацией

-  Добавить вспомогательный класс как поле в основной класс

-  Разработать пользовательский класс исключений

-  Реализовать валидацию данных через `throw` в конструкторах основных классов

### **Задание 1.** Создать класс \[БАЗОВЫЙ\_КЛАСС\].

\
● В классе \[БАЗОВЫЙ\_КЛАСС\] должны быть закрытое (private) поле  строкового типа, публичное (public) поле целочисленного типа и методы, устанавливающие и возвращающие данные значения («геттеры» «сеттеры»);\
● Класс \[БАЗОВЫЙ\_КЛАСС\] должен иметь конструктор, принимающий в качестве аргумента только \[идентификатор\], и конструктор, принимающий два аргумента;\
● Класс \[БАЗОВЫЙ\_КЛАСС\] должен иметь публичный метод – функцию `WriteInfo()`, которая возвращает информацию о \[сущность\] в виде строки;\
● Класс \[БАЗОВЫЙ\_КЛАСС\] должен иметь публичный метод – процедуру МЕТОД\_ИЗМЕНЕНИЯ, изменяющую \[параметр\];\
● Создать три объекта класса \[БАЗОВЫЙ\_КЛАСС\] различными способами;

| №  | \[БАЗОВЫЙ\_КЛАСС\] | private поле  | public поле     | Метод изменения                |
|----|--------------------|---------------|-----------------|--------------------------------|
| 1  | Car                | model         | Year            | MakeOlder()                    |
| 2  | Movie              | title         | DurationMinutes | Extend(int min)                |
| 3  | Course             | name          | Hours           | AddHours(int h)                |
| 4  | Player             | nickname      | Level           | LevelUp()                      |
| 5  | Pet                | name          | Age             | BecomeOlder()                  |
| 6  | Employee           | fullName      | ExperienceYears | AddExperience(int y)           |
| 7  | Room               | number        | Capacity        | IncreaseCapacity(int n)        |
| 8  | Product            | name          | Quantity        | AddStock(int n)                |
| 9  | Station            | title         | Platforms       | AddPlatform()                  |
| 10 | Gadget             | model         | WarrantyYears   | ExtendWarranty(int y)          |
| 11 | Account            | ownerName     | Balance         | Deposit(decimal sum)           |
| 12 | Project            | \_projectName | Budget          | IncreaseBudget(decimal amount) |

### **Задание 2.** Создать для класса \[БАЗОВЫЙ\_КЛАСС\] базовый абстрактный класс

\[АБСТРАКТНЫЙ\_БАЗОВЫЙ\], имеющий хотя бы одно абстрактное поле и один абстрактный метод;\
Разработать для класса \[БАЗОВЫЙ\_КЛАСС\] производный класс \[СПЕЦИАЛИЗИРОВАННЫЙ\_КЛАСС\];\
Продемонстрировать на примере классов \[БАЗОВЫЙ\_КЛАСС\] и \[СПЕЦИАЛИЗИРОВАННЫЙ\_КЛАСС\] различие между переопределением (`override`) и скрытием метода (`new`);



### **Задание 3.** Абстрактный класс \[АБСТРАКТНЫЙ\_БАЗОВЫЙ\] заменить интерфейсом

\[БАЗОВЫЙ\_ИНТЕРФЕЙС\]. Самостоятельно определить функциональность данного интерфейса;\
Для класса \[СПЕЦИАЛИЗИРОВАННЫЙ\_КЛАСС\] разработать интерфейс \[СПЕЦИАЛИЗИРОВАННЫЙ\_ИНТЕРФЕЙС\], производный от \[БАЗОВЫЙ\_ИНТЕРФЕЙС\]. Продемонстрировать явную реализацию интерфейса. Самостоятельно определить функциональность данного интерфейса;\
Разработать класс \[ПОЛЕ\_КЛАСС\]. Добавить в класс \[БАЗОВЫЙ\_КЛАСС\] объект этого класса в качестве поля, отражающего \[связь\];\
Создать класс исключений \[ИСКЛЮЧЕНИЕ\_КЛАСС\], прописать исключение через оператор `throw` в конструкторах класса \[БАЗОВЫЙ\_КЛАСС\] и \[ПОЛЕ\_КЛАСС\].

{% table header="row" %}

---

*  {% colwidth=[82] %}

   №

*  {% colwidth=[165.429] %}

   \[АБСТРАКТНЫЙ\_БАЗОВЫЙ\]

*  {% colwidth=[176.429] %}

   \[СПЕЦИАЛИЗИРОВАННЫЙ\_КЛАСС\]

*  {% colwidth=[134.429] %}

   \[БАЗОВЫЙ\_ИНТЕРФЕЙС\]

*  {% colwidth=[204.429] %}

   \[СПЕЦИАЛИЗИРОВАННЫЙ\_ИНТЕРФЕЙС\]

*  {% colwidth=[167.429] %}

   \[ПОЛЕ\_КЛАСС\]

*  {% colwidth=[178.429] %}

   \[ИСКЛЮЧЕНИЕ\_КЛАСС\]

---

*  {% colwidth=[82] %}

   0

*  {% colwidth=[165.429] %}

   `Publication`

*  {% colwidth=[176.429] %}

   `EBook`

*  {% colwidth=[134.429] %}

   `IPublication`

*  {% colwidth=[204.429] %}

   `IDigital`

*  {% colwidth=[167.429] %}

   `Author`

*  {% colwidth=[178.429] %}

   `PublicationException`

---

*  {% colwidth=[82] %}

   1

*  {% colwidth=[165.429] %}

   `VehicleBase`

*  {% colwidth=[176.429] %}

   `Truck`

*  {% colwidth=[134.429] %}

   `IVehicle`

*  {% colwidth=[204.429] %}

   `ICommercialVehicle`

*  {% colwidth=[167.429] %}

   `Manufacturer`

*  {% colwidth=[178.429] %}

   `VehicleException`

---

*  {% colwidth=[82] %}

   2

*  {% colwidth=[165.429] %}

   `MediaBase`

*  {% colwidth=[176.429] %}

   `Documentary`

*  {% colwidth=[134.429] %}

   `IMedia`

*  {% colwidth=[204.429] %}

   `IDocumentary`

*  {% colwidth=[167.429] %}

   `Director`

*  {% colwidth=[178.429] %}

   `MediaException`

---

*  {% colwidth=[82] %}

   3

*  {% colwidth=[165.429] %}

   `CourseBase`

*  {% colwidth=[176.429] %}

   `AdvancedCourse`

*  {% colwidth=[134.429] %}

   `ICourse`

*  {% colwidth=[204.429] %}

   `IAdvancedCourse`

*  {% colwidth=[167.429] %}

   `Instructor`

*  {% colwidth=[178.429] %}

   `CourseException`

---

*  {% colwidth=[82] %}

   4

*  {% colwidth=[165.429] %}

   `PlayerBase`

*  {% colwidth=[176.429] %}

   `ProPlayer`

*  {% colwidth=[134.429] %}

   `IPlayer`

*  {% colwidth=[204.429] %}

   `IProPlayer`

*  {% colwidth=[167.429] %}

   `Team`

*  {% colwidth=[178.429] %}

   `PlayerException`

---

*  {% colwidth=[82] %}

   5

*  {% colwidth=[165.429] %}

   `AnimalBase`

*  {% colwidth=[176.429] %}

   `ExoticPet`

*  {% colwidth=[134.429] %}

   `IAnimal`

*  {% colwidth=[204.429] %}

   `IExoticPet`

*  {% colwidth=[167.429] %}

   `Veterinarian`

*  {% colwidth=[178.429] %}

   `PetException`

---

*  {% colwidth=[82] %}

   6

*  {% colwidth=[165.429] %}

   `WorkerBase`

*  {% colwidth=[176.429] %}

   `SeniorEmployee`

*  {% colwidth=[134.429] %}

   `IWorker`

*  {% colwidth=[204.429] %}

   `ISeniorWorker`

*  {% colwidth=[167.429] %}

   `Department`

*  {% colwidth=[178.429] %}

   `EmployeeException`

---

*  {% colwidth=[82] %}

   7

*  {% colwidth=[165.429] %}

   `RoomBase`

*  {% colwidth=[176.429] %}

   `Suite`

*  {% colwidth=[134.429] %}

   `IRoom`

*  {% colwidth=[204.429] %}

   `ILuxuryRoom`

*  {% colwidth=[167.429] %}

   `Hotel`

*  {% colwidth=[178.429] %}

   `RoomException`

---

*  {% colwidth=[82] %}

   8

*  {% colwidth=[165.429] %}

   `ItemBase`

*  {% colwidth=[176.429] %}

   `PremiumProduct`

*  {% colwidth=[134.429] %}

   `IItem`

*  {% colwidth=[204.429] %}

   `IPremiumItem`

*  {% colwidth=[167.429] %}

   `Category`

*  {% colwidth=[178.429] %}

   `ProductException`

---

*  {% colwidth=[82] %}

   9

*  {% colwidth=[165.429] %}

   `StationBase`

*  {% colwidth=[176.429] %}

   `MetroStation`

*  {% colwidth=[134.429] %}

   `IStation`

*  {% colwidth=[204.429] %}

   `IMetroStation`

*  {% colwidth=[167.429] %}

   `Line`

*  {% colwidth=[178.429] %}

   `StationException`

---

*  {% colwidth=[82] %}

   10

*  {% colwidth=[165.429] %}

   `DeviceBase`

*  {% colwidth=[176.429] %}

   `PremiumGadget`

*  {% colwidth=[134.429] %}

   `IDevice`

*  {% colwidth=[204.429] %}

   `IPremiumDevice`

*  {% colwidth=[167.429] %}

   `Brand`

*  {% colwidth=[178.429] %}

   `GadgetException`

---

*  {% colwidth=[82] %}

   11

*  {% colwidth=[165.429] %}

   `AccountBase`

*  {% colwidth=[176.429] %}

   `PremiumAccount`

*  {% colwidth=[134.429] %}

   `IAccount`

*  {% colwidth=[204.429] %}

   `IPremiumAccount`

*  {% colwidth=[167.429] %}

   `Bank`

*  {% colwidth=[178.429] %}

   `AccountException`

{% /table %}
