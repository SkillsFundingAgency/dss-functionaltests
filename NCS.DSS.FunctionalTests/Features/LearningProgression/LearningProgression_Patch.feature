@patchV2
Feature: LearningProgression_Patch

Background:

	Given I post an adviser with the following details:
		| Field						 | Value				|
		| AdviserName				 | BillyAdviser			|
		| AdviserContactNumber		 | 98798678967967		|
	And I post a Customer with the following details:
		| Field                      | Value                |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
	Given I post a Learning Progression record with the following details:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |

@LearningProgression  @smoke
Scenario:Patch Learning Progression with  all values
	When I patch the following:
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
	And the response body should have <Field> with value <Value>
	And the response body should contain:
	| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
	| CurrentLearningStatus          | 1                    |
	| LearningHours                  | 1                    |
	| DateLearningStarted            | 2019-06-25T11:21:00Z |
	| CurrentQualificationLevel      | 2                    |
	| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
	| LastLearningProvidersUKPRN     | 12345678             |
	And the "learningprogression" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	And there should be a record in the learningprogression ChangeFeed table
	And there should be a record in the learningprogression-history ChangeFeed table
	


@LearningProgression @SubcontractorId
Scenario Outline: Patch Learning Progression with SubcontractorId

	When I patch the element <Field> with <value>:
	Then there should be a 200 response
	And the response body should have <Field> with value <Value>
	And the response body should contain:
	| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
	| CurrentLearningStatus          | 1                    |
	| LearningHours                  | 1                    |
	| DateLearningStarted            | 2019-06-25T11:21:00Z |
	| CurrentQualificationLevel      | 2                    |
	| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
	| LastLearningProvidersUKPRN     | 12345678             |
	And the "learningprogression" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	And the response body should contain the SubContractorId
	And there should be a record in the learningprogression ChangeFeed table
	And there should be a record in the learningprogression-history ChangeFeed table
	
	Examples:
	| Field                          | Value                |
	| DateProgressionRecorded        | 2019-06-19T09:01:00Z  |


###########################################################################################
##	DateProgressionRecorded
###########################################################################################
@LearningProgression
Scenario Outline: Patch Learning Progression with valid values for DateProgressionRecorded
	When I patch the element <Field> with <value>:
	Then there should be a 200 response
	And the response body should have <Field> with value <Value>
	And the response body should contain:
	| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
	| CurrentLearningStatus          | 1                    |
	| LearningHours                  | 1                    |
	| DateLearningStarted            | 2019-06-25T11:21:00Z |
	| CurrentQualificationLevel      | 2                    |
	| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
	| LastLearningProvidersUKPRN     | 12345678             |
	And the "learningprogression" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	And there should be a record in the learningprogression ChangeFeed table
	And there should be a record in the learningprogression-history ChangeFeed table
	
	Examples:
	| Field                          | Value                |
	| DateProgressionRecorded        | 2019-06-19T09:01:00Z  |

@LearningProgression
Scenario Outline: Patch Learning Progression with invalid DateProgressionRecorded

	When I patch the element <Field> with <value>:
	Then there should be a 403 response
	And the response body should include <ErrorMessage>
	
	Examples:
	| Field                   | Value                | <ErrorMessage> |
	| DateProgressionRecorded | 018-06-19T09:01:00Z  | placeholder    |
	| DateProgressionRecorded | 2018-00-19T09:01:00Z | placeholder    |
	| DateProgressionRecorded | 2018-13-19T09:01:00Z | placeholder    |
	| DateProgressionRecorded | 2018-05-00T09:01:00Z | placeholder    |
	| DateProgressionRecorded | 2018-05-32T09:01:00Z | placeholder    |


@LearningProgression
Scenario Outline: Patch Learning Progression with future dated DateProgressionRecorded

	When I patch the element <Field> with <value>:
	Then there should be a 403 response
	And the response body should include <ErrorMessage>
	
	Examples:
	| Field                   | Value     | <ErrorMessage> |
	| DateProgressionRecorded | Today +1D | placeholder    |
	| DateProgressionRecorded | Now + 1H  | placeholder    |
	| DateProgressionRecorded | Today +1Y | placeholder    |



@LearningProgression
Scenario Outline: Patch Learning Progression with empty DateProgressionRecorded
	When I patch the element <Field> with <value>:
	Then there should be a 200 response
	And the response body should have <Field> with value <Value>
	And the response body should contain:
	| Field                          | Value                |
	| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
	| CurrentLearningStatus          | 1                    |
	| LearningHours                  | 1                    |
	| DateLearningStarted            | 2019-06-25T11:21:00Z |
	| CurrentQualificationLevel      | 2                    |
	| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
	| LastLearningProvidersUKPRN     | 12345678             |
	
	Examples:
	| Field                   | Value |
	| DateProgressionRecorded |       |

