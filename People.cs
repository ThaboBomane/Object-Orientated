using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Orientated
{
    class People
    {
        public string name;
        public string race;
        public string gender;
        public int age;

        public People(string PersonName, string PersonGender, string PersonRace, int PersonAge)
        {

            name = PersonName;
            age = PersonAge;
            gender = PersonGender;
            race = PersonRace;
        }

    }
}
