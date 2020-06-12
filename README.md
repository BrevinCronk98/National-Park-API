# _National Park API_

#### _This is a web API, I constructed using C#, Entity FrameworkCore, and .NET Core" June 12th, 2020_

#### By Brevin Cronk

## Description
#### The Purpose of this repository was to demonstrate my understanding of how to construct an API. I built a National Park API where users can make API calls that return data from a database containing information on Nation Parks.

### Instructions for use:

1. Open Terminal (macOS) or PowerShell (Windows)
2. To download the project directory to your desktop enter the following commands:
```
cd Desktop
git clone https://github.com/BrevinCronk98/
cd NationalParkAPI (or the file name you created for the main directory of the download)
```
3. To view the downloaded files, open them in a text editor or IDE of your choice.
* if you have VSCode for example, when your terminal is within the main project directory you can open all of the files with the command:
```
code .
```
4. Locate the file named appsettings.json in the root directory of the project(NationalParkAPI).
5. Add the following code:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=national_park;uid=root;pwd=PutYourSQLPASSWORDHERE;"
  }
}
```
* Make any other changes needed if you have an alternative server, port, or uid selected. These are the default settings.

5. If you need to install the REPL dotnet script enter the following command in your terminal: 
```
dotnet tool install -g dotnet-script
```
6. To install the necessary dependencies and start a local host, after replicating the database steps below run the following commands:
```
dotnet restore
dotnet build
dotnet run
```

#### If you need to install and configure MySQL:
1. Download the MySQL Community Server DMG file [here](https://dev.mysql.com/downloads/file/?id=484914) with the "No thanks, just start my download" link.
2. On the configuration page of the installer select the following options:
* Use legacy password encryption
* Set your password
3. Open the terminal and enter the command:
*'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile
4. Download the MySQL Workbench DMG file [here](https://dev.mysql.com/downloads/file/?id=484391)
5. Open Local Instance 3306 with the password you set.

#### To create a local version of the database:
1. Open MySQL Workbench and Local Instance 3306.
2. Select the SQL + button in the top left of the navigation bar.
3. Paste the following in the query section to create the database:

```
CREATE DATABASE `national_park`;

USE `national_park`;

CREATE TABLE `parks` (
  `ParkId` int(11) NOT NULL AUTO_INCREMENT,
  `Description` varchar(255) DEFAULT NULL,
  `ParkFlora` varchar(255) DEFAULT NULL,
  `ParkFauna` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ParkId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

```

4. Press the lightning bolt button to run this command.
5. If the database does not appear, right click in the schemas bar and select Refresh All.
atch run" if You Plan on Modifying Project. 




## Known Bugs
#### There are no Known Bugs Yet


## Specifications:

#### User Can See List of All Parks
* Input: "/api/NationalParks"
* Output: "YellowStone, Mt. Rainer NP"

#### User Can Search Based on Park ID
* Input: "/api/NationalParks/#"
* Output: "YellowStone"

#### User can Delete using API
* Input "/api/NationalPark/3"
* Output "You have successfully deleted park bearing this ID"

#### User can Update using API
* Input: "api/NationalParks/3"
* Output: "YellowStone has been updated"

#### User can Post using API
* Input: "api/NationalParks/31"
* Output: "Thanks for adding Yellowstone has been updated"


## Technologies Used
* MySQL Workbench
* C#
* .NET Core
* Visual Studio Code
* Entity Framework

### License
This software is licensed under the MIT license.


Copyright (c) 2020 **_Brevin Cronk_**
