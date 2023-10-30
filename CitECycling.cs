using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CitECycling
{
class Program
{
static void Main(string[] args)
{
int iOption = getOption();
while (iOption != 4)
{
if (iOption == 1)
{
displayAllLocations();
}
else if (iOption == 2)
{
addParticipants();
}
else if (iOption == 3)
{
displayRegisteredParticipants();
}
else if (iOption == 4)
{
Environment.Exit(1);
}
iOption = getOption();
}
}
static int getOption()
{
// Declare variable to store user input
int iOption = -1;
// Display user options
Console.WriteLine("Please enter your option: ");
Console.WriteLine("1. View Cit-E Cycling Locations ");
Console.WriteLine("2. Register to participate ");
Console.WriteLine("3. Display all registered participants ");
Console.WriteLine("4. Exit ");
// Get user input
iOption = Convert.ToInt32(Console.ReadLine());
// Validate user input
// It must be within the correct range
while(iOption < 1 || iOption > 4)
{
Console.WriteLine("Please enter a valid option between 1 and 4");
iOption = Convert.ToInt32(Console.ReadLine());
}
// return validated option
return iOption;
}
// TO DO
// Add code to read locations from locations.txt and
// display to the user on console
// Hint: locations.txt is provided for you
// in bin / debug folder
static void displayAllLocations()
{
using (StreamReader sr = new StreamReader("locations.txt"))
{
while (sr.Peek() !=-1)
{
Console.WriteLine(sr.ReadLine());
}
}
}
// TO DO
// Add code that requests the user to enter participant info for a given location:
// Enter the location (Validate the location is one where an event is being held)
// Enter how many participants they would like to add
// ENter the following details for each participant
// Name
// Contact number
// Chosen time slot (1, 2, or 3) [VALIDATE THIS INPUT IN A SEPARATE
FUNCTION]
// Save the user input to a file whose name is the location of the event
// e.g. London.txt
// Hint: An example is provided for you (London.txt)
// in bin / debug folder
// The London.txt example shows the structure you should save data in
static void addParticipants()
{
Console.WriteLine("Where would you like to enter?");
Console.WriteLine("1. London");
Console.WriteLine("2. Aberdeen");
Console.WriteLine("3. Glasgow");
Console.WriteLine("4. Sheffield");
Console.WriteLine("5. Sunderland");
Console.WriteLine("6. Manchester");
Console.WriteLine("7. Bristol");
Console.WriteLine("8. Belfast");
Console.WriteLine("9. Belfast");
Console.WriteLine("10. Cardiff");
Console.WriteLine("11. Oxford");
string sLocation = Console.ReadLine();
Console.WriteLine("What is your name?");
string sName = Console.ReadLine();
Console.WriteLine("Please provide a contact number");
string sContactNumber = Console.ReadLine();
Console.WriteLine("What time slot would you like?");
Console.WriteLine("1");
Console.WriteLine("2");
Console.WriteLine("3");
string sTime = Console.ReadLine();
Console.WriteLine("Press any key to continue");
Console.ReadKey();
}
// TO DO
// Prompt the user to enter the location they wish to view data for
// If the location is a valid one then
// Read the data
// Display data on screen
// Count the total number of participants across all 3 time slots
// e.g output shown below:
/* London Event Information
* Total Registered Participants: 10
* Registered Participants for Slot 1: 6
* Registered Participants for Slot 2: 2
* Registered Participants for Slot 3: 2
*
* Participant 1 Name: Tom Jones
* Participant 2 Name: Katy Perry
*
*
*
*/
// Hint: An example is provided for you (London.txt)
// in bin / debug folder
// The example shows the structure you should read data in
static void displayRegisteredParticipants()
{
using (StreamReader sr = new StreamReader("London.txt.txt"))
{
while (sr.Peek() != -1)
{
Console.WriteLine(sr.ReadLine());
}
}
}
// This function has been used to create locations.txt
// You may use this as a reference for writing to file
static void writeOutLocationData()
{
const string sFILENAME = "locations.txt";
string[] sLocations = new string[]{ "London", "Aberdeen", "Glasgow", "Sheffield",
"Sunderland", "Manchester", "Bristol","Belfast", "Cardiff", "Oxford" };
string[] sDates = new string[] { "21 January 2020", "1 February 2020", "10 February
2020",
"01 March 2020","11 March 2020", "01 April 2020", "10 April 2020", "21 April 2020",
"21 May 2020","01 June 2020"};
const int iNUMLOCATIONS = 10;
using (StreamWriter sw = new StreamWriter(sFILENAME))
{
for(int i = 0; i < iNUMLOCATIONS; i++)
{
sw.WriteLine(sLocations[i]);
sw.WriteLine(sDates[i]);
}
}
}
}
}