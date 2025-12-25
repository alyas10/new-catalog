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

*  {% colwidth=[111.429] %}

   **№**

*  {% colwidth=[281.429] %}

   **\[АБСТРАКТНЫЙ\_БАЗОВЫЙ\]**

*  {% colwidth=[323.429] %}

   **\[СПЕЦИАЛИЗИРОВАННЫЙ\_КЛАСС\]**

*  {% colwidth=[241.429] %}

   **\[БАЗОВЫЙ\_ИНТЕРФЕЙС\]**

*  {% colwidth=[248.429] %}

   **\[СПЕЦИАЛИЗИРОВАННЫЙ\_ИНТЕРФЕЙС\]**

*  {% colwidth=[173.429] %}

   **\[ПОЛЕ\_КЛАСС\]**

*  {% colwidth=[150] %}

   **\[ИСКЛЮЧЕНИЕ\_КЛАСС\]**

---

*  {% colwidth=[111.429] %}

   1

*  {% colwidth=[281.429] %}

   ContentUnit

*  {% colwidth=[323.429] %}

   WebDocument

*  {% colwidth=[241.429] %}

   IContent

*  {% colwidth=[248.429] %}

   IOnlineContent

*  {% colwidth=[173.429] %}

   Publisher

*  {% colwidth=[150] %}

   ContentException

---

*  {% colwidth=[111.429] %}

   2

*  {% colwidth=[281.429] %}

   VehicleBase

*  {% colwidth=[323.429] %}

   Truck

*  {% colwidth=[241.429] %}

   IVehicle

*  {% colwidth=[248.429] %}

   ICommercialVehicle

*  {% colwidth=[173.429] %}

   Manufacturer

*  {% colwidth=[150] %}

   VehicleException

---

*  {% colwidth=[111.429] %}

   3

*  {% colwidth=[281.429] %}

   MediaBase

*  {% colwidth=[323.429] %}

   Documentary

*  {% colwidth=[241.429] %}

   IMedia

*  {% colwidth=[248.429] %}

   IDocumentary

*  {% colwidth=[173.429] %}

   Director

*  {% colwidth=[150] %}

   MediaException

---

*  {% colwidth=[111.429] %}

   4

*  {% colwidth=[281.429] %}

   CourseBase

*  {% colwidth=[323.429] %}

   AdvancedCourse

*  {% colwidth=[241.429] %}

   ICourse

*  {% colwidth=[248.429] %}

   IAdvancedCourse

*  {% colwidth=[173.429] %}

   Instructor

*  {% colwidth=[150] %}

   CourseException

---

*  {% colwidth=[111.429] %}

   5

*  {% colwidth=[281.429] %}

   PlayerBase

*  {% colwidth=[323.429] %}

   ProPlayer

*  {% colwidth=[241.429] %}

   IPlayer

*  {% colwidth=[248.429] %}

   IProPlayer

*  {% colwidth=[173.429] %}

   Team

*  {% colwidth=[150] %}

   PlayerException

---

*  {% colwidth=[111.429] %}

   6

*  {% colwidth=[281.429] %}

   AnimalBase

*  {% colwidth=[323.429] %}

   ExoticPet

*  {% colwidth=[241.429] %}

   IAnimal

*  {% colwidth=[248.429] %}

   IExoticPet

*  {% colwidth=[173.429] %}

   Veterinarian

*  {% colwidth=[150] %}

   PetException

---

*  {% colwidth=[111.429] %}

   7

*  {% colwidth=[281.429] %}

   WorkerBase

*  {% colwidth=[323.429] %}

   SeniorEmployee

*  {% colwidth=[241.429] %}

   IWorker

*  {% colwidth=[248.429] %}

   ISeniorWorker

*  {% colwidth=[173.429] %}

   Department

*  {% colwidth=[150] %}

   EmployeeException

---

*  {% colwidth=[111.429] %}

   8

*  {% colwidth=[281.429] %}

   RoomBase

*  {% colwidth=[323.429] %}

   Suite

*  {% colwidth=[241.429] %}

   IRoom

*  {% colwidth=[248.429] %}

   ILuxuryRoom

*  {% colwidth=[173.429] %}

   Hotel

*  {% colwidth=[150] %}

   RoomException

---

*  {% colwidth=[111.429] %}

   9

*  {% colwidth=[281.429] %}

   ItemBase

*  {% colwidth=[323.429] %}

   PremiumProduct

*  {% colwidth=[241.429] %}

   IItem

*  {% colwidth=[248.429] %}

   IPremiumItem

*  {% colwidth=[173.429] %}

   Category

*  {% colwidth=[150] %}

   ProductException

---

*  {% colwidth=[111.429] %}

   10

*  {% colwidth=[281.429] %}

   StationBase

*  {% colwidth=[323.429] %}

   MetroStation

*  {% colwidth=[241.429] %}

   IStation

*  {% colwidth=[248.429] %}

   IMetroStation

*  {% colwidth=[173.429] %}

   Line

*  {% colwidth=[150] %}

   StationException

---

*  {% colwidth=[111.429] %}

   11

*  {% colwidth=[281.429] %}

   DeviceBase

*  {% colwidth=[323.429] %}

   PremiumGadget

*  {% colwidth=[241.429] %}

   IDevice

*  {% colwidth=[248.429] %}

   IPremiumDevice

*  {% colwidth=[173.429] %}

   Brand

*  {% colwidth=[150] %}

   GadgetException

---

*  {% colwidth=[111.429] %}

   12

*  {% colwidth=[281.429] %}

   AccountBase

*  {% colwidth=[323.429] %}

   PremiumAccount

*  {% colwidth=[241.429] %}

   IAccount

*  {% colwidth=[248.429] %}

   IPremiumAccount

*  {% colwidth=[173.429] %}

   Bank

*  {% colwidth=[150] %}

   AccountException

{% /table %}
