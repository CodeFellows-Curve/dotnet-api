<br>

![alt text](https://github.com/CodeFellows-Curve/project-resources/blob/master/assets/logoSnip.JPG)
# Curve: Repository Name

## DESCRIPTION

<details>
  <summary><b>Contributers</b></summary>
    <ul>
      <li>Tanner Percival</li>
      <li>Andrew Roska</li>
      <li>Ben Taylor</li>
    </ul>
</details>


utilize OAuth for google and github through Auth0 (Library of OAuth providers) to quickly and seamlessly allow users to register and use the site as inteded. a couple of things to keep in mind about Auth0 is that there is a default and mandatory 
timeout for the access token where a new one is generated on login or register. this means that the access token is not persistant and becomes very difficult to validate. 


##### SUB HEADERS


## Repo Purpose

Handle authentication for the front end to access the back end

## Client Requirements


Use Auth0
Use GraphQL
Use multiple roles
maximize security

## Deployment Link


* [Here's a link](http://someurl.link)


## Frameworks and Tools Used

.NET Core 
MVC
JWT
Auth0
SQL

#### And Rational for that choice

The reason we chose to use Auth0 was because the client wanted the ability to OAuth with multiple different services, and Auth0 handles the requests and responses of verification 
securely. We are utilizing a controller to handle the actions to and from Auth0 and a model to store the proper data to verify the user

## UML

![a-neat-pic](http://someurl.link)


## Process flow


9 AM : Meet up and deligate work for the day 
10 AM: Team meeting (usually resulted in a pivot)
11  PM: Stand up and sync (soetimes a pivot)
4 PM : Stand up to sync with the other teams

## Current functionality

The current functionality is that the front end will handle the retriveal of the token and the authentication of a user.

## Known bugs 

#### Existing limitations, etc
Cannot send user information over http requests (security vulnerability)
- CANNOT use graphQL and a form of authentication through auth0
- MUST validate access token with Auth0 for a x amount of time. reoccurring, every request is different token - no persistence == the idea of renewing the token often increases security immensely


## Tasks remaining 

Adding more roles to facilitate more or less accessibility per user.
If we were not using GraphQL or this project was in one repo most of the issues are solved

#### TODOs


increase security for authorization for the data retrieval for the front end

## Recomendations for future development


look into this doc
[image of known solution proof on github ](assets/MediumBlog.JPG)
https://medium.com/volosoft/building-graphql-apis-with-asp-net-core-419b32a5305b

Explains what our problem is and why it exists.
## Docs Referenced (links)


* [Here's a link](http://someurl.link)
* [And another link](http://someurl.link)



<!-- ##### SUB HEADERS -->
<!--
 xof nworb kciuq eht xof nworb kciuq eht xof nworb kciuq eht xof nworb kciuq eht xof nworb kciuq eht xof nworb kciuq eht xof nworb kciuq eht xof nworb kciuq eht xof nworb kciuq eht xof nworb kciuq eht xof nworb kciuq eht xof nworb kciuq eht xof nworb kciuq eht 
-->
***

footnotes
# RAW DOCUMENTATION PLEASE READ!
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