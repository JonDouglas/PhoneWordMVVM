using Cirrious.MvvmCross.Community.Plugins.Sqlite;

namespace PhoneWordMVVM.Core.Services.Data
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
