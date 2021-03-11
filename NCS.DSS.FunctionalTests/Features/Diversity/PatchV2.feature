Feature: DiversityV2_Patch

Background: Create Adviser
	Given I post an adviser with the following details:
		| Field                | Value          |
		| AdviserName          | BillyAdviser   |
		| AdviserContactNumber | 98798678967967 |
	And I post a Customer with the following details:
		| Field      | Value    |
		| GivenName  | Bob      |
		| FamilyName | Customer |

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
Scenario Outline:Patch Diversity with valid values for ConsentToCollectLLDDHealth
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
	Then there should be a 200 response
	And the response body should have <Field> with value <Value>

	Examples:
		| Field                      | Value |
		| ConsentToCollectLLDDHealth | True  |
		| ConsentToCollectLLDDHealth | False |

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

#@diversitydetails
#Scenario: Patch Diversity with ConsentToCollectLLDDHealth where no value exists for DateAndTimeLLDDHealthConsentCollected
#
#	When I post a DiversityDetail with the following details V2:
#	| Field                                     | Value                |
#	| ConsentToCollectLLDDHealth                | false                |
#	| LearningDifficultyOrDisabilityDeclaration | 1                    |
#	| PrimaryLearningDifficultyOrDisability     | 4                    |
#	| SecondaryLearningDifficultyOrDisability   | 5                    |
#	| DateAndTimeLLDDHealthConsentCollected     |                      |
#	| ConsentToCollectEthnicity                 | true                 |
#	| Ethnicity                                 | 32                   |
#	| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
#Given I patch the following DiversityDetail V2:
#	| Field                      | Value |
#	Then there should be a 200 response
#	And the date field DateAndTimeLLDDHealthConsentCollected should hold a recent value
#
#
############################################################################################################################
## LearningDifficultyOrDisabilityDeclaration
############################################################################################################################
@diversitydetails
Scenario Outline:Patch Diversity with valid values for LearningDifficultyOrDisabilityDeclaration
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
	Then there should be a 200 response
	And the response body should contain:
		| Field                      | Value |
		| ConsentToCollectLLDDHealth | true  |
		| ConsentToCollectEthnicity  | true  |
		| Ethnicity                  | 32    |
	And the response body should have <Field> with value <Value>

	Examples:
		| Field                                     | Value |
		| LearningDifficultyOrDisabilityDeclaration | 1     |
		| LearningDifficultyOrDisabilityDeclaration | 2     |
		| LearningDifficultyOrDisabilityDeclaration | 9     |

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

@diversitydetails
Scenario Outline: Patch Diversity with no value supplied for LearningDifficultyOrDisabilityDeclaration
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

	Examples:
		| Field                                     | Value |
		| LearningDifficultyOrDisabilityDeclaration |       |

############################################################################################################################
## PrimaryLearningDifficultyOrDisability
############################################################################################################################
@diversitydetails
Scenario Outline:Patch Diversity with valid values for PrimaryLearningDifficultyOrDisability
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
	Then there should be a 200 response
	And the response body should contain:
		| Field                      | Value |
		| ConsentToCollectLLDDHealth | true  |
		| ConsentToCollectEthnicity  | true  |
		| Ethnicity                  | 32    |
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

#
@diversitydetails
Scenario Outline: Patch Diversity with no value supplied for PrimaryLearningDifficultyOrDisability
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

	Examples:
		| Field                                 | Value |
		| PrimaryLearningDifficultyOrDisability |       |

############################################################################################################################
## SecondaryLearningDifficultyOrDisability
############################################################################################################################
@diversitydetails
Scenario Outline:Patch Diversity with valid values for SecondaryLearningDifficultyOrDisability
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
	Then there should be a 200 response
	And the response body should have <Field> with value <Value>

	Examples:
		| Field                                   | Value |
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

#
@diversitydetails
Scenario Outline: Patch Diversity with no value supplied for SecondaryLearningDifficultyOrDisability
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

	Examples:
		| Field                                   | Value |
		| SecondaryLearningDifficultyOrDisability |       |

