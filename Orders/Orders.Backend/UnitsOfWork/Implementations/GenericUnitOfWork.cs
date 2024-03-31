using Orders.Backend.Repositories.Interfaces;
using Orders.Backend.UnitsOfWork.Interfaces;
using Orders.Shared.Responses;

namespace Orders.Backend.UnitsOfWork.Implementations
{
    public class GenericUnitOfWork<T> : IGenericUnitOfWork<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;

        public GenericUnitOfWork(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<ActionResponse<T>> AddAsync(T entity) => await _repository.AddAsync(entity);

        public async Task<ActionResponse<T>> DelteAsync(int id) => await _repository.DelteAsync(id);

        public async Task<ActionResponse<T>> GetAsync(int id) => await _repository.GetAsync(id);

        public async Task<ActionResponse<IEnumerable<T>>> GetAsync() => await _repository.GetAsync();

        public async Task<ActionResponse<T>> UpdateAsync(T entity) => await _repository.UpdateAsync(entity);
    }
}