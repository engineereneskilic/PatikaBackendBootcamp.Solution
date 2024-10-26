using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_11_interface
{

    public interface IPrinttable
    {
        void Print();
    }

    public interface ISavable
    {
        void Save();
    }


    public class Document : IPrinttable, ISavable
    {
        public void Print()
        {
            
        }

        public void Save()
        {
            
        }
    }
}
