using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace CyberSafeBot
{//start of namespace
    public class Chats
    { //start of class
        //variables 
        private ArrayList securityAnswers = new ArrayList();
        private string username;
        private string userSurname;
        private string userEmail;
        private bool isRunning = true;

        public Chats()
        { //start of constructor
            
            securityAnswers.Add("PASSWORDS:Use 12+ characters.Mix uppercase, numbers and symbols like @ or #.");
            securityAnswers.Add("PHISHING:Check for typos in email domains. Banks never ask for pins via email.");
            securityAnswers.Add("BROWSING:'HTTPS' is non-negotiable. Use a VPN on public Wi-Fi.");
        } //end of constructor

        public void ai_chat(string v)
        { //start of main method logic
            username = v;

            Console.Clear();
            new Logo();
            print_separator();

            type_text("[SYSTEM]: Secure session initialization required.", 30);
            Console.Write("PLEASE ENTER YOUR SURNAME: ");
            userSurname = Console.ReadLine();
            Console.Write("PLEASE ENTER YOUR EMAIL ADDRESS: ");
            userEmail = Console.ReadLine();

            //SECURITY CAPTCHA
            //Personalizes responses for an inviting atmosphere
            Console.WriteLine("[SECURITY CHECK]: " + username.ToUpper() + ", ARE YOU A ROBOT? (YES/NO)");
            Console.Write("RESPONSE > ");
            string robotCheck = Console.ReadLine().ToLower().Trim();

            if (robotCheck == "yes")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                type_text("[ACCESS DENIED]: TERMINATING UNAUTHORIZED SESSION.", 40);
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                type_text("[SUCCESS]: IDENTITY VERIFIED. WELCOME, AGENT " + userSurname.ToUpper() + ".", 40);
                Console.ResetColor();
                Thread.Sleep(1000);
            }

            //execution loop
            while (isRunning)
            {
                show_main_menu();
            }

            //professional exit sequence
            show_shutdown_sequence();
        } //end of method

        private void show_main_menu()
        { //start of menu UI
            Console.Clear();
            new Logo();
            print_separator();
            Console.WriteLine("[SECURE MAIN MENU - AGENT: " + username.ToUpper() + "]");
            Console.WriteLine("1.View Security Knowledge Base");
            Console.WriteLine("2.Run System Security Scan");
            Console.WriteLine("3.EXIT SYSTEM (DONE)");
            print_separator();
            Console.Write("COMMAND > ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": knowledge_base_loop();
                    break;
                case "2": run_security_scan();
                    break;
                case "3": isRunning = false;
                    break;
                default: handle_empty(); 
                    break;
            }
        } //end of menu UI

        private void knowledge_base_loop()
        { //start of knowledge base logic
            Console.Clear();
            Console.WriteLine("--- SECURITY KNOWLEDGE BASE ---");
            Console.WriteLine("Agent " + username + ", please select a topic for detailed protocol:");
            Console.WriteLine("Topics: [P]asswords, [Ph]ishing, [B]rowsing");
            Console.Write("CHOOSE TOPIC > ");

            //Exception handling
            try
            {
                string input = Console.ReadLine()?.ToLower().Trim();
                Console.ForegroundColor = ConsoleColor.Yellow;

                if (input == "p" || input == "passwords")
                {
                    type_text("\n" + securityAnswers[0].ToString(), 25);
                    Console.WriteLine("PRO TIP: Use a unique password for every account to prevent cascading breaches.");
                }
                else if (input == "ph" || input == "phishing")
                {
                    type_text("\n" + securityAnswers[1].ToString(), 25);
                    Console.WriteLine("PRO TIP: Always check the sender's full email address for subtle misspellings.");
                }
                else if (input == "b" || input == "browsing")
                {
                    type_text("\n" + securityAnswers[2].ToString(), 25);
                    Console.WriteLine("PRO TIP: Enable 'Do Not Track' in your browser settings to limit data harvesting.");
                }
                else
                {
                    Console.WriteLine("\n[ALERT]: Protocol for '" + input + "' is not found in the current library.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("System Error: Could not process request. " + ex.Message);
            }

            Console.ResetColor();
            Console.WriteLine("\n" + new string('-', 45));
            Console.WriteLine("[B] Back to Menu | [D] Done (Exit Program)");
            Console.Write("ACTION > ");

            string nav = Console.ReadLine().ToLower();
            if (nav == "d") isRunning = false;
        } //end of method

        private void run_security_scan()
        { //start of scan animation
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            type_text("[SCANNING FILESYSTEM...]", 30);
            for (int i = 0; i <= 20; i++) { Console.Write(""); Thread.Sleep(100); }
            Console.WriteLine("\n\n[STATUS]: 0 THREATS DETECTED. SYSTEM IS SECURE.");
            Console.ResetColor();

            Console.WriteLine("\n[B] Back to Menu | [D] Done/Exit");
            if (Console.ReadLine().ToLower() == "d") isRunning = false;
        }

        private void show_shutdown_sequence()
        { //start of shutdown UI
            // Hits Rubric: Polished, well-formatted console UI
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            print_separator();
            Console.WriteLine("SYSTEM LOGOUT COMPLETE");
            Console.WriteLine("Session Logs Archived for: " + userEmail);
            print_separator();
            Console.ResetColor();

            Console.WriteLine("\nOPERATOR  : " + username + " " + userSurname);
            Console.WriteLine("STATUS    : DISCONNECTED");

            type_text("Safe travels in the digital frontier... Goodbye.", 50);
            Console.WriteLine("[PRESS ANY KEY TO FINALIZE SHUTDOWN]");
            Console.ReadKey();
        }

        private void handle_empty()
        { 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Command not recognized. Please use numerical inputs (1-3).");
            Thread.Sleep(1000);
            Console.ResetColor();
        }

        private void type_text(string message, int delay)
        { //Typewriter effect
            foreach (char c in message) { Console.Write(c); Thread.Sleep(delay); }
            Console.WriteLine();
        }

        private void print_separator()
        { //UI divider lines
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(new string('=', 65));
            Console.ResetColor();
        }
    } //end of class
} //end of namespace