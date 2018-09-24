using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FirstProgram
{
    class User
    {
        private string UserName { get; set; }
        private string Password { get; set; }
        public User(string name,string pass)
        {
            this.UserName = name;
            this.Password = pass;
        }
        public string GetName()
        {
            return this.UserName;
        }
        public string GetPassword()
        {
            return this.Password;
        }
    
    }

    class ValidateUser
    {
        public void Validate(User user)
        {
            StringBuilder sb = new StringBuilder();
            if (user.GetName().Length == 0)
            {
                sb.Append("Invalid Name!\n");
            }
            if (user.GetPassword().Length == 0)
            {
                sb.Append("Invalid Password!\n");
            }
            
            if (sb.Length > 0)
            {
                throw new Exception(sb.ToString());
            }
            
        }
    }

    class UsernameAlreadyTakenException : Exception
    {
        public UsernameAlreadyTakenException(string name):base(String.Format("Username already taken: {0}",name))
        {

        }
    }
    
    class LogIn
    {
        IList<User> users = new List<User>();
        ValidateUser valid = new ValidateUser();
        
        //System.IO.File.ReadAllLines(@"C:\Users\iuliathira\source\repos\FirstProgram\FirstProgram\Users.txt");
        string fileName = @"C:\Users\iuliathira\source\repos\FirstProgram\FirstProgram\Users.txt";
        public LogIn()
        {
            ReadFromFile();
        }
        public void ReadFromFile()
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            users.Clear();

            for (int i = 0; i < lines.Length-1; i++)
            {
                if (lines[i] == "")
                    break;
                User user = new User(lines[i], lines[i + 1]);
                users.Add(user);
                i += 1;
            }
        }
        public bool FindUser(User user)
        {
            foreach (var us in users)
            {
                if (us.GetName() == user.GetName())
                    return true;
            }
            return false;
        }
        public User ReturnUser(User user)
        {
            foreach (var us in users)
            {
                if (us.GetName() == user.GetName())
                    return us;
            }
            return new User("NULL","NULL");
        }
        public void WriteToFile()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName))
            {
                foreach (User user in users)
                {
                    file.WriteLine(user.GetName());
                    file.WriteLine(user.GetPassword());

                }
            }


        }

        public void AddUser(string name,string password)
        {
            User user = new User(name, password);
            valid.Validate(user);
            if (FindUser(user)==true)
            {
                throw new UsernameAlreadyTakenException(name);
            }
            users.Add(user);
            this.WriteToFile();
        }



    }
}
