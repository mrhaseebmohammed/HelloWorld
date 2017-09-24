Write a ‘Hello World’ program.

a. The program has 1 current business requirement – write “Hello World” to the console/screen.
b. The program should have an API that is separated from the program logic to eventually support mobile applications, web applications, or console applications, or windows services.
c. The program should support future enhancements for writing to a database, console application, etc.
i. Use common design patterns (inheritance, e.g.) to account for these future concerns.
ii. Use configuration files or another industry-standard mechanism for determining where to write the information to.

Write unit tests to support the API.


To run unit tests:
Navigate to the HelloWorldAPITests folder and run in order:
dotnet restore
dotnet build
dotnet run

To run API:
Navigate to the HelloWorldAPI folder and run in order:
dotnet restore
dotnet build
dotnet run

To run console application:
Ensure HelloWorldAPI is running.
Navigate to the HelloWorldConsole folder and run in order:
dotnet restore
dotnet build
dotnet run

To run angular application:
Ensure HelloWorldAPI is running.
Navigate to the HelloWorldAngular folder and run in order:
npm install
npm start
Navigate to localhost:4200 on your machine.
If Chrome blocks api due to different origin, use "Allow-Control-Allow-Origin: *" extension.
Add localhost:5000 to the config of the extension.
