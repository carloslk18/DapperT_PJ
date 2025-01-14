using System;
namespace Blog.Screens.TagScreens{

public static class MenuTagScreen{

    public static void Load(){

        Console.Clear();
        Console.WriteLine("Tags Management");
        Console.WriteLine("---------------");
        Console.WriteLine("What do you want?");
        Console.WriteLine();
        Console.WriteLine("1 - Read Tags");
        Console.WriteLine("2 - Create Tags");
        Console.WriteLine("3 - Update Tags");
        Console.WriteLine("4 - Delete Tags");
        Console.WriteLine();
        Console.WriteLine();
        var option = short.Parse(Console.ReadLine());

        switch(option){
        
            case 1: ListTagScreen.Load();
            break;

            case 2: CreateTagScreen.Load();
            break;

            case 3: UpdateTagScreen.Load();
            break;

            case 4: DeleteTagScreen.Load();
            break;

            default: Load();
            break;
        }
    }
}
}