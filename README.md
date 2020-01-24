
---------------------------------
---------------------------------

# Project Dino CMS
---------------------------------
## We are deployed on Azure!
(Coming soon)
[project url here]


---------------------------------
## Web Application
Stores data for each dino that is available in the game - making it available to the players.

---------------------------------

## Tools Used
Microsoft Visual Studio Community 2019

- C#
- ASP.Net Core
- Entity Framework
- MVC
- xUnit
- Bootstrap
- Azure


---------------------------------

## Recent Updates
Initial build

---------------------------

## Getting Started

Clone this repository to your local machine.
```
$ git clone https://github.com/YourRepo/YourProject.git
```
Once downloaded, you can either use the dotnet CLI utilities or Visual Studio 2017 (or greater) to build the web application. The solution file is located in the AmandaFE subdirectory at the root of the repository.
```
cd YourRepo/YourProject
dotnet build
```
The dotnet tools will automatically restore any NuGet dependencies. Before running the application, the provided code-first migration will need to be applied to the SQL server of your choice configured in the /AmandaFE/AmandaFE/appsettings.json file. This requires the Microsoft.EntityFrameworkCore.Tools NuGet package and can be run from the NuGet Package Manager Console:
```
Update-Database
```
Once the database has been created, the application can be run. Options for running and debugging the application using IIS Express or Kestrel are provided within Visual Studio. From the command line, the following will start an instance of the Kestrel server to host the application:
```
cd YourRepo/YourProject
dotnet run
```
Unit testing is included in the AmandaFE/FrontendTesting project using the xUnit test framework. Tests have been provided for models, view models, controllers, and utility classes for the application.

---------------------------------

## Usage


### Overview of Recent Posts
![Home](/Scaffold-CMS/Data/Readme/Home.JPG)

### Creating a Post
![Post Creation](/Scaffold-CMS/Data/Readme/Create.JPG)

### Enriching a Post
![Enriching Post](/Scaffold-CMS/Data/Readme/DIndex.JPG)

### Viewing Post Details
![Details of Post](/Scaffold-CMS/Data/Readme/Details.JPG)

---------------------------
## Data Flow (Frontend, Backend, REST API)
***[Add a clean and clear explanation of what the data flow is. Walk me through it.]***
![Data Flow Diagram](/assets/img/Flowchart.png)

---------------------------
## Data Model

### Overall Project Schema
***[Add a description of your DB schema. Explain the relationships to me.]***
![Database Schema](/assets/img/ERD.png)

---------------------------
## Model Properties and Requirements


---------------------------

## Change Log
1.0: Launch (to come)
1.1: CRUD Works

------------------------------

## Authors
Tanner Percival

------------------------------

