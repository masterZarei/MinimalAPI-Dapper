using DataAccess.DBAccess;
using DataAccess.Models;

namespace DataAccess.Data;
public class UserData : IUserData
{
    private readonly ISqlDataAccess _db;

    public UserData(ISqlDataAccess db)
    {
        _db = db;
    }
    public Task<IEnumerable<UserModel>> GetUsers() =>
        _db.LoadData<UserModel, dynamic>("dbo.spUser_GetAll", new { });

    public async Task<UserModel?> GetUser(int id)
    {
        return (await _db.LoadData<UserModel, dynamic>(
                storedProc: "dbo.spUser_Get",
                new { Id = id })).FirstOrDefault();
    }
    public Task InsertUser(UserModel User) =>
        _db.SaveData("dbo.spUser_Insert", new { User.FirstName, User.LastName });

    public Task UpdateUser(UserModel user) =>
        _db.SaveData("dbo.spUser_Update", user);

    public Task DeleteUser(int id) =>
        _db.SaveData("dbo.spUser_Delete", new { Id = id });
}
