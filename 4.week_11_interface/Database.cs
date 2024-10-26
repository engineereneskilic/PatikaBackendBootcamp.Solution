using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_11_interface
{
    public interface IDatabase
    {
        void Connect();

        void Disconnect();

        void ExecuteQuery(string query);
    }

    public interface ICache
    {
        void Store(string key, object data);
        object Retrieve(string key);
    }



    public class MsSQLDatabase : IDatabase, ICache
    {
        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public void ExecuteQuery(string query)
        {
            throw new NotImplementedException();
        }

        public object Retrieve(string key)
        {
            throw new NotImplementedException();
        }

        public void Store(string key, object data)
        {
            throw new NotImplementedException();
        }
    }

    public class MySQLDatabase : IDatabase
    {
        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public void ExecuteQuery(string query)
        {
            throw new NotImplementedException();
        }
    }


    public class SQLiteDatabase : IDatabase
    {
        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public void ExecuteQuery(string query)
        {
            throw new NotImplementedException();
        }
    }

    public class Database
    {



    }
}
