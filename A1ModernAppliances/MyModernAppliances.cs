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

            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.

            // Create list to hold found Appliance objects

            // Iterate through loaded appliances
                // Test current appliance brand matches what user entered
                    // Add current appliance in list to found list


            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
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
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Residential"
            // Write "2 - Commercial"

            // Write "Enter grade:"

            // Get user input as string and assign to variable

            // Create grade variable to hold grade to find (Any, Residential, or Commercial)

            // Test input is "0"
                // Assign "Any" to grade
            // Test input is "1"
                // Assign "Residential" to grade
            // Test input is "2"
                // Assign "Commercial" to grade
            // Otherwise (input is something else)
                // Write "Invalid option."

                // Return to calling (previous) method
                // return;

            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"

            // Write "Enter voltage:"

            // Get user input as string
            // Create variable to hold voltage

            // Test input is "0"
                // Assign 0 to voltage
            // Test input is "1"
                // Assign 18 to voltage
            // Test input is "2"
                // Assign 24 to voltage
            // Otherwise
                // Write "Invalid option."
                // Return to calling (previous) method
                // return;

            // Create found variable to hold list of found appliances.

            // Loop through Appliances
                // Check if current appliance is vacuum
                    // Down cast current Appliance to Vacuum object
                    // Vacuum vacuum = (Vacuum)appliance;

                    // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
                        // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>

        //Paolo Bermudez
        //Completed tasks: DisplaayMicrowaves and Checkout methid
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
