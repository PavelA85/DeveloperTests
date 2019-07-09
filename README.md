# Developer test - coding



1. Create a word-count function in a self-chosen programming language which, given an input string (or char array), can efficiently implement the below two requirements

* return a list which contains the number of identical word occurrences 
* return a list which contains the number of word-length occurrences ("the" and "car" which are both three characters long words will count in the three-character-length category)

Input and output example:
* Input string: "I have a transportation device which is a red bike which I love to ride."
* Output
* * List: "I, 2", "have, 1", "a, 2", "transportation, 1", "device, 1", "which, 2", "is, 1", "love, 1", "to, 1", "ride, 1"
* * List: "1, 4", "2, 2", "3, 1", "4, 4", "5, 2", "6, 1", "14, 1" (four words of length 1, 2 words of length 2, 1 word of length 3, and so on).



2. What does the below function do and how would you optimise it (for efficiency or readability reasons)?
```
string foo(string argument) {
	string tmp;
	if (argument.length() == 1) {
		return argument;
	}	
	else {
		string tempChar1 = argument.substring(argument.length()-1,argument.length());
		string tempChar2 = argument.substring(0, argument.length() -1);
		tmp = tempChar1 + foo(tempChar2);
		return tmp;
	}
}
```
