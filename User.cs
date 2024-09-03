using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class User
    {
        private string _name;
        private string _password;

        public string Name { get { return _name; } }
        public string SaveString { get { return _name + ";" + _password; } }

        public User() { }
        public User(string name, string password)
        {
            _name = name;
            _password = password;
        }
        public User(string info)
        {
            string[] parts = info.Split(';');
            _name = parts[0];
            _password = parts[1];
        }

        public bool TryLogin(string name, string password)
        {
            if (name == _name && password == _password)
                return true;
            return false;
        }
    }
}
