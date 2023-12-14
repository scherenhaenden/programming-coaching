namespace ProgrammingCoaching.SOLID.Data.Models;

public class ResponseModel<T>
{
    public ResponseModel(T data)
    {
        Data = data;
        Success = true;
    }
    
    
    public ResponseModel(T data, string message, bool success)
    {
        Data = data;
        Message = message;
        Success = success;
    }
    
    public ResponseModel(string message)
    {
        Message = message;
        Success = false;
    }
    
    public ResponseModel(Exception exception)
    {
        Exception = exception;
        Success = false;
        Message = exception.Message;
    }
    
    
    public T? Data { get; set; }
    public bool Success { get; private set; }
    public string? Message { get; set; }
    // ReSharper disable once UnusedAutoPropertyAccessor.Global
    public Exception? Exception { get; set; }
}