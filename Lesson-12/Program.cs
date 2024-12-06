﻿using System;

class ColorGuessingGame
{
    static void Main()
    {
        // STEP 1: Using the menu above in Visual Studio, select: Git > Create Git Repository.

        // STEP 2: In the "Push to a new remote" section, select "Github."

        // STEP 3: Sign in to your Github account under "Create a new GitHub repository," name the repository, add a description, and click the "Create and Push" button.

        Console.WriteLine("Welcome to the Color Guessing Game!");

        // Randomly select a random color
        Random random = new Random();
        int colorChoice = random.Next(1, 4);
        string color;

        // STEP 4: Go to https://github.com/ to see your new repository.

        // STEP 5: Update the program to allow for more colors, then add/stage the changes to Program.cs, add a comment, and commit to the local repository.

        switch (colorChoice)
        {
            case 1:
                color = "red";
                break;
            case 2:
                color = "blue";
                break;
            case 3:
                color = "yellow";
                break;
            default:
                color = "unknown";
                break;
        }
        Console.WriteLine("Guess the color: red, blue, or yellow");

        // STEP 6: Push the changes to the remote repository, and then go back to https://github.com/ to see the updates.

        string guess = Console.ReadLine().ToLower();
        if (guess == color)
        {
            Console.WriteLine("Correct! You win!");
        }
        else
        {
            Console.WriteLine("Incorrect. The color was " + color);
        }
    }
}


// This application adapted from a simple C# program generated by Google Gemini.