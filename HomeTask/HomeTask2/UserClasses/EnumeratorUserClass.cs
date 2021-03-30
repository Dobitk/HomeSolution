using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HomeTask2.UserClasses
{
    public class EnumeratorUserClass : IEnumerable, IEnumerator
    {
        List<int> _UserList = new List<int>();
        private int _prIndex = -1;


        public IEnumerator GetEnumerator()
        {
            return this;

        }

        public void AddUser(int s)
        {
                _UserList.Add(s);

        }


        public void RemoveUser(int item)
        {
            int _Count = _UserList.Count;
            if (_Count > 5)
            {
                _UserList.Remove(item);
                // return true;
            }
            else
            {
                // return false;
                Console.WriteLine("В коллекции осталос 5 элементов. Больше удалить нельзя ");
            }

        }



        public bool MoveNext()
        {
            if (_prIndex == _UserList.Count - 1)
            {
                Reset();
                return false;
            }

            _prIndex++;
            return true;
        }
        public void Reset()
        {
            _prIndex = -1;
        }

        public object Current
        {
            get
            {
                return _UserList[_prIndex];
            }
        }

 
  




    }
}
