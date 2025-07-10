namespace BuilderPattern;

public class UserBuilder
{
    private readonly User _user = new();

    public UserBuilder SetName(string name)
    {
        _user.Name = name;
        return this; // Chainable üçün geri qaytarır
    }

    public UserBuilder SetAge(int age)
    {
        _user.Age = age;
        return this;
    }

    public UserBuilder SetEmail(string email)
    {
        _user.Email = email;
        return this;
    }

    public User Build() => _user;
}