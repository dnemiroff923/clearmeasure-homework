# clearmeasure-homework
FizzBuzz calculation is now in it's own class library and being called from Main().  Note: It is commented out for new project.
	Print numbers 1-100
	If number is divisible by 3, print Fizz
	If number is divisible by 5, print Buzz
	If number is divisible by 3 and 5, print FizzBuzz
	
New customized FizzBuzz called from Main().  Allows user to pass in values, as many as they want.  Nothing is hard-coded.
	User will be asked to enter a range.  A starting number and an ending number.
	User will be asked to enter a number to use a divisor and enter a cooresponding word to print.
	User can enter as many number/word combinations as they want and type "Quit" to exit.
	When they exit, the results will print to screen.
	
Unit Testing with NUnit
	Unit test is done with the original FizzBuzz logic
	Created FizzBuzzing.Library and FizzBuzzing.Library.Tests
	Tests include:
		If number is divisible by 15, print FizzBuzz
		If number is divisible by 3 or 6, print Fizz
		If number is divisible by 5, print Buzz
