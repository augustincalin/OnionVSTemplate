using OnionTemplate.Core.Model;

namespace OnionTemplate.Core.Interfaces
{
    public interface IValueService
    {
        Task<Value> GetAValue(int id);
    }
}
