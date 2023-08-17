namespace HomeTask_26_C24.N24_HT1;

public interface IUserCredentialService
{
    UserCredential Add(Guid userId, string userPassword);
    UserCredential? GetById(Guid id);
}