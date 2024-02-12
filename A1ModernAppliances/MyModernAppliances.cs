using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "
            Console.WriteLine("Enter the Item number of an appliance: ");
            
            // Create long variable to hold item number
            long applianceId;
            
            // Get user input as string and assign to variable.
            string input = Console.ReadLine();

            // Convert user input from string to long and store as item number variable.
            long.TryParse(input, out applianceId);

            // Create 'foundAppliance' variable to hold appliance with item number
            Appliance? foundAppliance = null;
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
           
            // Loop through Appliances
            foreach (var appliance in Appliances)
            {
                // Test appliance item number equals entered item number
                if (appliance.ItemNumber == applianceId)
                {
                    // Assign appliance in list to foundAppliance variable
                    foundAppliance = appliance;
                    // Break out of loop (since we found what need to)
                    break;
                }
            }
            // Test appliance was not found (foundAppliance is null)
            if (foundAppliance == null) 
            {
                // Write "No appliances found with that item number."
                Console.WriteLine("No appliances found with that item number");
                return;
            }
            // Otherwise (appliance was found)
            // Test found appliance is available
            if (foundAppliance.IsAvailable)
            {
                // Checkout found appliance
                foundAppliance.Checkout();
                // Write "Appliance has been checked out."
                Console.WriteLine($"Appliance \"{applianceId}\" has been checked out");
            }            
            else
            {
                // Otherwise (appliance isn't available)
                // Write "The appliance is not available to be checked out."
                Console.WriteLine("The appliance is not availabe to be checked out. ");
            }                        
        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.WriteLine("Enter brand to search for: ");
            // Create string variable to hold entered brand
            string Brand;
            // Get user input as string and assign to variable.
            Brand = Console.ReadLine();
            // Create list to hold found Appliance objects
            List<Appliance> found = new List<Appliance>();
            // Iterate through loaded appliances
            foreach (Appliance appliances in Appliances)
            {
                // Test current appliance brand matches what user entered
                if (appliances.Brand == Brand)
                {
                    // Add current appliance in list to found list
                    found.Add(appliances);
                }
            }
            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            //Jonathan Buccat
            //Completed tasks: DisplayRefrigerators & RandomList
            //Displayed the Refrigerator appliance and displayed the random list of appliance to user
            //Feb 11, 2024

            //display menu
            Console.WriteLine("Enter number of doors: 2 (double door), 3 (three doors) or 4 (four doors): ");
            int numberOfDoors = Convert.ToInt32(Console.ReadLine());

            //list of found Appliance objects
            List<Appliance> found = new List<Appliance>();

            //Loop through Refrigerator
            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Refrigerator)
                {
                    Refrigerator refrigerator = (Refrigerator)appliance;
                    if (numberOfDoors == 0 || refrigerator.Doors == numberOfDoors)
                    {
                        found.Add(appliance);
                    }
                }
            }

            //Displays info on refrigerator based on user input of doors
            Console.WriteLine("Matching refrigerators: ");
            DisplayAppliancesFromList(found, numberOfDoors);
            
            
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "2 - Double doors"
            // Write "3 - Three doors"
            // Write "4 - Four doors"

            // Write "Enter number of doors: "

            // Create variable to hold entered number of doors

            // Get user input as string and assign to variable

            // Convert user input from string to int and store as number of doors variable.

            // Create list to hold found Appliance objects

            // Iterate/loop through Appliances
            // Test that current appliance is a refrigerator
            // Down cast Appliance to Refrigerator
            // Refrigerator refrigerator = (Refrigerator) appliance;

            // Test user entered 0 or refrigerator doors equals what user entered.
            // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {

            //Romer John De Lina
            // Completed tasks: DisplayVacuums() & Find()
            //Displayed Vcuums appliance and done the Find() so the program can find what then user inputted
            // Feb 11, 2024
            //The display menu for grade
            Console.WriteLine("Possible options: ");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Residential");
            Console.WriteLine("2 - Commercial");
            Console.WriteLine("Enter grade: ");
            //user input
            string userInput = Console.ReadLine();

            //switch case for the options
            int grade;
            if (int.TryParse(userInput, out grade))
            {
                switch (grade)
                {
                    case 0:
                        Console.WriteLine("Any");
                        break;
                    case 1:
                        Console.WriteLine("Residential");
                        break;
                    case 2:
                        Console.WriteLine("Commercial");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        return;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number. ");
                return;
            }
            //The display menu for voltage
            Console.WriteLine("Possible options: ");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - 18 Volt");
            Console.WriteLine("2 - 24 Volt");
            Console.WriteLine("Enter voltage: ");
            string userInput2 = Console.ReadLine();
            //switch case for the options
            int voltage;
            if (int.TryParse(userInput2, out voltage))
            {
                switch (voltage)
                {
                    case 0:
                        Console.WriteLine("Any voltage");
                        break;
                    case 1:
                        Console.WriteLine("18 voltage");
                        break;
                    case 2:
                        Console.WriteLine("24 voltage");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number. ");
                return;
            }
            //List 
            List<Appliance> found = new List<Appliance>();
            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Vacuum)
                {
                    Vacuum vacuum = (Vacuum)appliance;
                    if (grade == 0 || (grade.Equals(vacuum.Grade) && vacuum.Voltage == 0) || (vacuum.Voltage == voltage))
                    {
                        found.Add(appliance);
                    }
                }
            }
            //Display
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>

        //Paolo Bermudez
        //Completed tasks: DisplayMicrowaves and Checkout method
        //Displayed the microwave appliance and displayed the checkout to user
        //Feb 11, 2024
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"
            Console.WriteLine("Room where the microwave will be installed: ");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - Kitchen"
            Console.WriteLine("1 - Kitchen");
            // Write "2 - Work site"
            Console.WriteLine("2 - Worksite");

            // Write "Enter room type:"
            Console.WriteLine("Enter room type: ");
            // Get user input as string and assign to variable
            string input = Console.ReadLine();
            // Create character variable that holds room type
            char roomType;
            // Test input is "0"
            if (input == "0")
            // Assign 'A' to room type variable
            {
                roomType = 'A';
            }
            // Test input is "1"
            else if (input == "1")
            // Assign 'K' to room type variable
            {
                roomType = 'K';
            }
            // Test input is "2"
            else if (input == "2")
            // Assign 'W' to room type variable
            {
                roomType = 'W';
            }
            // Otherwise (input is something else)
            else
            // Write "Invalid option."
            {
                Console.WriteLine("Invalid Option. ");
                // Return to calling method
                // return;
                return;
            }
            // Create variable that holds list of 'found' appliances
            List<Appliance>foundMicrowaves = new List<Appliance>();
            // Loop through Appliances
            foreach (var appliance in Appliances)
            {
                // Test current appliance is Microwave
                if (appliance is Microwave microwave)
                {
                    // Down cast Appliance to Microwave

                    // Test room type equals 'A' or microwave room type
                    if (roomType == 'A' || microwave.RoomType == roomType)
                    {
                        // Add current appliance in list to found list
                        foundMicrowaves.Add(microwave);
                    }

                }
            }
            DisplayAppliancesFromList(foundMicrowaves, 0);
            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {

            //Console.WriteLine("Possible options:");
            //Console.WriteLine("0 - Any");
            //Console.WriteLine("1 - Quietest");
            //Console.WriteLine("2 - Quieter");
            //Console.WriteLine("3 - Quiet");
            //Console.WriteLine("4 - Moderate");

            Console.WriteLine("Enter the sound rating of the dishwasher: Qt (Quietest), Qr (Quieter), Qu(Quiet) or M (Moderate): ");
            string soundRating = Console.ReadLine();

            List<Appliance> found = new List<Appliance>();

            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Dishwasher dishwasher)
                {
                    if (soundRating == "Qt" || soundRating == "Qr" || soundRating == "Qu" || soundRating == "M")
                    {
                        if (dishwasher.SoundRating == soundRating)
                        {
                            found.Add(dishwasher);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid sound rating option.");
                        return;
                    }
                }
            }

            Console.WriteLine("Matching dishwashers: ");
            DisplayAppliancesFromList(found, 0);

            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Quietest"
            // Write "2 - Quieter"
            // Write "3 - Quiet"
            // Write "4 - Moderate"

            // Write "Enter sound rating:"

            // Get user input as string and assign to variable

            // Create variable that holds sound rating

            // Test input is "0"
            // Assign "Any" to sound rating variable
            // Test input is "1"
            // Assign "Qt" to sound rating variable
            // Test input is "2"
            // Assign "Qr" to sound rating variable
            // Test input is "3"
            // Assign "Qu" to sound rating variable
            // Test input is "4"
            // Assign "M" to sound rating variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method

            // Create variable that holds list of found appliances

            // Loop through Appliances
            // Test if current appliance is dishwasher
            // Down cast current Appliance to Dishwasher

            // Test sound rating is "Any" or equals soundrating for current dishwasher
            // Add current appliance in list to found list

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            //Display options
            Console.WriteLine("");
            Console.WriteLine("Appliance Types");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 – Refrigerators");
            Console.WriteLine("2 – Vacuums");
            Console.WriteLine("3 – Microwaves");
            Console.WriteLine("4 – Dishwashers");

            //User input for type of appliance
            Console.WriteLine("");
            Console.Write("Enter type of appliance: ");
            int applianceType = Convert.ToInt32(Console.ReadLine());

            //User input for number of appliances
            Console.Write("Enter number of appliances: ");
            int listOfFoundAppliances = Convert.ToInt32(Console.ReadLine());

            //List of found appliances
            List<Appliance> found = new List<Appliance>();

            //Loop through Appliances
            foreach (Appliance appliance in Appliances)
            {
                if (applianceType == 0)
                {
                    found.Add(appliance);
                }
                else if (applianceType == 1 && appliance is Refrigerator)
                {
                    found.Add(appliance);
                }
                else if (applianceType == 2 && appliance is Vacuum)
                {
                    found.Add(appliance);
                }
                else if (applianceType == 3 && appliance is Microwave)
                {
                    found.Add(appliance);
                }
                else if (applianceType == 4 && appliance is Dishwasher)
                {
                    found.Add(appliance);
                }
            }

            //Randomize list of appliances
            found.Sort(new RandomComparer());

            //Displays random list
            Console.WriteLine("");
            DisplayAppliancesFromList(found, listOfFoundAppliances);
            
            
            
            // Write "Appliance Types"

            // Write "0 - Any"
            // Write "1 – Refrigerators"
            // Write "2 – Vacuums"
            // Write "3 – Microwaves"
            // Write "4 – Dishwashers"

            // Write "Enter type of appliance:"

            // Get user input as string and assign to appliance type variable

            // Write "Enter number of appliances: "

            // Get user input as string and assign to variable

            // Convert user input from string to int

            // Create variable to hold list of found appliances

            // Loop through appliances
            // Test inputted appliance type is "0"
            // Add current appliance in list to found list
            // Test inputted appliance type is "1"
            // Test current appliance type is Refrigerator
            // Add current appliance in list to found list
            // Test inputted appliance type is "2"
            // Test current appliance type is Vacuum
            // Add current appliance in list to found list
            // Test inputted appliance type is "3"
            // Test current appliance type is Microwave
            // Add current appliance in list to found list
            // Test inputted appliance type is "4"
            // Test current appliance type is Dishwasher
            // Add current appliance in list to found list

            // Randomize list of found appliances
            // found.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, num);
        }
    }
}
