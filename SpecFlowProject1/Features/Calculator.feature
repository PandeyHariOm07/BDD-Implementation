Feature: Calculator
As a Developer I wrote Calculator
Which I want to test

@tag1
Scenario: Add Number
	Given I have 50 and 60
	When I call the addnumber member
	Then It Should result 110

@tag2
Scenario: Subtract Number
	Given I have given the values below
		#DataTable
	| num1 | num2 |
	| 50   | 40   |
	When I call the Subtract method
	Then the result should be 10

Scenario Outline: Divide Number
	Given  <num1> and <num2>
	When I Call the Divide Method
	Then The Result is <result>

Examples:
	| num1 | num2 | result |
	| 0    | 5    | 0      |
	| 5    | 0    | 0      |
	| 6    | 2    | 3      |
