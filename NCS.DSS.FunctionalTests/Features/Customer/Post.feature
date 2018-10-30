Feature: Post



		@postCustomer
		Scenario: Post Missing GivenName
		Given I post a Customer with the following details:
		| field						 | value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 2                    |
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


		Scenario: Post Missing FamilyName
		Given I post a Customer with the following details:
		| field						 | value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 13                   |
		| GivenName                  | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| DateOfTermination          | 2018-07-27T14:45:00Z |
		| ReasonForTermination       | 1                    |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |
		Then there should be a 422 response
		#And the error message should be "Family Name is a required field"



		Scenario: Post Valid Customer
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
		#| DateOfTermination          | 2018-07-27T14:45:00Z |
		#| ReasonForTermination       | 1                    |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |
		| LastModifiedDate           | 2018-06-21T14:45:00Z |
		Then there should be a 201 response
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
		#| DateOfTermination          | 2018-07-27T14:45:00Z |
		#| ReasonForTermination       | 1                    |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |
		| LastModifiedDate           | 2018-06-21T14:45:00Z |






		Scenario: Post Valid Customer with maximum field lengths
		Given I post a Customer with the following details:
		| field                      | value                                                                                                |
		| DateOfRegistration         | 2018-07-27T16:11:00Z                                                                                 |
		| Title                      | 1                                                                                                    |
		| GivenName                  | AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghij |
		| FamilyName                 | AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghij |
		| DateofBirth                | 2005-07-26T13:45:00Z                                                                                 |
		| Gender                     | 1                                                                                                    |
		| UniqueLearnerNumber        | 9876543210                                                                                           |
		| OptInUserResearch          | true                                                                                                 |
		| OptInMarketResearch        | false                                                                                                |
		| DateOfTermination          | 2018-07-27T14:45:00Z                                                                                 |
		| ReasonForTermination       | 1                                                                                                    |
		| IntroducedBy               | 1                                                                                                    |
		| IntroducedByAdditionalInfo | AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghij |
		| LastModifiedDate           | 2018-06-21T14:45:00Z                                                                                 |
		Then there should be a 201 response
		And the response body should contain:
		| field                      | value                                                                                                |
		| DateOfRegistration         | 2018-07-27T16:11:00Z                                                                                 |
		| Title                      | 1                                                                                                    |
		| GivenName                  | AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghij |
		| FamilyName                 | AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghij |
		| DateofBirth                | 2005-07-26T13:45:00Z                                                                                 |
		| Gender                     | 1                                                                                                    |
		| UniqueLearnerNumber        | 9876543210                                                                                           |
		| OptInUserResearch          | true                                                                                                 |
		| OptInMarketResearch        | false                                                                                                |
		| DateOfTermination          | 2018-07-27T14:45:00Z                                                                                 |
		| ReasonForTermination       | 1                                                                                                    |
		| IntroducedBy               | 1                                                                                                    |
		| IntroducedByAdditionalInfo | AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghij |
		| LastModifiedDate           | 2018-06-21T14:45:00Z                                                                                 |



	Scenario: Post Customer with only Mandatory fields
		Given I post a Customer with the following details:

		| field						 | value                |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		Then there should be a 201 response
		And the response body should contain:
		| field						 | value                |
		| Title						 | 99                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | null								 |
		| Gender                     | 99                    |
		| UniqueLearnerNumber        | null           |
		| OptInUserResearch          | false                 |
		| OptInMarketResearch        | false                |
		| DateOfTermination          | null |
		| ReasonForTermination       | null                    |
		| IntroducedBy               | 99                    |
		| IntroducedByAdditionalInfo | null      |




		Scenario: Post Invalid DateOfRegistration						
		Given I post a Customer with the following details:
		| field						 | value                |
		| DateOfRegistration		 | 2048-07-27T16:11:00Z |
		| Title						 | 13                   |
		| GivenName                  | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| DateOfTermination          | 2018-07-27T14:45:00Z |
		| ReasonForTermination       | 1                    |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |
		Then there should be a 422 response
		And the error message should be "Family Name is a required field"		
		




