Feature: DiversityV2_Patch

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
Scenario:Patch Diversity with all values
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
	Then there should be a 201 response
	Given I patch the following DiversityDetail V2:
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
		| LastModifiedDate                          | 2018-08-25T11:21:00Z |
	#And the "diversitydetails" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 10 Seconds
	Then there should be a record in the dss-diversitydetails table with DiversityId

#And there should be a record in the diversitydetails-history ChangeFeed table
############################################################################################################################
##	ConsentToCollectLLDDHealth
############################################################################################################################


@diversitydetails
Scenario Outline: Patch Diversity with invalid values for ConsentToCollectLLDDHealth
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
	Given I want to send <Field> with value <Value> in the following request
	Given I patch the following DiversityDetail V2:
		| Field                      | Value |
	Then there should be a 422 response

	Examples:
		| Field                      | Value |
		| ConsentToCollectLLDDHealth | 1     |
		| ConsentToCollectLLDDHealth | car   |


#
#
############################################################################################################################
## LearningDifficultyOrDisabilityDeclaration
############################################################################################################################
@diversitydetails
Scenario Outline: Patch Diversity with invalid values for LearningDifficultyOrDisabilityDeclaration
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
	Given I want to send <Field> with value <Value> in the following request
	Given I patch the following DiversityDetail V2:
		| Field                      | Value |
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
Scenario Outline: Patch Diversity with invalid values for PrimaryLearningDifficultyOrDisability
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
	Given I want to send <Field> with value <Value> in the following request
	Given I patch the following DiversityDetail V2:
		| Field                      | Value |
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


############################################################################################################################
## SecondaryLearningDifficultyOrDisability
############################################################################################################################
@diversitydetails
Scenario Outline: Patch Diversity with invalid values for SecondaryLearningDifficultyOrDisability
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
	Given I want to send <Field> with value <Value> in the following request
	Given I patch the following DiversityDetail V2:
		| Field                      | Value |
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


############################################################################################################################
## DateAndTimeLDDHealthConsentCollected			MANDATORY IF CONSENT GIVEN	Date < NOW
############################################################################################################################
@diversitydetails
Scenario Outline: Patch Diversity with invalid values for DateAndTimeLDDHealthConsentCollected
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
	Given I want to send <Field> with value Translate Date To <Value>
	Given I patch the following DiversityDetail V2:
		| Field                      | Value |
	Then there should be a 422 response
	And the error message should be "Date And Time LLDD Health Consent Collected must be less the current date/time"

	Examples:
		| Field                                 | Value       |
		| DateAndTimeLLDDHealthConsentCollected | now +1Hour  |
		| DateAndTimeLLDDHealthConsentCollected | today +1Day |


#And the date field DateAndTimeEthnicityCollected should hold a recent value
#
############################################################################################################################
## Ethnicity MANDATORY LOOKUP
############################################################################################################################
@diversitydetails
Scenario Outline: Patch Diversity with invalid values for Ethnicity
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
	Given I want to send <Field> with value <Value> in the following request
	Given I patch the following DiversityDetail V2:
		| Field                      | Value |
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
Scenario Outline: Patch Diversity with invalid values for DateAndTimeEthnicityCollected
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
	Given I want to send <Field> with value Translate Date To <Value>
	Given I patch the following DiversityDetail V2:
		| Field                      | Value |
	Then there should be a 422 response
	And the error message should be "Date And Time Ethnicity Collected must be less the current date/time"

	Examples:
		| Field                         | Value       |
		| DateAndTimeEthnicityCollected | now +1Hour  |
		| DateAndTimeEthnicityCollected | today +1Day |

