using System;
using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog{

class Program{

    private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True";

    public static void Main(string[] args){

        var connection = new SqlConnection(CONNECTION_STRING);
        connection.Open();

        //ReadUsers(connection);
        //ReadRoles(connection);
        //ReadTags(connection);
        //CreateUsers(connection);
        //CreateRoles(connection);
        //CreateTags(connection);
        //UpdateUser(connection);
        //UpdateRole(connection);
        //UpdateTag(connection);
        //DeleteUsers(connection);
        //DeleteRoles(connection);
        //DeleteTags(connection);

        connection.Close();

    }

    public static void ReadUsers(SqlConnection connection){
       
        var repository = new Repository<User>(connection);
        var users = repository.Get();

        foreach (var user in users)
        {
            Console.WriteLine(user.Name);
        }
    }

    public static void ReadRoles(SqlConnection connection){
        var repository = new Repository<Role>(connection);
        var roles = repository.Get();

        foreach (var role in roles)
        {
            Console.WriteLine(role.Name);
        }
    }

    public static void ReadTags(SqlConnection connection){
        var repository = new Repository<Tag>(connection);
        var tags = repository.Get();

        foreach (var tag in tags)
        {
            Console.WriteLine(tag.Name);
        }
    }

    public static void CreateUsers(SqlConnection connection){

        var user = new User();
        user.Name = "Joao Paschoal";
        user.Email = "joao@balta.io";
        user.PasswordHash = "HASH";
        user.Bio = "Equipe balta.io";
        user.Image = "https://";
        user.Slug = "joao-paschoal";


        var repository = new Repository<User>(connection);
        repository.Create(user);
        Console.WriteLine("User created");
    }

    public static void CreateRoles(SqlConnection connection){

        var role = new Role();
        role.Name = "Role test";
        role.Slug = "role-test";

        var repository = new Repository<Role>(connection);
        repository.Create(role);
        Console.WriteLine("Role created");
    }

    public static void CreateTags(SqlConnection connection){

        var tag = new Tag();
        tag.Name = "Tag test";
        tag.Slug = "tag-test";


        var repository = new Repository<Tag>(connection);
        repository.Create(tag);
        Console.WriteLine("Tag created");
    }

    public static void UpdateUser(SqlConnection connection){
        var user = new User();
        user.Id = 3;
        user.Name = "Felipe Toscano";
        user.Email = "felipe_toscano@balta.io";
        user.PasswordHash = "felipe-toscano";
        user.Bio = "Test";
        user.Image = "https://";
        user.Slug = "felipe-toscano";
        
        var repository = new Repository<User>(connection);
        repository.Update(user);

        Console.WriteLine("User updated");
    }

    public static void UpdateRole(SqlConnection connection){
        var role = new Role();
        role.Id = 2;
        role.Name = "test";
        role.Slug = "test-test";
        
        var repository = new Repository<Role>(connection);
        repository.Update(role);

        Console.WriteLine("Role updated");
    }

    public static void UpdateTag(SqlConnection connection){
        var tag = new Tag();
        tag.Id = 3;
        tag.Name = "Felipe Toscano";
        tag.Slug = "felipe-toscano";
        
        var repository = new Repository<Tag>(connection);
        repository.Update(tag);

        Console.WriteLine("Tag updated");
    }

    public static void DeleteUsers(SqlConnection connection){

        var repository = new Repository<User>(connection);

        var user = connection.Get<User>(3);
        repository.Delete(user);

        Console.WriteLine("User deleted");
    }

    public static void DeleteRoles(SqlConnection connection){

        var repository = new Repository<Role>(connection);

        var role = connection.Get<Role>(2);
        repository.Delete(role);

        Console.WriteLine("Role deleted");
    }

    public static void DeleteTags(SqlConnection connection){

        var repository = new Repository<Tag>(connection);

        var tag = connection.Get<Tag>(3);
        repository.Delete(tag);

        Console.WriteLine("Tag deleted");
    }
}
}