
@postV1

Feature: Post


	Scenario: Create Valid Adviser
		Given I post an adviser with the following details:
			| Field                 | Value			|
			| AdviserName			| BillyAdviser	|
			| AdviserEmailAddress	| billy@bill.com|
			| AdviserContactNumber	| 98798678967967|
		Then there should be a 201 response
		And the response body should contain:
			| Field                 | Value			|
			| AdviserName			| BillyAdviser	|
			| AdviserEmailAddress	| billy@bill.com|
			| AdviserContactNumber	| 98798678967967|


		Scenario: Missing AdviserName
		Given I post an adviser with the following details:
			| Field                 | Value			|
			| AdviserEmailAddress	| billy@bill.com|
			| AdviserContactNumber	| 98798678967967|
		Then there should be a 422 response