	@postV3 @patchV2

Feature: DiversityV3_Post


Background: Create Adviser
	Given I post an adviser with the following details:
		| Field						 | Value				|
		| AdviserName				 | BillyAdviser			|
		| AdviserContactNumber		 | 98798678967967		|
	And I post a Customer with the following details:
		| Field                      | Value                |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |


@diversitydetails  @smoke
Scenario:Post Diversity with all values
	When I post a DiversityDetail with the following details:
	| Field                                     | Value                |
	| ConsentToCollectLLDDHealth                | true                 |
	| LearningDifficultyOrDisabilityDeclaration | 1                    |
	| PrimaryLearningDifficultyOrDisability     | 4                    |
	| SecondaryLearningDifficultyOrDisability   | 5                    |
	| DateAndTimeLLDDHealthConsentCollected     | 2018-06-25T11:21:00Z |
	| ConsentToCollectEthnicity                 | true                 |
	| Ethnicity                                 | 32                   |
	| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	| LastModifiedDate                          | 2018-08-25T11:21:00Z |
	Then there should be a 201 response
	And the response body should contain:
	| Field                                     | Value                |
	| ConsentToCollectLLDDHealth                | true                 |
	| LearningDifficultyOrDisabilityDeclaration | 1                    |
	| PrimaryLearningDifficultyOrDisability     | 4                    |
	| SecondaryLearningDifficultyOrDisability   | 5                    |
	| DateAndTimeLLDDHealthConsentCollected      | 2018-06-25T11:21:00Z |
	| ConsentToCollectEthnicity                 | true                 |
	| Ethnicity                                 | 32                   |
	| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	| LastModifiedDate                          | 2018-08-25T11:21:00Z |
	And the "diversitydetails" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	And there should be a record in the diversitydetails ChangeFeed table
	And there should be a record in the diversitydetails-history ChangeFeed table

@diversitydetails  
Scenario:Post Diversity with all mandatory values
	When I post a DiversityDetail with the following details:
	| Field                                     | Value |
	| ConsentToCollectLLDDHealth                | true  |
	| LearningDifficultyOrDisabilityDeclaration | 1     |
	| ConsentToCollectEthnicity                 | false |
	| Ethnicity                                 | 99    |
	Then there should be a 201 response
	And the response body should contain:
	| Field                                     | Value |
	| ConsentToCollectLLDDHealth                | true  |
	| LearningDifficultyOrDisabilityDeclaration | 1     |
	| ConsentToCollectEthnicity                 | false |
	| Ethnicity                                 | 99    |
	And the "diversitydetails" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	And there should be a record in the diversitydetails ChangeFeed table
	And there should be a record in the diversitydetails-history ChangeFeed table

############################################################################################################################
##	ConsentToCollectLLDDHealth
############################################################################################################################

@diversitydetails  
Scenario Outline:Post Diversity with valid values for ConsentToCollectLLDDHealth 

	Given I want to send <Field> with value <Value> in the following request
	When I post a DiversityDetail with the following details:
	| Field                                     | Value |
	| LearningDifficultyOrDisabilityDeclaration | 1     |
	| ConsentToCollectEthnicity                 | false |
	| Ethnicity                                 | 99    |
	Then there should be a 201 response
	And the response body should contain:
	| Field                                     | Value |
	| LearningDifficultyOrDisabilityDeclaration | 1     |
	| ConsentToCollectEthnicity                 | false |
	| Ethnicity                                 | 99    |
	And the response body should have <Field> with value <Value>
	
	Examples:
	| Field                     | Value |
	| ConsentToCollectLLDDHealth | True  |
	| ConsentToCollectLLDDHealth | False |		
	
@diversitydetails  
Scenario Outline: Post Diversity with invalid values for ConsentToCollectLLDDHealth 

	Given I want to send <Field> with value <Value> in the following request
	When I post a DiversityDetail with the following details:
	| Field                                     | Value |
	| LearningDifficultyOrDisabilityDeclaration | 1     |
	| ConsentToCollectEthnicity                 | false |
	| Ethnicity                                 | 99    |
	Then there should be a 422 response
	
	Examples:
	| Field                      | Value |
	| ConsentToCollectLLDDHealth | 1     |
	| ConsentToCollectLLDDHealth | car   |	

