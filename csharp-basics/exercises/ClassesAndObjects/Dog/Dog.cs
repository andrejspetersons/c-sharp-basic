using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    enum Sex
    {
        male,
        female
    }

    internal class Dog
    {
        public string name { get; private set; }
        public Sex sex { get; private set; }
        public Dog Mother { get; private set; }
        public Dog Father { get; private set; }

        public Dog(string name,Sex sex)
        {
            this.name = name;
            this.sex = sex;
        }

        public Dog(string name,Sex sex,Dog mother,Dog father)
        {
            this.name = name;
            this.sex = sex;
            Mother = mother;
            Father = father;
        }

        public string fathersName()
        {
            return Father == null ? "Unknown" : Father.name;
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            return Mother.name == otherDog.Mother.name;
        }
    }
}
