Feature: Calculator

Scenario Outline: calculate
	Given the input is <input>
	When the inputs are calculated
	Then the result should be <result>

	Examples:
		| input             | result |
		| 1 2 3 + -         | -4     |
		| 6 2 * 3 /         | 4      |
		| 2 3 ^ 4 5 + +     | 17     |
		| 50 % 2 *          | 1      |
		| 3 ! 4 5 * +       | 26     |
		| 12 3 / !          | 24     |
		| 5 1 2 + 4 * + 3 - | 14     |