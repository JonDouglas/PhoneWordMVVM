using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneWordMVVM.Core.Services
{
    public interface ICallService
    {
        List<Call> All();
        void Add(Call item);
    }
}
