using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System;


namespace ColorReel;

class Program
{
    static void Main(string[] args)
    {
        // Francisco Ramirez
        // 03/25/24
        // Color Reel: This is an app for developing poster art. Set the options below and watch the HTML we can generate!



        // Step 1: Define the core concept of the program - generating movie posters with colored barcodes.

        // Step 2: Design the user interface (UI) for the application using HTML, CSS, and JavaScript.
        // Include elements for uploading movie frames, selecting silhouette images, choosing poster sizes,
        // resizing elements, and previewing designs.

        // Step 3: Implement backend logic in C# for processing movie frames, extracting colors, generating colored barcodes,
        // handling silhouette integration, and preserving original colors.
        // Use C# libraries for image processing and barcode generation if needed.

        // Step 4: Develop frontend interactivity using JavaScript to allow users to:
        // - Choose poster sizes and resize elements dynamically.
        // - Upload movie frames and silhouette images.
        // - Preview and customize poster designs with dynamic generation of barcode lines.

        // Step 5: Integrate frontend and backend components to ensure seamless communication between user interactions,
        // data processing, and visual presentation.
        // Implement logic to overlay colored barcode elements onto silhouette images while preserving original colors
        // in specified areas.

        // Step 6: Add functionality for users to export finalized poster designs as print-ready PDF files.
        // Handle PDF generation based on user-selected poster sizes and design configurations.

        // Step 7: Conduct thorough testing of the application to ensure functionality, responsiveness, and usability
        // across different devices and screen sizes.
        // Gather feedback from users and iterate on the design and functionality based on user testing results.

        string[] menu = { "Size", "Bar", "Layout", "Color to Replace", "Movie", "Image Path" };
        int menuIndex = 0;

        while (true)
        {
            Console.Clear();

            DisplayMenuOptions(menu, menuIndex);

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    if (menuIndex > 0)
                        menuIndex--;
                    break;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:

                    if (menuIndex < menu.Length - 1)
                        menuIndex++;
                    break;
                case ConsoleKey.Enter:
                    Console.Clear();
                    Console.WriteLine("Selected option: " + menu[menuIndex]);
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey(true);
                    break;
            }
        }
    }


    static void DisplayMenuOptions(string[] options, int index)
    {
        for (int i = 0; i < options.Length; i++)
        {
            if (i == index)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
            }
            Console.WriteLine(options[i]);
            Console.ResetColor();
        }
    }

}