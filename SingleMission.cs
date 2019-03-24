//Adi Yanai 209009349
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        //the function of the mission
        private Func<double, double> funcMission;
        private string missionName;

        public string Type { get; private set; } = "Single";
        public event EventHandler<double> OnCalculate;

        //constructor
        public SingleMission(Func<double, double> func, string name)
        {
            funcMission = func;
            missionName = name;
        }

        public string Name
        {
            get {return missionName;}
            private set {missionName = value;}

        }

        //calculates the function with the input value
        public double Calculate(double value)
        {
            double result = funcMission(value);
            //if there are an events, invoke
            OnCalculate?.Invoke(this, result);
            return result;
        }
    }
}
