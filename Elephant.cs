using System;
using System.Collections.Generic;

public class Elephant
{
    public string Name;
    public int EarSize;

    public static string userResponse;

    //to redirect the order of the list
    public bool reverseIndicator = false;

    //create a list object to arrange the sequence if user presses 3
    public static List<string> elephantList = new List<string>();

    /// <summary>
    /// Issue is that i have is that i want to you a list to store elephant infomation
    /// Based on the reverse indicator flag, I will return the information
    /// But im stuck trying to use this concept and so my method can take care of everything
    /// then i would like to create a question method which tells customers their options and then assigns the value to 
    /// my whoami method to run on its own, (but not sure how to create a method which takes user input and then store to a variable
    /// </summary>
    /// <param name="whoDoYouWantToCall"></param>
    public void WhoAmI(int whoDoYouWantToCall)
    {   
        //check the validtiy of the input
        if (whoDoYouWantToCall == 1 || whoDoYouWantToCall == 2)
        {
            //if option 1 is selected without a reverse request from option 3
            if (whoDoYouWantToCall == 1 && reverseIndicator == false)
            {
                Console.WriteLine("Calling " + elephantList[0].Name + " whose ear size is " + elephantList[0].Earsize + " .");
            }

            //if option 1 is selected with a reverse request from option 3
            else if (whoDoYouWantToCall == 1 && reverseIndicator == true)
            {
                Console.WriteLine("Calling " + elephantList[1].Name + " whose ear size is " + elephantList[1].Earsize + " .");
            }

            //if option 2 is selected without a reverse request from option 3
            else if (whoDoYouWantToCall == 2 && reverseIndicator == false)
            {
                Console.WriteLine("Calling " + elephantList[1].Name + " whose ear size is " + elephantList[1].Earsize + " .");
            }

            //if option 2 is selected with a reverse request from option 3
            else 
            {
                Console.WriteLine("Calling " + elephantList[0].Name + " whose ear size is " + elephantList[0].Earsize + " .");
            }
        }

        else if (whoDoYouWantToCall == 3)
        {
            if (reverseIndicator == false)
            {
                reverseIndicator = true;
                Console.WriteLine("The two references have been exchanged! ");
            }

            else
            {
                reverseIndicator = false;
                Console.WriteLine("The two references have been exchanged! ");
            }
        }

        else if (whoDoYouWantToCall == 4)
        {
            Console.WriteLine("Thank you for playing until, take care and stay safe! ");
            System.Environment.Exit(10);
        }

        else
        {
            Console.WriteLine("That was not a valid option, good bye, take care, and stay safe! ");
            System.Environment.Exit(10);
        }

    }
}
