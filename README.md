### _This project is not in a complete or portfolio ready state, and should not be considered representiational of professional work._

# Top Restaurants - Pacific Northwest

### Epicodus Practice Project - Basic Databases

### By Collin Chapman, Theron Packus, Saoud Rana, Salim Mayan

## Technologies Used

* Git
* C#
* .NET 5.0
* ASP.NET Core
* Entity Framework Core
* Razor View Engine
* MVC
* RESTful Routing, CRUD & HTTP
* REPL
* MySQL MySQL Workbench
* Bootstrap

## Description

This is a C# MVC application to keep track of our favorite restaurants in the Pacific Northwest. This application uses two tables inside a schema we called TopRestaurants and it is managed using MySQL Workbench. The One to Many relationship within our database connects our restaurants to a cuisine type. Allowing users to add restaurants, cuisines and details for each to their database. Then organize them based on the cuisine types.


## Setup/Installation Requirements

* _Requires Visual Studio Code Installation_
* _Requires Terminal Installation_
* _Open the terminal on your local machine_
* _Navigate to the directory inside of which you wish to house this project_
* _Clone this project with the following command  `$ git clone <https://github.com/colchapm/TopRestaurants.Solutions.git>`_
* _Next you will need to download and install .NET Core through this link if you don't already have it: https://dotnet.microsoft.com/download_
* _After downloading and installing .NET Core, return to your terminal and navigate to the root directory by entering "cd TopRestaurants.Solutions"_
* _Then navigate to the desired subdirectory of the repository with the command `$ cd TopRestaurants`_
* _Retrieve and install packages listed in the .csproj files with the command `$ dotnet restore`_
* _In your terminal, log into MySQL by executing the command `$ mysql -u[YOUR-USERNAME] -p[YOUR-PASSWORD]`_


* add instruction here for the user to recreate database and tables


* Navigate to the `TopRestaurants` directory and create an **appsettings.json** file and input the following script:

{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-PROJECT-NAME];uid=root;pwd=[YOUR-PASSWORD];"
  }
}



* _Compile and run the application with the command `$ dotnet run`_

## Specificatons


## Known Bugs


## Link

This project is not hosted on GitHub Pages

## License

Copyright (c) 2021 Collin Chapman

This software is licensed under the MIT license

## Contact Information

cchap14@gmail.com