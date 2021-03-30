using System;

namespace HomeTask9.UserAttributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class UserAtt:Attribute
    {
        private readonly int att;
        private string v;

        private string positatt { get;}
        public UserAtt(int Att)
        {

            this.att = Att ;

        }

        public UserAtt(string v)
        {
            this.positatt = v;
        }
    }
}
