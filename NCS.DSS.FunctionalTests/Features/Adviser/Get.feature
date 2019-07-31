
@postV1 @patchV1

Feature: Get



	Background: Post
	Given I post an adviser with the following details:
		| Field                 | Value			|
		| AdviserName			| BillyAdviser	|
		| AdviserEmailAddress	| billy@bill.com|
		| AdviserContactNumber	| 98798678967967|

@adviserdetails @smoke
	Scenario: Get Adviser by ID
	When I get an Adviser by ID
	Then there should be a 200 response
	And the response body should contain:
		| Field                 | Value			|
		| AdviserName			| BillyAdviser	|
		| AdviserEmailAddress	| billy@bill.com|
		| AdviserContactNumber	| 98798678967967|