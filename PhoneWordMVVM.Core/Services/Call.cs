using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirrious.MvvmCross.Community.Plugins.Sqlite;

namespace PhoneWordMVVM.Core.Services
{
    public class Call
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return PhoneNumber;
        }
    }
}
