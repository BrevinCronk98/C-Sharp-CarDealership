# **Car DealerShip**

#### Author: **_Brevin Cronk_**
#### May 18th, 2020



### Description

_The purpose of this project is to create a C# web application using the .NET Core framework.

### Instructions for use:

1. Open Terminal (macOS) or PowerShell (Windows)
2. To download the project directory to your desktop enter the following commands:
```
cd Desktop
git clone https://github.com/BrevinCronk98/C-Sharp-ToDoList
cd C-Sharp-ToDoList(or the file name you created for the main directory of the download)
```
3. To view the downloaded files, open them in a text editor or IDE of your choice.
* if you have VSCode for example, when your terminal is within the main project directory you can open all of the files with the command:
```
code .
```
4. Create a file within the Blockbuster folder named appsettings.json.
5. Add the following code:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list;uid=root;pwd=YOURMYSQLPASSWORDHERE;"
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
CREATE DATABASE `blockbuster`;

USE `to_do_list`;

CREATE TABLE `items` (
  `ItemId` int(11) NOT NULL AUTO_INCREMENT,
  `Description` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ItemId`)
);

CREATE TABLE `categories` (
  `CategoryId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`CategoryId`)
);

```

4. Press the lightning bolt button to run this command.
5. If the database does not appear, right click in the schemas bar and select Refresh All.

### Known Bugs

No bugs have been identified at the time of this update.

### Support and Contact Information

Please contact me with any suggestions or questions at cronkbrevin98@gmail.com Thank you for your input!  

### Technologies Used

* C#
* `ASP.NET` Core
* `ASP.NET` Core MVC
* Entity Framework Core
* `ASP.NET` Core Identity
* MySQL
* Git and GitHub

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **User enters home page** | User Input:"URL: localhost:5000/" | Output: “Welcome!” |
| **User can navigate to a page that lists categories** | User Input:"Click: View Categories" | Output: “Chores, Groceries” |
| **If no categories have been added a message appears** | User Input:"Click: View Categories" | Output: “You have no categories listed! Add a few.” |
| **User can navigate to an add categories page** | User Input:"Click: Add Category" | Output: “Create a new category.” |
| **User can click on categories to view their details and items** | User Input:"Click:Chores" | Output: “Dishes, Walk the Dog” |
| **If no items have been added a message appears** | User Input:"Click: View Items " | Output: “You have no items listed.” |
| **User can navigate to a create new items page for each category** | User Input:"Click: Chores Click: Add Item" | Output: “Item Form" |
| **Usercan add a new item for each category** | User Input:"Description: Do Dishes | Output: “Chores: Do Dishes” |
| **User can delete a Category** | User Input:"Click: Delete Category" | Output: “You have removed this Category!” |
| **User can delete a Item** | User Input:"Click: Delete item" | Output: “You have removed this item!” |


<!-- &#9745; -->

### Resources
Microsoft Docs


#### License

This software is licensed under the MIT license.

Copyright © 2020 **_Brevin Cronk_**
