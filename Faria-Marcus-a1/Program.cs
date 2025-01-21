﻿// Step 0: Let the player know the controls
// Console.WriteLine("Hello Player! For this adventure, to proceed you will need to type exactly what is within the [ ].");
// Console.WriteLine("Are you ready to proceed, [Yes]");
// string input = Console.ReadLine();
// if (input == "Yes")

// Step 1: Introduce the player to their surroundings

Console.WriteLine("You awake in a pitch black room. The events of the previous night start to return to you in a haze.");
Console.WriteLine("You remember being in a bar, talking with a strange man than blacking out.");
Console.WriteLine("He must have put something in your drink! You feel chains around your wrists, but they are loose and you quickly slip out of them.");
Console.WriteLine("As your eyes adjust to the darkness, you begin to make things out.");
Console.WriteLine("To your left is a staircase going up. To your right is a hallway that seemingly leads deeper into this dark place.");

// Step 2: introduce the first choice
Console.WriteLine("Which way will you go, [Stairs] or [Hallway]");

string Option1 = Console.ReadLine();

if (Option1 == "Stairs")
{
    // Step 2a: Main Conditional statements section
    Console.WriteLine("You quickly run up the stairs.");
    Console.WriteLine("You reach the top of the stairs and find yourself on the ground floor of a house.");
    Console.WriteLine("You can see the front door on your left. To your right you see an open bathroom door.");
    Console.WriteLine("Which way do you go [FrontDoor] or [Bathroom]");

    string Option2 = Console.ReadLine();

    if (Option2 == "FrontDoor")
    {
        //Step 3a: First game over
        Console.WriteLine("You run for the front door.");
        Console.WriteLine("Suddenly, the man from the bar steps out from around the corner wielding a knife!");
        Console.WriteLine("GAME OVER");
    }

    if (Option2 == "Bathroom")
    {
        Console.WriteLine("You quietly slip into the bathroom.");
        Console.WriteLine("You hear someone walking in your direction coming from the front door.");
        Console.WriteLine("They open the basement door and start heading down");
        Console.WriteLine("With your opening you slip out of the bathroom.");
        Console.WriteLine("Exiting the bathroom you can now see the backdoor and the frontdoor, as well as a phone in the kitchen");
        Console.WriteLine("What do you do [Phone], [FrontDoor], or [BackDoor]");

        string Option3 = Console.ReadLine();

        if (Option3 == "Phone")
        {
            //Step 4a: 2nd game over
            Console.WriteLine("You rush for the phone and enter 911 as fast as you can!");
            Console.WriteLine("As you raise the phone to your ear, you hear nothing. The line has been cut.");
            Console.WriteLine("As you get ready to walk away you bump into something behind you. Its the man");
            Console.WriteLine("GAME OVER");
        }

        if (Option3 == "FrontDoor")
        {
            // Step 4b: 3rd game over
            Console.WriteLine("You sprint towards the front door.");
            Console.WriteLine("As you placed your hand on the knob you feel something shift underneath your feet.");
            Console.WriteLine("Suddenly the floor fall away beneth you and you find yourself in a deep hole.");
            Console.WriteLine("As you look up you see the man standing at the top of the hole staring down at you");
            Console.WriteLine("GAME OVER");
        }

        if (Option3 == "BackDoor")
        {
            // Step 4c: Advance the story/correct decision
            Console.WriteLine("You rush towards the back door!");
            Console.WriteLine("Stepping out into the backyard you can hear the man running up the stair behind you.");
            Console.WriteLine("You need to act quick");
            Console.WriteLine("The backyard is surrounded by a large fence but you could scale it if you tried. There is also a rundown shed in the backyard.");
            Console.WriteLine("Where will you go? [Shed] or [Fence]");

            string Option4 = Console.ReadLine();

            if (Option4 == "Fence")
            {
                // Step 5a: 4th Game Over
                Console.WriteLine("You hurridly run to the fence and begin climbing.");
                Console.WriteLine("As you reach the top of the fence, the man slams the door to the backyard open.");
                Console.WriteLine("You leap off the fence in a hurry not checking how far the drop is.");
                Console.WriteLine("Its too far. As you land you hear an audible SNAP");
                Console.WriteLine("Your leg is very broken.");
                Console.WriteLine("Unable to walk anymore the man is easily able to catch you.");
                Console.WriteLine("GAME OVER");
            }
            if (Option4 == "Shed")
            {
                // Step 5b: 1st winning path
                Console.WriteLine("You quickly hide in the shed.");
                Console.WriteLine("You hear the door to the backyard open.");
                Console.WriteLine("The man begins searching around the backyard for you.");
                Console.WriteLine("You quickly look around the shed for anything you can use. Thats when you spot it. A hole in the rotting wood at the back of the shed that leads under the fence!");
                Console.WriteLine("You quickly crawl through right as the man opens the door to the shed.");
                Console.WriteLine("Now on the other side of the fence you make a run for it!");
                Console.WriteLine("You are free from the crazy man, you have survived!");
                Console.WriteLine("CONGRATULATIONS YOU SURVIVED!");
            }
        }
    }
}

if (Option1 == "Hallway")
{
    // Step 2b: 
    Console.WriteLine("You run down the hallway.");
    Console.WriteLine("At the end of the hallway is a large metal door and a wooden hatch on the ground.");
    Console.WriteLine("The door looks like it would be loud, but the hatch, seemingly, leads underground.");
    Console.WriteLine("Suddenly, you hear the basement door open and someone walking down the stairs, you have to choose quickly!");
    Console.WriteLine("Which way do you go [MetalDoor] or [Hatch]");
    string Option5 = Console.ReadLine();
    if (Option5 == "Hatch")
    {
        // Part 2:  section
        Console.WriteLine("You open the hatch and start climbing down the ladder, closing the hatch behind you.");
        Console.WriteLine("At the bottom of the ladder you find a ");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
    }
    if (Option5 == "MetalDoor")
    {
        Console.WriteLine("You open the metal door, causing a loud sound as expected.");
    }
}