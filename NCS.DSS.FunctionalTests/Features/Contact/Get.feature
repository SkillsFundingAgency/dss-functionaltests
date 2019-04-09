@postV1
@getV1
Feature: Get


	Background: Setup
	Given I post a Customer with the following details:
		| Field                | Value                |
		| GivenName            | Bob                  |
		| FamilyName           | Customer             |
	And I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customer@customer.com        |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |


	Scenario: Get Contact by ID
	When I get a Contact by ID
	Then there should be a 200 response
	And the response body should contain:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customer@customer.com        |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |