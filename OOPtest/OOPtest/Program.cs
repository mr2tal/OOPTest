using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPtest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine(p1.ToString());
            p1.SetFullName("hans", "hansen");
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1.GetFullName());

            Person p2 = new Person("Jens", "Jensen", "tømrer", 40000.00, 93.21);
            Console.WriteLine(p2.ToString());
            p2.SetFullName("peter", "petersen");
            Console.WriteLine(p2.ToString());

            Person p3 = new Person("tom", "tomsen");
            p3.SetJob("programmør");
            Console.WriteLine(p3.ToString());
            Console.WriteLine(p3.GetFullName());
            
        }
    }

    class Person
    {
        //fields
        private string _fornavn;
        private string _efternavn;
        private string _job;
        private double _loen;
        private double _vaegt;

        //constructors
        public Person()
        {

        }
        public Person(string fnavn, string enavn)
        {
            Name = fnavn;
            Surname = enavn;
        }
        //this(fnavn, enavn) er en konstruktor der kalder en anden konstruktor  
        public Person(string fnavn, string enavn, string job, double loen, double vaegt) : this(fnavn, enavn)
        {
           // Name = fnavn;
           // Surname = enavn;
            SetJob(job);
            SetSalary(loen);
            SetWeight(vaegt);
        }

        //properties
        public string Name
        {
            get { return _fornavn; }
            set { _fornavn = value; }
        }
        public string Surname
        {
            get { return _efternavn; }
            set { _efternavn = value; }
        }

        //methods
        public string GetJob()
        {
            return _job;
        }
        public void SetJob(string j)
        {
            _job = j;
        }
        public double GetSalary()
        {
            return _loen;
        }
        public void SetSalary(double l)
        {
            _loen = l;
        }
        public double GetWeight()
        {
            return _vaegt;
        }
        public void SetWeight(double v)
        {
            _vaegt = v;
        }

        public void SetFullName(string fnavn, string enavn)
        {
            Name = fnavn;
            Surname = enavn;
        }
        public string GetFullName()
        {
            return string.Format("Fulde navn: {0} {1}", Name, Surname);
        }
        
        //override
        public override string ToString()
        {
            return string.Format("fornavn: {0}, efternavn: {1}, Job: {2}, løn: {3}, vægt: {4}", Name, Surname, GetJob(), GetSalary(), GetWeight());
        }

    }

    class Elev
    {
        //fields
        private string _name;
        private int _ID;
        
        //constructors
        public Elev()
        {

        }

        public Elev (string n, int i)
        {
            SetName(n);
            ID = i;
        }

        //override
        public override string ToString()
        {
            return string.Format("name: {0, -10} , ID: {1}", GetName(), ID);
        }
        //methods
        public string GetName()
        {
            return _name;
        }
        public void SetName(string n)
        {
            _name = n;
        }
        //property
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        
    } 
}
