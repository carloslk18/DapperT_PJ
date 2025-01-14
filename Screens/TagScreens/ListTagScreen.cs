using System;
using Blog.Models;
using Blog.Repositories;
namespace Blog.Screens.TagScreens{

public static class ListTagScreen{

    public static void Load(){
        Console.Clear();
        Console.WriteLine("Tag list");
        Console.WriteLine("--------");

        List();

        Console.ReadKey();
        MenuTagScreen.Load();

    }

    public static void List(){
        var repository = new Repository<Tag>(Database.DbConnection);
        var tags = repository.Get();
        foreach(var tag in tags){
            Console.WriteLine($"{tag.Id} - {tag.Name} - {tag.Slug}");
        }
    }
}
}