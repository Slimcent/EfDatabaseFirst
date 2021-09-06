using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using EfDatabaseFirst;

namespace EfDatabaseFirst
{
    public static class Application
    {
        public static void Japa()
        {

            //int Id = CrudOperation.AddNewUser();   //Add a new user
            //WriteLine(Id);

            //CrudOperation.UpdateUser(1007);  // Update a user

            //CrudOperation.FindUser(10);      //Find a user

            CrudOperation.DeleteUser(1004);  // Delete a user

            //CrudOperation.ShowAllUsers();    // Display all users
            ReadLine();
    }   }
}
