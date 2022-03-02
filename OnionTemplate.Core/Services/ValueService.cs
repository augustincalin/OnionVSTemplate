using OnionTemplate.Core.Interfaces;
using OnionTemplate.Core.Model;

namespace OnionTemplate.Core.Services
{
    public class ValueService : IValueService
    {
        private readonly IRepository<Value> _valueRepository;

        public ValueService(IRepository<Value> valueRepository)
        {
            _valueRepository = valueRepository;
        }

        public async Task<Value> GetAValue(int id)
        {
            return await _valueRepository.GetAsync(id);
        }
    }
}
