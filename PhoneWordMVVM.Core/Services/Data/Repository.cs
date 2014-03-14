using System.Collections.Generic;
using System.Linq;
using Cirrious.MvvmCross.Community.Plugins.Sqlite;

namespace PhoneWordMVVM.Core.Services.Data
{
    public class Repository : IRepository
    {
        private readonly ISQLiteConnection _connection;

        public Repository(ISQLiteConnectionFactory factory)
        {
            _connection = factory.Create("phoneword.sql");
            _connection.CreateTable<Call>();
        }

        public List<Call> All()
        {
            return _connection.Table<Call>().ToList();
        }

        public void Add(Call call)
        {
            _connection.Insert(call);
        }
    }
}