############################################################################################################################
## DateAndTimeLDDHealthConsentCollected			MANDATORY IF CONSENT GIVEN	Date < NOW
############################################################################################################################
@diversitydetails
Scenario Outline:Patch Diversity with valid values for DateAndTimeLLDDHealthConsentCollected
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
	Then there should be a 200 response

	#And the response body value for DateAndTimeLLDDHealthConsentCollected should match the last request
	Examples:
		| Field                                 | Value                |
		| DateAndTimeLLDDHealthConsentCollected | now                  |
		| DateAndTimeLLDDHealthConsentCollected | today                |
		| DateAndTimeLLDDHealthConsentCollected | 2018-08-25T11:21:00Z |

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

############################################################################################################################
## ConsentToCollectEthnicity	MANDATORY
############################################################################################################################
@diversitydetails
Scenario Outline:Patch Diversity with valid values for ConsentToCollectEthnicity
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
	Then there should be a 200 response
	And the response body should have <Field> with value <Value>

	Examples:
		| Field                     | Value |
		| ConsentToCollectEthnicity | True  |
		| ConsentToCollectEthnicity | False |

@diversitydetails
Scenario Outline: Patch Diversity with invalid values for ConsentToCollectEthnicity
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
		| Field                     | Value |
		| ConsentToCollectEthnicity | 1     |
		| ConsentToCollectEthnicity | abc   |

@diversitydetails
Scenario Outline: Patch Diversity with no value supplied for ConsentToCollectEthnicity
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

	Examples:
		| Field                     | Value |
		| ConsentToCollectEthnicity |       |

@diversitydetails
Scenario: Patch Diversity with ConsentToCollectEthnicity where no value exists for DateAndTimeEthnicityCollected
	When I post a DiversityDetail with the following details V2:
		| Field                                     | Value |
		| ConsentToCollectLLDDHealth                | false |
		| LearningDifficultyOrDisabilityDeclaration | 1     |
		| PrimaryLearningDifficultyOrDisability     | 4     |
		| SecondaryLearningDifficultyOrDisability   | 5     |
		| DateAndTimeLLDDHealthConsentCollected     |       |
		| ConsentToCollectEthnicity                 | false |
		| Ethnicity                                 | 32    |
		| DateAndTimeEthnicityCollected             |       |
	Given I patch the following DiversityDetail V2:
		| Field                     | Value |
		| ConsentToCollectEthnicity | true  |
	Then there should be a 200 response
	And the response body should contain:
		| Field                                     | Value |
		| ConsentToCollectLLDDHealth                | false |
		| LearningDifficultyOrDisabilityDeclaration | 1     |
		| PrimaryLearningDifficultyOrDisability     | 4     |
		| SecondaryLearningDifficultyOrDisability   | 5     |
		| DateAndTimeLLDDHealthConsentCollected     |       |
		| ConsentToCollectEthnicity                 | true  |
		| Ethnicity                                 | 32    |

#And the date field DateAndTimeEthnicityCollected should hold a recent value
#
############################################################################################################################
## Ethnicity MANDATORY LOOKUP
############################################################################################################################
@diversitydetails
Scenario Outline:Patch Diversity with valid values for Ethnicity
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
	Then there should be a 200 response
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

@diversitydetails
Scenario Outline: Patch Diversity with no value supplied for Ethnicity
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

	Examples:
		| Field                     | Value |
		| ConsentToCollectEthnicity |       |

############################################################################################################################
## DateAndTimeEthnicityCollected	MANDATORY if Consent is Given   :  <= Now
############################################################################################################################
@diversitydetails
Scenario Outline:Patch Diversity with valid values for DateAndTimeEthnicityCollected
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
	Then there should be a 200 response

	#And the response body should have <Field> with value <Value>
	Examples:
		| Field                         | Value                |
		| DateAndTimeEthnicityCollected | now                  |
		| DateAndTimeEthnicityCollected | today                |
		| DateAndTimeEthnicityCollected | 2018-08-25T11:21:00Z |

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

@diversitydetails
Scenario Outline: Patch Diversity with no value supplied for DateAndTimeEthnicityCollected
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

	Examples:
		| Field                         | Value |
		| DateAndTimeEthnicityCollected |       |