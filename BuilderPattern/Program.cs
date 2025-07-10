using BuilderPattern;

var user = new UserBuilder()
           .SetName("Jabrail")
           .SetAge(25)
           .SetEmail("jabrail@mail.com")
           .Build();

Console.WriteLine($"{user.Name}, {user.Age}, {user.Email}");

var query = new SqlQueryBuilder()
            .Select("Name, Age")
            .From("Users")
            .Where("IsActive = 1")
            .OrderBy("CreatedDate DESC")
            .Build();

Console.WriteLine(query);