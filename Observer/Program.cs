using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Entities;
using Observer.Interface;

namespace Observer
{
    class Program
    {
        public static void Main(string[] args)
        {
            IObserable a = new ObserA();
            IObserable b = new ObserB();
            IObserable c = new ObserC();
            WeatherData wd = new WeatherData(new List<IObserable>() {a,b,c});
            wd.SetFiled("111", "111", "111");
            wd.SetFiled("222", "222", "222");
            wd.SetFiled("333", "333", "333");
            Console.ReadKey();
        }
    }
}
