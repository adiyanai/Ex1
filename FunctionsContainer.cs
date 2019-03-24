//Adi Yanai 209009349
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{

    public class FunctionsContainer
    {
        //a map of pairs of function's name and her function
        Dictionary<string, Func<double, double>> functionsMap = new Dictionary<string, Func<double, double>>();

        //override the [] operator
        public Func<double, double> this[string key]
        {
            get
            {
                // if the function exist in the functionsMap
                if (functionsMap.ContainsKey(key))
                {
                    return functionsMap[key];
                } 
                // else, return id function
                else
                {
                    //add the id function to the map
                    functionsMap.Add(key, val => val);
                    return val => val;
                }
               
            }
            set
            {
                functionsMap[key] = value;
            }

        }

        //return a list of all the keys in the function map (all the functions names)
        public List<string> getAllMissions()
        {
            return functionsMap.Keys.ToList();
        }
    }
}