@diversitydetails  
Scenario: Post Diversity with no value supplied for ConsentToCollectLLDDHealth 


	When I post a DiversityDetail with the following details:
	| Field                                     | Value |
	| LearningDifficultyOrDisabilityDeclaration | 1     |
	| ConsentToCollectEthnicity                 | false |
	| Ethnicity                                 | 99    |
	| ConsentToCollectLLDDHealth                |       |
	Then there should be a 422 response
	And the error message should be "The ConsentToCollectLLDDHealth field is required."

############################################################################################################################
## LearningDifficultyOrDisabilityDeclaration
############################################################################################################################

@diversitydetails  
Scenario Outline:Post Diversity with valid values for LearningDifficultyOrDisabilityDeclaration 
	Given I want to send <Field> with value <Value> in the following request
	When I post a DiversityDetail with the following details:
	| Field                      | Value |
	| ConsentToCollectLLDDHealth | true  |
	| ConsentToCollectEthnicity  | false |
	| Ethnicity                  | 99    |
	Then there should be a 201 response
	And the response body should contain:
	| Field                      | Value |
	| ConsentToCollectLLDDHealth | true  |
	| ConsentToCollectEthnicity  | false |
	| Ethnicity                  | 99    |
	And the response body should have <Field> with value <Value>
	
	Examples:
	| Field                                     | Value |
	| LearningDifficultyOrDisabilityDeclaration | 1     |
	| LearningDifficultyOrDisabilityDeclaration | 2     |
	| LearningDifficultyOrDisabilityDeclaration | 9    |



@diversitydetails  
Scenario Outline: Post Diversity with invalid values for LearningDifficultyOrDisabilityDeclaration 
	Given I want to send <Field> with value <Value> in the following request
	When I post a DiversityDetail with the following details:
	| Field                      | Value |
	| ConsentToCollectLLDDHealth | true  |
	| ConsentToCollectEthnicity  | false |
	| Ethnicity                  | 99    |
	Then there should be a 422 response
	And the error message should be "Please supply a valid Learning Difficulty Or Disability Declaration"
	
	Examples:
	| Field                                     | Value | 
	| LearningDifficultyOrDisabilityDeclaration | -1    | 
	| LearningDifficultyOrDisabilityDeclaration | 0     | 
	| LearningDifficultyOrDisabilityDeclaration | 3     |
	| LearningDifficultyOrDisabilityDeclaration | 8     |
	| LearningDifficultyOrDisabilityDeclaration | 10     |
	| LearningDifficultyOrDisabilityDeclaration | 98    | 
	| LearningDifficultyOrDisabilityDeclaration | 99    | 
	| LearningDifficultyOrDisabilityDeclaration | 100   | 

@diversitydetails  
Scenario: Post Diversity with no value supplied for LearningDifficultyOrDisabilityDeclaration 

	When I post a DiversityDetail with the following details:
	| Field                                     | Value                |
	| ConsentToCollectLLDDHealth                | true                 |
	| LearningDifficultyOrDisabilityDeclaration |                      |
	| PrimaryLearningDifficultyOrDisability     | 4                    |
	| SecondaryLearningDifficultyOrDisability   | 5                    |
	| DateAndTimeLLDDHealthConsentCollected      | 2018-06-25T11:21:00Z |
	| ConsentToCollectEthnicity                 | true                 |
	| Ethnicity                                 | 32                   |
	| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	| LastModifiedDate                          | 2018-08-25T11:21:00Z |
	Then there should be a 201 response
	And the response body should contain:
	| Field                                     | Value |
	| LearningDifficultyOrDisabilityDeclaration | 9     |

############################################################################################################################
## PrimaryLearningDifficultyOrDisability
############################################################################################################################

