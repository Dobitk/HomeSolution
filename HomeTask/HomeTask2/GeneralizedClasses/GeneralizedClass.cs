using System;
using HomeTask2.UserClasses;

namespace HomeTask2.GeneralizedClasses
{
    class GeneralizedClass<T, R>  where R:UserType
    {
        private T _Boss;
        private R _User;
        public GeneralizedClass(T boss, R user)
        {
            this._Boss = boss;
            this._User = user;

        }

        public string Generic()
        {
            return _User._Name;
        }
    }
}
