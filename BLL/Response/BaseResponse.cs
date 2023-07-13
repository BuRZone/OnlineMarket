namespace OnlineMarket.BLL.Response
{
    public class BaseResponse<T> : IBaseResponse<T>
    {
        public string Description { get; set; } 

        public StatusCode StatusCode { get; set; }

        public T Data { get; set; }
    }
    public interface IBaseResponse<T>
    {
        string Description { get; }
        StatusCode StatusCode { get; }
        T Data { get; }

    }
    public enum StatusCode
    {
        UserNotFound = 0,
        UserAlreadyExists = 1,

        CarNotFound = 10,

        OrderNotFound = 20,

        OK = 200,
        InternalServerError = 500
    }

}
