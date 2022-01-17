namespace api_prueba_net_core.Controllers
{
    public class ModelResponse<T>
    {
        public ModelResponse(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
    }
}
