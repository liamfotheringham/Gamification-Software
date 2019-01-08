# Cyber Safe Kids
Cyber Safe Kids is an educational piece of gamification software that aims to teach young children of the dangers from being online.

This software is designed to be used in a School Environment. Users must login to the system initially, so they can be verified.

There is two kinds of system users, regular users and admins. Regular users can use all of the functionalities, play the game, view the highscores. Admins have the ability to maintain the application, by being able to add, delete and update questions within the database.

## Installation Requirements
* Relevent SQL Tables (Available through repository)

* Add connection string for each .cs (Connection function near top of each relevent namespace)

![alt text](https://github.com/liamfotheringham/Gamification-Software/blob/master/ReadMeImages/cfd214b691c0af7d2c7e2ed651155339.png)

# User Guide
## Login
![alt text](https://github.com/liamfotheringham/Gamification-Software/blob/master/ReadMeImages/Login.png)

When the player loads the application, they will be met with the login menu.

In order to play the game, they will need to have a Username and Password.

Enter the Username and Password into the correct boxes and click the *Login* button.

Clicking the *Exit* button will close the application.

###### Note: Usernames and Passwords should be given to players before they can play the game.

## Main Menu
![alt text](https://github.com/liamfotheringham/Gamification-Software/blob/master/ReadMeImages/Menu.png)

After logging in, the player should be met with the main menu. This is where you can select where you wish to go. These options are; *Play Game*, *Highscores*, *Logout* and *Admin*. 

**Play Game:** This will start the game

**Highscores:** This will show the Highscores table

**Logout:** This will log the player out of the application

**Admin:** This will show the Admin Panel

###### Note: The Admin will button will only appear when logged in as an admin user

## Game
![alt text](https://github.com/liamfotheringham/Gamification-Software/blob/master/ReadMeImages/Game.png)

At the beginning of the Game you will be met with a Question. In order to answer the Question, click one of the choice boxes allocated at the bottom of the screen.

Depending on which option you choose, it will affect the *Reputation* and *Virus* values differently. For every correct answer, the *Reputation* value increases and the *Virus* value decreases. For every incorrect answer, the *Virus* value increases and the *Reputation* value decreases. A box will then appear telling the player the correct way of handling the given question.

A player wins the game if they reach a *Reputation* value of 100 and *Virus* value of 0. A player’s score is based on the number of turns it takes for them to reach this, and if eligible, will be saved to the Highscores table for everyone to see.

If the player *Reputation* value reaches 0 or their *Virus* value reaches 100, then the game ends in defeat.

## Highscores Table
![alt text](https://github.com/liamfotheringham/Gamification-Software/blob/master/ReadMeImages/Highscore.png)

This displays the Top 10 scores. It shows the position in the table, their username and their score.

At the bottom of the screen, the player can click the *Return to Menu* button to return to the main menu screen.

## Admin Panel
![alt text](https://github.com/liamfotheringham/Gamification-Software/blob/master/ReadMeImages/Admin.png)

This panel allows authorised users to *Add*, *Update* and *Delete* questions from the game.

**Add:** To add a question to the game, add the relevant values into the boxes and simply click the *Add* button.

**Update:** To update a question to the game, select the question to update from the grid. This will fill the boxes with the values form the grid, where the user can change their values. To update the values, click the *Update* button.

**Delete:** To delete a Question, enter the *QuestionID* value of the question that is to be deleted. Once entered, click the *Delete* button.

**Clear:** To clear the boxes, click the *Clear* button. 
