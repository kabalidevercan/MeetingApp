using System.Linq.Expressions;

namespace MeetingApp.Models
{

    public class Repository
    {

        static Repository()
        {
            _users.Add(new UserInfo()
            {
                Id = 1,
                Name = "Ercan",
                Email = "abc@gmail.com",
                Phone = "123123",
                WillAttend = true
            });
            _users.Add(new UserInfo()
            {
                Id = 2,
                Name = "Selin",
                Email = "asdads@gmail.com",
                Phone = "334455",
                WillAttend = false
            });
            _users.Add(new UserInfo()
            {
                Id = 3,
                Name = "Mehmet",
                Email = "ask@gmail.com",
                Phone = "0000",
                WillAttend = true
            });

        }

        private static List<UserInfo> _users = new();



        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }

        public static void CreateUser(UserInfo userInfo)
        {

            userInfo.Id = Users.Count + 1;


            _users.Add(userInfo);
        }

        public static UserInfo? GetById(int id)
        {
            return Users.FirstOrDefault(user => user.Id == id);
        }

    }
}