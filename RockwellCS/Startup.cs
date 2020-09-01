using System;
using System.Collections.Generic;
using System.Text;
using RockwellCS.UserInterface;
using RockwellCS.ObjectsLesson;
namespace RockwellCS
{
    class Startup
    {
        UsersLibrary _userDb;
        bool _run;
        bool _userAuth;
        UserModel _User;
        ContainerController _containerController;

        public Startup()
        {
            _userDb = new UsersLibrary();
            _run = true;
            _userAuth = false;
            _containerController = new ContainerController();

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

                int choice = -1000;
                switch (action) 
                {
                    case 0:
                        _userAuth = false;
                        break;
                    case 1:
                        choice = UI.ObjectLessonMenu();
                        ObjectLessonOptions(choice);
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
        private void ObjectLessonOptions(int i) 
        {

            if (i == 1)
            {
                var container = _containerController.CreateRandomContainer();
                Console.WriteLine("Container Created...");
                container.saymessage();
                Console.WriteLine($"I have a capacity of {container._Capacity}");
                Console.ReadLine();
            }
            else if (i == 2)
            {
                var container = _containerController.CreateRandomContainer();
                Console.WriteLine("Container Created...");
                container.saymessage();
                Console.WriteLine($"I have a capacity of {container._Capacity}");
                _containerController.AddContainerToList(container);
                Console.WriteLine("Container added to list");
                Console.ReadLine();
            }
            else if (i == 3) 
            {
                foreach (IContainer container in _containerController._containers) 
                {
                    int currentCOntainer = (_containerController._containers.IndexOf(container) + 1);
                    Console.WriteLine(String.Format("{0,0} {1,-10} | {2,-15}",currentCOntainer, $"Type: {container._ContainerType}", $"Capacity: {container._Capacity}"));
                }

                Console.ReadLine();
            }
        }
        

    }
}
