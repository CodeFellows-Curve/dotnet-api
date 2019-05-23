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

### What we tried to do Third:
we have decided to use the framework to aid in authorization as not much else plays nice with graphQL, so on registration we will be using claim based policies to tell the front end what a user can or cannot do. this implementation did not end up how we 
wanted, we would also like to implement OAuth for github. - 3 hours later - turns out the current versioning of .NET core does not support the injection of header information from one domain to a completely separate domain. this becomes a problem because the front end need to
receive information about the role status of the given user and the visual and data access that they each individually have. this threw a wrench in all of the team's plans. This requires a full UML rework that we have come to and agreed on 
with the rest of the team (listed next)

button click front end ->
razor page back end login and register (custom form) ->
register user, and capture claims and assign role ->
SEND TO FRONT END ON A POST (PROBLEMS: Cannot just post to a url without it expecting a response, there can be no coordinated request from the front end to our back end because the user is on the back end login form.) not being able to send the data back to the front end is really what
the main problem with the attempted implementation. ->
front end dictates what the user can and cannot do in the application.

# With a newer version of graphQL : 
once graphQL gets a version update retry the implementation

[image of known solution proof on github ](assets/MediumBlog.JPG)
https://medium.com/volosoft/building-graphql-apis-with-asp-net-core-419b32a5305b

##Current plan of attack:

With this implementation attempt we have gone back to implementing Autho0, where as our problem with our previous implementation was that the access token was not persistent across logins and the Timeout timer of 24 hours (mandatory) which made authenticating each user that signs in close to impossible
across multiple tables. to mitigate this issue we will receive an access token from the first request to Auth0 (front end) and that access token will be sent to the back end on a request for information, on that request the back end will sinde the current access token to Auth0 where we will receive a 
confirmation on the back end or a unsuccessful attempt. given that the attempt is successful we will override the access token in the database with a private api key from a key generator that is implemented. this hashed and salted key will grant higher security on the GraphQL api requests, than if there was 
ono private access key per user. This overwritten token wil be sent back to front end along with the user role information. When the NEW access token is assigned the user and the key will be added to the graphQL database (signaling that the request is a valid user and is authenticated) where the user can request
from the graphQL database, to retrieve user data for themselves (user) or all users (superUser) passing in the assigned key to validate that the request is trusted and verified. 

Front end click login button ->
show model submit ->
request to Auth0 to authenticate the user ->
parse response and retrieve access token ->
send access token to the user api ->
validate access token with Auth0 ->
override access token with the hash and salt method (bad practice but necessary to get a application functioning) ->
send access token to GraphQL database for registry ->
Send role and new access token to front end ->
front end requests data from the GraphQL database passing along the new access token to validate the requesting user ->
if succeed send data


This current implementation is not the best route, first off we are no longer using identity so that means that we do not have access to their built in hashing methods so we needed to implement our own hash and salt (to mimic an api key).
it is bad practice to implement your OWN hash and salt as any algorithm created by a human can be cracked by a human which means there are vulnerabilities in the application.

This was our last idea, and our final chance to implement auth into the application where it meets the clients given requests. The trickiest part hypothetically is validating the queries sent to the GraphQL side with the integrated GraphQL User class which  takes care of some of the issues.


#Things that went well
- The Auth teams dynamic worked very well for an efficient and organized work flow where Andrew Roska was our star research teammate who was always finding the most up to date and relevant information to what we were trying to do at the given time.
- Collaborating with the 3 other teams was a challenge and really fun. being able to negotiate plans and pre solve blockers by coming together to make sure the front and back mesh properly. 
on day 2 the Auth team and the front end team collaborated for a 2 - 3 hour session where we laid out many issues,
fixed many issues, and came to what we thought at the time a working solution that we all agreed on. 
even though the implementation did not work the process of working together from several different perspectives really made the difference. As a large group we were able to come up with new ideas, 
and troubleshoot and debug faster and more efficiently.
- Documented the whole journey
- Stayed flexible. The auth team never got backed into a corner and never burned down any bridges, our team has come full circle. This really showed how powerful the Auth team was and how prepared we were for necessary pivots or reworks to connect with the other teams AND meet our clients
desires for authentication and role management.
- There is currently no working locked down implementation of the request the client gave to us regarding the requesting and sending of data from two different domains for authentication with GraphQL Which means that our Auth team was literally pioneering a new technology on its own. .NET 
Core does not support the sending of data from domain to domain for authentication, and it is suggested that when this is required to use OAuth as it was intended for this purpose. Knowing this i can confidently say that we are happy with our progress and troubleshooting skills and wonder how we can 
be the pioneers of this new technology in .NET Core (there are ways to work around this need but the work arounds are not industry standard, it would be nice to make a developer tool that was industry standard to maybe solve this problem in the future and make authentication with GraphQL a more enjoyable experience.)

#Things that did not go well
- Testing was neglected due to the 5 pivots the Auth team had to make. 
- The assigned and desired technology use simply did not work out with the authentication service. we ran into countless issues with graphQL and authentication
- We were able to push through but the constant implementation attempt with no success was morally defeating however we pulled through the end and was able to provide a viable authentication for a prototype application for the user.

#What could have made the experience more successful?
If all of the teams had more time to figure out what was required a day or even a few days ahead of the schedule that we were at we could have snuffed out a lot of these authentication issues just by talking about
database structure, what requests might look like, and what is required of each team.
Another thing that would have changed the progress of this application was if there was slightly more guidance for the project and for each team specifically. there was little to no organization and little to no time and
both of those factors combine to make a challenging implementation. If there was slightly more guidance and how the clients wanted us to use the technologies in more depth, issues would have came up sooner, and an agreed
plan of attack would have been uniform across the teams. This all being said All of the teams did a great job collaborating and quickly finding their responsibilities and 
effectively practicing AGILE SCRUM but rather than it being over the course of several weeks or months it all happened over a period of 3 days. This feat in its own is extremely impressive and something to be, and are proud of.
Creating this project has not been easy for any team, but the collaboration across teams through the integration team, and team leaders was nearly seamless and perfect. There was a lot of running around to keep everyone on track 
but in the end our work flow was efficient and the whole experience was fun, and valuable.

#If we could change this applications : 
Right off the bat if we had full control of the application structure, we would not have used GraphQL in pair with Authentication, that being said an even easier solution would be to combine both repositories into one solution, 
where database queries can take place in-house of the application, eliminating the need for a persistent access token or a header with given values in it, across domains. Just having the authentication and back end team 
in the front end repository would have made most of the difference.
Another thing to note is the fact that Authentication should have been completely handled on the front end of the application rather than the back end of the application. the reason we could not do this is that the front end of the application
was written in Gatsby.js which we do not know. But again all of these issues are easily solved with having the whole application in one repository eliminating the need for security risk requests and responses.

