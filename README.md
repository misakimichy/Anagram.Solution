# Anagram

#### _C#, .NET: Anagram, 12/17/2019_

## Description
Create a console application which takes an user input and returns a list of anagrams.
An anagram is a word that you can rearrange the letters and it becomes a new word. For example, "bread" is an anagram of "beard".

## Application should have:
- Interact with user and return an anagram
- Separated frontend and backend logic
- Unit testing for backend logic

## Unit Test
| Spec | User input | Expected output |
|  :------------- | :------------- | :------------- |
| Compares 2 single words and determines if they are anagrams. | beard, bread | true |
| Compares 2 single words and determines if they are anagrams. | car, bread| false |
| Compares more than 2 single words and determines if they are anagrams. | beard, bread, car| Only beard is an anagram of bread. |


## Installation:
1. Clone this repo:
```
$ git clone https://github.com/misakimichy/Anagram.Solution.git
```

2. Use the following codes:

a) Command to build the Anagram. Run this in Anagram directory:
```
$ dotnet build && $ dotnet run
```


b) Command for unit testing. Run this in Anagram.Tests directory:
```
$ dotnet restore && dotnet test
```


## Known Bugs
* No known bugs at this time.

## Support and contact details
 misaki.koonce@gmail.com

## Technologies Used
_Git, GitHub, C# and .NET Core


## License
Copyright © 2019 __Misaki Koonce__ under the MIT License