@diversitydetails  
Scenario Outline:Post Diversity with valid values for PrimaryLearningDifficultyOrDisability 
	Given I want to send <Field> with value <Value> in the following request
	When I post a DiversityDetail with the following details:
	| Field                                     | Value |
	| ConsentToCollectLLDDHealth                | true  |
	| ConsentToCollectEthnicity                 | false |
	| Ethnicity                                 | 99    |
	| LearningDifficultyOrDisabilityDeclaration | 1     |
	Then there should be a 201 response
	And the response body should contain:
	| Field                                     | Value |
	| ConsentToCollectLLDDHealth                | true  |
	| ConsentToCollectEthnicity                 | false |
	| Ethnicity                                 | 99    |
	| LearningDifficultyOrDisabilityDeclaration | 1     |
	And the response body should have <Field> with value <Value>
	
	Examples:
	| Field                                 | Value |
	| PrimaryLearningDifficultyOrDisability | 4     |
	| PrimaryLearningDifficultyOrDisability | 5     |
	| PrimaryLearningDifficultyOrDisability | 6     |
	| PrimaryLearningDifficultyOrDisability | 7     |
	| PrimaryLearningDifficultyOrDisability | 8     |
	| PrimaryLearningDifficultyOrDisability | 9     |
	| PrimaryLearningDifficultyOrDisability | 10    |
	| PrimaryLearningDifficultyOrDisability | 11    |
	| PrimaryLearningDifficultyOrDisability | 12    |
	| PrimaryLearningDifficultyOrDisability | 13    |
	| PrimaryLearningDifficultyOrDisability | 14    |
	| PrimaryLearningDifficultyOrDisability | 15    |
	| PrimaryLearningDifficultyOrDisability | 16    |
	| PrimaryLearningDifficultyOrDisability | 17    |
	| PrimaryLearningDifficultyOrDisability | 93    |
	| PrimaryLearningDifficultyOrDisability | 94    |
	| PrimaryLearningDifficultyOrDisability | 95    |
	| PrimaryLearningDifficultyOrDisability | 96    |
	| PrimaryLearningDifficultyOrDisability | 97    |
	| PrimaryLearningDifficultyOrDisability | 98    |
	| PrimaryLearningDifficultyOrDisability | 99    |



@diversitydetails  
Scenario Outline: Post Diversity with invalid values for PrimaryLearningDifficultyOrDisability 
	Given I want to send <Field> with value <Value> in the following request
	When I post a DiversityDetail with the following details:
	| Field                      | Value |
	| ConsentToCollectLLDDHealth | true  |
	| ConsentToCollectEthnicity  | false |
	| Ethnicity                  | 99    |
	Then there should be a 422 response
	And the error message should be "Please supply a valid Primary Learning Difficulty Or Disability"
	
	Examples:
	| Field                                 | Value |
	| PrimaryLearningDifficultyOrDisability |-1     |
	| PrimaryLearningDifficultyOrDisability | 1     |
	| PrimaryLearningDifficultyOrDisability | 2     |
	| PrimaryLearningDifficultyOrDisability | 3     |
	| PrimaryLearningDifficultyOrDisability | 18     |
	| PrimaryLearningDifficultyOrDisability | 20     |
	| PrimaryLearningDifficultyOrDisability | 20     |
	| PrimaryLearningDifficultyOrDisability | 90     |
	| PrimaryLearningDifficultyOrDisability | 92     |
	| PrimaryLearningDifficultyOrDisability | 100     |
#	| PrimaryLearningDifficultyOrDisability | a     |

@diversitydetails  
Scenario: Post Diversity with no value supplied for PrimaryLearningDifficultyOrDisability 

	When I post a DiversityDetail with the following details:
	| Field                                     | Value                |
	| ConsentToCollectLLDDHealth                | true                 |
	| LearningDifficultyOrDisabilityDeclaration |                      |
	| PrimaryLearningDifficultyOrDisability     |                     |
	| SecondaryLearningDifficultyOrDisability   | 5                    |
	| DateAndTimeLLDDHealthConsentCollected      | 2018-06-25T11:21:00Z |
	| ConsentToCollectEthnicity                 | true                 |
	| Ethnicity                                 | 32                   |
	| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	| LastModifiedDate                          | 2018-08-25T11:21:00Z |
	Then there should be a 201 response
	And the response body should contain:
	| Field                                     | Value                |
	| ConsentToCollectLLDDHealth                | true                 |
	| LearningDifficultyOrDisabilityDeclaration | 9                    |
	| PrimaryLearningDifficultyOrDisability     | 99                   |
	| SecondaryLearningDifficultyOrDisability   | 5                    |
	| DateAndTimeLLDDHealthConsentCollected     | 2018-06-25T11:21:00Z |
	| ConsentToCollectEthnicity                 | true                 |
	| Ethnicity                                 | 32                   |
	| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	| LastModifiedDate                          | 2018-08-25T11:21:00Z |

