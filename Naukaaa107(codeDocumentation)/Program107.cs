var user = new User(1, "Mike", "applepie123"); // shows info about method with intellisense
user.Name = "John"; // can change because of set;
//user.Id = 3; // cannot change because it is readonly - no set
var userInfo = user.GetUserInfo(user, "pieapple2");
Console.WriteLine(userInfo);

class User
{
    public int Id { get; }
    public string Name { get; set; }
    public string Password { get; private set; }

    public User(int id, string name, string password)
    {
        Id = id;
        Name = name;
        Password = password;
    }

    /// <summary>
    /// Get information about current user.
    /// </summary>
    /// <param name="user">Target user</param>
    /// <returns>String with user data</returns>
    public string GetUserInfo(User user, string password)
    {
        Password = password; // can change it in the method, because of private set
        //Id = 5; // cannot
        return $"{user.Id} {user.Name} {user.Password}";
    }
}

