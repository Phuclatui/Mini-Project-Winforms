\# Animal Racing Game (WinForms C#)



\## Introduction

Animal Racing Game is a simple mini game built using Windows Forms in C#.  

In this game, the player chooses one animal (Dog, Rabbit, or Turtle) and places a bet on the result of the race. The animals move with random speed until they reach the finish line.



\## Features

\- Three racing characters: Dog, Rabbit, Turtle  

\- Random movement speed for each character  

\- Timer-based animation  

\- Display running time for each racer  

\- Determine the winner based on finish time  

\- Betting system:

&#x20; - +100 points if the prediction is correct  

&#x20; - -100 points if the prediction is wrong  

\- New Game (reset positions and values)  

\- Run button to start the race  

\- Exit confirmation message  



\## How it works

\- A Timer is used to control the movement of the racers  

\- Each timer tick:

&#x20; - Random speed values are generated  

&#x20; - Each PictureBox moves to the right  

\- When all racers reach the finish line:

&#x20; - The timer stops  

&#x20; - The program compares times and shows the result  



\## Project structure

\- Form1.cs: main logic and UI handling  

\- ExtentionProgram: generates random speed values  

\- PictureBox: represents each racer  

\- Label: shows time and result  

\- RadioButton: used for betting choice  

\- Timer: controls the game loop  



\## How to run

1\. Open the project in Visual Studio  

2\. Build the solution  

3\. Run the program  

4\. Select a racer and click Run  



\## Rules

\- Choose one animal before starting the race  

\- Click Run to start  

\- Watch the race result  

\- Score changes:

&#x20; - Correct prediction: +100 points  

&#x20; - Wrong prediction: -100 points  



\## Notes

\- The game uses random speed so each race result is different  

\- The project can be improved by adding:

&#x20; - More racers  

&#x20; - Sound effects  

&#x20; - Leaderboard  

&#x20; - Save score to file or database  



\## Technology

\- C# WinForms  

\- .NET Framework  

\- System.Drawing  

\- Timer component

