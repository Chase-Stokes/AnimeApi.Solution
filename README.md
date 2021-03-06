#### _Anime API_

## Technologies Used

* C#
* html
* Markdown
* CSS
* Razor
* LINQ
* Entity
* Entity Framework Core
* ASP .NET Core
* ASP .NET Core MVC
* ASP .Net Core Identity
* ASP .Net 5.0 CLI

## Description

__

## Setup/Installation Requirements
  
1. Follow the instruction on this [website](https://www.simplilearn.com/tutorials/mysql-tutorial/mysql-workbench-installation) for installing MySQL server, MySQL Workbench, and MySQL shell.  
2. Clone the repository to your desktop and open your terminal then Navigate to the downloaded project by typing "cd (project-name)"
3.  Open project in your desired text editor. I recommend [visual studio code.](https://code.visualstudio.com/download)
4. Add a new file called `appsettings.json` in the project's production folder and store the following
        `{
            "ConnectionStrings": {
                "DefaultConnection": "Server=localhost;Port=3306;database=[NAME-OF-THE-DATABASE-YOU-CREATED-ABOVE];uid=root;pwd=[YOUR-PASSWORD-HERE];"
            }
        }`
5. Create your own database by following these steps: 
  
    1. Navigate to the AnimeApi folder
    2. Type "dotnet restore" in Terminal then hit enter
    3. Enter "dotnet build" to Terminal
    4. Type "dotnet ef migrations add InitialCreate" followed by enter
    5. Type "dotnet ef database update" then hit enter    
6. Once in the project's production folder, type "dotnet watch run" in the terminal - then navigate to your web browser and type http://localhost:5000/ in your url bar to see the application.
  
## Known Bugs

* No known bugs at this time.

## License

MIT License

Copyright (c) [2022] [Mikah Mathews](https://github.com/mikah-mathews) [Chase Stokes](https://github.com/Chase-Stokes)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.