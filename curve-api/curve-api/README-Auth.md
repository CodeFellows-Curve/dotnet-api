#GOALS for the auth team

utilize OAuth for google and github through Auth0 (Library of OAuth providers) to quickly and seamlessly allow users to register and use the site as inteded. a couple of things to keep in mind about Auth0 is that there is a default and mandatory 
timeout for the access token where a new one is generated on login or register. this means that the access token is not persistant and becomes very difficult to validate. 

# Back - End Authorization App Documentation


README 1 : PROJECT OVERVIEW README (Jason)
README 2 : README-Auth.md (Tanner)
README 3 : CODE IMPLEMENTATION README (Rocket)




The Authorization Back end aims to ensure web security, sensitive data security, and facilitate access to user data.

## Getting Started

Getting started the dev was to implement and utilize Auth0 to verify users and individuals who may wish to register and sign up to the website. Our front end team is using React.js and Auth0 pairs nicely with the React framework, however a problem we did
not for see was the sending of inputs from the front end and authorizing those inputs through graphQL on request. 
Auth0 has a default time-out where every 24 hours when an user is logged in they will be logged out(assuming they did not log out) this will
prompt the front end to consistently query the Auth0 server, for a valid access token, that changes per request.
this means we cannot persist the tokens, and we cannot facilitate authorization in .Net Core Currently. 

### Direct issues

[image of known solution proof on github ](assets/GithubKnownIssue.JPG)
see https://github.com/graphql-dotnet/authorization
- CANNOT use graphQL and a form of authentication through auth0
- MUST validate access token with Auth0 for a x amount of time. reoccurring, every request is different token - no persistence == the idea of renewing the token often increases security immensely


### Direct solutions
- Don't use graphQL with authentication
- Don't use gatsby with graphQL
- use seperate routing for OAuth instead of using Auth0 to mitigate the whole thing
####- It is currently not possible to add a policy to input objects using schema first approach (schema first uses graphQL authorize) dependant! don’t work!
- Cannot send user information over http requests (security vulnerability)

### What we were trying to do first:

Initially the web request response cycle looked like :

Login on front end ->
Req to Auth0 server ->
response to front end  (with user data (Email) and access token) ->
back end server ->
Retrieve information per the authorizations and email and token ->
render data on front end


Our issues began on step one, if we have the user login on the front end then user sensitive data needs to be sent back to the back end. 
there was a lot of issues with this possible implementation but the biggest was the amount of time it would take to have 3 
different servers (Auth0, Front end, back end) need to make 3 requests per single request from user. this is bad practice and was not the best solution.

### What we were trying to do Second:

after refactoring keeping the issues in mind we decided on a new web request response cycle:

Click of button on front end ->
redirect to action - a page hosted on the back end, and handles all of the Auth 0 logic ->
pass/fail ok/not Okay (success or fail) -> front end
request for data (with role information from access token that is parsed) ->
back end responds with data -> front end
render page


currently with the most up to date versioning of graphQL, It is currently not possible to add a policy to input objects using schema first approach, which is the implementation that is required in order to integrate graphQL with the back end.
this ended the implementation of Auth0 where we could not keep the access token persistent long enough to verify the user, and verify the request. this is not a viable solution because hackers can spoof an email and access another users data


### What we are doing now:

we have decided to use the framwork to aid in authorization as not much else plays nice with graphQL, so on registration we will be using claim based policies to tell the front end what a user can or cannot do. this implementation did not end up how we 
wanted, we would also like to implement OAuth for github.
# With a newer version of graphQL : 

once graphQL gets a version update retry the implementation

[image of known solution proof on github ](assets/MediumBlog.JPG)
https://medium.com/volosoft/building-graphql-apis-with-asp-net-core-419b32a5305b
