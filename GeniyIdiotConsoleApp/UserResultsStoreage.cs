using System;
using System.Collections.Generic;

namespace GeniyIdiotConsoleApp
{
    public class UserResultsStoreage
    {
        public static string Path = "UserResults.txt";
        public static void Append(User user)
        {
            var formattedData = user.Name + "$" + user.CounRightAnswers + "$" + user.Diagnose;
            FileProvider.Append(Path, formattedData);
        }

        public static List<User> GetAll()
        {
            var fileData = FileProvider.Get(Path);
            var lines = fileData.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            List<User> users = new List<User>();
            foreach (var line in lines)
            {
                var data = line.Split('$');
                var user = new User(data[0]);
                user.CounRightAnswers = Convert.ToInt32(data[1]);
                user.Diagnose= data[2];
                users.Add(user);
            }
            return users;
        }
    }
}
