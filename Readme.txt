// Program name: ScrewDepot
// Program purpose: Screws personal store
// Program author: Maksym Shatylo
// Date Created: 2022-10-09 745
// Date Finished: 2023-10-13 500

Screw Depot

ScrewDepot website of company which sales a Screws.
I P O Process

Declaring variables of the Screw Parameter
	public int Id 
  	public string Name 
        public string Description
        public string Material  
        public double LengthInMillimeters 
        public double DiameterInMillimeters 
        public decimal Price 
        public int StockQuantity 
        public string Manufacturer {
        public string Rating 


pseudocode - start > Stop

2023/10/09
7:45 - Creating a project in the Visual Studio 19
8:05 -Deleting default code inside Home/Index;
8:10 - Creating a new controller and model with a Screw Context;
8:40: - Creating a SeedData.cs file to fill database with those data;
9:27 - Made migration and created ScrewModelContext;
9:40 - Run the application and check database working with and shows on Screw/Index;
10:00 - Modified _layout.cshtml to add a Product link in Navbar;
10:15 - Added styles.css file to add custom styles on website layout;
10:20 - Changed font to Poppins and changed Navbar colour and body colour;
10:37 - Committed to Github Repos.

Tests:

Test 1 2023/10/09 10:16

Once SeedData added and migration made, ran the project and Tried to delete 2 of 10 files.
Test Done successfully.

Test 2 2023/10/09 10:40

Ran the project and Tried to add 2 new files.
Test Failed. Needed to delete all 10 files first to add new. 
