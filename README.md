<br>

![alt text](https://github.com/CodeFellows-Curve/project-resources/blob/master/assets/logoSnip.JPG)
# Curve: Repository Name

## DESCRIPTION

### Contributors
<details>
  <summary><b>Integrations Team Liaisons</b></summary>
  <ul>
    <li>Jason Burns, Authentication Liaison (https://github.com/jasonb315)</li>
    <li>Andrew Curtis, GraphQL API Liaison (https://github.com/amjcurtis)</li>
  </ul>
</details>
<details>
  <summary><b>Authentication Team</b></summary>
  <ul>
    <li>Tanner Percival, Lead Developer (https://github.com/Tanner253)</li>
    <li>Andrew Roska, Developer (https://github.com/Roketsu86)</li>
    <li>Ben Taylor, Developer (https://github.com/BenSTay)</li>
  </ul>
</details>
<details>
  <summary><b>GraphQL Team</b></summary>
  <ul>
    <li>Daniel Logerstedt, Lead Developer (https://github.com/daniellogerstedt)</li>
    <li>Ian Gifford, Developer (https://github.com/IanGifford261)</li>
    <li>Michael Kelly, Developer (https://github.com/Michael-S-Kelly)</li>
    <li>Christopher Morton, Developer (https://github.com/cmorto02)</li>
  </ul>
</details>

#### Authentication Team Goal
Utilize OAuth for Google and GitHub through Auth0 (Library of OAuth providers) to quickly and seamlessly allow users to register and use the site as intended. Note that with Auth0 there is a default and mandatory 
timeout for the access token where a new one is generated on login or register. This means that the access token is not persistant and so is challenging to validate.

#### GraphQL Team Goal
Build a responsive GraphQL API endpoint that has the ability to perform full CRUD operations with an attached database for storing professional competency reviews and comments based on the list of core competencies.

## Repo Purpose

Authentication and GraphQL API server, and database code for the back-end portion of the Curve app prototype.

## Client Requirements

Use Auth0
Use GraphQL
Utilize multiple user roles
Maximize security

## Deployment Link

The API is deployed on Azure: https://cfcurve.azurewebsites.net/graphql

## Frameworks and Tools Used

ASP.NET Core 
GraphQL
JWT
Auth0
Entity Framework
SQL Server
Swagger docs

#### Rationale for For Tool/Technology Choice

We chose to use Auth0 was because the client wanted the app to implement OAuth to allow multiple login services, and Auth0 handles the requests and responses of verification 
securely. We utilize a controller to handle the actions to and from Auth0 and a model to store the proper data to authenticate the user.

GraphQL was chosen for use in building the API because it was a hard requirement of the client. It was decided this would be used by the client because it allows dynamic and quick loading of data from the database that isn't restricted to a specific shape or type.

## Getting Started
Clone this repository to your local machine.
```
$ git clone https://github.com/CodeFellows-Curve/dotnet-api.git
```
#### To run the program from Visual Studio:
1. Select ```File``` -> ```Open``` -> ```Project/Solution```

2. Next navigate to the location you cloned the Repository.

3. Double click on the ```dotnet-api``` directory.

4. Then select and open ```curve-api.sln ```

5. Click the IIS Express button at the top.

#### Testing
1. Follow steps 1 - 4 of running.

2. Click ```Test``` menu

3. Select ```Run All Tests```

## UML

#### Backend UML
![Backend UML](./assets/BackendUML.png)


#### 5-Way Handshake UML
![5-Way Handshake](https://github.com/CodeFellows-Curve/dotnet-api/blob/pre-staging/assets/5wayhandshakeuml.png)

## Process flow

#### Auth Team
0900-0915: Debrief, assign work for the day 
1000-1015: Meeting of all Curve project teams and clients
1100-1115: Standup meeting to sync with project manager and Integrations team
1600-1630 PM : Standup to sync and do daily retro

<details>
  <summary><b>GraphQL Team Schedule</b></summary>
    <ul>
      <li>0900-0915: Meet up for internal team plan of the day.</li>
      <li>1030-1045: Standup meeting.</li>
      <li>1100-1130: Team leadership meeting.</li>
      <li>1200-1300: Break for lunch as needed.</li>
      <li>1300-1600: Work with other teams.</li>
      <li>1600-1630: Standup meeting.</li>
      <li>1630-1700: Work with other teams.</li>
      <li>1700-1730: Scrum of Scrums.</li>
      <li>1730-1800: End of day wrap up work.</li>
  </ul>
</details>

## Current functionality

The front end handles retrieval of the token and the authentication of a user.

#### GraphQL

The GraphQL endpoint can currently receive queries to GET, POST, and PUT data as requested.

## Known bugs 

#### Existing limitations, etc
* Cannot send user information over http requests (security vulnerability)
* CANNOT use GraphQL and a form of authentication through Auth0
* MUST validate access token with Auth0 at frequent intervals due to automatic token timeout. Every request generates a different token, so persistence is difficult to manage, though the necessity of renewing the token so often does offer a security advantage.

## Tasks remaining 

* Adding more roles to facilitate more or less accessibility per user.
* If we were not using GraphQL or this project was in one repo most of the issues would be solved more easily.

#### TODOs

Increase security for authorization for the data access from the front end

##### GraphQL Team

* Implement a return for delete functionality to prevent errors in GraphiQL and verify delete is properly completed
* More in-depth testing of GraphQL endpoint
* Build side-by-side REST API?
* Implement more policy controls and security

## Recommendations for future development

Look into GraphQL Resource #2 thoroughly (see below).

## Docs Referenced (links)

* [Auth Resource #1:](https://auth0.com/docs)
* [Auth Resource #2:](https://auth0.com/docs/quickstart/backend/aspnet-core-webapi)
* [GraphQL Resource #1](https://graphql-dotnet.github.io/docs/getting-started/introduction/)
* [GraphQL Resource #2](https://medium.com/volosoft/building-graphql-apis-with-asp-net-core-419b32a5305b)

<!-- ##### SUB HEADERS -->
<!--
 xof nworb kciuq eht xof nworb kciuq eht xof nworb kciuq eht xof nworb kciuq eht xof nworb kciuq eht xof nworb kciuq eht xof nworb kciuq eht xof nworb kciuq eht xof nworb kciuq eht xof nworb kciuq eht xof nworb kciuq eht xof nworb kciuq eht xof nworb kciuq eht 
-->
***

# RAW DOCUMENTATION FOR AUTH - PLEASE READ!
https://github.com/CodeFellows-Curve/dotnet-api/blob/pre-staging/curve-api/curve-api/README-Auth.md


<!-- Lengthy lists of things? Use: -->
<!--
<details>
  <summary><b>List Title</b></summary>
    <ul>
      <li></li>
      <li></li>
      <li></li>
      <li></li>
    </ul>
</details>
 -->

<!-- Endpoints? Methods? Arguments? Can use: -->
<!-- 
| Method | Use | Big O Time | Big O Space | IN | OUT |
| :----------- | :----------- | :-------------: | :-------------: | :-----------: | :-----------: |
| Method | desc | O(n) | O(n) | DICT | LIST |
 -->

------------------------------
