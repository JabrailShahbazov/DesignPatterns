using BuilderPattern;

var user = new UserBuilder()
           .SetName("Jabrail")
           .SetAge(25)
           .SetEmail("jabrail@mail.com")
           .Build();

Console.WriteLine($"{user.Name}, {user.Age}, {user.Email}");