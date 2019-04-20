using CRM.REST.Models;
using System.Collections.Generic;

namespace CRM.REST.Services
{
    public class UserService
    {
        List<UserModel> userList;
        static UserService userService = null;

        public UserService()
        {
            userList = new List<UserModel>();
        }

        public static UserService GetInstance()
        {
            if (userService == null)
            {
                userService = new UserService();
                return userService;
            }
            else
            {
                return userService;
            }
        }

        public List<UserModel> GetAll()
        {
            return userList;
        }

        public string Add(UserModel user)
        {
            userList.Add(user);
            return "Add successful";
        }

        public string Update(UserModel model)
        {
            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].Id.Equals(model.Id))
                {
                    userList[i] = model;
                    return "Update successful";
                }
            }
            return "Update un-successful; Id not found";
        }

        public string Delete(string id)
        {
            for (int i = 0; i < userList.Count; i++)
            {
                UserModel user = userList[i];
                if (user.Id.Equals(id))
                {
                    userList.RemoveAt(i);
                    return "Delete successful";
                }
            }
            return "Delete un-successful; Id not found";
        }
    }
}