############################################################################################################################
## SecondaryLearningDifficultyOrDisability
############################################################################################################################

@diversitydetails  
Scenario Outline:Post Diversity with valid values for SecondaryLearningDifficultyOrDisability 
	Given I want to send <Field> with value <Value> in the following request
	When I post a DiversityDetail with the following details:
	| Field                      | Value |
	| ConsentToCollectLLDDHealth | true  |
	| ConsentToCollectEthnicity  | false |
	| Ethnicity                  | 99    |
	Then there should be a 201 response
	And the response body should contain:
	| Field                      | Value |
	| ConsentToCollectLLDDHealth | true  |
	| ConsentToCollectEthnicity  | false |
	| Ethnicity                  | 99    |
	And the response body should have <Field> with value <Value>
	
	Examples:
	| Field                                 | Value |
	| SecondaryLearningDifficultyOrDisability | 4     |
	| SecondaryLearningDifficultyOrDisability | 5     |
	| SecondaryLearningDifficultyOrDisability | 6     |
	| SecondaryLearningDifficultyOrDisability | 7     |
	| SecondaryLearningDifficultyOrDisability | 8     |
	| SecondaryLearningDifficultyOrDisability | 9     |
	| SecondaryLearningDifficultyOrDisability | 10    |
	| SecondaryLearningDifficultyOrDisability | 11    |
	| SecondaryLearningDifficultyOrDisability | 12    |
	| SecondaryLearningDifficultyOrDisability | 13    |
	| SecondaryLearningDifficultyOrDisability | 14    |
	| SecondaryLearningDifficultyOrDisability | 15    |
	| SecondaryLearningDifficultyOrDisability | 16    |
	| SecondaryLearningDifficultyOrDisability | 17    |
	| SecondaryLearningDifficultyOrDisability | 93    |
	| SecondaryLearningDifficultyOrDisability | 94    |
	| SecondaryLearningDifficultyOrDisability | 95    |
	| SecondaryLearningDifficultyOrDisability | 96    |
	| SecondaryLearningDifficultyOrDisability | 97    |
	| SecondaryLearningDifficultyOrDisability | 98    |
	| SecondaryLearningDifficultyOrDisability | 99    |



@diversitydetails  
Scenario Outline: Post Diversity with invalid values for SecondaryLearningDifficultyOrDisability 
	Given I want to send <Field> with value <Value> in the following request
	When I post a DiversityDetail with the following details:
	| Field                      | Value |
	| ConsentToCollectLLDDHealth | true  |
	| ConsentToCollectEthnicity  | false |
	| Ethnicity                  | 99    |
	Then there should be a 422 response
	And the error message should be "Please supply a valid Secondary Learning Difficulty Or Disability"
	
	Examples:
	| Field                                 | Value |
	| SecondaryLearningDifficultyOrDisability |-1     |
	| SecondaryLearningDifficultyOrDisability | 1     |
	| SecondaryLearningDifficultyOrDisability | 2     |
	| SecondaryLearningDifficultyOrDisability | 3     |
	| SecondaryLearningDifficultyOrDisability | 18     |
	| SecondaryLearningDifficultyOrDisability | 20     |
	| SecondaryLearningDifficultyOrDisability | 20     |
	| SecondaryLearningDifficultyOrDisability | 90     |
	| SecondaryLearningDifficultyOrDisability | 92     |
	| SecondaryLearningDifficultyOrDisability | 100     |
#	| PrimaryLearningDifficultyOrDisability | a     |

