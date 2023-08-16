namespace HomeTask_26_C24.N24_HT1;

public interface IUserService
{
    void Get(int pageSize, int pageToken);
    User Add(string firstName, string lastName, string emailAddress);
    List<User> Filter(UserFilterModel userFilterModel);
    List<User> Search(string searchKeyWord, int pageSize, int pageToken);
    User Update(User user);
    bool Delete(int id);
}