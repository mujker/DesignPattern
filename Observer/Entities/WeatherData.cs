using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Interface;

namespace Observer.Entities
{
    public class WeatherData : IWeatherable
    {
        private string str1 = "1";
        private string str2 = "2";
        private string str3 = "3";

        private List<IObserable> _obserables;

        public WeatherData(List<IObserable> obserables)
        {
            _obserables = obserables;
        }

        public void AddObser(IObserable obser)
        {
            _obserables.Add(obser);
        }

        public void RemoveObser(IObserable obser)
        {
            _obserables.Remove(obser);
        }

        public void NotifyObser(IObserable obser)
        {
            obser.Update(str1,str2,str3);
        }

        public void NotifyObser()
        {
            foreach (IObserable obserable in _obserables)
            {
                obserable.Update(str1, str2, str3);
            }
        }

        public void SetFiled(string s1, string s2, string s3)
        {
            str1 = s1;
            str2 = s2;
            str3 = s3;
            NotifyObser();
        }
    }
}