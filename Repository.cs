using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    class Repository
    {
        public Repository()
        {
            this.People = new Dictionary<int, Person>();
            this.Count = 0;
        }
        public Dictionary<int,Person> People { get; private set; }
        public int Count { get; private set; }

        public void Add(Person person)
        {
            if (!this.People.ContainsValue(person))
            {
                People[Count] = person;
            }

            this.Count++;
        }

        public Person Get(int id)
        {
            //var result = People.Where(x => x.Key == id).ToDictionary(x=>x,y=>y);
            //(Person)result.Values.Select(x => x.Key == id);

            return this.People[id];
        }

        public bool Update(int id,Person newPerson)
        {
            if (this.People.ContainsKey(id))
            {
                this.People[id] = newPerson;

                return true;
            }

            return false;
        }

        public bool Delete(int id)
        {
            if (this.People.ContainsKey(id))
            {
                this.People.Remove(id);

                this.Count--;

                return true;
            }

            return false;
        }
    }
}