###########################################################################################
##	CurrentLearningStatus
###########################################################################################

@LearningProgression
Scenario Outline: Patch Learning Progression with CurrentLearningStatus
	When I patch the element <Field> with <value>:
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
	And the "learningprogression" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	And there should be a record in the learningprogression ChangeFeed table
	And there should be a record in the learningprogression-history ChangeFeed table

	Examples:
	| Field                 | Value |
	| CurrentLearningStatus | 1     |
	| CurrentLearningStatus | 2     |
	| CurrentLearningStatus | 3     |
	| CurrentLearningStatus | 98    |
	| CurrentLearningStatus | 99    |



@LearningProgression
Scenario Outline: Patch Learning Progression with invalid CurrentLearningStatus

	When I patch the element <Field> with <value>:
	Then there should be a 403 response
	And the response body should include <ErrorMessage>
	And the "learningprogression" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	And there should be a record in the learningprogression ChangeFeed table
	And there should be a record in the learningprogression-history ChangeFeed table
	
	Examples:
	| Field                 | Value | <ErrorMessage> |
	| CurrentLearningStatus | -1    | placeholder    |
	| CurrentLearningStatus | 0     | placeholder    |
	| CurrentLearningStatus | 4     | placeholder    |
	| CurrentLearningStatus | 97    | placeholder    |
	| CurrentLearningStatus | 100   | placeholder    |
	

@LearningProgression
Scenario Outline: Patch Learning Progression with empty CurrentLearningStatus
	When I patch the element <Field> with <value>:
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
	| CurrentLearningStatus | 2     |
	
@LearningProgression
Scenario Outline: Patch Learning Progression with value for CurrentLearningStatus where there was no previous value for CurrentLearningStatus or LearningHours
	Given I post a Learning Progression record with the following details:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	When I patch the element <Field> with <value>:
	Then there should be a 403 response
	And the response body should include <ErrorMessage>
	
	Examples:
	| Field                 | Value | ErrorMessage |
	| CurrentLearningStatus | 2     | PlaceHolder  |

@LearningProgression
Scenario: Patch Learning Progression with value for CurrentLearningStatus AND DateLearningStarted where there was no previous value for CurrentLearningStatus or LearningHours

	Given I post a Learning Progression record with the following details:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-24T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
		| DateLearningStarted            | 2019-07-23T11:21:00Z |
	When I patch the following:
	 | Field                 | Value |
	 | CurrentLearningStatus | 1     |
	 | LearningHours         | 1     |
	Then there should be a 403 response
	And the response body should include "Place Holder"
	
@LearningProgression
Scenario: Patch Learning Progression with value for CurrentLearningStatus where there was no previous value for CurrentLearningStatus or DateLearningStarted
	Given I post a Learning Progression record with the following details:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-24T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
		| DateLearningStarted            | 2019-07-23T11:21:00Z |
	When I patch the following:
	 | Field                 | Value |
	 | CurrentLearningStatus | 1     |

	Then there should be a 403 response
	And the response body should include "Place Holder"

@LearningProgression
Scenario: Patch Learning Progression with value for CurrentLearningStatus AND DateLearningStarted where there was no previous value for CurrentLearningStatus or DateLearningStarted or LearningHours
	Given I post a Learning Progression record with the following details:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-24T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |

	When I patch the following:
	 | Field                 | Value                |
	 | CurrentLearningStatus | 1                    |
	 | DateLearningStarted   | 2019-07-23T11:21:00Z |

	Then there should be a 403 response
	And the response body should include "Place Holder"

@LearningProgression
Scenario: Patch Learning Progression with value for CurrentLearningStatus where there was no previous value for CurrentLearningStatus, DateLearningStarted or LearningHours
	Given I post a Learning Progression record with the following details:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-24T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |

	When I patch the following:
	 | Field                 | Value                |
	 | CurrentLearningStatus | 1                    |

	Then there should be a 403 response
	And the response body should include "Place Holder"

@LearningProgression
Scenario: Patch Learning Progression with value for CurrentLearningStatus AND DateLearningStarted AND LearningHours where there was no previous value for CurrentLearningStatus, DateLearningStarted or LearningHours

	Given I post a Learning Progression record with the following details:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-24T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |

	When I patch the following:
	 | Field                 | Value                |
	 | CurrentLearningStatus | 1                    |
	 | DateLearningStarted   | 2019-07-24T11:21:00Z |
	 | LearningHours         | 2                    |

	Then there should be a 200 response
	And the response body should include "Place Holder"


