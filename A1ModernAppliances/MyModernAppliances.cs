using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;


//Authors:                                                           Date: Feb 11, 2024
//Jonathan Buccat
//Completed tasks: DisplayRefrigerators & RandomList
//Displayed the Refrigerator appliance and displayed the random list of appliance to user
//---------------------------------------------------------------------------------------
//Romer John De Lina
// Completed tasks: DisplayVacuums() & Find()
//Displayed Vacuums appliance and done the Find() so the program can find what then user inputted
//The display menu for grade
//----------------------------------------------------------------------------------------
//Paolo Bermudez
//Completed tasks: DisplayMicrowaves and Checkout method
//Displayed the microwave appliance and displayed the checkout to user
//----------------------------------------------------------------------------------------
//Jeffry Ancheta
//Completed Task: DisplayDishwashers()
//Displaying the diswasher list depending on the sound rating

namespace ModernAppliances
{
    
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
        }
        /// <summary>
        /// Displays Vacuums
        /// </summary>       
        public override void DisplayVacuums()
        {
            Console.WriteLine("");
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Residential");
            Console.WriteLine("2 - Commercial");
            Console.WriteLine("Enter grade:");

            //User input for grade
            int gradeInput = Convert.ToInt32(Console.ReadLine());

            //grade variable to hold string option
            string grade;

            //switch case checking to see what user inputs
            switch (gradeInput)
            {
                case 0:
                    grade = "Any";
                    break;
                case 1:
                    grade = "Residential";
                    break;
                case 2:
                    grade = "Commercial";
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            //display for voltage
            Console.WriteLine("");
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - 18 Volt");
            Console.WriteLine("2 - 24 Volt");
            Console.WriteLine("Enter voltage:");

            //user input for voltage
            int voltageInput = Convert.ToInt32(Console.ReadLine());

            //grade variable to hold string option
            string voltage;

            //switch case checking to see what user inputs
            switch (voltageInput)
            {
                case 0:
                    voltage = "Any voltage";
                    break;
                case 1:
                    voltage = "18 Volt";
                    break;
                case 2:
                    voltage = "24 Volt";
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            //creating a list of vacuums
            List<Appliance> found = new List<Appliance>();

            //Loop through vacuum appliances
            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Vacuum vacuum)
                {
                    if ((grade == "Any" || grade == vacuum.Grade) && (voltage == "Any voltage" || voltage == $"{vacuum.BatteryVoltage} Volt"))
                    {
                        found.Add(appliance);
                    }
                }
            }

            Console.WriteLine("");
            DisplayAppliancesFromList(found, 0);
        }
        /// <summary>
        /// Displays microwaves
        /// </summary>
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
        }
        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Quietest");
            Console.WriteLine("2 - Quieter");
            Console.WriteLine("3 - Quiet");
            Console.WriteLine("4 - Moderate");

            // Write "Enter sound rating:"
            Console.WriteLine("Enter the sound rating of the dishwasher: Qt (Quietest), Qr (Quieter), Qu(Quiet) or M (Moderate): ");
            // Get user input as string and assign to variable

            // Create variable that holds sound rating
            string soundRating = Console.ReadLine();
            

            // Create variable that holds list of found appliances
            List<Appliance> found = new List<Appliance>();
            // Loop through Appliances
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
        }
    }
}
