Feature: LearningProgression_Patch

Background:
	Given I post an adviser with the following details V2:
		| Field                | Value          |
		| AdviserName          | BillyAdviser   |
		| AdviserContactNumber | 98798678967967 |
	And I post a Customer with the following details V3:
		| Field          | Value    |
		| GivenName      | Bob      |
		| FamilyName     | Customer |
		| PriorityGroups | 1,3      |

@learningprogressions  @smoke
Scenario:Patch Learning Progression with  all values
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	When I patch the following LearningProgression V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
		| LastModifiedDate               | 2019-07-25T11:21:00Z |
	Then there should be a 200 response
	And the response body should contain:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	#And the "learningprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-learningprogressions table with LearningProgressionId

#And there should be 2 records in the dss-learningprogressions-history table with LearningProgressionId
###########################################################################################
##	DateProgressionRecorded
###########################################################################################
@learningprogressions
Scenario Outline: Patch Learning Progression with valid values for DateProgressionRecorded
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	Given I want to send <Field> with value Translate Date To <Value>
	When I patch the following LearningProgression V3:
		| Field                   | Value                |
	Then there should be a 200 response
	And the response body should contain:
		| Field                          | Value                |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	#And the "learningprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-learningprogressions table with LearningProgressionId

	Examples:
		| Field                   | Value                |
		| DateProgressionRecorded | Today                |
		| DateProgressionRecorded | Now                  |
		| DateProgressionRecorded | 2019-06-19T09:01:00Z |

@learningprogressions
Scenario Outline: Patch Learning Progression with invalid DateProgressionRecorded
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	Given I want to send <Field> with value Translate Date To <Value>
	When I patch the following LearningProgression V3:
		| Field                   | Value                |
	Then there should be a 422 response
	And the response body should include <ErrorMessage>
	And the number of errors returned should be 1

	Examples:
		| Field                   | Value                | ErrorMessage                         |
		| DateProgressionRecorded | gtfr-06-19T09:01:00Z | Could not convert string to DateTime |
		| DateProgressionRecorded | 2018-00-19T09:01:00Z | Could not convert string to DateTime |
		| DateProgressionRecorded | 2018-13-19T09:01:00Z | Could not convert string to DateTime |
		| DateProgressionRecorded | 2018-05-00T09:01:00Z | Could not convert string to DateTime |
		| DateProgressionRecorded | 2018-05-32T09:01:00Z | Could not convert string to DateTime |

@learningprogressions
Scenario Outline: Patch Learning Progression with future dated DateProgressionRecorded
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	Given I want to send <Field> with value Translate Date To <Value>
	When I patch the following LearningProgression V3:
		| Field                   | Value                |
	Then there should be a 422 response
	And the response body should include <ErrorMessage>
	And the number of errors returned should be 1

	Examples:
		| Field                   | Value     | ErrorMessage                                               |
		| DateProgressionRecorded | Today +1D | DateProgressionRecorded must be less than or equal to now. |
		| DateProgressionRecorded | Now + 1H  | DateProgressionRecorded must be less than or equal to now. |
		| DateProgressionRecorded | Today +1Y | DateProgressionRecorded must be less than or equal to now. |

@learningprogressions
Scenario Outline: Patch Learning Progression with empty DateProgressionRecorded
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	Given I want to send <Field> with value <Value> in the following request
	When I patch the following LearningProgression V3:
		| Field                   | Value                |
	Then there should be a 200 response
	#And the response body value for <Field> should match the original request
	And the response body should contain:
		| Field                          | Value                |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |

	Examples:
		| Field                   | Value |
		| DateProgressionRecorded |       |

###########################################################################################
##	CurrentLearningStatus
###########################################################################################
@learningprogressions
Scenario Outline: Patch Learning Progression with CurrentLearningStatus
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	Given I want to send <Field> with value <Value> in the following request
	When I patch the following LearningProgression V3:
		| Field                   | Value                |
	Then there should be a 200 response
	And the response body should have <Field> with value <Value>
	And the response body should contain:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	#And the "learningprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-learningprogressions table with LearningProgressionId

	Examples:
		| Field                 | Value |
		| CurrentLearningStatus | 1     |
		| CurrentLearningStatus | 2     |
		| CurrentLearningStatus | 3     |
		| CurrentLearningStatus | 98    |
		| CurrentLearningStatus | 99    |

