using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens{

public static class CreateTagScreen{

    public static void Load(){
        Console.Clear();
        Console.WriteLine("Create Tag");
        Console.WriteLine("--------");
        Console.WriteLine("Name: ");
        var name = Console.ReadLine();
        Console.WriteLine("Slug: ");
        var slug = Console.ReadLine();

        Create(new Tag{
            Name = name,
            Slug = slug
        });

        Console.ReadKey();
        MenuTagScreen.Load();

    }

    public static void Create(Tag tag){
        try{
            var repository = new Repository<Tag>(Database.DbConnection);
            repository.Create(tag);
            
            Console.WriteLine("-----------");
            Console.WriteLine("Tag created!");
        }
        catch(Exception ex){
            Console.WriteLine("Was not possible to create the tag");
            Console.WriteLine(ex.Message);

        }
    }
}
}
