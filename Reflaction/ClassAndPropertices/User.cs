using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflaction.ClassAndPropertices
{
    public class User
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }    
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }

        public void AssambolyClass() { 
            Type type = Type.GetType("Reflaction.ClassAndPropertices.User");

            Console.WriteLine("Full Name = "+type.FullName+ " Name - "+type.Name +" name spane "+ type.Namespace);

        }


        public void LoadAssamboly()
        {
            string path = @"D:\c#project\BasicSharpWithBook\csharp-basic\Reflaction\bin\Debug\net7.0\Reflaction.dll";
            Assembly load = Assembly.LoadFile(path);

            //Console.WriteLine(load.FullName);

            Type[] types =  load.GetTypes();

           foreach(var type in types)
            {
                Console.WriteLine("class Name " + type.Name);

                Console.WriteLine("");

                PropertyInfo[] propertyInfos= type.GetProperties();

                foreach(PropertyInfo info in propertyInfos)
                {
                    Console.WriteLine("----property Name "+ info.Name);
                }

                Console.WriteLine(" ");

                MethodInfo[] methods = type.GetMethods();
                foreach(MethodInfo method in methods)
                {
                    Console.WriteLine("------Mtod name " + method.Name + " return type "+ method.ReturnType);

                    ParameterInfo[] parameters = method.GetParameters();
                    foreach(ParameterInfo parameter in parameters)
                    {
                        Console.WriteLine("---------parameter name "+ parameter.Name + "  paramiter type "+ parameter.ParameterType);
                    }
                }
            }


        }

        public User() { }

        public User(int id, string name, string email, string password, string userName, string userEmail, string userPassword)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            UserName = userName;
            UserEmail = userEmail;
            UserPassword = userPassword;
        }

    }
}
