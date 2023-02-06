# TwitterOExercise

## Solution Steps

:white_check_mark: Get Twitter API working in Postman
  Logon to dev.twitter.  Generate a bearer token, use it as a sanity check to see if you can get any old tweet(s).
  e.g. https://api.twitter.com/2/tweets?ids=1622410145849376768,1622023657370406914

:white_large_square: Get the specific twitter API working in Postman. 
  **"sampled stream endpoint provides a random sample of approximately 1% of the full tweet stream."**

:white_large_square: Get Twitter API working in code

:white_large_square: TBD






## Directions:

```
programming exercise 

No time limit
keep us updated we'll know it’s active. 
 
Overview 
The Twitter API provides a stream endpoint that delivers 1% random sample of Tweets in real-time. 
build an application that utilizes that endpoint
processes incoming tweets to compute statistics.
NET Core or .NET Framework project, 

 
The Twitter API v2 sampled stream endpoint provides a random sample of approximately 1% of the full tweet stream. Your app should consume this sample stream and keep track of the following: 
•	Total number of tweets received  
•	Average tweets per minute 
 
•	provide some way to report these values to a user (periodically log to terminal, return from RESTful web service, etc). 
•	If there are other interesting statistics you’d like to collect, that would be great. 
•	Persist in memory is fine
•	BUT, think about how you would persist data in DB. 
 
•	Don't block stats reporting when processing tweets
•	(your app may receive 57 tweets/second or higher.
•	process tweets as concurrently as possible.
•	think about how you could scale up your app . 
 
•	Use SOLID principles
•	we are looking for patterns that could scale
•	loosely coupled to external systems / dependencies.
•	Some level of error handling
•	Unit testing
 
•	put your project in a repository 
•	send us a link
•	Give provide guidance as to where the Twitter API Token is
•	We may follow-up with an interview session
 
```
 

