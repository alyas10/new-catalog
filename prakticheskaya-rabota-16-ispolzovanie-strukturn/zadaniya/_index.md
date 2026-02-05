---
order: 1
title: Задания
---

### **Вариант 1**

*Тема: Система управления библиотекой*

1. **Паттерн Адаптер (объектов)**\
   У вас есть старый класс `OldBook` с методами `GetTitle()`, `GetAuthor()`, `GetPages()` и свойством `ISBN`. Новый интерфейс `IBook` требует методы: `GetName()`, `GetAuthorName()`, `GetPageCount()`, `GetCode()`. Реализуйте адаптер `BookAdapter`, который позволяет использовать старый класс `OldBook` как объект типа `IBook` без изменения исходного кода.

2. **Паттерн Фасад**\
   Система библиотеки включает три подсистемы: `CatalogManager` (поиск книг), `LoanService` (выдача/возврат), `FineCalculator` (расчёт штрафов). Создайте класс `LibraryFacade`, который упрощает взаимодействие с ними: например, метод `BorrowBook(string isbn, string readerId)` вызывает нужные методы внутри, скрывая сложность.

3. **Паттерн Декоратор**\
   Базовый класс `Reader` имеет базовый рейтинг читателя (например, 50). Декораторы добавляют бонусы:

   -  `LoyalReaderDecorator` (+10 за стаж > 2 года),

   -  `StudentDecorator` (+5 за статус студента),

   -  `VIPDecorator` (+20 за премиум-статус).\
      Реализуйте декораторы так, чтобы можно было комбинировать их (например, студент + VIP = +25).

---

### **Вариант 2**

*Тема: Магазин электроники*

1. **Паттерн Адаптер (классов)**\
   У вас есть внешний класс `LegacySensor` (из старой библиотеки) с методами `ReadVoltage()` и `ReadTemperature()`. Новый интерфейс `ISmartDevice` требует методы `GetPower()` и `GetTemp()`. Создайте адаптер на основе наследования (`SmartSensorAdapter : LegacySensor, ISmartDevice`), чтобы использовать старый класс в новой системе.

2. **Паттерн Фасад**\
   При оформлении заказа в магазине нужно взаимодействовать с: `InventorySystem` (проверка наличия), `PaymentGateway` (оплата), `DeliveryService` (доставка), `EmailNotifier` (уведомление). Создайте `OrderFacade`, который объединяет эти шаги в один вызов: `PlaceOrder(Product product, string address)`.

3. **Паттерн Декоратор**\
   Базовый класс `Gadget` имеет цену и описание. Декораторы добавляют функциональность:

   -  `ExtendedWarrantyDecorator` (+15% к цене, +2 года гарантии),

   -  `InsuranceDecorator` (+10% к цене, страхование от поломки),

   -  `GiftWrapDecorator` (+50 руб., упаковка).\
      Пользователь может выбрать любую комбинацию -- цена и описание автоматически обновляются.

---

### **Вариант 3**

*Тема: Игра «Герои и монстры»*

1. **Паттерн Адаптер (объектов)**\
   Есть старый класс `MonsterV1` с методами `AttackPower()`, `Defence()`, `IsAlive()`. Новый интерфейс `IEnemy` требует: `GetStrength()`, `GetArmor()`, `IsDead()`. Реализуйте адаптер `MonsterAdapter`, который переводит вызовы нового интерфейса в старые методы.

2. **Паттерн Фасад**\
   В игре есть подсистемы: `BattleEngine` (расчёт урона), `StatusManager` (здоровье, мана), `AchievementSystem` (выдача достижений). Создайте `GameFacade`, который запускает бой одним вызовом: `StartBattle(Hero h, Enemy e)`, а сам управляет всеми подсистемами.

3. **Паттерн Декоратор**\
   Базовый герой `Hero` имеет базовую силу = 10. Декораторы:

   -  `SwordDecorator` (+5 силы),

   -  `ShieldDecorator` (+3 защиты),

   -  `PotionDecorator` (+7 здоровья).\
      Герой может одновременно иметь меч, щит и зелье -- суммарная сила рассчитывается динамически.

---

### **Вариант 4**

*Тема: Офисная система документооборота*

1. **Паттерн Адаптер (классов)**\
   У вас есть внешний класс `PdfGenerator` (старая библиотека) с методом `GenerateReport(data)`. Новый интерфейс `IDocumentExporter` требует метод `ExportTo(string format)`. Создайте адаптер `PdfExporterAdapter : PdfGenerator, IDocumentExporter`, чтобы использовать старый генератор в новой системе.

2. **Паттерн Фасад**\
   Для создания отчёта нужны: `DataSource` (загрузка данных), `ReportBuilder` (формирование структуры), `Printer` (печать), `Archiver` (сохранение в архив). Реализуйте `ReportFacade`, где метод `CreateAndPrintReport(string id)` выполняет всю цепочку.