@diversitydetails  
Scenario: Post Diversity with no value supplied for SecondaryLearningDifficultyOrDisability 

	When I post a DiversityDetail with the following details:
	| Field                                     | Value                |
	| ConsentToCollectLLDDHealth                | true                 |
	| LearningDifficultyOrDisabilityDeclaration |                      |
	| PrimaryLearningDifficultyOrDisability     | 5                    |
	| SecondaryLearningDifficultyOrDisability   |                      |
	| DateAndTimeLLDDHealthConsentCollected      | 2018-06-25T11:21:00Z |
	| ConsentToCollectEthnicity                 | true                 |
	| Ethnicity                                 | 32                   |
	| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	| LastModifiedDate                          | 2018-08-25T11:21:00Z |
	Then there should be a 201 response
	And the response body should contain:
	| ConsentToCollectLLDDHealth                | true                 |
	| LearningDifficultyOrDisabilityDeclaration | 9                    |
	| PrimaryLearningDifficultyOrDisability     | 5                    |
	| SecondaryLearningDifficultyOrDisability   | 99                   |
	| DateAndTimeLLDDHealthConsentCollected     | 2018-06-25T11:21:00Z |
	| ConsentToCollectEthnicity                 | true                 |
	| Ethnicity                                 | 32                   |
	| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	| LastModifiedDate                          | 2018-08-25T11:21:00Z |

############################################################################################################################
## DateAndTimeLLDDHealthConsentCollected			MANDATORY IF CONSENT GIVEN	Date < NOW
############################################################################################################################

@diversitydetails  
Scenario Outline:Post Diversity with valid values for DateAndTimeLLDDHealthConsentCollected 
	Given I want to send <Field> with value <Value> in the following request
	When I post a DiversityDetail with the following details:
	| Field                      | Value |
	| ConsentToCollectLLDDHealth | true  |
	| ConsentToCollectEthnicity  | false |
	| Ethnicity                  | 99    |
	Then there should be a 201 response
	And the response body should contain:
	| Field                      | Value |
	| ConsentToCollectLLDDHealth | true  |
	| ConsentToCollectEthnicity  | false |
	| Ethnicity                  | 99    |
	And the response body value for DateAndTimeLLDDHealthConsentCollected should match the last request
#	And the response body should have <Field> with value <Value>
	
	Examples:
	| Field                                | Value                |
	| DateAndTimeLLDDHealthConsentCollected | now                  |
	| DateAndTimeLLDDHealthConsentCollected | today                |
	| DateAndTimeLLDDHealthConsentCollected | 2018-08-25T11:21:00Z |




@diversitydetails  
Scenario Outline: Post Diversity with invalid values for DateAndTimeLLDDHealthConsentCollected 
	Given I want to send <Field> with value <Value> in the following request
	When I post a DiversityDetail with the following details:
	| Field                      | Value |
	| ConsentToCollectLLDDHealth | true  |
	| ConsentToCollectEthnicity  | false |
	| Ethnicity                  | 99    |
	Then there should be a 422 response
	And the error message should be "Date And Time LLDD Health Consent Collected must be less the current date/time"
	
	Examples:
	| Field                                 | Value       |
	| DateAndTimeLLDDHealthConsentCollected | now +1Hour  |
	| DateAndTimeLLDDHealthConsentCollected | today +1Day |





@diversitydetails  
Scenario: Post Diversity with no value supplied for DateAndTimeLLDDHealthConsentCollected with no consent to collect  LDD Health data given

	When I post a DiversityDetail with the following details:
	| Field                                     | Value                |
	| ConsentToCollectLLDDHealth                | false                |
	| LearningDifficultyOrDisabilityDeclaration |                      |
	| PrimaryLearningDifficultyOrDisability     | 5                    |
	| SecondaryLearningDifficultyOrDisability   |                      |
	| DateAndTimeLLDDHealthConsentCollected      |                      |
	| ConsentToCollectEthnicity                 | true                 |
	| Ethnicity                                 | 32                   |
	| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	Then there should be a 201 response
	And the response body should contain:
	| Field                                     | Value                |
	| ConsentToCollectLLDDHealth                | false                |
	| LearningDifficultyOrDisabilityDeclaration | 9                    |
	| PrimaryLearningDifficultyOrDisability     | 5                    |
	| SecondaryLearningDifficultyOrDisability   | 99                   |
	| DateAndTimeLLDDHealthConsentCollected     |                      |
	| ConsentToCollectEthnicity                 | true                 |
	| Ethnicity                                 | 32                   |
	| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |

