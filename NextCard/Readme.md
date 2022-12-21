# NEXT CARD
## Video Demo:  <URL HERE>
### Description:
Loop scheduling has made an impact in my life and I wish there was an app for it, so I started one. 
We are more likely to succeed in our tasks and reduce the stress around them if we have a flexible management system for them. 
The idea is to loop through your list of tasks, instead of assigning particular tasks to particular times or days.
This works particularly well for routine tasks like housework that need to be completed over and over again. 
Rather than a set schedule like Monday = dishes, Tuesday = vacuum, you can complete tasks in a loop whenever you have time to do the next thing.

Some days we can't get anything extra done, and some days we could do a dozen things! Plus this way your brain never has to track anything or worry about the to-do list being a mile long. 
Just check whatever card is next, do it, and flip to the next card.

I chose to highlight weight lifting exercises because it has an impact in my own life right now. I want to be able to get any sets in whenever I have time, so being able to just look at a card and do that exercise without having to think, plan, prep, etc, is a great tool!

You can read more about loop scheduling [here](https://en.wikipedia.org/wiki/Loop_scheduling)

or [here](https://pambarnhill.com/loop-scheduling)


### Files:

#### Controllers:
I chose to create a solution in Visual Studio using .net 6 MVC because I like the architecture

##### HomeController.cs
This is currently my main function. I had & have bigger ideas for this, and will continue developing it, so there are other 
controllers. The HomeController has some commented out code that includes methods to return an ordered next card or a random 
next card, this is functionality I will work on as I intend to get this set up with a database and get it on android & apple 
markets. Commented out code also includes a private static list that was part of my development as I navigated challenges. 
That list is now a list with a private get with a public set in CardList.cs

##### HomeCareController.cs
This will get used in the future when List type options include housework. It currently includes a static list of these tasks.
##### ExercisesController.cs

##### SelfCareController.cs

#### Models:

##### Card.cs
This is somewhat of a template to be set currently by the CardList.cs Model and will in the future be able to be set by 
user input and stored in a new Card.cs or CardList.cs model object so that it can be used in a view.

##### CardList.cs
I made this class as a static list, as I don't currently have a database set up. This has a private get with a public set. 
During part of my development, I had this as a private static list inside my HomeController. 

#### Services:

##### NextCardService.cs
This will shine when I connect to a database and can allow users 

#### Views:

##### About.cshtml
Info about the idea, the function, and an example of a card. Most of this info is included in the readme.

##### Index.cshtml
This is the landing page. You are welcomed and given a card to "click for your first next card"

##### Card.cshtml
This is the meat of it. It gives the user the view of their card, using the Card.cs Model

##### Shared._Favicon.cshtml
I just like using favicons



TODO namespace;
cshtml
video