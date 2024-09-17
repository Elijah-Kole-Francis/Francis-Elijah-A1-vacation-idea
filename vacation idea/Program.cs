using System.ComponentModel.Design;
using System.IO.Pipes;
using System.Timers;


Console.WriteLine($"I hear you're on vacation, is that true or false?");
bool onVacation = bool.Parse( Console.ReadLine() );

if (onVacation)

{
    string beach = "beach";
    string mountains = "mountains";
    string town = "town";

    Console.WriteLine($"Where do you want to go? \nThe beach? \nThe mountains? \nTo town?");
    string inputLocation = Console.ReadLine();

    if (inputLocation == beach)
    {
        Console.WriteLine($"You decided to spend the afternoon at the {beach}. What will you do? \nSwim? \nGet a tan? \nSurf?");
        string inputBeach = Console.ReadLine();

        //Gotta remember to isolate the input strings because they're individual variables, otherwise code breaks.
        // e.g. input, input2, input3, etc. Assign proper names/values later

        string swim = "swim";
        string tan = "tan";
        string surf = "surf";

        if (inputBeach == swim)
        {
            Console.WriteLine($"You {swim} all afternoon until dusk, impressive! But, now you're tired. It's time to go home and rest.");
        }

        else if (inputBeach == tan)
        {
            Console.WriteLine($"You decided to lay down in the sun ans get a {tan}. Uh oh, you fell asleep! Better go get some cream for those burns...");
        }

        else if (inputBeach == surf)
        {
            Console.WriteLine($"Time to hang ten and shred that gnar! Be sure not to wipeout while you {surf}!");
        }
    }
    //Best to do the rule of 3s, three initial choices leading into 3 more choices
    // Remember to put vairables and choices below the inputs, just for simplicity sake.

    //isolate the mountains and town 'else if' statements, they're failing because they're nested within the 'beach' if statement
    else if (inputLocation == mountains)
    {
        Console.WriteLine($"You hike up a tall {mountains} to soak in a wonderful view. While you're here you may as well do something. \nFish? \nCatch bugs? \nHunt?");
        string inputMountains = Console.ReadLine();

        string fish = "fish";
        string bugs = "bugs";
        string hunt = "hunt";

        if (inputMountains == fish)
        {
            Console.WriteLine($"Testing you might and patience you settled near a pond and cast your line to {fish}... this is gonna take a while.");
        }

        else if (inputMountains == bugs)
        {
            Console.WriteLine($"Hope you know those creatures better than I do, but sure go grab those {bugs} with your bare hands. \nHope nothing poisonus is around...");
        }

        else if (inputMountains == hunt)
        {
            Console.WriteLine($"Thankfully you remebered your gear. Congrats you were able to {hunt}");
        }

    }

    else if (inputLocation == town)
    {
        Console.WriteLine($"You decided to {town} for whatever you might need off the top of your head. While you're there, what would you like to do? \nVisit a cafe? \nGo to a movie? \nGo shopping?");
        string inputTown = Console.ReadLine();

        string cafe = "cafe";
        string movie = "movie";
        string shopping = "shopping";

        if (inputTown == cafe)
        {
            Console.WriteLine($"You decided to settle down in a the quiet nook of a {cafe}, time to enjoy some coffee and sweets. If only you had a book to accompany it all.");
        }
        // maybe I should make it an r rated movie to try and use a bool to check if the person is of age
        // now I gotta figure out how
        else if (inputTown == movie)
        {
            Console.WriteLine($"You go to buy a ticket to the afternoon show of a new blockbuster {movie}, but its R18, enter your age.");
            int userAge = int.Parse(Console.ReadLine());

            if (userAge >= 18)
            {
                Console.WriteLine($"Congratulations, you're good to go!");
            }

            else if (userAge < 18)
            {
                Console.WriteLine($"Sorry, you're gonna have to find another movie to watch. :(");
            }
        }

        else if (inputTown == shopping)
        {
            Console.WriteLine($"You went on a {shopping} spree for all sorts of clothes, accessories and knick-knacks. Hope you like them.");
        }


    }
    else
    {
        Console.WriteLine($"You're not gonna shirk a free vacation, are you?");
    }
}

else
Console.WriteLine($"That's a drag, sorry to hear it.");