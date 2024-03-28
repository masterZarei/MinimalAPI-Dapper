namespace DataAccess.DBAccess;

public interface ISqlDataAccess
{
    Task<IEnumerable<T>> LoadData<T, U>(string storedProc, U parameteres, string connectionId = "Default");
    Task SaveData<T>(string storedProc, T parameteres, string connectionId = "Default");
}