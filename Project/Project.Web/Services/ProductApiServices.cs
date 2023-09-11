using Project.Core.DTOs;

namespace Project.Web.Services
{
    public class ProductApiServices
    {
        private readonly HttpClient _httpClient;

        public ProductApiServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<ProductWithCategoryDto>> GetProductWithCategories()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<ProductWithCategoryDto>>>("product/GetProductWitCategory");
            return response.Data;
        }
        public async Task<ProductDto> Save(ProductDto product)
        {
            var response = await _httpClient.PostAsJsonAsync("product",product);
            if (!response.IsSuccessStatusCode) return null;

            var responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDto<ProductDto>>();
            return responseBody.Data;
        }

    }
}