@diversitydetails  
Scenario: Post Diversity with no value supplied for DateAndTimeLLDDHealthConsentCollected with consent to collect LDD Health data given

	When I post a DiversityDetail with the following details:
	| Field                                     | Value                |
	| ConsentToCollectLLDDHealth                | true                 |
	| LearningDifficultyOrDisabilityDeclaration |                      |
	| PrimaryLearningDifficultyOrDisability     | 5                    |
	| SecondaryLearningDifficultyOrDisability   |                      |
	| DateAndTimeLLDDHealthConsentCollected     |                      |
	| ConsentToCollectEthnicity                 | true                 |
	| Ethnicity                                 | 32                   |
	| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	Then there should be a 201 response
	And the response body should contain:
	| Field                                     | Value                |
	| ConsentToCollectLLDDHealth                | true                 |
	| LearningDifficultyOrDisabilityDeclaration | 9                    |
	| PrimaryLearningDifficultyOrDisability     | 5                    |
	| SecondaryLearningDifficultyOrDisability   | 99                   |
	| ConsentToCollectEthnicity                 | true                 |
	| Ethnicity                                 | 32                   |
	| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	And the date field DateAndTimeLLDDHealthConsentCollected should hold a recent value

############################################################################################################################
## ConsentToCollectEthnicity	MANDATORY
############################################################################################################################


@diversitydetails  
Scenario Outline:Post Diversity with valid values for ConsentToCollectEthnicity 
	Given I want to send <Field> with value <Value> in the following request
	When I post a DiversityDetail with the following details:
	| Field                                     | Value |
	| ConsentToCollectLLDDHealth                | false |
	| LearningDifficultyOrDisabilityDeclaration | 9     |
	| Ethnicity                                 | 99    |
	Then there should be a 201 response
	And the response body should contain:
	| Field                      | Value |
	| Ethnicity                  | 99    |
	And the response body should have <Field> with value <Value>
	
	Examples:
	| Field                     | Value |
	| ConsentToCollectEthnicity | True  |
	| ConsentToCollectEthnicity | False |
	




@diversitydetails  
Scenario Outline: Post Diversity with invalid values for ConsentToCollectEthnicity 
	Given I want to send <Field> with value <Value> in the following request
	When I post a DiversityDetail with the following details:
	| Field                                     | Value |
	| LearningDifficultyOrDisabilityDeclaration |   9    |
	| ConsentToCollectLLDDHealth | false  |
	| Ethnicity                  | 99    |
	Then there should be a 422 response
	#And the error message should be "PLACEHOLDER"
	
	Examples:
	| Field                     | Value |
	| ConsentToCollectEthnicity | 1     |
	| ConsentToCollectEthnicity | abc   |

@diversitydetails  
Scenario: Post Diversity with no value supplied for ConsentToCollectEthnicity

	When I post a DiversityDetail with the following details:
	| Field                                     | Value                |
	| ConsentToCollectLLDDHealth                | false                |
	| LearningDifficultyOrDisabilityDeclaration |                      |
	| PrimaryLearningDifficultyOrDisability     | 5                    |
	| SecondaryLearningDifficultyOrDisability   |                      |
	| DateAndTimeLLDDHealthConsentCollected      |                      |
	| ConsentToCollectEthnicity                 |                      |
	| Ethnicity                                 | 32                   |
	| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	Then there should be a 422 response
	And the error message should be "The ConsentToCollectEthnicity field is required."


############################################################################################################################
## Ethnicity MANDATORY LOOKUP
############################################################################################################################


