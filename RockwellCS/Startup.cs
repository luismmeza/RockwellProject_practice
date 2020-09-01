using System;
using System.Collections.Generic;
using System.Text;
using RockwellCS.UserInterface;

namespace RockwellCS
{
    class Startup
    {
        UsersLibrary _userDb;
        bool _run;
        bool _userAuth;
        UserModel _User;

        public Startup()
        {
            _userDb = new UsersLibrary();
            _run = true;
            _userAuth = false;

        }

        public void Start() 
        {
            if (_userAuth == false) 
            {
                UserModel activeUser = new UserModel();
                activeUser = UI.GetUserModel(activeUser);
                AuthorizeUser(activeUser);

            }
            while (_run == true && _userAuth == true) 
            {
                string answer = UI.GetMenuInput();
                int action = GetAction(answer);
                DisplayAction(action);
            }

            if (_run == false) 
            {
                Console.WriteLine($"Goodbye {_User.Name}");
            }
        }

        private int GetAction(string answer) 
        {
            int action = -1;
            try
            {
                action = Convert.ToInt32(answer);
                return action;
            }
            catch (Exception e) 
            {
                Console.WriteLine("There Was an error");
                Console.WriteLine("================ ERROR =================");
                Console.WriteLine(" ");
                Console.WriteLine(e);
                Console.WriteLine(" ");
                Console.WriteLine("============== END ERROR ===============");
                return action;
            }
        }
        private void DisplayAction(int action) 
        {
            if (action == -1)
            {
                //do nothing, and the Main Menu should reappear.
            }
            else if (action < -1) 
            {
                _run = false; // they used a number lower than -1;
            }
            else 
            {
                switch (action) 
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    default:
                        break;
                }
            }
        }
        private void AuthorizeUser(UserModel user) 
        {
            foreach (UserModel u in _userDb.users) 
            {
                if (u.username == user.username && u.password == user.password)
                {
                    _userAuth = true;
                    _User = u;
                    UI.SetMainMenuTitle(u);
                    break;
                }
            }
        }

    }
}
