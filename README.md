Specs:
Console Function Goal:
1. Console will ask the user to input a sentence (Console.WriteLine()), from there the user input will be stored into a variable (Console.ReadLine()).
2. Console will ask use to input another word that will be used to find duplicates in the original sentence.

Method Plan:
1. Firstly we will have a 2 Console.ReadLines() to store the original sentence and the duplicate word finder and create variables associated with those responses.
2. Seocndly we will stor this information in a datatype (EX. Array, Dictionary, List).
3. After storing the repeated word we will have a forloop go through each word look ing for duplicates. (It should avoid words within words by using .Split()).
4. The duplicate word will be stored in a variable and returned at the end of the loop.

Testing:
1. The test we can conduct is making sure our function is collecting ALL of the same words no matter the capitalization.
2. We can also check its not finding words within words.