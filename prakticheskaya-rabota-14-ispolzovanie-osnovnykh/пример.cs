using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    public interface IHuman
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Height { get; set; }
        double Weight { get; set; }
    }

    public class Human : IHuman, IComparable<Human>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Height { get; set; }
        public double Weight { get; set; }
        public string FullName => string.Format("{0} {1}", FirstName, LastName);

        public int CompareTo(Human other) => 
            string.Compare(other.FullName, FullName, StringComparison.InvariantCultureIgnoreCase);

        public override string ToString() => 
            string.Format("Class Human: FullName = {0}, Height = {1}, Weight = {2}", FullName, Height, Weight);
    }

    public class Worker : Human
    {
        public double Salary { get; set; }

        public void DoWork() { }

        public override string ToString() => 
            string.Format("Class Worker: FullName = {0}, Height = {1}, Weight = {2}, Salary = {3}", 
                          FullName, Height, Weight, Salary);
    }

    public class Student : Human
    {
        public string University { get; set; }

        public void DoStudy() { }

        public override string ToString() => 
            string.Format("Class Student: FullName = {0}, Height = {1}, Weight = {2}, University = {3}", 
                          FullName, Height, Weight, University);
    }

    public class HumanContainer<T> : IEnumerable<T> where T : Human
    {
        private readonly List<T> container = new List<T>();

        public int Count => container.Count;

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count) throw new IndexOutOfRangeException();
                return container[index];
            }
            set
            {
                if (index < 0 || index >= Count) throw new IndexOutOfRangeException();
                container[index] = value;
            }
        }

        public T GetByName(string name) => 
            container.FirstOrDefault(h => string.Compare(h.FirstName, name, StringComparison.InvariantCultureIgnoreCase) == 0);

        public void Add(T human) => container.Add(human);

        public T Remove(T human)
        {
            var element = container.FirstOrDefault(h => h == human);
            if (element != null) container.Remove(element);
            return element ?? throw new NullReferenceException();
        }

        public void Sort() => container.Sort();

        public IEnumerator<T> GetEnumerator() => container.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    class Program
    {
        static void Main()
        {
            try
            {
                var st1 = new Student { Weight = 60, Height = 190, FirstName = "Marie", LastName = "Little", University = "BSTU" };
                var st2 = new Student { Weight = 54, Height = 172, FirstName = "Sue", LastName = "Jackson", University = "BSTU" };
                var st3 = new Student { Weight = 54, Height = 181, FirstName = "Lance", LastName = "Knight", University = "BSU" };
                var st4 = new Student { Weight = 78, Height = 184, FirstName = "Lance", LastName = "Stepth", University = "BSU" };
                var st5 = new Student { Weight = 81, Height = 184, FirstName = "Wesley", LastName = "Jackson", University = "BSTU" };
                var wr1 = new Worker { Weight = 67, Height = 190, FirstName = "Douglas", LastName = "Collins", Salary = 578.4 };
                var wr2 = new Worker { Weight = 67, Height = 190, FirstName = "Lynn", LastName = "Gibson", Salary = 976.5 };
                var wr3 = new Worker { Weight = 55, Height = 172, FirstName = "Olivi", LastName = "Smith", Salary = 493 };

                var container1 = new HumanContainer<Human> { st1, st2, wr1, wr2 };
                container1.Remove(wr2);
                container1.Remove(st1);
                Console.WriteLine(container1[1] == st1 ? "container[1] == st1" : "");
                Console.WriteLine(container1[6] == st1 ? "container[6] == st1" : "");
                Console.WriteLine(container1[1] == st1 ? "container[1] == st1" : "");
                foreach (var human in container1)
                    Console.WriteLine(human.ToString());

                var container2 = new HumanContainer<Human>();
                container2.Add(st3);
                container2.Add(st4);
                container2.Add(st5);
                container2.Add(wr3);
                container2.Sort();
                foreach (var human in container2)
                    Console.WriteLine(human.ToString());

                var list = new List<HumanContainer<Human>> { container1, container2 };

                Console.WriteLine("To objects OrderBy, ThenBy");
                var orderRes = container1.OrderBy(h => h.Height).ThenBy(h => h.Weight);
                foreach (var human in orderRes) Console.WriteLine(human);

                Console.WriteLine("To objects Where");
                var whereRes = container1.Where(h => h.Height > 170 && h.Weight > 58 && h.FullName.StartsWith("L"));
                foreach (var human in whereRes) Console.WriteLine(human.ToString());

                Console.WriteLine("To objects Select");
                var selectRes = container1.Select((h, i) => new { i = i + 1, human = h });
                foreach (var el in selectRes) Console.WriteLine(el);

                Console.WriteLine("To objects SelectMany");
                var selectManyRes = container1.SelectMany(h => h.FullName.Split(' '));
                foreach (var el in selectManyRes) Console.WriteLine(el);

                Console.WriteLine("To objects Skip");
                var skipRes = container1.Skip(2);
                foreach (var human in skipRes) Console.WriteLine(human);

                Console.WriteLine("To objects SkipWhile");
                var skipWhileRes = container1.SkipWhile(h => h.Height < 190);
                foreach (var human in skipWhileRes) Console.WriteLine(human);

                Console.WriteLine("To objects Take");
                var takeRes = container1.Take(2);
                foreach (var human in takeRes) Console.WriteLine(human);

                Console.WriteLine("To objects TakeWhile");
                var takeWhileRes = container1.TakeWhile(h => h.Height < 190);
                foreach (var human in takeWhileRes) Console.WriteLine(human);

                Console.WriteLine("To objects Concat");
                var concatRes = container1.Concat(container2);
                foreach (var human in concatRes) Console.WriteLine(human);

                Console.WriteLine("To objects GroupBy");
                var groupByRes = concatRes.Where(h => h is Student).GroupBy((Student)h => h.University);
                foreach (var group in groupByRes)
                {
                    Console.WriteLine("Group {0}, Count {1}", group.Key, group.Count());
                    foreach (var human in group) Console.WriteLine(human);
                }

                Console.WriteLine("To objects First");
                var firstRes = concatRes.First(h => h.FullName.Length < 12);
                Console.WriteLine(firstRes);

                Console.WriteLine("To objects FirstOrDefault");
                var firstOrDefRes = concatRes.FirstOrDefault(h => h.FullName.Length > 14);
                if (firstOrDefRes != null) Console.WriteLine(firstOrDefRes);

                Console.WriteLine("To objects DefaultIfEmpty");
                var defaultIfEmptyRes = container2.Where(c => c.FirstName == "Eleanor").DefaultIfEmpty(new Human { FirstName = "Eleanor", LastName = "Fuller" }).First();
                Console.WriteLine(defaultIfEmptyRes);

                Console.WriteLine("To objects Min");
                var minRes = container1.Min(h => h.Weight);
                Console.WriteLine(minRes);

                Console.WriteLine("To objects Max");
                var maxRes = container1.Max(h => h.Height);
                Console.WriteLine(maxRes);

                Console.WriteLine("To objects All/Any");
                var allAnyRes = list.First(c => c.All(h => h.Height > 160) && c.Any(h => h is Worker))
                                .Select(h => h.FirstName).OrderByDescending(s => s);
                foreach (var name in allAnyRes) Console.WriteLine(name);

                Console.WriteLine("To objects Contains");
                var containsRes = list.Where(c => c.Contains(wr3))
                                      .SelectMany(c => c.SelectMany(h => h.FullName.Split(' ')))
                                      .Distinct().OrderBy(s => s).ToList();
                foreach (var name in containsRes) Console.WriteLine(name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
