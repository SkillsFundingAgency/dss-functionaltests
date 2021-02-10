@postV1
Feature: Post

	Background: Create Customer
	Given I post a Customer with the following details:
		| Field                      | Value                |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |

@diversitydetails @smoke
	Scenario: Post Valid DiversityDetails with all Fields
		When I post a DiversityDetail with the following details:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                 | true                 |
		| LearningDifficultyOrDisabilityDeclaration | 1	                   |
		| PrimaryLearningDifficultyOrDisability     | 5                    |
		| SecondaryLearningDifficultyOrDisability   | 7                    |
		| DateAndTimeLLDDHealthConsentCollected      | 2018-09-19T09:01:00Z |
		| ConsentToCollectEthnicity                 | true                 |
		| Ethnicity                               | 44                   |
		| DateAndTimeEthnicityCollected             | 2018-09-19T09:01:00Z |
		| LastModifiedDate                          | 2018-09-19T09:01:00Z |
		Then there should be a 201 response
		And the response body should contain:
		| Field										| Value	  			   |
		| ConsentToCollectLLDDHealth                 | true                 |
		| LearningDifficultyOrDisabilityDeclaration | 1	                   |
		| PrimaryLearningDifficultyOrDisability     | 5                    |
		| SecondaryLearningDifficultyOrDisability   | 7                    |
		| DateAndTimeLLDDHealthConsentCollected      | 2018-09-19T09:01:00Z |
		| ConsentToCollectEthnicity                 | true                 |
		| Ethnicity                               | 44                   |
		| DateAndTimeEthnicityCollected             | 2018-09-19T09:01:00Z |
		| LastModifiedDate                          | 2018-09-19T09:01:00Z |
		And there should be a record in the diversitydetails ChangeFeed table
		And there should be a record in the diversitydetails-history ChangeFeed table

@diversitydetails
	Scenario: Post DiversityDetails with only mandatory Fields
		When I post a DiversityDetail with the following details:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                 | true                 |
		| LearningDifficultyOrDisabilityDeclaration | 1                 |
		| ConsentToCollectEthnicity                 | true                 |
		| Ethnicity                               | 44                   |
		Then there should be a 201 response
		And the response body should contain:
		| Field										| Value	  			   |
		| ConsentToCollectLLDDHealth                 | true                 |
		| LearningDifficultyOrDisabilityDeclaration | 1                 |
		| ConsentToCollectEthnicity                 | true                 |
		| Ethnicity                               | 44                   |
		And there should be a record in the diversitydetails ChangeFeed table
		And there should be a record in the diversitydetails-history ChangeFeed table

@diversitydetails
	Scenario: Post DiversityDetails with missing ConsentToCollectLLDDHealth Value
		When I post a DiversityDetail with the following details:
		| Field                                     | Value                |
		| LearningDifficultyOrDisabilityDeclaration | true                 |
		| PrimaryLearningDifficultyOrDisability     | 9                    |
		| SecondaryLearningDifficultyOrDisability   | 7                    |
		| DateAndTimeLLDDHealthConsentCollected      | 2018-09-19T09:01:00Z |
		| ConsentToCollectEthnicity                 | true                 |
		| Ethnicity                               | 31                   |
		| DateAndTimeEthnicityCollected             | 2018-09-19T09:01:00Z |
		| LastModifiedDate                          | 2018-09-19T09:01:00Z |
		Then there should be a 422 response

@diversitydetails
	Scenario: Post DiversityDetails with invalid ConsentToCollectLLDDHealth Value
		When I post a DiversityDetail with the following details:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                 | tru                  |
		| LearningDifficultyOrDisabilityDeclaration | 1	                   |
		| PrimaryLearningDifficultyOrDisability     | 9                    |
		| SecondaryLearningDifficultyOrDisability   | 7                    |
		| DateAndTimeLLDDHealthConsentCollected      | 2018-09-19T09:01:00Z |
		| ConsentToCollectEthnicity                 | true                 |
		| Ethnicity                               | 31                   |
		| DateAndTimeEthnicityCollected             | 2018-09-19T09:01:00Z |
		| LastModifiedDate                          | 2018-09-19T09:01:00Z |
		Then there should be a 422 response

@diversitydetails
	Scenario: Post DiversityDetails with missing LearningDifficultyOrDisabilityDeclaration Value
		When I post a DiversityDetail with the following details:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                 | true                 |
		| PrimaryLearningDifficultyOrDisability     | 9                    |
		| SecondaryLearningDifficultyOrDisability   | 7                    |
		| DateAndTimeLLDDHealthConsentCollected      | 2018-09-19T09:01:00Z |
		| ConsentToCollectEthnicity                 | true                 |
		| Ethnicity                               | 31                   |
		| DateAndTimeEthnicityCollected             | 2018-09-19T09:01:00Z |
		| LastModifiedDate                          | 2018-09-19T09:01:00Z |
		Then there should be a 422 response

@diversitydetails
		Scenario: Post DiversityDetails with invalid LearningDifficultyOrDisabilityDeclaration Value
		When I post a DiversityDetail with the following details:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                 | true                 |
		| LearningDifficultyOrDisabilityDeclaration | 4                    |
		| PrimaryLearningDifficultyOrDisability     | 2                    |
		| SecondaryLearningDifficultyOrDisability   | 3                    |
		| DateAndTimeLLDDHealthConsentCollected      | 2018-09-19T09:01:00Z |
		| ConsentToCollectEthnicity                 | true                 |
		| Ethnicity                               | 31                   |
		| DateAndTimeEthnicityCollected             | 2018-09-19T09:01:00Z |
		| LastModifiedDate                          | 2018-09-19T09:01:00Z |
		Then there should be a 422 response

