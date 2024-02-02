using App.Application.Contracts;
using App.Application.Services;
using App.Models.Models;
using System;
using System.Text.RegularExpressions;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public bool DetermineUserRole(string selectedRole)
    {
        return selectedRole == "Admin";
    }

    public void Add(User user)
    {
        ValidateInputs(user.Username, user.Email, user.Password, user.ConfirmPassword, user.PhoneNumber, user.Role.ToString());

        bool parsedRole = ParseRoleString(user.Role.ToString());

        var newUser = new User
        {
            Username = user.Username,
            Email = user.Email,
            Password = user.Password,
            ConfirmPassword=user.ConfirmPassword,
            PhoneNumber = user.PhoneNumber,
            Role = parsedRole,
            Address = user.Address,
            FirstName = user.FirstName,
            LastName = user.LastName,
            RegistrationDate = DateTime.Now,
            
        };

        _userRepository.Add(newUser);
    }

    private bool ParseRoleString(string roleString)
    {
        if (!bool.TryParse(roleString, out bool parsedRole))
        {
            throw new Exception("Invalid user role specified.");
        }

        return parsedRole;
    }

    private void ValidateInputs(string userName, string email, string password,string confirmPassword, string phoneNumber, string selectedRole)
    {
        if (string.IsNullOrWhiteSpace(userName) || userName.Length < 4)
        {
            throw new Exception("Username must be more than 3 characters and cannot be empty or contain only spaces.");
        }

        if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@gmail\.com$", RegexOptions.IgnoreCase))
        {
            throw new Exception("Invalid email format. Please use a Gmail address.");
        }

        if (password != confirmPassword)
        {
            throw new Exception("Password and Confirm Password do not match.");
        }

        if (!Regex.IsMatch(phoneNumber, @"^01[0-9]{9}$"))
        {
            throw new Exception("Invalid phone number format. Please use a valid Egyptian phone number.");
        }
    }

    public User AddUser(string userName, string email, string password, string confirmPassword, string phoneNumber, string selectedRole)
    {
        ValidateInputs(userName, email, password, confirmPassword, phoneNumber, selectedRole);

        bool isAdmin = DetermineUserRole(selectedRole);

        var newUser = new User
        {
            Username = userName,
            Email = email,
            Password = password,
            ConfirmPassword = confirmPassword,
            PhoneNumber = phoneNumber,
            Role = isAdmin,
            RegistrationDate = DateTime.Now
        };

        return newUser;
    }


}