@learningprogressions
Scenario Outline: Patch Learning Progression with invalid CurrentLearningStatus
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	Given I want to send <Field> with value <Value> in the following request
	When I patch the following LearningProgression V3:
		| Field                   | Value                |
	Then there should be a 422 response
	And the response body should include <ErrorMessage>
	And the number of errors returned should be 1

	Examples:
		| Field                 | Value | ErrorMessage                                                  |
		| CurrentLearningStatus | -1    | CurrentLearningStatus must be a valid current Learning Status |
		| CurrentLearningStatus | 0     | CurrentLearningStatus must be a valid current Learning Status |
		| CurrentLearningStatus | 4     | CurrentLearningStatus must be a valid current Learning Status |
		| CurrentLearningStatus | 97    | CurrentLearningStatus must be a valid current Learning Status |
		| CurrentLearningStatus | 100   | CurrentLearningStatus must be a valid current Learning Status |

@learningprogressions
Scenario Outline: Patch Learning Progression with empty CurrentLearningStatus
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	Given I want to send <Field> with value <Value> in the following request
	When I patch the following LearningProgression V3:
		| Field                   | Value                |
	Then there should be a 200 response
	And the response body should contain:
		| Field                          | Value                |
		| CurrentLearningStatus          | 1                    |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |

	Examples:
		| Field                 | Value |
		| CurrentLearningStatus |       |

@learningprogressions
Scenario Outline: Patch Learning Progression to set CurrentLearningStatus to a new valid value where there was no previous value for CurrentLearningStatus or LearningHours
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
		| CurrentLearningStatus          | 99                   |
	Given I want to send <Field> with value <Value> in the following request
	When I patch the following LearningProgression V3:
		| Field                   | Value                |
	Then there should be a 200 response
	And the response body should have <Field> with value <Value>
	And the response body should contain:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |

	Examples:
		| Field                 | Value |
		| CurrentLearningStatus | 2     |
		| CurrentLearningStatus | 3     |
		| CurrentLearningStatus | 98    |
		| CurrentLearningStatus | 99    |

#
#@learningprogressions
#Scenario Outline: Patch Learning Progression to set CurrentLearningStatus to InLearning where there was no previous value for CurrentLearningStatus or LearningHours
#
#	Given I post a Learning Progression record with the following details:
#		| Field                          | Value                |
#		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
#		| CurrentQualificationLevel      | 2                    |
#		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
#		| LastLearningProvidersUKPRN     | 12345678             |
#		| CurrentLearningStatus          | 99                   |
#	When I patch the element <Field> with <Value>:
#	Then there should be a 422 response
#	And the response body should include DateLearningStarted must have a value when Current Learning Status is InLearning
#	And the response body should include LearningHours must have a value when Current Learning Status is InLearning
#	And the number of errors returned should be 2
#
#	Examples:
#	| Field                 | Value |
#	| CurrentLearningStatus | 1     |
#
@learningprogressions
Scenario: Patch Learning Progression with value for CurrentLearningStatus AND DateLearningStarted where there was no previous value for CurrentLearningStatus or LearningHours
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-24T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
		| DateLearningStarted            | 2019-07-23T11:21:00Z |
		| CurrentLearningStatus          | 99                   |
	Given I want to send <Field> with value <Value> in the following request
	When I patch the following LearningProgression V3:
		| Field                 | Value                |
		| CurrentLearningStatus | 1                    |
		| DateLearningStarted   | 2019-07-23T11:21:00Z |
	Then there should be a 422 response
	And the response body should include LearningHours must have a value when Current Learning Status is InLearning
	And the number of errors returned should be 1

@learningprogressions
Scenario: Patch Learning Progression with value for CurrentLearningStatus where there was no previous value for CurrentLearningStatus or DateLearningStarted
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-24T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
		| DateLearningStarted            | 2019-07-23T11:21:00Z |
		| CurrentLearningStatus          | 99                   |
	When I patch the following LearningProgression V3:
		| Field                 | Value |
		| CurrentLearningStatus | 1     |
	Then there should be a 422 response
	And the response body should include "LearningHours must have a value when Current Learning Status is InLearning."
	And the number of errors returned should be 1