@diversitydetails		
	Scenario: Post DiversityDetails with invalid PrimaryLearningDifficultyOrDisability Value
		When I post a DiversityDetail with the following details:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                 | true                 |
		| LearningDifficultyOrDisabilityDeclaration | 1                    |
		| PrimaryLearningDifficultyOrDisability     | 21                   |
		| SecondaryLearningDifficultyOrDisability   | 3                    |
		| DateAndTimeLLDDHealthConsentCollected      | 2018-09-19T09:01:00Z |
		| ConsentToCollectEthnicity                 | true                 |
		| Ethnicity                               | 31                   |
		| DateAndTimeEthnicityCollected             | 2018-09-19T09:01:00Z |
		| LastModifiedDate                          | 2018-09-19T09:01:00Z |
		Then there should be a 422 response

@diversitydetails
	Scenario: Post DiversityDetails with invalid SecondaryLearningDifficultyOrDisability Value
		When I post a DiversityDetail with the following details:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                 | true                 |
		| LearningDifficultyOrDisabilityDeclaration | 1                    |
		| PrimaryLearningDifficultyOrDisability     | 9                    |
		| SecondaryLearningDifficultyOrDisability   | 21                   |
		| DateAndTimeLLDDHealthConsentCollected      | 2018-09-19T09:01:00Z |
		| ConsentToCollectEthnicity                 | true                 |
		| Ethnicity                               | 31                   |
		| DateAndTimeEthnicityCollected             | 2018-09-19T09:01:00Z |
		| LastModifiedDate                          | 2018-09-19T09:01:00Z |
		Then there should be a 422 response

@diversitydetails
	Scenario: Post DiversityDetails with invalid DateAndTimeLLDDHealthConsentCollected Value
		When I post a DiversityDetail with the following details:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                 | true                 |
		| LearningDifficultyOrDisabilityDeclaration | 1                    |
		| PrimaryLearningDifficultyOrDisability     | 9                    |
		| SecondaryLearningDifficultyOrDisability   | 7                    |
		| DateAndTimeLLDDHealthConsentCollected      | 2033-09-19T09:01:00Z |
		| ConsentToCollectEthnicity                 | true                 |
		| Ethnicity                               | 31                   |
		| DateAndTimeEthnicityCollected             | 2018-09-19T09:01:00Z |
		| LastModifiedDate                          | 2018-09-19T09:01:00Z |
		Then there should be a 422 response

@diversitydetails
	Scenario: Post DiversityDetails with missing ConsentToCollectEthnicity Value
		When I post a DiversityDetail with the following details:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                 | true                 |
		| LearningDifficultyOrDisabilityDeclaration | true                 |
		| PrimaryLearningDifficultyOrDisability     | 2                    |
		| SecondaryLearningDifficultyOrDisability   | 3                    |
		| DateAndTimeLLDDHealthConsentCollected      | 2018-09-19T09:01:00Z |
		| Ethnicity                               | 31                   |
		| DateAndTimeEthnicityCollected             | 2018-09-19T09:01:00Z |
		| LastModifiedDate                          | 2018-09-19T09:01:00Z |
		Then there should be a 422 response

@diversitydetails
	Scenario: Post DiversityDetails with invalid ConsentToCollectEthnicity Value
		When I post a DiversityDetail with the following details:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                 | true                 |
		| LearningDifficultyOrDisabilityDeclaration | true                 |
		| PrimaryLearningDifficultyOrDisability     | 2                    |
		| SecondaryLearningDifficultyOrDisability   | 3                    |
		| DateAndTimeLLDDHealthConsentCollected      | 2018-09-19T09:01:00Z |
		| ConsentToCollectEthnicity                 | tru                  |
		| Ethnicity                               | 31                   |
		| DateAndTimeEthnicityCollected             | 2018-09-19T09:01:00Z |
		| LastModifiedDate                          | 2018-09-19T09:01:00Z |
		Then there should be a 422 response

@diversitydetails
	Scenario: Post DiversityDetails with invalid Ethnicity Value
		When I post a DiversityDetail with the following details:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                 | true                 |
		| LearningDifficultyOrDisabilityDeclaration | true                 |
		| PrimaryLearningDifficultyOrDisability     | 2                    |
		| SecondaryLearningDifficultyOrDisability   | 3                    |
		| DateAndTimeLLDDHealthConsentCollected      | 2018-09-19T09:01:00Z |
		| ConsentToCollectEthnicity                 | true                 |
		| Ethnicity                               | 12                   |
		| DateAndTimeEthnicityCollected             | 2018-09-19T09:01:00Z |
		| LastModifiedDate                          | 2018-09-19T09:01:00Z |
		Then there should be a 422 response

@diversitydetails
	Scenario: Post DiversityDetails with invalid DateAndTimeEthnicityCollected Value
		When I post a DiversityDetail with the following details:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                 | true                 |
		| LearningDifficultyOrDisabilityDeclaration | true                 |
		| PrimaryLearningDifficultyOrDisability     | 2                    |
		| SecondaryLearningDifficultyOrDisability   | 3                    |
		| DateAndTimeLLDDHealthConsentCollected      | 2018-09-19T09:01:00Z |
		| ConsentToCollectEthnicity                 | true                 |
		| Ethnicity                               | 31                   |
		| DateAndTimeEthnicityCollected             | 2033-09-19T09:01:00Z |
		| LastModifiedDate                          | 2018-09-19T09:01:00Z |
		Then there should be a 422 response


