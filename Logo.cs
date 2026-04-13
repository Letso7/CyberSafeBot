using System;
using System.Drawing;
using System.Threading;

namespace CyberSafeBot
{//start of name space
    public class Logo
    {
        //start of class
        string path_logo = AppDomain.CurrentDomain.BaseDirectory;

        public Logo()
        { //start of constructor
            asci();
        } //end of constructor

        private void asci()
        { //start of method
            string full_path = path_logo.Replace(@"bin\Debug\", "") + "logo.jpg";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[SYSTEM]: INITIALIZING SECURE INTERFACE");
            Thread.Sleep(600);

            try
            { //start of try
                Bitmap image = new Bitmap(full_path);
                Bitmap resized = new Bitmap(image, 80, 32);

                // Bold characters first to make the key "pop"
                string asciiChars = "@#W$?!+=-:. ";

                for (int y = 0; y < resized.Height; y++)
                { //start of outer for loop
                    for (int x = 0; x < resized.Width; x++)
                    { //start of inner for loop
                        Color pixel = resized.GetPixel(x, y);
                        int brightness = (pixel.R + pixel.G + pixel.B) / 3;

                        //Match the blue glow of your picture
                        if (brightness > 180) Console.ForegroundColor = ConsoleColor.White;
                        else if (pixel.B > 140) Console.ForegroundColor = ConsoleColor.Cyan;
                        else if (pixel.B > 60) Console.ForegroundColor = ConsoleColor.Blue;
                        else Console.ForegroundColor = ConsoleColor.DarkGray;

                        int index = (brightness * (asciiChars.Length - 1)) / 255;
                        Console.Write(asciiChars[index]);
                    } //end of inner for loop
                    Console.WriteLine();
                } //end of outer for loop

                Console.WriteLine();
                string label = " CYBERSAFE BOT ";
                Console.Write(new string(' ', 80 - label.Length));
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(label);
                Console.ResetColor();
                Console.WriteLine("Securing the Digital Frontier");
            } //end of try
            catch (Exception)
            { //start of catch
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ERROR]: Graphic Asset 'logo.jpg' Load Failure.");
                Console.ResetColor();
            } //end of catch
        } //end of method
    } //end of class
} //end of namespace
