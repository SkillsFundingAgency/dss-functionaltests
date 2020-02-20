@postV2 @getV2

Feature: DiversityV2_Get

Background: Create Adviser
	Given I post an adviser with the following details:
		| Field						 | Value				|
		| AdviserName				 | BillyAdviser			|
		| AdviserContactNumber		 | 98798678967967		|
	And I post a Customer with the following details:
		| Field                      | Value                |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
	

@diversitydetails @smoke
Scenario:Get Diversity Details by ID

	Given I post a Diversity Details record with the following details:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                | true                 |
		| LearningDifficultyOrDisabilityDeclaration | 1                    |
		| PrimaryLearningDifficultyOrDisability     | 4                    |
		| SecondaryLearningDifficultyOrDisability   | 5                    |
		| DateAndTimeLLDDHealthConsentCollected     | 2018-06-25T11:21:00Z |
		| ConsentToCollectEthnicity                 | true                 |
		| Ethnicity                                 | 32                   |
		| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	When I get a Diversity Details by ID
	Then there should be a 200 response
		And the response body should contain:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                | true                 |
		| LearningDifficultyOrDisabilityDeclaration | 1                    |
		| PrimaryLearningDifficultyOrDisability     | 4                    |
		| SecondaryLearningDifficultyOrDisability   | 5                    |
		| DateAndTimeLLDDHealthConsentCollected     | 2018-06-25T11:21:00Z |
		| ConsentToCollectEthnicity                 | true                 |
		| Ethnicity                                 | 32                   |
		| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	And the response body should not contain the "CreatedBy"
	And the date field LastModifiedDate should hold a recent value
	And the response body should have LastModifiedBy with value 9000000001


@LearningProgression
Scenario:Get All Diversity Details records where 1 exists
	Given I post a Diversity Details record with the following details:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                | false                |
		| LearningDifficultyOrDisabilityDeclaration | 1                    |
		| PrimaryLearningDifficultyOrDisability     | 4                    |
		| SecondaryLearningDifficultyOrDisability   | 5                    |
		| DateAndTimeLLDDHealthConsentCollected     | 2018-06-25T11:21:00Z |
		| ConsentToCollectEthnicity                 | false                |
		| Ethnicity                                 | 32                   |
		| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	When I get all Diversity Details records for a customer
	Then there should be a 200 response
	And the response should contain 1 document(s)
	And the response body should incorporate a document with the following details:
	#  In this table Booleans are capitalised - haven't worked out how to keep consistent with the rest so far
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                | False                |
		| LearningDifficultyOrDisabilityDeclaration | 1                    |
		| PrimaryLearningDifficultyOrDisability     | 4                    |
		| SecondaryLearningDifficultyOrDisability   | 5                    |
		| DateAndTimeLLDDHealthConsentCollected     | 2018-06-25T11:21:00Z |
		| ConsentToCollectEthnicity                 | False                |
		| Ethnicity                                 | 32                   |
		| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	#And the response body should not contain the "CreatedBy"
	#And the date field LastModifiedDate should hold a recent value
	#And the response body should have LastModifiedByTouchpointID with value 9000000001


@LearningProgression  
Scenario:Get Diversity Details by invalid ID
	Given I post a Diversity Details record with the following details:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                | true                 |
		| LearningDifficultyOrDisabilityDeclaration | 1                    |
		| PrimaryLearningDifficultyOrDisability     | 4                    |
		| SecondaryLearningDifficultyOrDisability   | 5                    |
		| DateAndTimeLDDHealthConsentCollected      | 2018-06-25T11:21:00Z |
		| ConsentToCollectEthnicity                 | true                 |
		| EthnicityID                               | 32                   |
		| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	And I post a Customer with the following details:
		| Field      | Value    |
		| GivenName  | Bob      |
		| FamilyName | Customer |
	When I get a Diversity Details by ID
	Then there should be a 404 response

@LearningProgression
Scenario:Get All Diversity Details records where none exist

	#Given I post a Diversity Details record with the following details:
	#	| Field                                     | Value                |
	#	| ConsentToCollectLLDDHealth                | true                 |
	#	| LearningDifficultyOrDisabilityDeclaration | 1                    |
	#	| PrimaryLearningDifficultyOrDisability     | 4                    |
	#	| SecondaryLearningDifficultyOrDisability   | 5                    |
	#	| DateAndTimeLDDHealthConsentCollected      | 2018-06-25T11:21:00Z |
	#	| ConsentToCollectEthnicity                 | true                 |
	#	| EthnicityID                               | 32                   |
	#	| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	#And I post a Customer with the following details:
	#	| Field      | Value    |
	#	| GivenName  | Bob      |
	#	| FamilyName | Customer |
	When I get all Diversity Details records for a customer
	Then there should be a 404 response