###########################################################################################
##	LearningHours
###########################################################################################



@LearningProgression
Scenario Outline: Patch Learning Progression with LearningHours
	When I patch the element <Field> with <value>:
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
	And the "learningprogression" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	And there should be a record in the learningprogression ChangeFeed table
	And there should be a record in the learningprogression-history ChangeFeed table
	
	Examples:
	| Field         | Value |
	| LearningHours | 1     |
	| LearningHours | 2     |


@LearningProgression
Scenario Outline: Patch Learning Progression with invalid LearningHours

	When I patch the element <Field> with <value>:
	Then there should be a 403 response
	And the response body should include <ErrorMessage>
	
	Examples:
	| Field         | Value | <ErrorMessage> |
	| LearningHours | -1    | placeholder    |
	| LearningHours | 0     | placeholder    |
	| LearningHours | 3     | placeholder    |
	| LearningHours | 99    | placeholder    |
	


@LearningProgression
Scenario Outline: Patch Learning Progression with empty LearningHours

	When I patch the element <Field> with <value>:
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

@LearningProgression
Scenario Outline: Patch Learning Progression with DateLearningStarted
	When I patch the element <Field> with <value>:
	Then there should be a 200 response
	And the response body should have <Field> with value <Value>
	And the response body should contain:
	| Field                          | Value                |
	| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
	| CurrentLearningStatus          | 1                    |
	| LearningHours                  | 1                    |
	| DateLearningStarted            | 2019-06-25T11:21:00Z |
	| CurrentQualificationLevel      | 2                    |
	| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
	| LastLearningProvidersUKPRN     | 12345678             |
	And the "learningprogression" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	And there should be a record in the learningprogression ChangeFeed table
	And there should be a record in the learningprogression-history ChangeFeed table
	
	Examples:
	| Field               | Value                |
	| DateLearningStarted | 2018-06-25T11:21:00Z |
	| DateLearningStarted | Now                  |
	| DateLearningStarted | Today                |


@LearningProgression
Scenario Outline: Patch Learning Progression with invalid value for DateLearningStarted
	When I patch the element <Field> with <value>:
	Then there should be a 403 response
	And the response body should include <ErrorMessage>
	
	Examples:
	| Field               | Value                | <ErrorMessage> |
	| DateLearningStarted | 018-06-19T09:01:00Z  | placeholder    |
	| DateLearningStarted | 2018-00-19T09:01:00Z | placeholder    |
	| DateLearningStarted | 2018-13-19T09:01:00Z | placeholder    |
	| DateLearningStarted | 2018-05-00T09:01:00Z | placeholder    |
	| DateLearningStarted | 2018-05-32T09:01:00Z | placeholder    |

@LearningProgression
Scenario Outline: Patch Learning Progression with future value for DateLearningStarted

	When I patch the element <Field> with <value>:
	Then there should be a 403 response
	And the response body should include <ErrorMessage>
	
	Examples:
	| Field               | Value     | <ErrorMessage> |
	| DateLearningStarted | Today +1D | placeholder    |
	| DateLearningStarted | Now + 1H  | placeholder    |
	| DateLearningStarted | Today +1Y | placeholder    |

###########################################################################################
##	CurrentQualificationLevel
###########################################################################################

@LearningProgression
Scenario Outline: Patch Learning Progression with CurrentQualificationLevel

	When I patch the element <Field> with <value>:
	Then there should be a 200 response
	And the response body should have <Field> with value <Value>
	And the response body should contain:
	| Field                          | Value                |
	| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
	| LearningHours                  | 1                    |
	| DateLearningStarted            | 2019-06-25T11:21:00Z |
	| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
	| LastLearningProvidersUKPRN     | 12345678             |
	And the "learningprogression" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	And there should be a record in the learningprogression ChangeFeed table
	And there should be a record in the learningprogression-history ChangeFeed table
	
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

@LearningProgression
Scenario Outline: Patch Learning Progression with invalid value for CurrentQualificationLevel

	When I patch the element <Field> with <value>:
	Then there should be a 403 response
	And the response body should include <ErrorMessage>
	
	Examples:
	| Field                   | Value | <ErrorMessage> |
	| CurrentQualificationLevel   | -1    | placeholder    |
	| CurrentQualificationLevel   | 9     | placeholder    |
	| CurrentQualificationLevel | 98     | placeholder    |
	| CurrentQualificationLevel | 100   | placeholder    |

