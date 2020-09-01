using System;
using System.Collections.Generic;
namespace RockwellCS
{
    public class UsersLibrary
    {
        public List<UserModel> users;
        public UsersLibrary()
        {
            users = new List<UserModel>();
            populateUsersDb();
        }


        public void populateUsersDb()
        {
            UserModel moy = new UserModel();
            moy.username = "moym";
            moy.password = "password123";
            moy.Name = "Luis";

            UserModel esi = new UserModel();
            esi.username = "esig";
            esi.password = "password123";
            esi.Name = "Esequiel";

            UserModel david = new UserModel();
            david.username = "davidm";
            david.password = "password123";
            david.Name = "David";

            users.Add(moy);
            users.Add(esi);
            users.Add(david);
        }
    }
}
