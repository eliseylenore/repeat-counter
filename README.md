# _Word Counter_

#### _App returns how frequently a word appears in a given sentence or paragraph, 02/17/2017_

#### By _**Elise St Hilaire**_

## Specs

**The program returns the given word and string.**
* Input: "the" "When the baby grows up to be an old man, they bury his body in the ground."
* **Why it's the simplest way to test behavior:** These strings are formatted in the exact way that our program will spit them back out._
* Output: "the" "When the baby grows up to be an old man, they bury his body in the ground."


**The program breaks up the string into multiple words.**
* Input: "the" "Here rests the old oak tree"
* **Why it's the simplest way to test behavior:** All words in this string are separated by spaces, and doesn't include any punctuation._
* Output: {"Here", "rests", "the", "old", "oak", "tree"}

**The program compares each word in the string to the given word and returns the number of times it is found.**
* Input: "the" "Here rests the old oak tree"
_**Why it's the simplest way to test behavior:** There is only one "the" to be found, and it uses the same casing as the given word._
* Output: 1

**The program returns the number of times the given word is found in the string, regardless of capitalization**
* Input: "this" "This house is haunted"
* **Why it's the simplest way to test behavior:** There is only one "this" to be found, and there is no extra punctuation._
* Output: 1

**The program returns the number of times the given word is found in the string, regardless of punctuation**
* Input: "man" "When the baby grows up to be an old man, they bury his body in the ground."
* **Why it's the simplest way to test behavior:** There is only one "man" to be found._
* Output: 1



## Setup/Installation Requirements

* _Clone repository_
* _Use Kestrel to view on your browser._
* _www.eliseylenore.github.io/repeat-counter_


## Known Bugs

_If the back button is pressed, multiple contacts are created from one entry._

## Support and contact details

_Please contact me with any problems at eliseylenore@gmail.com_

## Technologies Used

_I used C# with the Nancy framework. I also relied on Bootstrap._

### License

*MIT*

Copyright (c) 2016 **_Elise St Hilaire_**
