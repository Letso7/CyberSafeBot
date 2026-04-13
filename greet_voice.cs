using System;
using System.IO;
using System.Media;

namespace CyberSafeBot
{//start of namespace

    public class greet_voice
    { //start of class

        //variable to store the base path
        string path = AppDomain.CurrentDomain.BaseDirectory;

        public greet_voice()
        { //start of constructor
            //call the voice method to start greeting
            voice();
        } 

        //method to handle audio greeting
        private void voice()
        { //start of method voice

            //try statement to manage audio playback and potential errors
            try
            { 

                //getting the path of the application
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;

                //cleaning the path and attaching the audio file name
                string audioPath = baseDir.Replace(@"bin\Debug\", "") + "greet2.wav";

                //creating the SoundPlayer instance
                SoundPlayer voice_play = new SoundPlayer(audioPath);

                //Loading the file into memory
                voice_play.Load();

                //Playing the audio (Sync ensures it finishes before the logo displays)
                voice_play.PlaySync();

            } 
            catch (FileNotFoundException ex)
            { //start of catch statement
                //setting color to red for error feedback
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("System Alert: Audio file was not found.{ex.Message}");
                Console.ResetColor();
            }
            catch (Exception ex)
            { //general catch for other hardware or format issues
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("System Alert: Audio playback failed. {ex.Message}");
                Console.ResetColor();
            } //end of catch statement

        } //end of method voice
    } //end of class
} //end of namespace 