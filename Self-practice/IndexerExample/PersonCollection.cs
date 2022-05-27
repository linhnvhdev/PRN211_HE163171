using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IndexerExample
{
    internal class PersonCollection
    {
        private ArrayList _arPeople = new ArrayList();

        public Person this[int index]
        {
            get => (Person)_arPeople[index];
            set => _arPeople.Insert(index, value);
        }

        public int Count => _arPeople.Count;
    }
}
