# Back - End Authorization App Documentation


README 1 : PROJECT OVERVIEW README (Jason)
README 2 : README-Auth.md (Tanner)
README 3 : CODE IMPLEMENTATION README (Rocket)




The Authorization Back end aims to ensure web security, sensitive data security, and facilitate access to user data.

## Getting Started

Getting started the dev was to implement and utilize Auth0 to verify users and individuals who may wish to register and sign up to the website. Our front end team is using React.js and Auth0 pairs nicely with the React framework, however a problem we did
not for see was the sending of inputs from the front end and authorizing those inputs through graphQL on request. Auth0 has a default time-out where every 24 hours when an user is logged in they will be logged out(assuming they did not log out) this will
prompt the front end to consistently query the Auth0 server, for a valid access token, that changes per request. this means we cannot persist the tokens, and we cannot facilitate authorization in .Net Core Currently. 

### Direct issues
- CANNOT use graphQL and a form of authentication through auth0
- MUST validate access token with Auth0 for a x amount of time. reoccurring, every request is different token - no persistence == the idea of renewing the token often increases security immensely
####- It is currently not possible to add a policy to input objects using schema first approach (schema first uses graphQL authorize) dependant! don’t work!
- Cannot send user information over http requests (security vulnerability)

### What we were trying to do first:
Initially the web request response cycle looked like :

Login on front end ->
Req to Auth0 server ->
response to front end  (with user data and access token) ->
back end server ->
Retrieve information per the authorizations ->
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
this ended the implementation of Auth0 where we could not keep the access token persistent long enough to verify the user, and verify the request. this is not a viable solution because hackers can spoof an email and access another users info



# With a newer version of graphQL : 
once graphQL gets a version update 
