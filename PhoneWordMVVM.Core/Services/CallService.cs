using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneWordMVVM.Core.Services.Data;

namespace PhoneWordMVVM.Core.Services
{
    public class CallService : ICallService
    {
        private readonly IRepository _repository;

        public CallService(IRepository repository)
        {
            _repository = repository;
        }

        public List<Call> All()
        {
            return _repository.All();
        }

        public void Add(Call item)
        {
            _repository.Add(item);
        }
    }
}
