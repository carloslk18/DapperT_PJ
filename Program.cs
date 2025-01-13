using System;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.TagScreens;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog{

class Program{

    private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True";

    public static void Main(string[] args){

        var connection = new SqlConnection(CONNECTION_STRING);
        connection.Open();

        Load();

        Console.ReadKey();
        connection.Close();

    }

    public static void Load(){

        Console.Clear();
        Console.WriteLine("Welcome to Blog");
        Console.WriteLine("---------------");
        Console.WriteLine("Let's to work");
        Console.WriteLine();
        Console.WriteLine("1 - User Management");
        Console.WriteLine("2 - Role Management");
        Console.WriteLine("3 - Category Management");
        Console.WriteLine("4 - Tag Management");
        Console.WriteLine("5 - Vinculate User/Role");
        Console.WriteLine("6 - Vinculate Post/Tag");
        Console.WriteLine("7 - Reports");
        Console.WriteLine();
        Console.WriteLine();

        var option = short.Parse(Console.ReadLine());

        switch(option){
            case 1:

            case 2:

            case 3:

            case 4: MenuTagScreen.Load(); 
            break;

            case 5:

            case 6:

            case 7:

            default: Load();
            break;
        }
    }
}
}