using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public delegate void PersonEventHandler(object? sender, Person? per);
    public class PersonListX : PersonList
    {
        public event PersonEventHandler? Added;
        public event PersonEventHandler? Removed;
        public event PersonEventHandler? Modified;
        public event PersonEventHandler? Cleared;
        public override bool Add(Person per)
        {
            var result = base.Add(per);
            if (result == true) Added?.Invoke(this, per);
            return result;
        }
        public override bool Remove(Person per)
        {
            var result = base.Remove(per);
            if (result == true)
            {
                Added?.Invoke(this, per);
            }
            return result;
        }
        public override Person? Remove(int targetNo)
        {
            var result = base.Remove(targetNo);
            if (result != null) Removed?.Invoke(this, result);
            return result;
        }
        public override Person? Modify(int targetNo, string name, string gender, byte age)
        {
            var result = base.Modify(targetNo, name, gender, age);
            if (result != null) Modified?.Invoke(this, result);
            return result;
        }
        public override void Clear()
        {
            base.Clear();
            Cleared?.Invoke(this, null);
        }
        public Person? this[int key] => _pers.FirstOrDefault(x => x.No == key);
    }
}
