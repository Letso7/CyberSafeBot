using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSafeBot
{//start of namesapce
    public class Program
    { //start of class
        static void Main(string[] args)
        { //start of method
            //Initialization
            Console.Title = "CYBERSAFE BOT - Security Awareness System";

            //Creating an instance for greet_voice class          
            new greet_voice();

            //Clear the console to make sure the logo is at the very top
            Console.Clear();

            //ASCII Logo
            new Logo();

            //USER IDENTIFICATION PHASE
            print_line();

            //Handle user welcome and name input
            greet_and_name greeting_and_name = new greet_and_name();

            //Professional and engaging conversation style
            greeting_and_name.welcome();
            greeting_and_name.ask_name();

            //Main Chatbot Interaction Transition
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[STATUS]: Initializing Secure Chat Session");
            System.Threading.Thread.Sleep(800);
            Console.ResetColor();

            //Entering the core Chat Logic
            Chats chatSession = new Chats();
            chatSession.ai_chat(greeting_and_name.GetUserName());
        } //end of method

        // Helper method for visual structure and consistency
        private static void print_line()
        { //start of method
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("============================================================");
            Console.ResetColor();
        } //end of method
    } //end of class
} //end of namespace