@LearningProgression
Scenario: Patch Learning Progression with value for CurrentQualificationLevel where there was no previous value for CurrentQualificationLevel or DateQualificationLevelAchieved

	Given I post a Learning Progression record with the following details:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
		| DateLearningStarted            | 2019-07-23T11:21:00Z |
	When I patch the following:
	 | Field                     | Value |
	 | CurrentQualificationLevel | 1     |
	Then there should be a 403 response
	And the response body should include "Place Holder"

###########################################################################################
##	DateQualificationLevelAchieved
###########################################################################################

@LearningProgression
Scenario Outline: Patch Learning Progression with DateQualificationLevelAchieved
	When I patch the element <Field> with <value>:
	Then there should be a 200 response
	And the response body should have <Field> with value <Value>
	And the response body should contain:
	| Field                          | Value                |
	| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
	| CurrentLearningStatus          | 1                    |
	| LearningHours                  | 1                    |
	| DateLearningStarted            | 2019-06-25T11:21:00Z |
	| CurrentQualificationLevel      | 2                    |
	| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
	| LastLearningProvidersUKPRN     | 12345678             |
	And the "learningprogression" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	And there should be a record in the learningprogression ChangeFeed table
	And there should be a record in the learningprogression-history ChangeFeed table
	
	Examples:
	| Field               | Value                |
	| DateQualificationLevelAchieved | 2018-06-25T11:21:00Z |
	| DateQualificationLevelAchieved | Now                  |
	| DateQualificationLevelAchieved | Today                |


@LearningProgression
Scenario Outline: Patch Learning Progression with invalid value for DateQualificationLevelAchieved
	When I patch the element <Field> with <value>:
	Then there should be a 403 response
	And the response body should include <ErrorMessage>
	
	Examples:
	| Field               | Value                | <ErrorMessage> |
	| DateQualificationLevelAchieved | 018-06-19T09:01:00Z  | placeholder    |
	| DateQualificationLevelAchieved | 2018-00-19T09:01:00Z | placeholder    |
	| DateQualificationLevelAchieved | 2018-13-19T09:01:00Z | placeholder    |
	| DateQualificationLevelAchieved | 2018-05-00T09:01:00Z | placeholder    |
	| DateQualificationLevelAchieved | 2018-05-32T09:01:00Z | placeholder    |

@LearningProgression
Scenario Outline: Patch Learning Progression with future value for DateQualificationLevelAchieved

	When I patch the element <Field> with <value>:
	Then there should be a 403 response
	And the response body should include <ErrorMessage>
	
	Examples:
	| Field                          | Value     | <ErrorMessage> |
	| DateQualificationLevelAchieved | Today +1D | placeholder    |
	| DateQualificationLevelAchieved | Now + 1H  | placeholder    |
	| DateQualificationLevelAchieved | Today +1Y | placeholder    |

###########################################################################################
##	LastLearningProvidersUKPRN
###########################################################################################



@LearningProgression
Scenario Outline: Patch Learning Progression with LastLearningProvidersUKPRN

	When I patch the element <Field> with <value>:
	Then there should be a 200 response
	And the response body should have <Field> with value <Value>
	And the response body should contain:
	| Field                          | Value                |
	| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
	| LearningHours                  | 1                    |
	| DateLearningStarted            | 2019-06-25T11:21:00Z |
	| CurrentQualificationLevel      | 2                    |
	| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
	And the "learningprogression" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	And there should be a record in the learningprogression ChangeFeed table
	And there should be a record in the learningprogression-history ChangeFeed table
	
	Examples:
	| Field                      | Value    |
	| LastLearningProvidersUKPRN | 10000000 |
	| LastLearningProvidersUKPRN | 10000001 |
	| CurrentLearningStatus      | 51234567 |
	| CurrentLearningStatus      | 99999998 |
	| CurrentLearningStatus      | 99999999 |
	| CurrentLearningStatus      |          |
	

Scenario Outline: Patch Learning Progression with invalid LastLearningProvidersUKPRN

	When I patch the element <Field> with <value>:
	Then there should be a 422 response
	And the response body should include <ErrorMessage>
	
	Examples:
	| Field                      | Value     | <ErrorMessage> |
	| LastLearningProvidersUKPRN | 00000001  | placeholder    |
	| LastLearningProvidersUKPRN | 9999999   | placeholder    |
	| LastLearningProvidersUKPRN | 1         | placeholder    |
	| LastLearningProvidersUKPRN | 1234567A  | placeholder    |
	| LastLearningProvidersUKPRN | abcdefgh  | placeholder    |
	| LastLearningProvidersUKPRN | 100000000 | placeholder    |


