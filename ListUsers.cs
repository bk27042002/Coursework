using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Coursework
{
    class ListUsers
    {
        List<User> _users = new List<User>();

        public ListUsers() { }

        public void Save()
        {
            using(StreamWriter streamWriter = new StreamWriter("../../Users.txt"))
            {
                foreach (User user in _users)
                    streamWriter.WriteLine(user.SaveString);
            }
        }

        public bool TryLogin(string name, string password)
        {
            foreach(User user in _users)
            {
                if(user.TryLogin(name, password))
                {
                    return true;
                }
            }
            return false;
        }

        public static void SaveNewUser(User user)
        {
            using(StreamWriter streamWriter = new StreamWriter("../../Users.txt", true))
            {
                streamWriter.WriteLine(user.SaveString);
            }
        }
        public void Load()
        {
            string info;
            using (StreamReader streamReader = new StreamReader("../../Users.txt"))
                info = streamReader.ReadToEnd().Replace("\r", "");

            List<string> parts = new List<string>(info.Split('\n'));
            parts.RemoveAt(parts.Count - 1);
            foreach (string part in parts)
                _users.Add(new User(part));
        }
        public User FindByName(string name)
        {
            foreach (User user in _users)
                if (user.Name == name)
                    return user;
            return null;
        }
    }
}
