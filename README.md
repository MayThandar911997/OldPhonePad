# OldPhonePad
This project implements an Old Phone Keypad Decoder in C#. It simulates text input using a traditional mobile phone keypad, where multiple key presses cycle through different characters (e.g., pressing 2 once gives A, twice gives B, etc.).
Additionally, if the user pauses for more than 1 second between key presses, a space is automatically added to separate words.
The program runs in a loop until the user presses Enter without typing anything to exit.

# How It Works
  1.	User inputs digits in real time (simulating old keypad typing).
  2.	If a key is pressed multiple times consecutively, the program cycles through the corresponding letters.
  3.	If the user pauses for more than 1 second, a space is added automatically.
  4.	The decoded output is displayed after each input.
  5.	Press Enter without input to exit the program.

# Installation
git clone [https://github.com/your-username/old-phone-keypad-decoder.git](https://github.com/MayThandar911997/OldPhonePad.git)
cd old-phone-keypad-decoder

# Compile and Run
  •	Using .NET CLI:
      dotnet run
  •	Using Visual Studio:
      1.	Open the project in Visual Studio.
      2.	Click Run.
# Unit Testing
  Used xUnit for unit testing.
      
# Usage
  •	Typing 2 once → A, typing 22 → B, typing 222 → C.
  •	If 1 second passes between key presses, a space is inserted automatically.
  •	Pressing * acts as a backspace, deleting the last typed character.
  •	Pressing Enter without input exits the program.

# Contributing
  Feel free to fork the repository and submit pull requests! 