###########################################################################################
##	LastModifiedDate
###########################################################################################

@LearningProgression
Scenario Outline: Patch Learning Progression with LastModifiedDate
	When I patch the element <Field> with <value>:
	Then there should be a 200 response
	And the response body should have <Field> with value <Value>
	And the response body should contain:
	| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
	| CurrentLearningStatus          | 1                    |
	| LearningHours                  | 1                    |
	| DateLearningStarted            | 2019-06-25T11:21:00Z |
	| CurrentQualificationLevel      | 2                    |
	| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
	| LastLearningProvidersUKPRN     | 12345678             |
	And the "learningprogression" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	And there should be a record in the learningprogression ChangeFeed table
	And there should be a record in the learningprogression-history ChangeFeed table
	
	Examples:
	| Field            | Value                |
	| LastModifiedDate | 2019-06-19T09:01:00Z |
	| LastModifiedDate | Now                  |
	| LastModifiedDate | Now + 1              |


@LearningProgression
Scenario Outline: Patch Learning Progression with invalid value for LastModifiedDate
	When I patch the element <Field> with <value>:
	Then there should be a 422 response
	And the response body should include <ErrorMessage>
	
	Examples:
	| Field            | Date                 | ErrorMessage |
	| LastModifiedDate | 018-06-19T09:01:00Z  | placeholder  |
	| LastModifiedDate | 2018-00-19T09:01:00Z | placeholder  |
	| LastModifiedDate | 2018-13-19T09:01:00Z | placeholder  |
	| LastModifiedDate | 2018-05-00T09:01:00Z | placeholder  |
	| LastModifiedDate | 2018-05-32T09:01:00Z | placeholder  |


#############################################################################################
## GENERAL TESTS
#############################################################################################
@LearningProgression
Scenario: Patch to Learning Progression received from another touchpoint

		When I patch the following via a different touchpoint
		| Field                     | Value |
		| CurrentQualificationLevel | 1     |
		Then there should be a 200 response
		And the response body should not contain the "CreatedBy"
		And the response body should have different LastUpdatedBy
		And the response body should contain:
         | Field                     | Value |
         | CurrentQualificationLevel | 1     |
		And there should be a record in the learningprogression ChangeFeed table
		And there should be a record in the learningprogression-history ChangeFeed table


@LearningProgression
Scenario Outline: Patch Learning Progression with value for LastModifiedTouchpointID
	When I patch the element <Field> with <value>:
	Then there should be a 200 response
	And the response body should have <Field> with value <Value>
	And the response body should contain:
	| Field                          | Value                |
	| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
	| CurrentLearningStatus          | 1                    |
	| LearningHours                  | 1                    |
	| DateLearningStarted            | 2019-06-25T11:21:00Z |
	| CurrentQualificationLevel      | 2                    |
	| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
	| LastLearningProvidersUKPRN     | 12345678             |
	And there should be a record in the learningprogression ChangeFeed table
	And there should be a record in the learningprogression-history ChangeFeed table
	
	Examples:
	| Field                    | Value    |
	| LastModifiedTouchpointID | 99999999 |

@LearningProgression
Scenario Outline: Patch Learning Progression with value for CreatedBy
	When I patch the element <Field> with <value>:
	Then there should be a 200 response
	And the response body should have <Field> with value <Value>
	And the response body should contain:
	| Field                          | Value                |
	| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
	| CurrentLearningStatus          | 1                    |
	| LearningHours                  | 1                    |
	| DateLearningStarted            | 2019-06-25T11:21:00Z |
	| CurrentQualificationLevel      | 2                    |
	| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
	| LastLearningProvidersUKPRN     | 12345678             |
	And there should be a record in the learningprogression ChangeFeed table
	And there should be a record in the learningprogression-history ChangeFeed table
	
	Examples:
	| Field     | Value    |
	| CreatedBy | 99999999 |

@LearningProgression
Scenario Outline: Patch unknown Learning Progression record

	When I patch an unknown resource with the element <Field> with <value>:
	Then there should be a 204 response
	And the response body should contain <ErrorMessage>
	
	Examples:
	| Field         | Value | ErrorMessage |
	| LearningHours | 1     | PlaceHolder  |

@LearningProgression
Scenario Outline: Patch Learning Progression record with incorrect CustomerId

	When I patch an unknown resource with the element <Field> with <value>:
	Then there should be a 204 response
	And the response body should contain <ErrorMessage>
	
	Examples:
	| Field         | Value | ErrorMessage |
	| LearningHours | 1     | PlaceHolder  |