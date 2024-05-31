using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class PersonList
    {
        protected List<Person> _pers = new();
        public virtual bool Add(Person rect)
        {
            if (_pers.Any(x => x.No == rect.No)) return false;
            _pers.Add(rect);
            return true;
        }
        public virtual Person? Modify(int targetNo, string name, string gender, byte age)
        {
            var found = _pers.FirstOrDefault(x => x.No == targetNo);
            if (found != null)
            {
                found.Name = name;
                found.Gender = gender;
                found.Age = age;
            }
            return found;
        }
        public virtual Person? Remove(int targetNo)
                {
            var found = _pers.FirstOrDefault(x => x.No == targetNo);
            if (found != null)
            {
            if (_pers.Remove(found))
            return found;
            else
            return null;
            }
            return null;
            }
            public virtual bool Remove(Person per)
            {
                return _pers.Remove(per);
            }
            public virtual void Clear()
            {
                _pers.Clear();
            }
            public List<Person> People => _pers;
            public byte MaxAge => _pers.Max(x => x.Age);
            public int Count => _pers.Count;
            }
}
