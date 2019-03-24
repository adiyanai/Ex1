//Adi Yanai 209009349
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        //list of the mission's functions
        private List<Func<double, double>> functions = new List<Func<double, double>>();
        private string missionName;

        public string Type { get; private set; } = "Composed";
        public event EventHandler<double> OnCalculate;

        //constructor
        public ComposedMission(string name)
        {
            missionName = name;
        }

        public string Name
        {
            get { return missionName; }
            private set { missionName = value; }

        }

        //add a function to the list of functions
        public ComposedMission Add(Func<double, double> function)
        {
            functions.Add(function);
            return this;
        }

        //calculates the concatenation of all the functions in the list
        public double Calculate(double value)
        {
            double result = value;
            //go over all the functions
            foreach (var func in functions)
            {
                //update the result after using the corrent function
                result = func(result);
            }
            //if there are an events, invoke
            OnCalculate?.Invoke(this, result);
            return result;
        }
    }
}