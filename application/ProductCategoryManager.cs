using application.Contracts;
using AutoMapper;
using Bogus;
using domain.Dtos;
using domain.Models;
using domain.RequestFeatures;
using infrastructure.Contracts;

namespace application
{
    public class ProductCategoryManager : IProductCategoryService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public ProductCategoryManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task CreateProductCategoryAsync(ProductCategoryDto productCategoryDto)
        {
            _repositoryManager.ProductCategoryRepository.Create(_mapper.Map<ProductCategory>(productCategoryDto));
            await _repositoryManager.SaveAsync();
        }        

        public async Task DeleteProductCategoryAsync(int id, bool trackChanges)
        {
            var productCategory = await GetProductCategoryByIdAndCheckExists(id, trackChanges);
            _repositoryManager.ProductCategoryRepository.Delete(productCategory);
            await _repositoryManager.SaveAsync();
        }

        public async Task<IEnumerable<ProductCategoryDto>> GetAllProductCategoriesAsync(RequestParameters requestParameters, bool trackChanges)
        {
            return _mapper.Map<IEnumerable<ProductCategoryDto>>(await _repositoryManager.ProductCategoryRepository.GetAllProductCategoriesAsync(requestParameters, trackChanges));
        }

        public async Task<ProductCategoryDto> GetProductCategoryByIdAsync(int id, bool trackChanges)
        {
            var productCategory = await GetProductCategoryByIdAndCheckExists(id, trackChanges);
            return _mapper.Map<ProductCategoryDto>(productCategory);
        }

        public async Task UpdateProductCategoryAsync(ProductCategoryDto productCategoryDto)
        {
            _repositoryManager.ProductCategoryRepository.Update(_mapper.Map<ProductCategory>(productCategoryDto));
            await _repositoryManager.SaveAsync();
        }

        private async Task<ProductCategory> GetProductCategoryByIdAndCheckExists(int id, bool trackChanges)
        {
            var entity = await _repositoryManager.ProductCategoryRepository.GetProductCategoryByIdAsync(id, trackChanges);
            if (entity == null)
                throw new Exception();
            return entity;
        }
    }
}
