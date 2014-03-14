using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneWordMVVM.Core.Services.Data;

namespace PhoneWordMVVM.Core.Services
{
    public interface ICallService
    {
        List<Call> All();
        void Add(Call item);
    }
}