@learningprogressions
Scenario: Patch Learning Progression with value for CurrentLearningStatus AND DateLearningStarted where there was no previous value for CurrentLearningStatus or DateLearningStarted or LearningHours
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-24T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
		| CurrentLearningStatus          | 99                   |
	When I patch the following LearningProgression V3:
		| Field                 | Value                |
		| CurrentLearningStatus | 1                    |
		| DateLearningStarted   | 2019-07-23T11:21:00Z |
	Then there should be a 422 response
	And the response body should include LearningHours must have a value when Current Learning Status is InLearning
	And the number of errors returned should be 1

@learningprogressions
Scenario: Patch Learning Progression with value for CurrentLearningStatus where there was no previous value for CurrentLearningStatus, DateLearningStarted or LearningHours
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-24T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
		| CurrentLearningStatus          | 99                   |
	When I patch the following LearningProgression V3:
		| Field                 | Value |
		| CurrentLearningStatus | 1     |
	Then there should be a 422 response
	And the response body should include DateLearningStarted must have a value when Current Learning Status is InLearning
	And the response body should include LearningHours must have a value when Current Learning Status is InLearning
	And the number of errors returned should be 2

@learningprogressions
Scenario: Patch Learning Progression with value for CurrentLearningStatus AND DateLearningStarted AND LearningHours where there was no previous value for CurrentLearningStatus, DateLearningStarted or LearningHours
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-24T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
		| CurrentLearningStatus          | 99                   |
	When I patch the following LearningProgression V3:
		| Field                 | Value                |
		| CurrentLearningStatus | 1                    |
		| DateLearningStarted   | 2019-07-24T11:21:00Z |
		| LearningHours         | 2                    |
	Then there should be a 200 response
	And the response body should contain:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-24T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
		| CurrentLearningStatus          | 1                    |
		| DateLearningStarted            | 2019-07-24T11:21:00Z |
		| LearningHours                  | 2                    |

###########################################################################################
##	LearningHours
###########################################################################################
@learningprogressions
Scenario Outline: Patch Learning Progression with LearningHours
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 99                   |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	Given I want to send <Field> with value <Value> in the following request
	When I patch the following LearningProgression V3:
		| Field                 | Value                |
	Then there should be a 200 response
	And the response body should have <Field> with value <Value>
	And the response body should contain:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	#And the "learningprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-learningprogressions table with LearningProgressionId

	Examples:
		| Field         | Value |
		| LearningHours | 1     |
		| LearningHours | 2     |
		| LearningHours | 98    |
		| LearningHours | 99    |

@learningprogressions
Scenario Outline: Patch Learning Progression with invalid LearningHours
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	Given I want to send <Field> with value <Value> in the following request
	When I patch the following LearningProgression V3:
		| Field                 | Value                |
	Then there should be a 422 response
	And the response body should include <ErrorMessage>
	And the number of errors returned should be 1

	Examples:
		| Field         | Value | ErrorMessage                                         |
		| LearningHours | -1    | LearningHours must have a valid Learning Hours value |
		| LearningHours | 0     | LearningHours must have a valid Learning Hours value |
		| LearningHours | 3     | LearningHours must have a valid Learning Hours value |
		| LearningHours | 97    | LearningHours must have a valid Learning Hours value |
		| LearningHours | 100   | LearningHours must have a valid Learning Hours value |

@learningprogressions
Scenario Outline: Patch Learning Progression with empty LearningHours
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	Given I want to send <Field> with value <Value> in the following request
	When I patch the following LearningProgression V3:
		| Field                 | Value                |
	Then there should be a 200 response
	And the response body should contain:
		| Field                          | Value                |
		| CurrentLearningStatus          | 1                    |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |

	Examples:
		| Field         | Value |
		| LearningHours |       |

