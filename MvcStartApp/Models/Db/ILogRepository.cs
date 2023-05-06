namespace MvcStartApp.Models.Db
{
    public interface ILogRepository
    {
        Task AddLog(Request request);

        Task<Request[]> GetLogs();
    }
}