@diversitydetails  
Scenario Outline:Post Diversity with valid values for Ethnicity 
	Given I want to send <Field> with value <Value> in the following request
	When I post a DiversityDetail with the following details:
	| Field                                     | Value |
	| ConsentToCollectLLDDHealth                | true  |
	| ConsentToCollectEthnicity                 | true  |
	| LearningDifficultyOrDisabilityDeclaration | 1      |
	Then there should be a 201 response
	And the response body should contain:
	| Field                      | Value |
	| ConsentToCollectLLDDHealth | true  |
	| ConsentToCollectEthnicity  | true  |
	And the response body should have <Field> with value <Value>
	
	Examples:
	| Field     | Value |
	| Ethnicity | 31    |
	| Ethnicity | 32    |
	| Ethnicity | 33    |
	| Ethnicity | 34    |
	| Ethnicity | 35    |
	| Ethnicity | 36    |
	| Ethnicity | 37    |
	| Ethnicity | 38    |
	| Ethnicity | 39    |
	| Ethnicity | 40    |
	| Ethnicity | 41    |
	| Ethnicity | 42    |
	| Ethnicity | 43    |
	| Ethnicity | 44    |
	| Ethnicity | 45    |
	| Ethnicity | 46    |
	| Ethnicity | 47    |
	| Ethnicity | 98    |
	| Ethnicity | 99    |

@diversitydetails  
Scenario Outline: Post Diversity with invalid values for Ethnicity 
	Given I want to send <Field> with value <Value> in the following request
	When I post a DiversityDetail with the following details:
	| Field                      | Value |
	| ConsentToCollectLLDDHealth | true  |
	| ConsentToCollectEthnicity  | true  |
	Then there should be a 422 response
	And the error message should be "Please supply a valid Ethnicity"
	
	Examples:
	| Field     | Value |
	| Ethnicity | 0     |
	| Ethnicity | 30    |
	| Ethnicity | 48    |
	| Ethnicity | 50    |
	| Ethnicity | 90    |
	| Ethnicity | 97    |
	| Ethnicity | 100   |

@diversitydetails  
Scenario: Post Diversity with no value supplied for Ethnicity

	When I post a DiversityDetail with the following details:
	| Field                                     | Value |
	| ConsentToCollectLLDDHealth                | false |
	| LearningDifficultyOrDisabilityDeclaration |       |
	| PrimaryLearningDifficultyOrDisability     | 5     |
	| SecondaryLearningDifficultyOrDisability   |       |
	| DateAndTimeLLDDHealthConsentCollected     |       |
	| ConsentToCollectEthnicity                 | true  |
	| Ethnicity                                 |       |
	Then there should be a 201 response
		And the response body should contain:
	| Field     | Value |
	| Ethnicity | 99    |
	

############################################################################################################################
## DateAndTimeEthnicityCollected	MANDATORY if Consent is Given   :  <= Now
############################################################################################################################

@diversitydetails  
Scenario Outline:Post Diversity with valid values for DateAndTimeEthnicityCollected 
	Given I want to send <Field> with value <Value> in the following request
	When I post a DiversityDetail with the following details:
	| Field                                     | Value |
	| ConsentToCollectLLDDHealth                | true  |
	| ConsentToCollectEthnicity                 | false |
	| LearningDifficultyOrDisabilityDeclaration | 1     |
	| Ethnicity                                 | 99    |
	Then there should be a 201 response
	And the response body should contain:
	| Field                      | Value |
	| ConsentToCollectLLDDHealth | true  |
	| ConsentToCollectEthnicity  | false |
	| Ethnicity                  | 99    |
	And the response body value for DateAndTimeEthnicityCollected should match the last request

	Examples:
	| Field                         | Value                |
	| DateAndTimeEthnicityCollected | now                  |
	| DateAndTimeEthnicityCollected | today                |
	| DateAndTimeEthnicityCollected | 2018-08-25T11:21:00Z |




@diversitydetails  
Scenario Outline: Post Diversity with invalid values for DateAndTimeEthnicityCollected 
	Given I want to send <Field> with value <Value> in the following request
	When I post a DiversityDetail with the following details:
	| Field                                     | Value |
	| ConsentToCollectLLDDHealth                | true  |
	| ConsentToCollectEthnicity                 | false |
	| LearningDifficultyOrDisabilityDeclaration | 1     |
	| Ethnicity                                 | 99    |
	Then there should be a 422 response
	And the error message should be "Date And Time Ethnicity Collected must be less the current date/time"
	
	Examples:
	| Field                         | Value       |
	| DateAndTimeEthnicityCollected | now +1Hour  |
	| DateAndTimeEthnicityCollected | today +1Day |

