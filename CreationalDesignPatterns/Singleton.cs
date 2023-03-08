using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.CreationalDesignPatterns
{
    internal class Singleton
    {
        //make it class method
        private static Singleton _UniqueInstance;
        private Singleton()
        {

        }
        public static Singleton getInstance()
        {
            if(_UniqueInstance == null)
            {
                _UniqueInstance = new Singleton();
            }
            return _UniqueInstance;
        }
    }
}
