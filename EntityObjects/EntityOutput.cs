namespace service_generator.EntityObjects
{
    public class OutputResponse
    {
        public int Status { get; set; }
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
        public string? Data { get; set; }

        //public static OutputResponse<T> Success(T data) => new OutputResponse<T> { IsSuccess = true, Data = data };
        //public static OutputResponse<T> Failure(string error) => new OutputResponse<T> { IsSuccess = false, Message = error };
    }
}
