Specs:
# _Friday Programming Test Project_

## Description/Specs

#### _Console Function Goal:_

1. Console will ask the user to input a sentence (Console.WriteLine()), from there the user input will be stored into a variable (Console.ReadLine()).
2. Console will ask use to input another word that will be used to find duplicates in the original sentence.

#### _Method Plan:_

1. Firstly we will have a 2 Console.ReadLines() to store the original sentence and the duplicate word finder and create variables associated with those responses.
2. Seocndly we will stor this information in a datatype (EX. Array, Dictionary, List).
3. After storing the repeated word we will have a forloop go through each word look ing for duplicates. (It should avoid words within words by using .Split()).
4. The duplicate word will be stored in a variable and returned at the end of the loop.

#### _Testing:_

1. The test we can conduct is making sure our function is collecting ALL of the same words no matter the capitalization.
2. We can also check its not finding words within words.
3. Make sure the word is still recognized with punctuation.

## Setup/Installation Requirements

* _1. Open the Terminal (Mac) or Git Bash (PC)
* _2. Go to the dir. where you would like to install the file. (for ex. computer-name:~ Guest$ cd desktop
* _3. To make a copy of a repository from Github on a local machine computer-name:desktop Guest$ git clone https://github.com/AnthonyGolovin/WordCounterTests.
* _4. A boom a new file should appear named "WordCounterTests" > enter the directory a WordCounter and type "dotnet build" and then "dotnet run" _

## Support and contact details

_For any syntax errors please review the Setup/Installation Requirements section above and follow the above steps._

## Technologies Used

_*C#
_*WindowsConsole
### License
*Licensed under the MIT license*
Copyright (c) 2016 **_Anthony P Golovin**_
