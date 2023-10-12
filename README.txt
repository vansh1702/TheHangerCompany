Author : Vansh
Date: 2023-10-12  1459  
Created a default asp.net core mvc web app but as I got the hanger so i cahnged it accordingly
Kept a TheHangerCompany as its name
Using ASP.Net Core 3.1 (out of support)
No authentication
HTTPS on by default

Tested https os not available....
tweaked the properties > launchsettings.json .... coomented out the Line 7
      //"sslPort": 44365     as i m using college computers

Then we have to add the controller by going to the controller folder and named it as TheHangerCompanyController
Adding in the public method for ccertain output
Testing it by using the domain https://localhost:portnumber/TheHangerCompanyapp.UseEndpoints(endpoints =>
Then routing method is set in configure method in Startup.cs file 
using pattern: "{controller=Home}/{action=Index}/{id?}"); for output

tested it using the domain https://localhost:{PORT}/TheHangerCompany/Welcome
got the output 

Commented out the previous code in TheHangerCompanyController.cs
and changed the code for another output

Then putting in the certain parameters to check the code by using the domain 
https://localhost:{PORT}/HelloWorld/Welcome?name=Rick&numtimes=4
Got the desired output

Again commented out the code so can make the changes in TheHangerCompanyController.cs
Tested it http://localhost:42400/TheHangerCompany/Welcome/3?name=Rick  
got the output

Now we have to replace Welcome method by going to Startup.cs

Adding a view
Going to TheHangercompanyController.cs to replace the Index method 
Created a new folder in views folder and named it as TheHangerCompany
In that folder created razorview and named as Index.cshtml
Made changes in Views/TheHangerCompany/Index.cshtml
Run the http://localhost:42400/TheHangerCompany  got the desired output

Going to Views/Shared/_Layout.cshtml and made changes in the code
asp-controller="Hangers" rest the code was set to default
Check the Views/_ViewStart.cshtml file
Open the Views/HelloWorld/Index.cshtml view file and change the h2
Save and checked if it works, working fine 
Go to controller/TheHangerCompanyController and make changes to it 
First we need to add new Welcome.cshtml to views folder
after that we'll create a loop in the Welcome.cshtml so it shows the num times whenever we opens the page  in Views/TheHangerCompany/Welcome.cshtml
checked using http://localhost:42400/TheHangerCompany/Welcome?name=Rick&numtimes=11111111111111111111111111111111111111111111111111111111111111111111111111111
Got 1 as its set to default

Add a model data class
Models folder > Add > Class. Name the file Hanger.cs

Then installed the Then installed Microsoft.EntityFrameworkCore.SqlServer  version 3.1.0
Add a Data/TheHangerCompanyContext.cs, made changes to the code
Added the code in Startup.cs and made changes in the code
Adding a connection string to the appsettings.json file and made changes accordingly
 Added > New Scaffolded Item in controllers folder, item successfully added 
then in the PMC , run the commands
Add-Migration InitialCreate
Update-Database

