namespace Orders.Frontend.Repositories
{
    public interface IRepository
    {
        Task<HttpResponseWrapper<T>> GetAsync<T>(string url);
        Task<HttpResponseWrapper<Object>> PostAsync<T>(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PostASync<T, TActionResponse>(string url, T model);
        Task<HttpResponseWrapper<Object>> DeleteAsync<T>(string url);
        Task<HttpResponseWrapper<Object>> PutAsync<T>(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PutASync<T, TActionResponse>(string url, T model);
    }
}
