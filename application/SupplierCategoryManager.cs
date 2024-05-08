using application.Contracts;
using AutoMapper;
using domain.Dtos;
using domain.Models;
using infrastructure.Contracts;

namespace application
{
    public class SupplierCategoryManager : ISupplierCategoryService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public SupplierCategoryManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task CreateSupplierCategoryAsync(SupplierCategoryDto supplierCategoryDto)
        {
            _repositoryManager.SupplierCategoryRepository.Create(_mapper.Map<SupplierCategory>(supplierCategoryDto));
            await _repositoryManager.SaveAsync();
        }

        public async Task DeleteSupplierCategoryAsync(int id, bool trackChanges)
        {
            var supplierCategory = await GetSupplierCategoryByIdAndCheckExists(id, trackChanges);
            _repositoryManager.SupplierCategoryRepository.Delete(supplierCategory);
            await _repositoryManager.SaveAsync();
        }

        public async Task<IEnumerable<SupplierCategoryDto>> GetAllSupplierCategoryAsync(bool trackChanges)
        {
            return _mapper.Map<IEnumerable<SupplierCategoryDto>>(await _repositoryManager.SupplierCategoryRepository.FindAllAsync(trackChanges));
        }

        public async Task<SupplierCategoryDto> GetSupplierCategoryByIdAsync(int id, bool trackChanges)
        {
            var supplierCategory = await GetSupplierCategoryByIdAndCheckExists(id, trackChanges);
            return _mapper.Map<SupplierCategoryDto>(supplierCategory);
        }

        public async Task UpdateSupplierCategoryAsync(SupplierCategoryDto supplierCategoryDto)
        {
            _repositoryManager.SupplierCategoryRepository.Update(_mapper.Map<SupplierCategory>(supplierCategoryDto));
            await _repositoryManager.SaveAsync();
        }

        private async Task<SupplierCategory> GetSupplierCategoryByIdAndCheckExists(int id, bool trackChanges)
        {
            var entity = await _repositoryManager.SupplierCategoryRepository.FindByCondititonAsync(s => s.SupplierCategoryId.Equals(id), trackChanges);
            if (entity == null)
                throw new Exception();
            return entity;
        }
    }
}
