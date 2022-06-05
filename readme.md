> This is an api that supports creating, reading, updating and deleting data... 

The API that is being made will be able to manage books, using endpoints there will be: 
1. **GET**`/api/SuperHero` - Get all super heros 
2. **GET**`/api/SuperHero/{id}` - Get a super hero by id 
3. **POST**`/api/SuperHero` - insert a new super hero 
4. **PUT**`/api/SuperHero/{id}` - Update a super hero 
5. **DELETE** `/api/SuperHero/{id}` - Delete a super hero 


**Requirements**
- Visual Studio 2019 
- .NET 5 SDK 
- sql express 

**visual studio packages**

* in order to use SQL express you need to install the package within visual studio 
1. Go to the **Package Manager Console**
2. install by typing ```dotnet tool install --global dotnet-ef```