###########################################################################################
##	DateLearningStarted
###########################################################################################
@learningprogressions
Scenario Outline: Patch Learning Progression with DateLearningStarted
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	Given I want to send <Field> with value Translate Date To <Value>
	When I patch the following LearningProgression V3:
		| Field                 | Value                |
	Then there should be a 200 response
	And the response body should have <Field> with value Translate Date To <Value>
	And the response body should contain:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	#And the "learningprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-learningprogressions table with LearningProgressionId

	Examples:
		| Field               | Value                |
		| DateLearningStarted | 2018-06-25T11:21:00Z |
		| DateLearningStarted | Now                  |
		| DateLearningStarted | Today                |

@learningprogressions
Scenario Outline: Patch Learning Progression with invalid value for DateLearningStarted
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	Given I want to send <Field> with value Translate Date To <Value>
	When I patch the following LearningProgression V3:
		| Field                 | Value                |
	Then there should be a 422 response
	And the response body should include <ErrorMessage>
	And the number of errors returned should be 1

	Examples:
		| Field               | Value                 | ErrorMessage                         |
		| DateLearningStarted | dfgdf-06-19T09:01:00Z | Could not convert string to DateTime |
		| DateLearningStarted | 2018-00-19T09:01:00Z  | Could not convert string to DateTime |
		| DateLearningStarted | 2018-13-19T09:01:00Z  | Could not convert string to DateTime |
		| DateLearningStarted | 2018-05-00T09:01:00Z  | Could not convert string to DateTime |
		| DateLearningStarted | 2018-05-32T09:01:00Z  | Could not convert string to DateTime |

@learningprogressions
Scenario Outline: Patch Learning Progression with future value for DateLearningStarted
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	Given I want to send <Field> with value Translate Date To <Value>
	When I patch the following LearningProgression V3:
		| Field                 | Value                |
	Then there should be a 422 response
	And the response body should include <ErrorMessage>
	And the number of errors returned should be 1

	Examples:
		| Field               | Value     | ErrorMessage                                           |
		| DateLearningStarted | Today +1D | DateLearningStarted must be less than or equal to now. |
		| DateLearningStarted | Now + 1H  | DateLearningStarted must be less than or equal to now. |
		| DateLearningStarted | Today +1Y | DateLearningStarted must be less than or equal to now. |

###########################################################################################
##	CurrentQualificationLevel
###########################################################################################
@learningprogressions
Scenario Outline: Patch Learning Progression with CurrentQualificationLevel
	Given I want to set the scenario touchPointId header to 9111111111
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	Given I want to send <Field> with value <Value> in the following request
	When I patch the following LearningProgression V3:
		| Field                 | Value                |
	Then there should be a 200 response
	And the response body should have <Field> with value <Value>
	And the response body should contain:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-learningprogressions table with LearningProgressionId
	Given I fetch a actions cosmos document from actions database using key ActionId
	Then the cosmos document should have property CreatedBy with value 9111111111

	Examples:
		| Field                     | Value |
		| CurrentQualificationLevel | 0     |
		| CurrentQualificationLevel | 1     |
		| CurrentQualificationLevel | 2     |
		| CurrentQualificationLevel | 3     |
		| CurrentQualificationLevel | 4     |
		| CurrentQualificationLevel | 5     |
		| CurrentQualificationLevel | 6     |
		| CurrentQualificationLevel | 7     |
		| CurrentQualificationLevel | 8     |
		| CurrentLearningStatus     | 99    |

@learningprogressions
Scenario Outline: Patch Learning Progression with invalid value for CurrentQualificationLevel
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	Given I want to send <Field> with value <Value> in the following request
	When I patch the following LearningProgression V3:
		| Field                 | Value                |
	Then there should be a 422 response
	And the response body should include <ErrorMessage>
	And the number of errors returned should be 1

	Examples:
		| Field                     | Value | ErrorMessage                                                          |
		| CurrentQualificationLevel | -1    | CurrentQualificationLevel must be a valid current Qualification Level |
		| CurrentQualificationLevel | 9     | CurrentQualificationLevel must be a valid current Qualification Level |
		| CurrentQualificationLevel | 98    | CurrentQualificationLevel must be a valid current Qualification Level |
		| CurrentQualificationLevel | 100   | CurrentQualificationLevel must be a valid current Qualification Level |

