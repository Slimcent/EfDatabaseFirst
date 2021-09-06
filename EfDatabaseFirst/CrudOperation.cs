using System;
using static System.Console;
using EfDatabaseFirst.Ef;
using System.Data.Entity;

namespace EfDatabaseFirst
{
    public static class CrudOperation
    {
        public static void UpdateUser(int id)
        {
            using (var context = new EfEntities())
            {
                try
                {
                    Ef.User userToUpdate = context.Users.Find(id);
                    if (userToUpdate != null)
                    {
                        WriteLine(context.Entry(userToUpdate).State);
                        userToUpdate.Name = "Check";
                        WriteLine(context.Entry(userToUpdate).State);
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                } 
            }
        }

        public static int AddNewUser()
        {
            using (var context = new EfEntities())
            {
                try
                {
                    var user = new Ef.User() { Name = "Entity", Email = "e@gmail.com" };
                    context.Users.Add(user);
                    context.SaveChanges();
                    return user.Id;
                }
                catch (Exception ex)
                {
                    WriteLine(ex.InnerException?.Message);
                    return 0;
                }
            }
        }

        public static void ShowAllUsers()
        {
            try
            {
                using (var context = new EfEntities())
                {
                    foreach (Ef.User user in context.Users)
                    {
                        WriteLine(user.Id.ToString() + " " + user.Name + " " + user.Email);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }

        public static void FindUser(int id)
        {
            try
            {
                using (var context = new EfEntities())
                {
                    Ef.User userToFind = context.Users.Find(id);
                    if (userToFind != null)
                    {
                        Console.WriteLine(userToFind.Id.ToString() + " " + userToFind.Name + " " + userToFind.Email);
                    }
                    else
                    {
                        Console.WriteLine("User not found");
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }

        public static void DeleteUser(int id)
        {
            try
            {
                using (var context = new EfEntities())
                {
                    Ef.User userToDelete = context.Users.Find(id);
                    if (userToDelete != null)
                    {
                        context.Users.Remove(userToDelete);
                        Console.WriteLine("User deleted");
                        if (context.Entry(userToDelete).State != EntityState.Deleted)
                        {
                            throw new Exception("Unable to delete the record");
                        }
                        context.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine("User not found");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
