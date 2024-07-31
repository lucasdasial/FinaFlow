using Core.Models;
using Core.Requests.Categories;
using Core.Responses;

namespace Core.Handlers;

interface ICategoryHandler
{

    Task<Response<CategoryModel?>> CreateAsync(CreateCategoryRequest req);
    Task<Response<CategoryModel?>> DeleteAsync(DeleteCategoryRequest req);
    Task<Response<CategoryModel?>> UpdateAsync(UpdateCategoryRequest req);
    Task<Response<CategoryModel?>> GetByIdAsync(GetCategoryByIdRequest req);
    Task<PagedResponse<List<CategoryModel>?>> GetAllAsync(GetAllCategoryRequest req);
}