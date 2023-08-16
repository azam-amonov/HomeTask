namespace HomeTask_26_C24.N24_HT1;

public interface IUserCredentialService
{
    void Add(int userId, string userPassword);
    User? GetById(int id);
}