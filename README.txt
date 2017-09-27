ClearMeasure Homework:

1.  FizzBuzz calculation is now in it's own class library and being called from Main().  It is commented out at the bottom.
		a.  Print numbers 1-100.
		b.  If number is divisible by 3, print Fizz.
		c.   If number is divisible by 5, print Buzz.
		d.  If number is divisible by 3 and 5, print FizzBuzz.

2.  New customized FizzBuzz called from Main().  Allows user to pass in values, as many as they want.  Nothing is hard-coded.
		a.  User will be asked to enter a range.  A starting number and an ending number.
		b.  User will be asked to enter a number to use a divisor and enter a cooresponding word to print.
		c.  User can enter as many number/word combinations as they want and type "Quit" to exit.
		d.  When they exit, the results will print to screen.
		
3.  Unit Testing with NUnit
		a.  Unit test is done with the original FizzBuzz logic.
		b.  Created FizzBuzzing.Library and FizzBuzzing.Library.Tests.
		c.  Tests include:
				If number is divisible by 15, print FizzBuzz.
				If number is divisible by 3 or 6, print Fizz.
				If number is divisible by 5, print Buzz.
