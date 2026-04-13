using System;

namespace CyberSafeBot
{//start of namespace

    public class greet_and_name
    { //start of class
        //variable to store the name globally for the class
        private string username = string.Empty;

        //method to display the header UI
        public void welcome()
        { //start of method welcome
           
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========================================");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[WELCOME TO CYBERSAFE BOT]");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========================================");

            //Resetting color after the header
            Console.ResetColor();
        } //end of method welcome

        //method to ask the user for their name
        public void ask_name()
        { //start of method ask_name
            // Requirement: Use Yellow for AI prompts
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Greetings.Please enter your name to begin system access");
            Console.ResetColor();

           //Validation Loop
            do
            { 
                // DarkMagenta for the tag, Gray for the typing
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("User ");

                Console.ForegroundColor = ConsoleColor.Gray;
                username = Console.ReadLine();

                Console.ResetColor();

            } while (!isValid()); 

            // Successful greeting
            Console.WriteLine("Identity confirmed. Hello " + username + "!");
            Console.WriteLine("WELCOME TO THE CYBERSAFE BOT SECURITY INTERFACE");
        } //end of method ask_name

        //method to validate the user input
        private bool isValid()
        { //start of method isValid
            // Check if the input is empty or just spaces
            if (!string.IsNullOrWhiteSpace(username))
            {
                // Extra check: Ensure name is at least 2 characters
                if (username.Trim().Length >= 2)
                {
                    return true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Access Denied.The name is too short.Please try again");
                    Console.ResetColor();
                    return false;
                }
            }
            else
            {
                // Error for the empty input
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Access Denied.Name cannot be empty.Please enter your name.");
                Console.ResetColor();
                return false;
            }
        } //end of method isValid

        //Getter method so Program.cs and Chats.cs can use the name
        public string GetUserName()
        { //start of method GetUserName
            return username;
        } //end of method GetUserName

    } //end of class
} //end of namespace     
    
