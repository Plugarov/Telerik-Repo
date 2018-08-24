using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndAnonymousAndExtension
{
    class Program
    {
        delegate string ConvertMethod(string inString);

        private static string UppercaseString(string inString)
        {
            return inString.ToUpper();
        }

        private static string AddSomeXXXInBehind(string inString)
        {
            return inString + "XXX";
        }

        static void Main()
        {
            //ConvertMethod convertMeth = UppercaseString;
            //Func<string, string> convertMethod = UppercaseString;
            //convertMethod += AddSomeXXXInBehind;
            //string name = "Dakota";
            //Console.WriteLine(convertMethod(name));


            // ======== Delegates ===========
            //MyDelegate button = new Button(someclassToInvoke);
            //button.Invoke();

            // ======== Anonymous methods ========
            //MyDelegate action = delegate ()
            //{
            //    Console.WriteLine("123");
            //};

            //action += delegate ()
            //{
            //    Console.WriteLine("321");
            //};

            //action += delegate ()
            //{
            //    Console.WriteLine("333");
            //};

            //action();

            // ============ events =========


            //homework

            List<Student> students = new List<Student>()
            {
                new Student("Penka", "Georgieva", 1006, 0234689343, "as@abv.bg", new List<int>() {6, 6, 3, 3 },new Group(2,"Mathmatics")),
                new Student("Goosho", "Penchev", 1006, 0276723343,"as@mail.bg", new List<int>() {4, 6, 6 }, new Group(2,"Physics")),
                new Student("Anton", "Dimitrov", 1006, 0876743343,"as@mail.bg", new List<int>() {4, 2, 2 }, new Group(2,"Physics")),
                new Student("Anton", "Ivanov", 1007, 0876743343,"as@abv.bg", new List<int>() {6, 4 }, new Group(1,"Mathmatics")),
                new Student("Anton", "Staviiski", 3007, 0876743343,"as@abv.bg", new List<int>() {6, 4 }, new Group(1,"Mathmatics")),
            };

            var res = students
                .GroupBy();

                

            //var phones = students
            //    .FindAll(delegate (Student x)
            //    {
            //        int tmp = (x.Tel + "")[0];
            //        return tmp == '2';
            //    })
            //    .ToList();

            //GetStudentInformation convertMeth = byEmail;
            //convertMeth += byFN;
            //convertMeth(students);

            //names.ForEach(delegate (int name)
            //{
            //    Console.WriteLine(name);
            //});


            //List<object> list = new List<object>();
            //students
            //    .FindAll(delegate (Student record)
            //    {
            //        if (record.Marks.IndexOf(6) != -1)
            //            return true;
            //        return false;
            //    })
            //    .ForEach(delegate (Student record)
            //    {
            //        list.Add(new { name = record.FirstName, marks = record.Marks });
            //    });

            //list.ForEach(x => Console.WriteLine(x));

            //foreach (var v in getMarks)
            //{
            //    Console.WriteLine(string.Format("{0} {1}", v.LastName, v.FirstName));
            //}

            //var list = new MyList();
            //list.ListChanged += HandlerListChanged;
            //list.Add(1);
            //list.Add(3);
            //list.Add(2);
            //list.Add(3);


        }

        //public static void HandlerListChanged(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Event handeled");
        //    Console.WriteLine((sender as MyList).nums.Count);
        //}


        //private static bool checkEnrolledIn2006(Student record)
        //{
        //    if(record.fN % 100 == 06)
        //        return true;
        //    return false;
        //}

        //private static bool CheckDvoikadjii(Student record)
        //{
        //    if ((record.Marks
        //        .FindAll(x => x == 2)
        //        .Count) == 2)
        //        return true;
        //    return false;
        //}


        //delegate void GetStudentInformation(List<Student> s);

        //private static List<Student> result = new List<Student>();

        //private static void byEmail(List<Student> s)
        //{
        //    var phones = s
        //        .FindAll(delegate (Student x)
        //        {
        //            int tmp = (x.Tel + "")[0];
        //            return tmp == '2';
        //        })
        //        .ToList();
        //    foreach (var v in phones)
        //    {
        //        result.Add(v);
        //    }
        //}

        //private static void byFN(List<Student> s)
        //{
        //    var phones = s
        //        .FindAll(x => x.fN == 3)
        //        .ToList();
        //    foreach (var v in phones)
        //    {
        //        result.Add(v);
        //    }
        //}

        //public static void HandlerListChanged(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Event handeled");
        //    Console.WriteLine((sender as MyList<int>).data.Count);
        //}
    }

    internal static class Extensions
    {
        public static int[] GroupBy(this object record)
        {

            return null;
        }
    }

    //class MyList
    //{
    //    public event EventHandler ListChanged;
    //    public List<int> nums;

    //    public MyList()
    //    {
    //        this.nums = new List<int>();
    //    }

    //    public void Add(int num)
    //    {
    //        nums.Add(num);
    //        NotifyListChanged(new EventArgs());
    //    }

    //    private void NotifyListChanged(EventArgs e)
    //    {
    //        this.ListChanged.Invoke(this, e);
    //    }
    //}

    //class MyList<T>
    //{
    //    public event EventHandler ListChanged;
    //    public List<T> data;
    //    public MyList()
    //    {
    //        this.data = new List<T>();
    //    }

    //    public void Add(T item)
    //    {
    //        this.data.Add(item);
    //        this.NotifyListChange(new EventArgs());
    //    }

    //    public void Clear(T item)
    //    {
    //        this.data.Clear();
    //        this.NotifyListChange(new EventArgs());
    //    }

    //    private void NotifyListChange(EventArgs e)
    //    {
    //        this.ListChanged?.Invoke(this, e);
    //    }
    //}

    //    public delegate void CustomEventHandler();

    //    class Students
    //    {
    //        private string name;
    //        private string lastName;
    //        private int studentID;

    //        public Students(string name, string lastName, int id)
    //        {
    //            this.Name = name;
    //            this.LastName = lastName;
    //            this.StudentID = id;
    //        }

    //        public string LastName { get => lastName; set => lastName = value; }

    //        public string Name { get => name; set => name = value; }

    //        public int StudentID { get => studentID; set => studentID = value; }
    //    }

    //    public static class Extensions
    //    {
    //        public static int WordCount(this string str)
    //        {
    //            return str.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries).Length;
    //        }

    //        public static StringBuilder Substring(this StringBuilder str, int startIndex)
    //        {
    //            StringBuilder result = new StringBuilder();
    //            int strLen = str.Length;

    //            for (int i = startIndex; i < strLen; i++)
    //            {
    //                result.Append(str[i]);
    //            }
    //            return result;
    //        }

    //        public static StringBuilder Substring(this StringBuilder str, int startIndex, int length)
    //        {
    //            StringBuilder result = new StringBuilder();
    //            int strLen = startIndex + length;

    //            for (int i = startIndex; i < strLen; i++)
    //            {
    //                result.Append(str[i]);
    //            }
    //            return result;
    //        }
    //    }

    //    public static class IEnumerableExtensions
    //    {
    //        public static decimal Sum(this IEnumerable<decimal> source)
    //        {
    //            decimal sum = 0;
    //            foreach (decimal v in source) sum += v;
    //            return sum;
    //        }

    //        public static decimal Average(this IEnumerable<decimal> source)
    //        {
    //            decimal sum = 0;
    //            long count = 0;
    //            foreach (decimal v in source)
    //            {
    //                sum += v;
    //                count++;
    //            }
    //            if (count > 0) return sum / count;
    //            throw new Exception("Empty list");
    //        }

    //        public static decimal Product(this IEnumerable<decimal> source)
    //        {
    //            decimal product = 1;
    //            foreach (decimal i in source) product *= i;
    //            return product;
    //        }

    //        public static decimal Min(this IEnumerable<decimal> source)
    //        {
    //            decimal min = decimal.MaxValue;

    //            foreach (decimal v in source)
    //            {
    //                if (v < min)
    //                {
    //                    min = v;
    //                }
    //            }
    //            return min;
    //        }

    //        public static decimal Max(this IEnumerable<decimal> source)
    //        {
    //            decimal max = 0;
    //            foreach (decimal v in source)
    //            {
    //                if (max < v)
    //                {
    //                    max = v;
    //                }
    //            }
    //            return max;
    //        }
    //    }

}
