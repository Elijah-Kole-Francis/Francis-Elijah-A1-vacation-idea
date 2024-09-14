using System.ComponentModel.Design;
using System.IO.Pipes;

string beach = "beach";
string mountains = "mountains";
string town = "town";

Console.WriteLine($"You find yourself on a sudden break from work, a forced vacation. Where do you want to go? \nThe beach? \nThe mountains? \nTo town?");
string input = Console.ReadLine();

if (input == "beach")
{
    Console.WriteLine($"You decided to spend the afternoon at the beach. What will you do? \nSwim? \nGet a tan? \nSurf?");
    string input2 = Console.ReadLine();
    
    //Gotta remember to isolate the input strings because they're individual variables, otherwise code breaks.
    // e.g. input, input2, input3, etc.

    string swim = "swim";
    string tan = "tan";
    string surf = "surf";

    if (input2 == "swim")
    {
        Console.WriteLine($"You swam all afternoon until dusk, impressive! But, now you're tired. It's time to go home and rest.");
    }

    else if (input2 == "tan")
    {
        Console.WriteLine($"You decided to lay down in the sun ans get a tan. Uh oh, you fell asleep! Better go get some cream for those burns...");
    }

    else if (input2 == "surf")
    {
        Console.WriteLine($"Time to hang ten and shred that gnar! Be sure not to wipeout.");
    }

    //Best to do the rule of 3s, three initial choices leading into 3 more choices
    // Remember to put vairables and choices below the inputs, just for simplicity sake.

    else if (input == "mountain")
    {
        Console.WriteLine($"You hike up a tall mountain to soak in a wonderful view. While you're here you may as well do something. \nFish? \nCatch bugs? \nHunt?");
        string input3 = Console.ReadLine();

        string fish = "fish";
        string bugs = "bugs";
        string hunt = "hunt";

        if (input3 == "fish")
        {
            Console.WriteLine($"Testing you might and patience you settled near a pond and cast your line... this is gonna take a while.");
        }

        else if (input3 == "bugs")
        {
            Console.WriteLine($"Hope you know those creatures better than I do, but sure go grab them with your bare hands. \nHope nothing poisonus is around...");
        }

        else if (input3 == "hunt")
        {
            Console.WriteLine($"Thankfully you remebered your gear. Congrats you were able to hunt");
        }

    }

    else if (input == "town")
    {
        Console.WriteLine($"You decided to town for whatever you might need off the top of your head.");
        string input4 = Console.ReadLine();

        string cafe = "cafe";
        string movie = "movie";
        string shopping = "shopping";

        if (input4 == "cafe")
        {
            Console.WriteLine($"You decided to settle down in a the quiet nook of a cafe, time to enjoy some coffee and sweets. If only you had a book to accompany it all.");
        }

        else if (input4 == "movie")
        {
            Console.WriteLine($"You bought a ticket to the afternoon show of a new blockbuster hit, settle in and enjoy!");
        }

        if (input4 == "shopping")
        {
            Console.WriteLine($"You went on a shopping spree for all sorts of clothes, accessories and knick-knacks. Hope you like them.");
        }

    }

    else
    {
        Console.WriteLine($"You're not gonna shirk a free vacation, are you?");
    }
}
