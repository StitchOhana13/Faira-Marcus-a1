// Step 0: Let the player know the controls
// Console.WriteLine("Hello Player! For this adventure, to proceed you will need to type exactly what is within the [ ].");
// Console.WriteLine("Are you ready to proceed, [Yes]");
// string input = Console.ReadLine();
// if (input == "Yes")

// Step 1: Introduce the player to their surroundings

string captor1 = "Your captor draws close.";
string captor2 = "Your captor approaches.";

Console.WriteLine("You awake in a pitch black room. The events of the previous night start to return to you in a haze.");
Console.WriteLine("You remember being in a bar, talking with a strange man than blacking out.");
Console.WriteLine("He must have put something in your drink! You feel chains around your wrists, but they are loose and you quickly slip out of them.");
Console.WriteLine("As your eyes adjust to the darkness, you begin to make things out.");
Console.WriteLine("To your left is a staircase going up. To your right is a hallway that seemingly leads deeper into this dark place.");

// Step 2: introduce the first choice
Console.WriteLine("Which way will you go, [Stairs] or [Hallway]");

string initialChoice = Console.ReadLine();

if (initialChoice == "Stairs")
{
    // Step 2a: Main Conditional statements section
    Console.WriteLine("You quickly run up the stairs.");
    Console.WriteLine("You reach the top of the stairs and find yourself on the ground floor of a house.");
    Console.WriteLine("You can see the front door on your left. To your right you see an open bathroom door.");
    Console.WriteLine("Which way do you go [FrontDoor] or [Bathroom]");

    string part1Choice1 = Console.ReadLine();

    if (part1Choice1 == "FrontDoor")
    {
        //Step 3a: First game over
        Console.WriteLine("You run for the front door.");
        Console.WriteLine("Suddenly, the man from the bar steps out from around the corner wielding a knife!");
        Console.WriteLine("GAME OVER");
    }

    if (part1Choice1 == "Bathroom")
    {
        Console.WriteLine("You quietly slip into the bathroom.");
        Console.WriteLine("You hear someone walking in your direction coming from the front door.");
        Console.WriteLine("They open the basement door and start heading down");
        Console.WriteLine("With your opening you slip out of the bathroom.");
        Console.WriteLine("Exiting the bathroom you can now see the backdoor and the frontdoor, as well as a phone in the kitchen");
        Console.WriteLine("What do you do [Phone], [FrontDoor], or [BackDoor]");

        string part1Choice2 = Console.ReadLine();

        if (part1Choice2 == "Phone")
        {
            //Step 4a: 2nd game over
            Console.WriteLine("You rush for the phone and enter 911 as fast as you can!");
            Console.WriteLine("As you raise the phone to your ear, you hear nothing. The line has been cut.");
            Console.WriteLine("As you get ready to walk away you bump into something behind you. Its the man");
            Console.WriteLine("GAME OVER");
        }

        if (part1Choice2 == "FrontDoor")
        {
            // Step 4b: 3rd game over
            Console.WriteLine("You sprint towards the front door.");
            Console.WriteLine("As you placed your hand on the knob you feel something shift underneath your feet.");
            Console.WriteLine("Suddenly the floor fall away beneth you and you find yourself in a deep hole.");
            Console.WriteLine("As you look up you see the man standing at the top of the hole staring down at you");
            Console.WriteLine("GAME OVER");
        }

        if (part1Choice2 == "BackDoor")
        {
            // Step 4c: Advance the story/correct decision
            Console.WriteLine("You rush towards the back door!");
            Console.WriteLine("Stepping out into the backyard you can hear the man running up the stair behind you.");
            Console.WriteLine("You need to act quick");
            Console.WriteLine("The backyard is surrounded by a large fence but you could scale it if you tried. There is also a rundown shed in the backyard.");
            Console.WriteLine("Where will you go? [Shed] or [Fence]");

            string part1Choice3 = Console.ReadLine();

            if (part1Choice3 == "Fence")
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
            if (part1Choice3 == "Shed")
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

if (initialChoice == "Hallway")
{
    // Step 2b: Maze to fusebox math riddles

    Console.WriteLine("You quickly run down the hallway.");
    Console.WriteLine("You quickly realize the hallway turns into a pitch black maze.");
    Console.WriteLine("Before you can think to turn around, you hear a door at the top of the stairs open and someone coming down.");
    Console.WriteLine("You quickly run deeper into the maze hoping you'll find a way out... If there is one.");
    Console.WriteLine("After traversing the maze for a few minutes you find a wooden door.");
    Console.WriteLine("Hoping you found a way out you open it, only to find a small room with no other exits.");
    Console.WriteLine("Looking around the room, sitting atop a large wooden box, you find what looks like a large cylindrical fuse.");
    Console.WriteLine("You take it, hoping it may lead to your survival.");
    Console.WriteLine("A few minutes later, you find a staircase leading down. With no other way to go, you head down.");
    Console.WriteLine("At the bottom of the stairs you find a lit room. On the walls are 3 fuseboxes with power lines connecting to a large electrical metal door at the end of the room.");
    Console.WriteLine("You quickly surmise that 2 of fuseboxes are locked and none of them are powered.");
    Console.WriteLine("As you open the third fusebox you find that it is missing a fuse. Thankful you grabbed the fuse earlier you place it in the box.");
    Console.WriteLine("The fuse box hums to life. As it starts you notice a math riddle on the fusebox, the only to fully power it on is to solve the equation.");
    Console.WriteLine("You get to work solving.");
    Console.WriteLine("Solve the riddle (How many 9's are there between 1 and 100?)");
    Console.WriteLine("[Answer in whole numbers]");
    string mathRiddle1 = Console.ReadLine();
    if (mathRiddle1 == "20")
    {
        Console.WriteLine("The console flashes green and power is delivered to the door.");
        Console.WriteLine("But the door isn't open yet. as you prepare to go back up the stairs, one of the locked fuseboxes opens revealing the necessary fuse inside of it.");
        Console.WriteLine("Placing the the fuse inside the box you prepare yourself for another Math Riddle.");
        Console.WriteLine("Solve the riddle (When my father was 31 I was 8. Now he is twice as old as me. How old am I?");
        Console.WriteLine("[Answer in whole numbers]");
        string mathRiddle2 = Console.ReadLine();
        if (mathRiddle2 == "23")
        {
            Console.WriteLine("Once again the console flashes green.");
            Console.WriteLine("The final fusebox opens and you once again prepare youself for the final riddle.");
            Console.WriteLine("Solve the riddle (I am four times as old as my daughter. In 20 years time I shall be twice as old as her. How old am I now?)");
            Console.WriteLine("[Answer in whole numbers]");
            string mathRiddle3 = Console.ReadLine();
            if (mathRiddle3 == "40")
            {
                Console.WriteLine("The console flashes green, and power is sent to the door.");
                Console.WriteLine("You watch the door open and start to hear footsteps quickly running down the stairs behind you.");
                Console.WriteLine("You run through the door finding a ladder behind. With nowhere else to go you quickly start climbing up.");
                Console.WriteLine("As you reach the top of the ladder, you push a wooden hatch open a find yourself in what looks like a rundown shed.");
                Console.WriteLine("At the back of the shed you see a hole that leads to the other side of a fence, you quickly crawl through");
                Console.WriteLine("Now on the other side of the fence you make a run for it!");
                Console.WriteLine("You are free from you captor, you have survived!");
                Console.WriteLine("CONGRATULATIONS YOU SURVIVED!");
            }
            if (mathRiddle3 != "40")
            {
                Console.WriteLine("The console flashes red and before you have the chance to try again someone grabs you grab behind.");
                Console.WriteLine("GAME OVER");
            }
        }
        if (mathRiddle2 != "23")
        {
            Console.WriteLine($"The screen flashes red you must quickly try again. {captor2}");
            Console.WriteLine("Solve the riddle (I am four times as old as my daughter. In 20 years time I shall be twice as old as her. How old am I now?)");
            Console.WriteLine("[Answer in whole numbers]");
            string mathRiddle4 = Console.ReadLine();
            if (mathRiddle4 == "23")
            {
                Console.WriteLine("Once again the console flashes green.");
                Console.WriteLine("The final fusebox opens and you once again prepare youself for the final riddle.");
                Console.WriteLine("Solve the riddle (I am four times as old as my daughter. In 20 years time I shall be twice as old as her. How old am I now?)");
                Console.WriteLine("[Answer in whole numbers]");
                string mathRiddle5 = Console.ReadLine();
                if (mathRiddle5 == "40")
                {
                    Console.WriteLine("The console flashes green, and power is sent to the door.");
                    Console.WriteLine("You watch the door open and start to hear footsteps quickly running down the stairs behind you.");
                    Console.WriteLine("You run through the door finding a ladder behind. With nowhere else to go you quickly start climbing up.");
                    Console.WriteLine("As you reach the top of the ladder, you push a wooden hatch open a find yourself in what looks like a rundown shed.");
                    Console.WriteLine("At the back of the shed you see a hole that leads to the other side of a fence, you quickly crawl through");
                    Console.WriteLine("Now on the other side of the fence you make a run for it!");
                    Console.WriteLine("You are free from you captor, you have survived!");
                    Console.WriteLine("CONGRATULATIONS YOU SURVIVED!");
                }
                if (mathRiddle5 != "40")
                {
                    Console.WriteLine("The console flashes red and before you have the chance to try again someone grabs you grab behind.");
                    Console.WriteLine("GAME OVER");
                }
            }
            if (mathRiddle4 != "23")
            {
                Console.WriteLine("The console flashes red and before you have the chance to try again someone grabs you grab behind.");
                Console.WriteLine("GAME OVER");
            }
        }
    }
    if (mathRiddle1 != "20")
    {
        Console.WriteLine($"The screen flashes red you must quickly try again. {captor1}");
        Console.WriteLine("Solve the riddle (How many 9's are there between 1 and 100?)");
        Console.WriteLine("[Answer in whole numbers]");
        string mathRiddle6 = Console.ReadLine();
        if (mathRiddle6 == "20")
        {
            Console.WriteLine("The console flashes green and power is delivered to the door.");
            Console.WriteLine("But the door isn't open yet. as you prepare to go back up the stairs, one of the locked fuseboxes opens revealing the necessary fuse inside of it.");
            Console.WriteLine("Placing the the fuse inside the box you prepare yourself for another Math Riddle.");
            Console.WriteLine("Solve the riddle (When my father was 31 I was 8. Now he is twice as old as me. How old am I?");
            Console.WriteLine("[Answer in whole numbers]");
            string mathRiddle2 = Console.ReadLine();
            if (mathRiddle2 == "23")
            {
                Console.WriteLine("Once again the console flashes green.");
                Console.WriteLine("The final fusebox opens and you once again prepare youself for the final riddle.");
                Console.WriteLine("Solve the riddle (I am four times as old as my daughter. In 20 years time I shall be twice as old as her. How old am I now?)");
                Console.WriteLine("[Answer in whole numbers]");
                string mathRiddle3 = Console.ReadLine();
                if (mathRiddle3 == "40")
                {
                    Console.WriteLine("The console flashes green, and power is sent to the door.");
                    Console.WriteLine("You watch the door open and start to hear footsteps quickly running down the stairs behind you.");
                    Console.WriteLine("You run through the door finding a ladder behind. With nowhere else to go you quickly start climbing up.");
                    Console.WriteLine("As you reach the top of the ladder, you push a wooden hatch open a find yourself in what looks like a rundown shed.");
                    Console.WriteLine("At the back of the shed you see a hole that leads to the other side of a fence, you quickly crawl through");
                    Console.WriteLine("Now on the other side of the fence you make a run for it!");
                    Console.WriteLine("You are free from you captor, you have survived!");
                    Console.WriteLine("CONGRATULATIONS YOU SURVIVED!");
                }
                if (mathRiddle3 != "40")
                {
                    Console.WriteLine("The console flashes red and before you have the chance to try again someone grabs you grab behind.");
                    Console.WriteLine("GAME OVER");
                }
            }
            if (mathRiddle2 != "23")
            {
                Console.WriteLine($"The screen flashes red you must quickly try again. {captor2}");
                Console.WriteLine("Solve the riddle (I am four times as old as my daughter. In 20 years time I shall be twice as old as her. How old am I now?)");
                Console.WriteLine("[Answer in whole numbers]");
                string mathRiddle4 = Console.ReadLine();
                if (mathRiddle4 == "23")
                {
                    Console.WriteLine("Once again the console flashes green.");
                    Console.WriteLine("The final fusebox opens and you once again prepare youself for the final riddle.");
                    Console.WriteLine("Solve the riddle (I am four times as old as my daughter. In 20 years time I shall be twice as old as her. How old am I now?)");
                    Console.WriteLine("[Answer in whole numbers]");
                    string mathRiddle5 = Console.ReadLine();
                    if (mathRiddle5 == "40")
                    {
                        Console.WriteLine("The console flashes green, and power is sent to the door.");
                        Console.WriteLine("You watch the door open and start to hear footsteps quickly running down the stairs behind you.");
                        Console.WriteLine("You run through the door finding a ladder behind. With nowhere else to go you quickly start climbing up.");
                        Console.WriteLine("As you reach the top of the ladder, you push a wooden hatch open a find yourself in what looks like a rundown shed.");
                        Console.WriteLine("At the back of the shed you see a hole that leads to the other side of a fence, you quickly crawl through");
                        Console.WriteLine("Now on the other side of the fence you make a run for it!");
                        Console.WriteLine("You are free from you captor, you have survived!");
                        Console.WriteLine("CONGRATULATIONS YOU SURVIVED!");
                    }
                    if (mathRiddle5 != "40")
                    {
                        Console.WriteLine("The console flashes red and before you have the chance to try again someone grabs you grab behind.");
                        Console.WriteLine("GAME OVER");
                    }
                }
                if (mathRiddle4 != "23")
                {
                    Console.WriteLine("The console flashes red and before you have the chance to try again someone grabs you grab behind.");
                    Console.WriteLine("GAME OVER");
                }
            }
        }
        if (mathRiddle6 != "20")
        {
            Console.WriteLine("The console flashes red and before you have the chance to try again someone grabs you grab behind.");
            Console.WriteLine("GAME OVER");
        }
    }
}