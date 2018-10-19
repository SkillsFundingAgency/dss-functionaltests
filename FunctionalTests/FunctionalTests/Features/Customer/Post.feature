Feature: Post


		Scenario: Post Missing GivenName
		Given I post a Customer with the following details:
		| field						 | value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 13                   |
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
		Then there should be a 422 response
		And the error message should be "Given Name is a required field"


