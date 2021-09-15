Feature: DiversityV2_Post

Background: Create Adviser
	Given I post an adviser with the following details V2:
		| Field                | Value          |
		| AdviserName          | BillyAdviser   |
		| AdviserContactNumber | 98798678967967 |
	And I post a Customer with the following details V3:
		| Field      | Value    |
		| GivenName  | Bob      |
		| FamilyName | Customer |
		| PriorityGroups | 1,3  |

@diversitydetails  @smoke
Scenario: Post Diversity with all values
	When I post a DiversityDetail with the following details V2:
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
		| DateAndTimeLLDDHealthConsentCollected     | 2018-06-25T11:21:00Z |
		| ConsentToCollectEthnicity                 | true                 |
		| Ethnicity                                 | 32                   |
		| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
		| LastModifiedDate                          | 2018-08-25T11:21:00Z |
	#And the "diversitydetails" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-diversitydetails table with DiversityId

############################################################################################################################
##	ConsentToCollectLLDDHealth
############################################################################################################################
@diversitydetails
Scenario Outline: Post Diversity with invalid values for ConsentToCollectLLDDHealth
	Given I want to send <Field> with value <Value> in the following request
	When I post a DiversityDetail with the following details V2:
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
	When I post a DiversityDetail with the following details V2:
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
Scenario Outline: Post Diversity with invalid values for LearningDifficultyOrDisabilityDeclaration
	Given I want to send <Field> with value <Value> in the following request
	When I post a DiversityDetail with the following details V2:
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
		| LearningDifficultyOrDisabilityDeclaration | 10    |
		| LearningDifficultyOrDisabilityDeclaration | 98    |
		| LearningDifficultyOrDisabilityDeclaration | 99    |
		| LearningDifficultyOrDisabilityDeclaration | 100   |


############################################################################################################################
## PrimaryLearningDifficultyOrDisability
############################################################################################################################
@diversitydetails
Scenario Outline: Post Diversity with invalid values for PrimaryLearningDifficultyOrDisability
	Given I want to send <Field> with value <Value> in the following request
	When I post a DiversityDetail with the following details V2:
		| Field                      | Value |
		| ConsentToCollectLLDDHealth | true  |
		| ConsentToCollectEthnicity  | false |
		| Ethnicity                  | 99    |
	Then there should be a 422 response
	And the error message should be "Please supply a valid Primary Learning Difficulty Or Disability"

	Examples:
		| Field                                 | Value |
		| PrimaryLearningDifficultyOrDisability | -1    |
		| PrimaryLearningDifficultyOrDisability | 1     |
		| PrimaryLearningDifficultyOrDisability | 2     |
		| PrimaryLearningDifficultyOrDisability | 3     |
		| PrimaryLearningDifficultyOrDisability | 18    |
		| PrimaryLearningDifficultyOrDisability | 20    |
		| PrimaryLearningDifficultyOrDisability | 20    |
		| PrimaryLearningDifficultyOrDisability | 90    |
		| PrimaryLearningDifficultyOrDisability | 92    |
		| PrimaryLearningDifficultyOrDisability | 100   |

#############################################################################################################################
## SecondaryLearningDifficultyOrDisability
############################################################################################################################
@diversitydetails
Scenario Outline: Post Diversity with invalid values for SecondaryLearningDifficultyOrDisability
	Given I want to send <Field> with value <Value> in the following request
	When I post a DiversityDetail with the following details V2:
		| Field                      | Value |
		| ConsentToCollectLLDDHealth | true  |
		| ConsentToCollectEthnicity  | false |
		| Ethnicity                  | 99    |
	Then there should be a 422 response
	And the error message should be "Please supply a valid Secondary Learning Difficulty Or Disability"

	Examples:
		| Field                                   | Value |
		| SecondaryLearningDifficultyOrDisability | -1    |
		| SecondaryLearningDifficultyOrDisability | 1     |
		| SecondaryLearningDifficultyOrDisability | 2     |
		| SecondaryLearningDifficultyOrDisability | 3     |
		| SecondaryLearningDifficultyOrDisability | 18    |
		| SecondaryLearningDifficultyOrDisability | 20    |
		| SecondaryLearningDifficultyOrDisability | 20    |
		| SecondaryLearningDifficultyOrDisability | 90    |
		| SecondaryLearningDifficultyOrDisability | 92    |
		| SecondaryLearningDifficultyOrDisability | 100   |