3. **Паттерн Декоратор**\
   Базовый документ `Document` имеет уровень конфиденциальности = "Общий". Декораторы:

   -  `ConfidentialDecorator` -> уровень "Конфиденциально",

   -  `UrgentDecorator` -> добавляет пометку "СРОЧНО",

   -  `SignedDecorator` -> добавляет подпись и дату.\
      Можно комбинировать: например, `SignedDecorator(ConfidentialDecorator(doc))`.

---

### **Вариант 5**

*Тема: Система доставки еды*

1. **Паттерн Адаптер (объектов)**\
   Есть старый класс `LegacyCourier` с методами `Deliver(address, order)` и `GetSpeed()`. Новый интерфейс `IDeliveryService` требует: `Send(order, location)` и `GetETA()`. Создайте адаптер `CourierAdapter`, который оборачивает `LegacyCourier` и реализует новый интерфейс.

2. **Паттерн Фасад**\
   При заказе еды нужно: `MenuService` (выбор блюд), `CartManager` (корзина), `PaymentProcessor` (оплата), `CourierDispatcher` (назначение курьера). Создайте `FoodOrderFacade`, где `PlaceOrder(List<string> items, string address)` делает всё за один вызов.

3. **Паттерн Декоратор**\
   Базовый заказ `Order` имеет стоимость = 200 ₽. Декораторы:

   -  `ExtraSauceDecorator` (+20 ₽),

   -  `FastDeliveryDecorator` (+50 ₽, +15 мин скорости),

   -  `GiftCardDecorator` (−30 ₽, если есть карта).\
      Итоговая цена и описание формируются динамически.

---

### **Вариант 6**

*Тема: Школа программирования*

1. **Паттерн Адаптер (классов)**\
   У вас есть внешний класс `OldCourse` (из старой системы) с методами `GetCourseName()`, `GetDurationDays()`. Новый интерфейс `ICourse` требует: `GetName()`, `GetLength()`, `GetLevel()`. Создайте адаптер `CourseAdapter : OldCourse, ICourse`, используя наследование.

2. **Паттерн Фасад**\
   Для записи на курс нужны: `StudentRegistry` (проверка студента), `CourseScheduler` (доступность), `PaymentService` (оплата), `EmailSender` (подтверждение). Реализуйте `EnrollmentFacade` с методом `RegisterStudent(string studentId, string courseId)`.

3. **Паттерн Декоратор**\
   Базовый курс `BasicCourse` даёт 10 баллов знаний. Декораторы:

   -  `PracticeDecorator` (+5 баллов, практика),

   -  `MentorDecorator` (+8 баллов, персональный наставник),

   -  `CertificateDecorator` (+3 балла, сертификат).\
      Студент может выбрать любую комбинацию -- итоговые баллы суммируются.

---

### **Вариант 7**

*Тема: Кино-сервис (стриминг)*

1. **Паттерн Адаптер (объектов)**\
   Есть старый класс `VhsPlayer` с методами `Play()`, `Stop()`, `GetRuntime()`. Новый интерфейс `IMediaPlayer` требует: `Start()`, `Pause()`, `GetDuration()`. Создайте `VhsAdapter`, который преобразует старый API в новый.

2. **Паттерн Фасад**\
   При просмотре фильма нужно: `LicenseChecker` (права), `StreamingService` (поток), `SubtitleLoader` (субтитры), `AnalyticsTracker` (статистика). Создайте `MovieFacade` с методом `Watch(string movieId, bool withSubs)`.

3. **Паттерн Декоратор**\
   Базовый фильм `Movie` имеет рейтинг = 6.0. Декораторы:

   -  `HDQualityDecorator` (+0.5 рейтинга),

   -  `DirectorCutDecorator` (+0.8, расширенная версия),

   -  `CommentaryDecorator` (+0.3, комментарии режиссёра).\
      Рейтинг пересчитывается при каждом обёртывании.

---

### **Вариант 8**

*Тема: Система управления проектами*

1. **Паттерн Адаптер (классов)**\
   У вас есть внешний класс `JiraTask` с методами `GetSummary()`, `GetStatus()`. Новый интерфейс `ITask` требует: `GetTitle()`, `GetState()`, `GetPriority()`. Создайте адаптер `JiraTaskAdapter : JiraTask, ITask`.

2. **Паттерн Фасад**\
   Для создания задачи нужны: `ProjectManager` (выбор проекта), `AssigneeService` (назначение исполнителя), `DeadlineSetter` (срок), `Notifier` (уведомление команды). Реализуйте `TaskFacade` с методом `CreateTask(string title, string assignee, DateTime due)`.

