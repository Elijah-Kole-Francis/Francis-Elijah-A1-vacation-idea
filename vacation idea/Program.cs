using System.ComponentModel.Design;

string beach = "beach";
string mountains = "mountains";
string town = "town";

Console.WriteLine($"You find yourself on a sudden break from work, a forced vacation. Where do you want to go? \nThe beach? \nThe mountains? \nTo town?");
string input = Console.ReadLine();

if (input == "beach")
{
    string swim = "swim";
    string tan = "tan";

    Console.WriteLine($"You decided to spend the afternoon at the beach. What will you do? \nSwim? \nGet a tan?");
    string input = Console.ReadLine();

    if (input == "swim") ;
    {
        Console.WriteLine($"You swam all afternoon until dusk, impressive! Unfortunately it's time to go home now and sleep.");
    }

    else (input == tan);
    {
        Console.WriteLine($"You decided to lay down in the sun ans get a tan. Uh oh! You fell asleep! Better go get some cream for those burns...");
    }

}

else if (input == "mountain")
{
    Console.WriteLine($"You hike up a tall mountain to soak in a wonderful view.");
}

else if (input == "town")
{
    Console.WriteLine($"You decided to go on a shopping spree in the town for colourful clothing and dazzling accessories! Yippee!");
}

else
{
    Console.WriteLine($"You're not gonna shirk a free vacation, are you?");
}