@diversitydetails  
Scenario: Post Diversity with no value supplied for DateAndTimeEthnicityCollected and no consent to collect  Ethnicity data given

	When I post a DiversityDetail with the following details:
	| Field                                     | Value |
	| ConsentToCollectLLDDHealth                | false |
	| LearningDifficultyOrDisabilityDeclaration | 1     |
	| PrimaryLearningDifficultyOrDisability     | 5     |
	| SecondaryLearningDifficultyOrDisability   |       |
	| DateAndTimeLLDDHealthConsentCollected     |       |
	| ConsentToCollectEthnicity                 | false |
	| Ethnicity                                 | 38    |
	| DateAndTimeEthnicityCollected             |       |
	Then there should be a 201 response
	And the response body should contain:
	| Field                                     | Value |
	| ConsentToCollectLLDDHealth                | false |
	| LearningDifficultyOrDisabilityDeclaration | 1     |
	| PrimaryLearningDifficultyOrDisability     | 5     |
	| SecondaryLearningDifficultyOrDisability   | 99    |
	| DateAndTimeLLDDHealthConsentCollected     |       |
	| ConsentToCollectEthnicity                 | false |
	| DateAndTimeEthnicityCollected             |       |

@diversitydetails  
Scenario: Post Diversity with no value supplied for DateAndTimeEthnicityCollected with consent to collect Ethnicity data given

	When I post a DiversityDetail with the following details:
	| Field                                     | Value |
	| ConsentToCollectLLDDHealth                | false |
	| LearningDifficultyOrDisabilityDeclaration |       |
	| PrimaryLearningDifficultyOrDisability     | 5     |
	| SecondaryLearningDifficultyOrDisability   |       |
	| DateAndTimeLLDDHealthConsentCollected      |       |
	| ConsentToCollectEthnicity                 | true |
	| DateAndTimeEthnicityCollected             |       |
	Then there should be a 201 response
	And the date field DateAndTimeEthnicityCollected should hold a recent value
	#And the error message should be "PLACEHOLDER"


############################################################################################################################
## CreatedBy
############################################################################################################################



############################################################################################################################
## Other tests
############################################################################################################################


@diversitydetails  
Scenario: Post a second Diversity record

	Given I post a Diversity Details record with the following details:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                | true                 |
		| LearningDifficultyOrDisabilityDeclaration | 1                    |
		| PrimaryLearningDifficultyOrDisability     | 4                    |
		| SecondaryLearningDifficultyOrDisability   | 5                    |
		| DateAndTimeLLDDHealthConsentCollected      | 2018-06-25T11:21:00Z |
		| ConsentToCollectEthnicity                 | true                 |
		| EthnicityID                               | 32                   |
		| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	When I post a DiversityDetail with the following details:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                | true                 |
		| LearningDifficultyOrDisabilityDeclaration | 1                    |
		| PrimaryLearningDifficultyOrDisability     | 4                    |
		| SecondaryLearningDifficultyOrDisability   | 5                    |
		| DateAndTimeLLDDHealthConsentCollected      | 2018-06-25T11:21:00Z |
		| ConsentToCollectEthnicity                 | true                 |
		| EthnicityID                               | 32                   |
		| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	Then there should be a 409 response

Scenario: Post diversity for a terminated customer
		Given I patch "Customers" with the following details:
		 | Field                | Value                |
		 | DateOfTermination    | 2018-07-20T21:45:00Z |
		 | ReasonForTermination | 1                    |
		When I post a DiversityDetail with the following details:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                | true                 |
		| LearningDifficultyOrDisabilityDeclaration | 1                    |
		| PrimaryLearningDifficultyOrDisability     | 4                    |
		| SecondaryLearningDifficultyOrDisability   | 5                    |
		| DateAndTimeLLDDHealthConsentCollected      | 2018-06-25T11:21:00Z |
		| ConsentToCollectEthnicity                 | true                 |
		| EthnicityID                               | 32                   |
		| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
		Then there should be a 403 response