@learningprogressions
Scenario Outline: Patch Learning Progression to set CurrentQualificationLevel < 99 where there was no previous value for CurrentQualificationLevel or DateQualificationLevelAchieved
	Given I post a Learning Progression record with the following details V3:
		| Field                      | Value                |
		| DateProgressionRecorded    | 2018-06-25T11:21:00Z |
		| LastLearningProvidersUKPRN | 12345678             |
		| DateLearningStarted        | 2019-07-23T11:21:00Z |
		| CurrentLearningStatus      | 99                   |
		| CurrentQualificationLevel  | 99                   |
	Given I want to send <Field> with value <Value> in the following request
	When I patch the following LearningProgression V3:
		| Field                 | Value                |
	Then there should be a 422 response
	And the response body should include DateQualificationLevelAchieved is required when QualificationLevel < NoQualification (99).
	And the number of errors returned should be 1

	Examples:
		| Field                     | Value |
		| CurrentQualificationLevel | 1     |
		| CurrentQualificationLevel | 8     |

###########################################################################################
##	DateQualificationLevelAchieved
###########################################################################################
@learningprogressions
Scenario Outline: Patch Learning Progression with DateQualificationLevelAchieved
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	Given I want to send <Field> with value Translate Date To <Value>
	When I patch the following LearningProgression V3:
		| Field                 | Value                |
	Then there should be a 200 response
	And the response body should contain:
		| Field                      | Value                |
		| DateProgressionRecorded    | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus      | 1                    |
		| LearningHours              | 1                    |
		| DateLearningStarted        | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel  | 2                    |
		| LastLearningProvidersUKPRN | 12345678             |
	#And the "learningprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-learningprogressions table with LearningProgressionId

	Examples:
		| Field                          | Value                |
		| DateQualificationLevelAchieved | 2018-06-25T11:21:00Z |
		| DateQualificationLevelAchieved | Now                  |
		| DateQualificationLevelAchieved | Today                |

@learningprogressions
Scenario Outline: Patch Learning Progression with invalid value for DateQualificationLevelAchieved
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	Given I want to send <Field> with value Translate Date To <Value>
	When I patch the following LearningProgression V3:
		| Field                 | Value                |
	Then there should be a 422 response
	And the response body should include <ErrorMessage>
	And the number of errors returned should be 1

	Examples:
		| Field                          | Value                | ErrorMessage                         |
		| DateQualificationLevelAchieved | sdfg-06-19T09:01:00Z | Could not convert string to DateTime |
		| DateQualificationLevelAchieved | 2018-00-19T09:01:00Z | Could not convert string to DateTime |
		| DateQualificationLevelAchieved | 2018-13-19T09:01:00Z | Could not convert string to DateTime |
		| DateQualificationLevelAchieved | 2018-05-00T09:01:00Z | Could not convert string to DateTime |
		| DateQualificationLevelAchieved | 2018-05-32T09:01:00Z | Could not convert string to DateTime |

@learningprogressions
Scenario Outline: Patch Learning Progression with future value for DateQualificationLevelAchieved
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	Given I want to send <Field> with value Translate Date To <Value>
	When I patch the following LearningProgression V3:
		| Field                 | Value                |
	Then there should be a 422 response
	And the response body should include <ErrorMessage>
	And the number of errors returned should be 1

	Examples:
		| Field                          | Value     | ErrorMessage                                                     |
		| DateQualificationLevelAchieved | Today +1D | DateQualificationLevelAchieved must be less than or equal to now |
		| DateQualificationLevelAchieved | Now + 1H  | DateQualificationLevelAchieved must be less than or equal to now |
		| DateQualificationLevelAchieved | Today +1Y | DateQualificationLevelAchieved must be less than or equal to now |

###########################################################################################
##	LastLearningProvidersUKPRN
###########################################################################################
@learningprogressions
Scenario Outline: Patch Learning Progression with LastLearningProvidersUKPRN
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	Given I want to send <Field> with value <Value> in the following request
	When I patch the following LearningProgression V3:
		| Field                   | Value                |
	Then there should be a 200 response
	And the response body should have <Field> with value <Value>
	And the response body should contain:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
	#And the "learningprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-learningprogressions table with LearningProgressionId

	Examples:
		| Field                      | Value    |
		| LastLearningProvidersUKPRN | 10000000 |
		| LastLearningProvidersUKPRN | 10000001 |
		| LastLearningProvidersUKPRN | 51234567 |
		| LastLearningProvidersUKPRN | 99999998 |
		| LastLearningProvidersUKPRN | 99999999 |

