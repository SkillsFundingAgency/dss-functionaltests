
@customer

Feature: Get

	Scenario: Get Customer by ID
	Given I post a Customer with the following details:
		| Field                      | Value                |
		| DateOfRegistration         | 2018-07-27T16:11:00Z |
		| Title                      | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| DateOfTermination          | 2018-07-27T14:45:00Z |
		| ReasonForTermination       | 1                    |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |
		| LastModifiedDate           | 2018-06-21T14:45:00Z |
	When I get a Customer by ID
	Then there should be a 200 response
	And the response body should contain:
		| Field                      | Value                |
		| DateOfRegistration         | 2018-07-27T16:11:00Z |
		| Title                      | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| DateOfTermination          | 2018-07-27T14:45:00Z |
		| ReasonForTermination       | 1                    |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |
		| LastModifiedDate           | 2018-06-21T14:45:00Z |


	Scenario: Get Customer by FamilyName
		Given I post a Customer with the following details:
		| Field                      | Value               |
		| GivenName                  | Bob                 |
		| FamilyName                 | Binks               |
	When I search for:
		| Field                      | Value               |
		| parameter1                 | FamilyName          |
		| parameter2                 | Binks               |
		Then there should be a 200 response
	And all returned Customers should contain:
		| Field                      | Value               |
		| FamilyName                 | Binks               |


	Scenario: Get Customers by FamilyName
	Given I post a Customer with the following details:
		| Field                      | Value               |
		| GivenName                  | Bob                 |
		| FamilyName                 | Bloggs              |
	And I post a Customer with the following details:
		| Field                      | Value               |
		| GivenName                  | Phil                |
		| FamilyName                 | Banks               |
	And I post a Customer with the following details:
		| Field                      | Value               |
		| GivenName                  | Bob                 |
		| FamilyName                 | Bloggs              |
	When I search for:
		| Field                      | Value               |
		| parameter1                 | FamilyName          |
		| parameter2                 | Bloggs              |
	Then there should be a 200 response
	And all returned Customers should contain:
		| Field                      | Value               |
		| FamilyName                 | Bloggs              |


	Scenario: Get Customers by Partial FamilyName
	Given I post a Customer with the following details:
		| Field                      | Value               |
		| GivenName                  | Bob                 |
		| FamilyName                 | Newton              |
	And I post a Customer with the following details:
		| Field                      | Value               |
		| GivenName                  | Phil                |
		| FamilyName                 | Newten              |
	And I post a Customer with the following details:
		| Field                      | Value               |
		| GivenName                  | Bob                 |
		| FamilyName                 | Newtoo              |
	When I search for:
		| Field                      | Value               |
		| parameter1                 | FamilyName          |
		| parameter2                 | New                 |
	Then there should be a 200 response
	And all returned Customers should contain:
		| Field                      | Value               |
		| FamilyName                 | New	               |







	



