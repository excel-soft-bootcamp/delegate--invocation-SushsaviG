using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateFunctionProgram _delegate = new DelegateFunctionProgram();
            
            Action<int> Object1 = new Action<int>(Calculate);
            Action<string> Object2 = new Action<string>(_delegate.function2);
            Action object3 = new Action(_delegate.function);
            Func<int, double, double> Object4 = new Func<int, double, double>(_delegate.Funnction5);
            Func<int, int> Object5 = new Func<int, int>(_delegate.function3);
            Func<string, string, bool> Object6 = new Func<string, string, bool>(_delegate.function4);
            Func<int, double, double> Object7 = new Func<int, double, double>(_delegate.Funnction5);

            FunctionsAsAnArguments(Object1, Object2, object3, Object4, Object5, Object6, Object7);
        }
    }
}
