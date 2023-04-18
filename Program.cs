using System;
using System.Collections.Generic;


public class Program
{
    public static void Main(string[] args)
    {
        UserList userList = new UserList();
        userList.CreateUser("fullname1", "login1", "pass1", "group1", "23.04.2023", "18.04.2023", 0);
        userList.CreateUser("fullname2", "login2", "pass2", "group2", "23.04.2023", "18.04.2023", 1);

        List<User> users = userList.GetUsers();
        foreach (User user in users)
        {
            Console.WriteLine("Full name: " + user.FullName);
            Console.WriteLine("Login: " + user.Login);
            Console.WriteLine("Group: " + user.Group);
            Console.WriteLine("Last login: " + user.LastLogin);
            Console.WriteLine("Creation date: " + user.CreationDate);
            Console.WriteLine("Warnings: " + user.Warnings);
            Console.WriteLine();
        }
    }
}


public class User
{
    public string FullName { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Group { get; set; }
    public string LastLogin { get; set; }
    public string CreationDate { get; set; }
    public int Warnings { get; private set; }

    public User(string fullName, string login, string password, string group, string lastLogin, string creationDate, int warnings)
    {
        FullName = fullName;
        Login = login;
        Password = password;
        Group = group;
        LastLogin = lastLogin;
        CreationDate = creationDate;
        Warnings = warnings;
    }

    public void ChangeWarnings(int amount)
    {
        Warnings += amount;
    }
}

public class UserList
{
    private List<User> users;

    public UserList()
    {
        users = new List<User>();
    }
    
    public List<User> GetUsers()
    {
        return users;
    }

    public void CreateUser(string fullName, string login, string password, string group, string lastLogin, string creationDate, int warnings)
    {
        User user = new User(fullName, login, password, group, lastLogin, creationDate, warnings);
        users.Add(user);
    }

    public void RemoveUser(User user)
    {
        users.Remove(user);
    }
}