3. **Паттерн Декоратор**\
   Базовая задача `SimpleTask` имеет сложность = 1. Декораторы:

   -  `UrgentDecorator` (+2 сложности),

   -  `ReviewRequiredDecorator` (+1, нужна проверка),

   -  `BlockedDecorator` (+3, заблокирована).\
      Итоговая сложность = сумма всех декораторов.

---

### **Вариант 9**

*Тема: Медицинская клиника*

1. **Паттерн Адаптер (объектов)**\
   Есть старый класс `LegacyPatient` с методами `GetFullName()`, `GetAge()`, `GetDiagnosis()`. Новый интерфейс `IPatientRecord` требует: `GetName()`, `GetYears()`, `GetCondition()`. Создайте `PatientAdapter`, который оборачивает старый объект.

2. **Паттерн Фасад**\
   При записи на приём: `DoctorScheduler` (свободное время), `InsuranceVerifier` (проверка полиса), `MedicalHistoryLoader` (анамнез), `ReceiptGenerator` (чек). Создайте `AppointmentFacade` с методом `BookVisit(string patientId, string doctorSpecialty)`.

3. **Паттерн Декоратор**\
   Базовый рецепт `Prescription` содержит 1 препарат. Декораторы добавляют лекарства:

   -  `AntibioticDecorator` (+1 препарат),

   -  `PainkillerDecorator` (+1),

   -  `VitaminDecorator` (+1),\
      и каждый увеличивает стоимость на фиксированную сумму. Итоговый список препаратов и цена формируются динамически.

---

### **Вариант 10**

*Тема: Автомобильный сервис*

1. **Паттерн Адаптер (классов)**\
   У вас есть внешний класс `OBD2Scanner` (старая версия) с методом `ReadCode()`. Новый интерфейс `IDiagnosticTool` требует: `Scan()`, `GetErrorDescription()`, `ClearCodes()`. Создайте адаптер `OBD2Adapter : OBD2Scanner, IDiagnosticTool`.

2. **Паттерн Фасад**\
   При обслуживании автомобиля: `OilChecker`, `BrakeTester`, `TireBalancer`, `InvoiceGenerator`. Создайте `ServiceFacade` с методом `PerformFullCheck(string carId)`.

3. **Паттерн Декоратор**\
   Базовая услуга `BasicService` стоит 1000 ₽. Декораторы:

   -  `ACCleanDecorator` (+300 ₽),

   -  `WheelAlignmentDecorator` (+500 ₽),

   -  `PolishDecorator` (+400 ₽).\
      Итоговая стоимость и список услуг выводятся вместе.

---

### **Вариант 11**

*Тема: Онлайн-магазин одежды*

1. **Паттерн Адаптер (объектов)**\
   Есть старый класс `LegacyProduct` с полями `Name`, `Price`, `Size`. Новый интерфейс `IProduct` требует методы: `GetTitle()`, `GetCost()`, `GetSizeCode()`. Реализуйте `ProductAdapter`, который преобразует старый объект в новый интерфейс.

2. **Паттерн Фасад**\
   При оформлении заказа: `InventoryChecker`, `SizeGuide`, `DiscountApplier`, `ShippingCalculator`. Создайте `CheckoutFacade` с методом `ProcessOrder(List<Item> cart, string address)`.

3. **Паттерн Декоратор**\
   Базовый товар `ClothingItem` имеет цену и материал. Декораторы:

   -  `ExpressShippingDecorator` (+200 ₽),

   -  `GiftWrapDecorator` (+50 ₽),

   -  `ExtendedReturnDecorator` (+0 ₽, но +14 дней на возврат).\
      Цена и условия обновляются при добавлении декораторов.

---

### **Вариант 12**

*Тема: Система управления парком автомобилей*

1. **Паттерн Адаптер (классов)**\
   У вас есть внешний класс `CarV1` с методами `GetModel()`, `GetFuelLevel()`. Новый интерфейс `IVehicle` требует: `GetBrand()`, `GetTankPercent()`, `IsReady()`. Создайте адаптер `CarAdapter : CarV1, IVehicle`.

2. **Паттерн Фасад**\
   Для выдачи авто: `AvailabilityChecker`, `DriverVerifier`, `FuelRefiller`, `LogRecorder`. Создайте `FleetFacade` с методом `AssignCar(string driverId, string purpose)`.

3. **Паттерн Декоратор**\
   Базовый автомобиль `BaseCar` имеет надёжность = 70%. Декораторы:

   -  `GPSDecorator` (+5 надёжности),

   -  `MaintenanceDecorator` (+10, недавно обслужен),

   -  `WinterTiresDecorator` (+8, зимние шины).\
      Итоговая надёжность = сумма базовой + всех декораторов.