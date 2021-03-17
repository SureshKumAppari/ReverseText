# Test Objectives

In this C# coding test you should create two .NET Core projects:
- One for production. This has already been created for you (`ReverseText`)
- One a unit test project

## Production project

The requirements of the production project is to implement code that will:
- Read all the text of the supplied `TestTextFile.txt` text file.
- Reverse the text (for example: "hello" would become "olleh").
- Write out the reversed text back to the same file.
- Return the reversed text back to the calling method.

The empty class `FileTextReverser` has been provided as a starting point. You are free to write any other classes.

## Unit test project

The requirements of the unit test project:
- Write a unit test that tests that the production code in class `FileTextReverser` is reading the contents of the text file, reversing it and then writing it back to the file.
- **IMPORTANT**: This is a unit test. The test **MUST NOT** hit the disk of the machine it is running on.
	
Bonus points:
- Write any other unit tests for scenarios you can think of.
	
## Additional requirements

- You must target .NET Core in the production project and unit test project.
- You can use any packages you wish that are on nuget.
- Please do not send us assemblies.
- Please only code in C#.

Once completed clean your solution, remove any bin or obj folders and zip up the entire solution and send to us.

This test should not take you longer than one hour to complete.