@diversitydetails
Scenario: Post Diversity with no value supplied for SecondaryLearningDifficultyOrDisability
	When I post a DiversityDetail with the following details V2:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                | true                 |
		| LearningDifficultyOrDisabilityDeclaration |                      |
		| PrimaryLearningDifficultyOrDisability     | 5                    |
		| SecondaryLearningDifficultyOrDisability   |                      |
		| DateAndTimeLLDDHealthConsentCollected     | 2018-06-25T11:21:00Z |
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
Scenario Outline: Post Diversity with invalid values for DateAndTimeLLDDHealthConsentCollected
	Given I want to send <Field> with value Translate Date To <Value>
	When I post a DiversityDetail with the following details V2:
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


#And the date field DateAndTimeLLDDHealthConsentCollected should hold a recent value
#
############################################################################################################################
## ConsentToCollectEthnicity	MANDATORY
############################################################################################################################
@diversitydetails
Scenario Outline: Post Diversity with invalid values for ConsentToCollectEthnicity
	Given I want to send <Field> with value <Value> in the following request
	When I post a DiversityDetail with the following details V2:
		| Field                                     | Value |
		| LearningDifficultyOrDisabilityDeclaration | 9     |
		| ConsentToCollectLLDDHealth                | false |
		| Ethnicity                                 | 99    |
	Then there should be a 422 response

	#And the error message should be "PLACEHOLDER"
	Examples:
		| Field                     | Value |
		| ConsentToCollectEthnicity | 1     |
		| ConsentToCollectEthnicity | abc   |

@diversitydetails
Scenario: Post Diversity with no value supplied for ConsentToCollectEthnicity
	When I post a DiversityDetail with the following details V2:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                | false                |
		| LearningDifficultyOrDisabilityDeclaration |                      |
		| PrimaryLearningDifficultyOrDisability     | 5                    |
		| SecondaryLearningDifficultyOrDisability   |                      |
		| DateAndTimeLLDDHealthConsentCollected     |                      |
		| ConsentToCollectEthnicity                 |                      |
		| Ethnicity                                 | 32                   |
		| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	Then there should be a 422 response
	And the error message should be "The ConsentToCollectEthnicity field is required."

############################################################################################################################
## Ethnicity MANDATORY LOOKUP
############################################################################################################################
@diversitydetails
Scenario Outline: Post Diversity with invalid values for Ethnicity
	Given I want to send <Field> with value <Value> in the following request
	When I post a DiversityDetail with the following details V2:
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


############################################################################################################################
## DateAndTimeEthnicityCollected	MANDATORY if Consent is Given   :  <= Now
############################################################################################################################
@diversitydetails
Scenario Outline: Post Diversity with invalid values for DateAndTimeEthnicityCollected
	Given I want to send <Field> with value Translate Date To <Value>
	When I post a DiversityDetail with the following details V2:
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


#And the date field DateAndTimeEthnicityCollected should hold a recent value
#And the error message should be "PLACEHOLDER"
############################################################################################################################
## CreatedBy
############################################################################################################################
#
#
############################################################################################################################
## Other tests
############################################################################################################################
@diversitydetails
Scenario: Post a second Diversity record
	When I post a DiversityDetail with the following details V2:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                | true                 |
		| LearningDifficultyOrDisabilityDeclaration | 1                    |
		| PrimaryLearningDifficultyOrDisability     | 4                    |
		| SecondaryLearningDifficultyOrDisability   | 5                    |
		| DateAndTimeLLDDHealthConsentCollected     | 2018-06-25T11:21:00Z |
		| ConsentToCollectEthnicity                 | true                 |
		| EthnicityID                               | 32                   |
		| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	And  I post a DiversityDetail with the following details V2:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                | true                 |
		| LearningDifficultyOrDisabilityDeclaration | 1                    |
		| PrimaryLearningDifficultyOrDisability     | 4                    |
		| SecondaryLearningDifficultyOrDisability   | 5                    |
		| DateAndTimeLLDDHealthConsentCollected     | 2018-06-25T11:21:00Z |
		| ConsentToCollectEthnicity                 | true                 |
		| EthnicityID                               | 32                   |
		| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	Then there should be a 409 response

#
Scenario: Post diversity for a terminated customer
	When I patch the following Customer V3:
		| Field                | Value                |
		| DateOfTermination    | 2018-07-20T21:45:00Z |
		| ReasonForTermination | 1                    |
	And I post a DiversityDetail with the following details V2:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                | true                 |
		| LearningDifficultyOrDisabilityDeclaration | 1                    |
		| PrimaryLearningDifficultyOrDisability     | 4                    |
		| SecondaryLearningDifficultyOrDisability   | 5                    |
		| DateAndTimeLLDDHealthConsentCollected     | 2018-06-25T11:21:00Z |
		| ConsentToCollectEthnicity                 | true                 |
		| EthnicityID                               | 32                   |
		| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	Then there should be a 403 response