using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.week_GenericYapilar
{
    public class Stack<T>
    {
        private List<T> _elements = new List<T>();
        
        public void Push(T item)
        {
            _elements.Add(item);
        }

        public T Pop() // eleman çıkar
        {
            if(_elements.Count == 0)
            {
                throw new InvalidOperationException("stack boş");

            }

           T item =_elements[_elements.Count - 1]; // son elemanı al

           _elements.RemoveAt(_elements.Count -1);

            return item;
        }

        public T Peek() // en üstündeki eleman
        {
            if(_elements.Count == 0)
            {
                throw new InvalidOperationException("stack boş");
            }

            return _elements[_elements.Count - 1];
        }

        public bool IsEmpty()
        {
            return _elements.Count == 0;
        }

        

       


    }
}
