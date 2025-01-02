using System;
using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog{

class Program{

    private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True";

    public static void Main(string[] args){

        //ReadUsers();
        //ReadUser();
        //CreateUser();
        //UpdateUser();
        DeleteUser();

    }

    public static void ReadUsers(){
        using (var connection = new SqlConnection(CONNECTION_STRING)){
            var users = connection.GetAll<User>();

            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
            }
        }
    }

    public static void ReadUser(){
        using (var connection = new SqlConnection(CONNECTION_STRING)){
            var users = connection.Get<User>(1);
            Console.WriteLine(users.Bio);

        }
    }

    public static void CreateUser(){

        var tutu = new User(){
            Name = "Tutu",
            Email = "tutu@balta.io",
            PasswordHash = "HASH",              
            Bio = "VamoqVamo",
            Image = "http://",
            Slug = "tutu-balta"

        };
        using (var connection = new SqlConnection(CONNECTION_STRING)){
            var users = connection.Insert<User>(tutu);
            Console.WriteLine("User created");

        }
    }

    public static void UpdateUser(){

        var user = new User(){
            Id = 2,
            Name = "Tutu Updated",
            Email = "tutu@balta.io",
            PasswordHash = "HASH",              
            Bio = "VamoqVamo",
            Image = "http://",
            Slug = "tutu-balta-updated"

        };
        using (var connection = new SqlConnection(CONNECTION_STRING)){
            var users = connection.Delete<User>(user);
            Console.WriteLine("Register updated");
        }
    }

    public static void DeleteUser(){

        using (var connection = new SqlConnection(CONNECTION_STRING)){
            
            var user = connection.Get<User>(2);
            var users = connection.Delete<User>(user);
            Console.WriteLine("Register deleted");
        }
    }
}
}