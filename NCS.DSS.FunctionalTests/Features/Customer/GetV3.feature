Feature: CustomerGetV3

@customers @smoke	@subcontractorId
Scenario: Get Customer by ID
	Given I post a Customer with the following details V3:
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
		| PriorityGroups             | 1,3                  |
	When I get a Customer by ID V3
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
		| PriorityGroups             | [1,3]                |
	And the response body should contain the SubContractorId