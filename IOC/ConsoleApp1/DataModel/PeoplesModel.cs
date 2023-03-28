using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataModelModel
{
    public class PeoplesModel
    {
        public List<People> Peoples { get; set; }

        public PeoplesModel()
        {
            Peoples = new List<People>();
        }

        public void AddPeople(People people)
        {
            var number = Peoples.Count;

            Peoples.Add(new People() { Name = people.Name, Sex = people.Sex, Number = number + 1 });
        }
    }

    public class People
    {
        public string Name { get; set; }

        public int Sex { get; set; }

        public int Number { get; set; }

        public static People ConverterTo(string name, int sex)
        {
            return new People() { Name = name, Sex = sex };
        }
    }
}
