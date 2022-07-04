using System;

namespace opps
{
    class studentt
    {
        //instant variable
        string name;
        int percentage;
        int passoutyear;
        string branch;
        string techn;


        public void accept()
        {
            Console.WriteLine("Enter name,percentage,passoutyear,branch,tech");
            name = Console.ReadLine();
            percentage = int.Parse(Console.ReadLine());
            passoutyear = int.Parse(Console.ReadLine());
            branch = Console.ReadLine();
            techn = Console.ReadLine();

        }
        public void display()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("percentage :" + percentage);
            Console.WriteLine("Pass out year :" + passoutyear);
            Console.WriteLine("Branch" + branch);
            Console.WriteLine("Technical Skills :" + techn);
        }
    }
    class Test
    {

        static void Main(string[] args)
        {
            studentt s1 = new studentt();

            s1.accept();
            s1.display();


            studentt s2 = new studentt();

            s2.accept();
            s1.display();


            //int x = 10;

            /*studentt s1 = new studentt();
            s1.name = "sid";
            s1.percentage = 87;
            s1.passoutyear = 2022;
            s1.branch = "Mech";
            s1.technicalskill = "C Sharp";


            studentt s2 = new studentt();
           /* s2.name = "Sami";
            s2.percentage = 97;
            s2.passoutyear = 2022;
            s2.branch = "Mechanical";
            s2.technicalskill = "Java";*/


            Console.WriteLine();
        }
    }
    class Books
    {
        string book_name;     // Theory of Machine
        string book1_Authorname;  //S. S. Rattan
        double book1_price;       //292.00



        public void accept()
        {
            Console.WriteLine("Enter book_name");
            book_name = Console.ReadLine();
            Console.WriteLine("Enter any 3 books Authorname");
            book1_Authorname = Console.ReadLine();

            Console.WriteLine("Enter 3 books price");
            book1_price = double.Parse(Console.ReadLine());


        }
        public void display()
        {
            Console.WriteLine("book_name" + book_name);
            Console.WriteLine("book_Authorname1" + book1_Authorname);

            Console.WriteLine("book1_price" + book1_price);

        }
    }
    class calll
    {
        static void Main(string[] args)
        {
            Books s1 = new Books();
            s1.accept();
            s1.display();

            Books s2 = new Books();
            s2.accept();
            s2.display();

            Books s3 = new Books();
            s3.accept();
            s3.display();


        }
    }
    class calculater
    {
        int n1, n2;  //instance variable
        public void accept()
        {
            Console.WriteLine("Enter Two numbers");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
        }

        //void u are not going to return any value
        public void add()
        {
            int sum = n1 + n2;
            Console.WriteLine("sum = " + sum);
        }
        public int sub()
        {
            int sub = n1 - n2;
            return sub;
        }
        public float divide()
        {
            float r = n1 / n2;
            return r;

        }
    }
    class Caall
    {
        static void Main(string[] args)
        {

            calculater s1 = new calculater();
            s1.accept();
            s1.add();

            int s = s1.sub();
            Console.WriteLine("sub =" + s);
            float f = s1.divide();
            Console.WriteLine("divide =" + f);

        }
    }
    class DD
    {
        int a, b, fac = 1;
        public void accept()
        {
            Console.WriteLine("Enter number");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

        }

        public int fact()
        {
            // int fac = 1;
            for (int i = 1; i <= a; i++)
            {
                fac = fac * i;
            }
            return fac;
        }
        public bool iseven()
        {

            {
                if (b % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool isprime()
        {
            int count = 0;
            for (int i = 2; i <= b / 2; i++)
            {
                if (b % i == 0)
                {
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class AA
    {
        static void Main(string[] args)
        {
            DD s = new DD();
            s.accept();
            int i = s.fact();
            Console.WriteLine("Factorial " + i);

            bool b = s.iseven();
            Console.WriteLine("Even " + b);
            if (b == true)
                Console.WriteLine("Even");
            else
                Console.WriteLine("odd");

            bool c = s.isprime();
            Console.WriteLine("isprime " + c);
            if (c == true)
                Console.WriteLine("prime");
            else
                Console.WriteLine("Not prime");

        }
    }
    class bank
    {
        string Acc_holder_name;
        long Acc_No;
        string Acc_Type;
        int Acc_bal;

        public void access()
        {
            Console.WriteLine("Enter Acc holder name,Acc number,Acc Type,Acc bal");
            Acc_holder_name = Console.ReadLine();
            Acc_No = long.Parse(Console.ReadLine());
            Acc_Type = Console.ReadLine();
            Acc_bal = int.Parse(Console.ReadLine());

        }
        public void display()
        {
            Console.WriteLine("Acc Holder Name : " + Acc_holder_name);
            Console.WriteLine("Acc Number : " + Acc_No);
            Console.WriteLine("Acc Type : " + Acc_Type);
            Console.WriteLine("Acc bal :" + Acc_bal);

        }
        public void withdrow()
        {
            Console.WriteLine("Enter the withdrow Amount");
            int amt = int.Parse(Console.ReadLine());

            if (amt > Acc_bal)
            {
                Console.WriteLine("insufficient balnce");
            }
            else
            {
                Acc_bal = Acc_bal - amt;
                Console.WriteLine("withdrow Successful");
                Console.WriteLine("After withdrow");
                Console.WriteLine("your bal is : " + Acc_bal);
            }
        }
        public int checkebal()
        {
            return Acc_bal;
        }
        public int deposite()
        {
            Console.WriteLine("Enter deposite Amt");
            int amt = int.Parse(Console.ReadLine());

            Acc_bal = Acc_bal + amt;
            return amt;
        }
        public int Total()
        {
            return Acc_bal;
        }
        public void RD()
        {
            Console.WriteLine("Sir let me creat your RD account");
            string str = Console.ReadLine();
            int i = 0, s = 0;
            if (str == "yes")
            {
                Console.WriteLine("How much amount");
                i = int.Parse(Console.ReadLine());
                if (i > 5000)
                {
                    Console.WriteLine("How much month");
                    s = int.Parse(Console.ReadLine());
                    if (s > 6)
                    {
                        Console.WriteLine("thank you sir");
                        Console.WriteLine("You are successfully created RD Accounr\n" + "Your RD Amount is {0},in {1} month", i, s);

                    }
                    else
                    {
                        Console.WriteLine("Soory sir is no less than {0} month", s);
                    }
                }
                else
                {
                    Console.WriteLine("Soory sir is no less than {0} Amount", i);
                }
            }
            else
            {
                Console.WriteLine("Ok thank you sir,/n" + "Have a good day");
            }

        }

    }
    class Account
    {
        static void Main(string[] args)
        {
            //class_name object = new class_name
            bank ob = new bank();
            ob.access();
            ob.display();
            ob.withdrow();
            int c = ob.checkebal();
            //Console.WriteLine("Your acc ball : "+c);
            int d = ob.deposite();
            Console.WriteLine("Deposite Amt : " + d);
            int tb = ob.Total();
            Console.WriteLine("Total Amt : " + tb);
            ob.RD();

        }
    }
    class HDFCbank
    {
        int accid;
        string accnm;
        int bal;
        static float roi = 7.8f;

        //object require to call instance method
        public void m1()
        {
            int a = 90;
        }
        //static doesnt require object
        //classname.m2()
        static void m2()
        {

        }
        static void Main(string[] arg)
        {
            HDFCbank h1 = new HDFCbank();
            h1.m1();
            h1.accid = 900;
            HDFCbank.m2();

            Console.WriteLine(" Hello");
            Console.WriteLine(HDFCbank.roi);
        }
    }
    class Moviee
    {
        string moviename;
        int rating;
        //set value to moviename
        public void setMoviename(string nm)
        {
            moviename = nm;
        }
        public string getMoviename()
        {
            return moviename;

        }
        public void setRating(int r)
        {
            rating = r;
        }
        public int getRating()
        {
            return rating;
        }
    }
    class MTest
    {
        static void Main(string[] args)
        {
            Moviee m1 = new Moviee();
            m1.setMoviename("Ready");
            Console.WriteLine(m1.getMoviename());
        }
    }
    class restaurant
    {

        string restaurantname;
        string area;
        long mobilename;
        int rating;

        public void setRestaurntName(string nm)
        {
            restaurantname = nm;

        }
        public string getRestaurntName()
        {
            return restaurantname;
        }
        public void setRating(int r)
        {
            this.rating = r;
        }
        public int getrating()
        {
            return rating;
        }
        public string RestaurantName //property
        {
            set { restaurantname = value; }
            get { return restaurantname; }
        } 
        public string Area
        {
            set { this.Area = value; }
            get { return area; }

        }
        public long Rating
        {
            set { this.Rating = value; }
            get { return rating; }
        }



    }
    class RTest
    {
        static void Main(string[] args)
        {


            restaurant r1 = new restaurant();
            /*  r1.setRestaurntName("Kalinga");
             *  r1.setRating(4);
             *  string n = r1.getRestaurantName();*/
            Console.WriteLine("enter hotel name");
            r1.RestaurantName = Console.ReadLine();
            Console.WriteLine(r1.RestaurantName);

            restaurant r = new restaurant();
            r.RestaurantName = "sid";
            Console.WriteLine(r.getRestaurntName);

            r.Area = "solapur";
            Console.WriteLine();



        }


    }


    //--------------15/6/22--------------
    class P
    {
        int id = 101;
        string nm = "sid";

        public int Id { get => id; set => id = value; }
        public string Nm { get => nm; set => nm = value; }

        

        public void m1()
        {
            Console.WriteLine("in parent m1");
        }
    }
   class Child : P
    {
        public void m2()
        {
            Console.WriteLine("in child m2 ");
        }
    }
    class grandChild : Child
    {
        public void m3()
        {
            Console.WriteLine("grand child");
        }
    }

    class inherit
    {
        static void Main(string[] args)
        {
            grandChild c = new grandChild();
            c.m1();
            c.m2();
            c.m3();
            Console.WriteLine(c.Id);
            Console.WriteLine(c.Nm);
            Console.WriteLine();
        }
    }

    class Teacher
    {
        string tname;
       
        int experience;
        public Teacher()
        {
            Console.WriteLine("in teacher constructor");
        }
        public Teacher(string tname, int experience)
        {
            this.tname = tname;
           
            this.experience = experience;
        }

        public string Tname { get => Tname; set => Tname = value; }
       
        public int Experience { get => experience; set => experience = value; }

    }

    //Relationship is
    class VisitingTeacher:Teacher
    {
        int hrs, rates;

        public VisitingTeacher(string nm, int exp, int hrs, int r):base(nm,exp)
        {
            Console.WriteLine("in visiting tracher constructor");
            this.hrs = hrs;
            this.rates = r;
        }
    }
    class Pen
    {
        string brand;
        int cost;
        string color;

        public Pen(string brand, int cost, string color)
        {
            this.Brand = brand;
            this.Cost = cost;
            this.Color = color;
        }
        public Pen()
        {

        }
        public void write()
        {

        }

        public string Brand { get => brand; set => brand = value; }
        public int Cost { get => cost; set => cost = value; }
        public string Color { get => color; set => color = value; }


    }
    class CompassBox
    {
        string compass_brand;
        int price;
        Pen pen;

        static void Main(string[] args)
        {
            CompassBox box = new CompassBox();
            box.compass_brand = "asara";
            box.price = 200;

            box.pen = new Pen();
            box.pen.Brand = "Trimax";
            box.pen.Color = "red";
            box.pen.Cost = 60;

            box.pen.write();
        }
    }

    //-----------------------------16/6/22--------------------------------------------
    class parent  //permission authority
    {
        string name;

        public void play()
        {
            Console.WriteLine(("play on ground"));

        }
        public virtual void study()
        {
            Console.WriteLine("Read book");
        }
    }
    //polymorphism--one name but multiple form /we can perform a single action by different ways
    //overloading // compile time polymorphism /a function with an object during compile time
    //over riding // runtime polymorphism  /THE BASE USING DERIVED CLASSES WITH THE SAME NAME AND THE SAME PARAMETER.

    class child : parent
    {
        //method riding
        public override void study()
        {
            Console.WriteLine("Learn watching online videos");
        }
    }
    class TTest
    {
        static void Main(string[] args)
        {
            parent p = new parent();
            p.study();

            child c1 = new child();
            c1.study();

            parent p2 = new child();
            p2.study();
        }
    }
    //========================17/6/22==============================
    class pparent
    {
        string name;

        //instant method without virtual keyword
        public void play()
        {
            Console.WriteLine("play on a ground");
        }
        public virtual void study()
        {
            Console.WriteLine("Read book");
        }
        //method hiding
        public static void m1()
        {
            Console.WriteLine("in parent");
        }


    }
    class Cchild:pparent
    {
        //method hiding
        public static void m1()
        {
            Console.WriteLine("in child m1");
        }
        //To do method hiding we use new kyeword
        public new void play()
        {
            Console.WriteLine("play video games");
        }
        //method riding
        public override void study()
        {
            Console.WriteLine("learn watching online videos");
        }
    }
    class ss
    {
        static void Main(string[] args)
        {

        }
    }

    //============================================
    class pppp
    {
        public virtual void m1()
        {
            Console.WriteLine("in parent m1");
        }
    }
    class cc : pppp
    {
        public sealed override void m1()
        {
            Console.WriteLine("in cc m1");
        }
    }
    class cc1 : pppp  //cc1 : cc then error bec sealed kyeword used
    {
        public override void m1() //cc1.m1():cannot override inherited member cc.m1() beacuse it is sealed
        {
            Console.WriteLine("in child cc1");
        }
    }
    class mm
    {
        static void Main(string[] args)
        {
            pppp ob = new cc1();
            ob.m1();
        }
    }
    //===========================
    class student
    {
        int num;
        string name;
        int percent;

        public student(int num, string name, int percent)
        {
            this.num = num;
            this.name = name;
            this.percent = percent;
        }
        public override string ToString()
        {
            //return "Num:" + num + "Name:" + name +"Percent:" + percent
            return $"Num:{num} Name:{name} Percentage:{percent}";
        }
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);
            student s1 = new student(1, "sid", 90);

            Console.WriteLine(s1);
            Console.WriteLine(s1.percent);//internally it tries to call toString()
        }
    }

    //abstract class Teacherr
    //{
    //    string name;
    //    int expert;

        

    //    public Teacherr(string name, int exper)
    //    {
    //        this.Name = name;
    //        this.Expert = Expert;
    //    }

    //    public Teacherr()
    //    {

    //    }
    //    public void m3()
    //    {

    //    }
    //    abstract public void CalculateSalary();
    //    //abstract public void m2();

    //    public string Name { get => name; set => name = value; }
    //    public int Expert { get => expert; set => expert = value; }
    //}
    //class PermanentTeacher : Teacher
    //{
    //    int salary;
    //    public PermanentTeacher():base()
    //    {

    //    }
    //    public override void CalculateSalary()
    //    {
    //        Console.WriteLine("Salalry"+salary);
    //    }
    //}
    //class VisitingTeacherr:Teacherr
    //{
    //    int hrs, rate;
    //    public override void CalculateSalary()
    //    {
    //        Console.WriteLine("Salary = "+hrs*rate);
    //    }
    //}
    //class TTT
    //{
    //    static void Main(string[] args)
    //    {
    //        Teacherr t = new ParmanentTeacher();
    //        t.CalculateSalary();
    //    }

    //}

    class xx
    {
        static void Main(string[] args)
        {
            
        }
    }



 







}