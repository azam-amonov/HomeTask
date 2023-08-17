namespace HomeTask_26_C24.N24_HT1.Service;

public class UserService : IUserService
{
    private List<User> _users;
    public UserService() => _users = new List<User>();
    public List<User> Get(int pageSize, int pageToken)
    {
        return _users.Where(user => !user.IsDeleted).Skip((pageToken - 1) * pageSize).Take(pageSize).ToList();
    }

    public List<User> GetAllData() => _users;

    public List<User> Filter(UserFilterModel userFilter)
    {
        return _users.Where(u => !u.IsDeleted
                                 && (userFilter.FirstName is not null || userFilter.FirstName.Equals(u.FirstName))
                                 && (userFilter.LastName is not null || userFilter.LastName.Equals(u.LastName)))
                        .Skip((userFilter.PageToken - 1) * userFilter.PageSize)
                        .Take(userFilter.PageSize)
                        .ToList();

    }

    public List<User> Search(string searchKeyWord, int pageSize, int pageToken)
    {
        return _users.Where(u => !u.IsDeleted
                                 && u.FirstName.Contains(searchKeyWord, StringComparison.OrdinalIgnoreCase)
                                 || u.LastName.Contains(searchKeyWord, StringComparison.OrdinalIgnoreCase)
                                 || u.EmailAddress.Contains(searchKeyWord, StringComparison.OrdinalIgnoreCase)
                            ).Skip((pageToken - 1) * pageSize).Take(pageSize).ToList();

    }

    public User Add(string firstName, string lastName, string emailAddress)
    {
        if (!(_users.Any(u => u.EmailAddress == emailAddress)))
        {
            var user = new User(firstName, lastName, emailAddress);
            _users.Add(user);
            return user;
        }
        throw new Exception("This email address is already in use!");
    }

    public User Update(User user)
    {
        if (_users.Any(u => u.UserId == user.UserId))
        {
            var userToUpdate = _users.Find(u => u.UserId == user.UserId);
            userToUpdate.FirstName = user.FirstName;
            userToUpdate.LastName = user.LastName;
            userToUpdate.EmailAddress = user.EmailAddress;
            return userToUpdate;
        }
        throw new Exception("User not found!");
    }

    public bool Delete(Guid id)
    {
        if (_users.Any(u => u.UserId == id))
        {
            var userToDelete = _users.Find(u => u.UserId == id);
            userToDelete.IsDeleted = true;
            return true;
        }
        throw new Exception("User not found!");
    }
}