Scenario Outline: Patch Learning Progression with invalid LastLearningProvidersUKPRN
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	Given I want to send <Field> with value <Value> in the following request
	When I patch the following LearningProgression V3:
		| Field                   | Value                |
	Then there should be a 422 response
	And the response body should include <ErrorMessage>
	And the number of errors returned should be <ErrorCount>

	Examples:
		| Field                      | Value     | ErrorMessage                                                                                                | ErrorCount |
		| LastLearningProvidersUKPRN | 9999999   | The field LastLearningProvidersUKPRN must be a string with a minimum length of 8 and a maximum length of 8  | 1          |
		| LastLearningProvidersUKPRN | 1         | The field LastLearningProvidersUKPRN must be a string with a minimum length of 8 and a maximum length of 8. | 1          |
		| LastLearningProvidersUKPRN | 1234567A  | LastLearningProvidersUKPRN must be a Number                                                                 | 1          |
		| LastLearningProvidersUKPRN | abcdefgh  | LastLearningProvidersUKPRN must be a Number                                                                 | 1          |
		| LastLearningProvidersUKPRN | 100000000 | The field LastLearningProvidersUKPRN must be a string with a minimum length of 8 and a maximum length of 8  | 1          |

Scenario Outline: Patch Learning Progression no value for LastLearningProvidersUKPRN
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	Then there should be a 201 response
	Given I want to send <Field> with value <Value> in the following request
	When I patch the following LearningProgression V3:
		| Field                   | Value                |
	Then there should be a 200 response
	Then the response body should contain:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |

	Examples:
		| Field                      | Value |
		| LastLearningProvidersUKPRN |       |

###########################################################################################
##	LastModifiedDate
###########################################################################################
@learningprogressions
Scenario Outline: Patch Learning Progression with LastModifiedDate
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	Given I want to send <Field> with value Translate Date To <Value>
	When I patch the following LearningProgression V3:
		| Field                 | Value                |
	Then there should be a 200 response
	And the response body should contain:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	#And the "learningprogressions" cosmos document should include CreatedBy
	Given I wait for 10 Seconds
	Then there should be a record in the dss-learningprogressions table with LearningProgressionId

	Examples:
		| Field            | Value                |
		| LastModifiedDate | 2019-06-19T09:01:00Z |
		| LastModifiedDate | now                  |
		| LastModifiedDate | now + 1Hour          |

@learningprogressions
Scenario Outline: Patch Learning Progression with invalid value for LastModifiedDate
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	Given I want to send <Field> with value Translate Date To <Value>
	When I patch the following LearningProgression V3:
		| Field                 | Value                |
	Then there should be a 422 response
	And the response body should include <ErrorMessage>
	And the number of errors returned should be 1

	Examples:
		| Field            | Date                 | ErrorMessage                         |
		| LastModifiedDate | sdrg-06-19T09:01:00Z | Could not convert string to DateTime |
		| LastModifiedDate | 2018-00-19T09:01:00Z | Could not convert string to DateTime |
		| LastModifiedDate | 2018-13-19T09:01:00Z | Could not convert string to DateTime |
		| LastModifiedDate | 2018-05-00T09:01:00Z | Could not convert string to DateTime |
		| LastModifiedDate | 2018-05-32T09:01:00Z | Could not convert string to DateTime |

#############################################################################################
## GENERAL TESTS
#############################################################################################
@learningprogressions
Scenario: Patch to Learning Progression received from another touchpoint
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	#When I patch the following via a different touchpoint
	When I patch the following LearningProgression V3:
		| Field                     | Value |
		| CurrentQualificationLevel | 1     |
	Then there should be a 200 response
	And the response body should not contain the "CreatedBy"
	#And the response body should have different LastUpdatedBy
	And the response body should contain:
		| Field                     | Value |
		| CurrentQualificationLevel | 1     |