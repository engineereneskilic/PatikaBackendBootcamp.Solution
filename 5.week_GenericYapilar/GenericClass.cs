using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.week_GenericYapilar
{
    public class GenericClass<T>
    {
        private T _field;

        public GenericClass(T value)
        {
            _field = value;
        }

        public T GetValue()
        {
            return _field;
        }

    }
}
