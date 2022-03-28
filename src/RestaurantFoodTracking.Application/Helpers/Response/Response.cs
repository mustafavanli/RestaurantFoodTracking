namespace RestaurantFoodTracking.Application.Helpers
{
    public class Response<T>
    {
        public T Data { get; private set; }
        public bool IsSuccess { get; private set; }
        public List<string> Errors { get; set; }

        public static Response<T> Success(T data)
        {
            return new Response<T>
            {
                Data = data,
                IsSuccess = true
            };

        }
        public static Response<T> Success(T data,List<string> errors)
        {
            return new Response<T>
            {
                Data = data,
                IsSuccess = true,
                Errors = errors
            };

        }
        public static Response<T> Success(List<string> errors)
        {
            return new Response<T>
            {
                Data = default(T),
                IsSuccess = true,
                Errors = errors
            };

        }
        public static Response<T> Success()
        {
            return new Response<T>
            {
                Data = default(T),
                IsSuccess = true
            };
        }


        public static Response<T> Fail(List<string> errors)
        {
            return new Response<T>
            {
                Errors = errors,
                IsSuccess = false
            };

        }
        public static Response<T> Fail(string error)
        {
            return new Response<T>
            {
                Errors = new List<string> { error },
                IsSuccess = false
            };
        }


        public static Response<T> Exception()
        {
            return new Response<T>
            {
                Errors = new List<string> { $"Catch exception {typeof(T).Name}"},
                IsSuccess = false
            };
        }
    }
}
