using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Technical_Test.Models.Repositories
{
    public class UserRepositories : ITechnicalTest<User>
    {
        List<User> Users;
        public UserRepositories()
        {
            Users = new List<User>()

            {
                new User
                {
                    User_Id = 1 ,FirstName= "Ababneh", LastName="Ahmad",Email="Ahmaddssvcs"
                }

            };
           
        }
        public void Signup(User User)
        {
            Users.Add(User);
        }

        public User Find(int Id)
        {
            var user = Users.SingleOrDefault(b => b.User_Id == Id);
            return (user);
        }

        public IList<User> List()
        {
            return Users;
        }
        
        
            public void Update(User UpUser, int ID)
        {
            var user = Find(ID);

            user.FirstName = UpUser.FirstName;
            user.LastName = UpUser.LastName;
            user.Email = UpUser.Email;
            user.Password = UpUser.Password;
        }

        public User Signin(User USer, int id)
        {
            var user = Find(1);
            if (user.Email == USer.Email & user.Password == USer.Password)
            { return USer; }
            else 
            {
                return user;
            }
        }

    }
}
