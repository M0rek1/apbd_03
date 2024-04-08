using System;

namespace LegacyApp
{
    public class UserService
    {
        
        
        
        public bool AddUser(string firstName, string lastName, string email, DateTime dateOfBirth, int clientId)
        {
            var now = DateTime.Now;
            int age = now.Year - dateOfBirth.Year;
            var clientRepository = new ClientRepository();
            var client = clientRepository.GetById(clientId);
            var user = new User
            {
                Client = client,
                DateOfBirth = dateOfBirth,
                EmailAddress = email,
                FirstName = firstName,
                LastName = lastName
            };








            clientChecker.checkclient(client, user);
            UserDataAccess.AddUser(user);
            return name_checker.checkname(firstName, lastName) && emailchecker.checkemail(email) && dateCheck.checkdate(dateOfBirth, now, age)  && creditlimitChecker.checkcreditlimit(user);
            
        }
    }
}
