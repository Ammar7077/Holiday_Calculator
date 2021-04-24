using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Parents
    {
        private string name;
        private int age;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public Parents(string pName,int pAge)
        {
            name = pName;
            age = pAge;
        }
        //-----------
        public string printName()
        {
            return("Parent name is: "+this.Name);
        }
        /*
        string getName()
        {
            return name;
        }
        void setAge(int newAge)
        {
            age = (newAge>0)?newAge:-1;
        }
        int getAge()
        {
            return age;
        }
        */

    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Parents pa1=new Parents("Ammar",21);
            Parents pa2 = new Parents("Kayed", 20);
            // print
            Console.WriteLine($"Parent1 name is: {pa1.Name} ");
            Console.WriteLine($"Parent1 age is: {pa1.Age} ");
            //
            Console.WriteLine($"Parent2 name is: {pa2.Name} ");
            Console.WriteLine($"Parent2 age is: {pa2.Age} ");
            //----
            pa1.Name="Omari";
            pa2.Name = "Obeidat";
            // Changed Names and Same Ages
            //----
            //print name using function
            Console.WriteLine(pa1.printName());
            Console.WriteLine(pa2.printName());
            // ----------
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignInForm());
        }
    }
}
