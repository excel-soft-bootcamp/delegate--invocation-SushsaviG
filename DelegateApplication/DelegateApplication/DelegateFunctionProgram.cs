using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApplication
{
    public class DelegateFunctionProgram
    {
        static double Calculate(int x, double y) { return x + y; }

        void Update(int newNumber) { System.Console.WriteLine(newNumber); }
        void Delete(string key) { }
        public void function() { }

        public void function2(string data)
        {

        } 
        
        public int function3(int data) { return data; }
        public bool function4(string data ,string _data)
        {
            return true;
        }
        public double Funnction5(int data, double _data)
        {
            return(data) ;
        }

        static void FunctionsAsAnArguments(Action obj, Action<string> obj2, Func<int, int> obj3, Func<string, string, bool> obj4, Func<int,double,double> obj5,Action<int>obj6)
        {
            obj.Invoke();
            obj2.Invoke("swathi");
            obj3.Invoke(45);
            obj4.Invoke("swa", "AAA");
            obj5.Invoke(34, 33);
            obj6.Invoke(77);





        }
    }
}