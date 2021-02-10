Feature: LearningProgression_Post

Background: Create Adviser
	Given I post an adviser with the following details:
		| Field                | Value          |
		| AdviserName          | BillyAdviser   |
		| AdviserContactNumber | 98798678967967 |
	And I post a Customer with the following details:
		| Field      | Value    |
		| GivenName  | Bob      |
		| FamilyName | Customer |

@learningprogressions  @smoke
Scenario:Post learning progression with all values
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

#And there should be a record in the learningprogressions ChangeFeed table
#And there should be a record in the learningprogressions-history ChangeFeed table
@learningprogressions
Scenario:Post learning progression with all mandatory values
	Given I post a Learning Progression record with the following details V3:
		| Field                     | Value                |
		| DateProgressionRecorded   | 2019-06-25T11:21:00Z |
		| CurrentLearningStatus     | 99                   |
		| CurrentQualificationLevel | 99                   |
	Then there should be a 201 response
	And the response body should contain:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2019-06-25T11:21:00Z |
		| CurrentLearningStatus          | 99                   |
		| LearningHours                  |                      |
		| DateLearningStarted            |                      |
		| CurrentQualificationLevel      | 99                   |
		| DateQualificationLevelAchieved |                      |
		| LastLearningProvidersUKPRN     |                      |
	#And the "learningprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"

	#And there should be a record in the learningprogressions ChangeFeed table
	#And there should be a record in the learningprogressions-history ChangeFeed table
	Examples:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |

@learningprogressions
Scenario:Post learning progression supplying LastModifiedDate
	Given I want to send <Field> with value Translate Date To <Value>
	Given I post a Learning Progression record with the following details V3:
		| Field                     | Value                |
		| DateProgressionRecorded   | 2018-12-19T09:01:00Z |
		| CurrentLearningStatus     | 99                   |
		| DateLearningStarted       | Today                |
		| CurrentQualificationLevel | 99                   |
		| LastModifiedDate          | 2019-06-19T09:01:00Z |
	Then there should be a 201 response
	And the response body should contain:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-12-19T09:01:00Z |
		| CurrentLearningStatus          | 99                   |
		| LearningHours                  |                      |
		| CurrentQualificationLevel      | 99                   |
		| DateQualificationLevelAchieved |                      |
		| LastLearningProvidersUKPRN     |                      |
		| LastModifiedDate               | 2019-06-19T09:01:00Z |
	#And the "learningprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"

	Examples:
		| Field               | Value |
		| DateLearningStarted | Today |

#And there should be a record in the learningprogressions ChangeFeed table
#And there should be a record in the learningprogressions-history ChangeFeed table
@learningprogressions
Scenario Outline: Post learning progression with valid values for DateProgressionRecorded
	Given I want to send <Field> with value Translate Date To <Value>
	Given I want to send DateLearningStarted with value Translate Date To Today
	Given I post a Learning Progression record with the following details V3:
		| Field                     | Value                |
		| CurrentLearningStatus     | 99                   |
		| CurrentQualificationLevel | 99                   |
		| LastModifiedDate          | 2019-06-19T09:01:00Z |
	Then there should be a 201 response
	And the response body should contain:
		| Field                     | Value                |
		| CurrentLearningStatus     | 99                   |
		| CurrentQualificationLevel | 99                   |
		| LastModifiedDate          | 2019-06-19T09:01:00Z |

	Examples:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-12-19T09:01:00Z |
		| DateProgressionRecorded | Today                |
		| DateProgressionRecorded | Now                  |
#
#@learningprogressions
#Scenario Outline:  Post learning progression with valid values for CurrentLearningStatus
#	Given I want to send <Field> with value <Value> in the following request
#	Given I post a Learning Progression record with the following details V3:
#		| Field                     | Value                |
#		| DateProgressionRecorded   | 2019-06-19T09:01:00Z |
#		| CurrentQualificationLevel | 99                   |
#		| LearningHours             | 1                    |
#		| DateLearningStarted       | 2019-06-19T09:01:00Z |
#	Then there should be a 201 response
#	And the response body should contain:
#		| Field                     | Value                |
#		| DateProgressionRecorded   | 2019-06-19T09:01:00Z |
#		| LearningHours             | 1                    |
#		| DateLearningStarted       | 2019-06-19T09:01:00Z |
#		| CurrentQualificationLevel | 99                   |
#	And the response body should have <Field> with value <Value>
#
#	Examples:
#		| Field                 | Value |
#		| CurrentLearningStatus | 1     |
#		| CurrentLearningStatus | 2     |
#		| CurrentLearningStatus | 3     |
#		| CurrentLearningStatus | 98    |
#		| CurrentLearningStatus | 99    |
#
#@learningprogressions
#Scenario Outline: Post learning progression with valid values for LearningHours
#	Given I want to send <Field> with value <Value> in the following request
#	Given I post a Learning Progression record with the following details V3:
#		| Field                     | Value                |
#		| DateProgressionRecorded   | 2018-12-19T09:01:00Z |
#		| CurrentLearningStatus     | 99                   |
#		| DateLearningStarted       | Today                |
#		| CurrentQualificationLevel | 99                   |
#		| LastModifiedDate          | 2019-06-19T09:01:00Z |
#	Then there should be a 201 response
#	And the response body should contain:
#		| Field                     | Value                |
#		| DateProgressionRecorded   | 2018-12-19T09:01:00Z |
#		| CurrentLearningStatus     | 99                   |
#		| CurrentQualificationLevel | 99                   |
#		| LastModifiedDate          | 2019-06-19T09:01:00Z |
#	And the response body should have <Field> with value <Value>
#
#	Examples:
#		| Field         | Value |
#		| LearningHours | 1     |
#		| LearningHours | 2     |
#
#@learningprogressions
#Scenario Outline: Post learning progression with valid values for CurrentQualificationLevel
#	Given I want to send <Field> with value <Value> in the following request
#	Given I post a Learning Progression record with the following details V3:
#		| Field                          | Value                |
#		| DateProgressionRecorded        | 2018-06-19T09:01:00Z |
#		| CurrentLearningStatus          | 99                   |
#		| DateQualificationLevelAchieved | 2019-06-19T09:01:00Z |
#	Then there should be a 201 response
#	And the response body should contain:
#		| Field                          | Value                |
#		| DateProgressionRecorded        | 2018-06-19T09:01:00Z |
#		| CurrentLearningStatus          | 99                   |
#		| DateQualificationLevelAchieved | 2019-06-19T09:01:00Z |
#	And the response body should have <Field> with value <Value>
#
#	Examples:
#		| Field                     | Value |
#		| CurrentQualificationLevel | 0     |
#		| CurrentQualificationLevel | 1     |
#		| CurrentQualificationLevel | 2     |
#		| CurrentQualificationLevel | 3     |
#		| CurrentQualificationLevel | 4     |
#		| CurrentQualificationLevel | 5     |
#		| CurrentQualificationLevel | 6     |
#		| CurrentQualificationLevel | 7     |
#		| CurrentQualificationLevel | 8     |
#		| CurrentQualificationLevel | 99    |
#
#@learningprogressions
#Scenario Outline: Post learning progression with valid values for LastLearningProvidersUKPRN
#	Given I want to send <Field> with value <Value> in the following request
#	Given I post a Learning Progression record with the following details V3:
#		| Field                     | Value                |
#		| DateProgressionRecorded   | 2018-06-19T09:01:00Z |
#		| CurrentLearningStatus     | 99                   |
#		| CurrentQualificationLevel | 99                   |
#	Then there should be a 201 response
#	And the response body should contain:
#		| Field                     | Value                |
#		| DateProgressionRecorded   | 2018-06-19T09:01:00Z |
#		| CurrentLearningStatus     | 99                   |
#		| CurrentQualificationLevel | 99                   |
#	And the response body should have <Field> with value <Value>
#
#	Examples:
#		| Field                      | Value    |
#		| LastLearningProvidersUKPRN | 10000000 |
#		| LastLearningProvidersUKPRN | 12345678 |
#		| LastLearningProvidersUKPRN | 54123234 |
#		| LastLearningProvidersUKPRN | 99999999 |
#
#@learningprogressions
#Scenario: Post learning progression with no value for LastLearningProvidersUKPRN
#	Given I want to send <Field> with value <Value> in the following request
#	Given I post a Learning Progression record with the following details:
#		| Field                     | Value                |
#		| DateProgressionRecorded   | 2018-06-19T09:01:00Z |
#		| CurrentLearningStatus     | 99                   |
#		| CurrentQualificationLevel | 99                   |
#	Then there should be a 201 response
#	And the response body should contain:
#		| Field                      | Value                |
#		| DateProgressionRecorded    | 2018-06-19T09:01:00Z |
#		| CurrentLearningStatus      | 99                   |
#		| CurrentQualificationLevel  | 99                   |
#		| LastLearningProvidersUKPRN |                      |
#
#@learningprogressions
#Scenario Outline: Post learning progression with invalid value for LastLearningProvidersUKPRN
#	Given I want to send <Field> with value <Value> in the following request
#	Given I post a Learning Progression record with the following details V3:
#		| Field                     | Value |
#		| DateProgressionRecorded   | Now   |
#		| CurrentLearningStatus     | 99    |
#		| CurrentQualificationLevel | 99    |
#	Then there should be a 422 response
#	And the response body should include <ErrorMessage>
#
#	Examples:
#		| Field                      | Value     | ErrorMessage                                                                                                |
#		| LastLearningProvidersUKPRN | 9999999   | The field LastLearningProvidersUKPRN must be a string with a minimum length of 8 and a maximum length of 8. |
#		| LastLearningProvidersUKPRN | 100000000 | The field LastLearningProvidersUKPRN must be a string with a minimum length of 8 and a maximum length of 8. |
#		| LastLearningProvidersUKPRN | a         | LastLearningProvidersUKPRN must be a Number.                                                                |
#		| LastLearningProvidersUKPRN | a1234567  | LastLearningProvidersUKPRN must be a Number.                                                                |
#		| LastLearningProvidersUKPRN | sausages  | LastLearningProvidersUKPRN must be a Number.                                                                |
#
#@learningprogressions
#Scenario Outline: Post learning progression with invalid values for  CurrentLearningStatus
#	Given I want to send <Field> with value <Value> in the following request
#	Given I post a Learning Progression record with the following details V3:
#		| Field                     | Value                |
#		| DateProgressionRecorded   | 2018-06-19T09:01:00Z |
#		| CurrentQualificationLevel | 99                   |
#	Then there should be a 422 response
#	And the response body should include <ErrorMessage>
#
#	Examples:
#		| Field                 | Value | ErrorMessage                                                  |
#		| CurrentLearningStatus | 0     | CurrentLearningStatus must be a valid current Learning Status |
#		| CurrentLearningStatus | 4     | CurrentLearningStatus must be a valid current Learning Status |
#		| CurrentLearningStatus | 97    | CurrentLearningStatus must be a valid current Learning Status |
#		| CurrentLearningStatus | 100   | CurrentLearningStatus must be a valid current Learning Status |
#
#@learningprogressions
#Scenario Outline: Post learning progression with invalid values for  LearningHours
#	Given I want to send <Field> with value <Value> in the following request
#	Given I post a Learning Progression record with the following details V3:
#		| Field                     | Value                |
#		| DateProgressionRecorded   | 2018-06-19T09:01:00Z |
#		| CurrentLearningStatus     | 1                    |
#		| CurrentQualificationLevel | 1                    |
#	Then there should be a 422 response
#	And the response body should include DateLearningStarted must have a value
#
#	Examples:
#		| Field         | Value | ErrorMessage |
#		| LearningHours | 0     | placeholder  |
#		| LearningHours | 3     | placeholder  |
#		| LearningHours | 99    | placeholder  |
#
#@learningprogressions
#Scenario Outline:Post learning progression with invalid values for  CurrentQualificationLevel
#	Given I want to send <Field> with value <Value> in the following request
#	Given I post a Learning Progression record with the following details V3:
#		| Field                   | Value                |
#		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
#		| CurrentLearningStatus   | 99                   |
#	Then there should be a 422 response
#	And the response body should include <ErrorMessage>
#
#	Examples:
#		| Field                     | Value | ErrorMessage                                                           |
#		| CurrentQualificationLevel | -1    | CurrentQualificationLevel must be a valid current Qualification Level. |
#		| CurrentQualificationLevel | 9     | CurrentQualificationLevel must be a valid current Qualification Level. |
#		| CurrentQualificationLevel | 98    | CurrentQualificationLevel must be a valid current Qualification Level. |
#		| CurrentQualificationLevel | 100   | CurrentQualificationLevel must be a valid current Qualification Level. |
#
#@learningprogressions
#Scenario Outline: Post learning progression with invalid dates
#	Given I want to send <Field> with value <Date> in the following request
#	Given I post a Learning Progression record with the following details V3:
#		| Field                     | Value                |
#		| DateProgressionRecorded   | 2018-06-19T09:01:00Z |
#		| CurrentLearningStatus     | 99                   |
#		| DateLearningStarted       | Today                |
#		| CurrentQualificationLevel | 99                   |
#	Then there should be a 422 response
#	And the response body should include <ErrorMessage>
#
#	Examples:
#		| Field                   | Value                | ErrorMessage                         |
#		| DateProgressionRecorded | 2018-00-19T09:01:00Z | Could not convert string to DateTime |
#		| DateProgressionRecorded | 2018-13-19T09:01:00Z | Could not convert string to DateTime |
#		| DateProgressionRecorded | 2018-05-00T09:01:00Z | Could not convert string to DateTime |
#		| DateProgressionRecorded | 2018-05-32T09:01:00Z | Could not convert string to DateTime |
#		| DateLearningStarted     | 018-0g-19T09:01:00Z  | Could not convert string to DateTime |
#		| DateLearningStarted     | 2018-00-19T09:01:00Z | Could not convert string to DateTime |
#		| DateLearningStarted     | 2018-13-19T09:01:00Z | Could not convert string to DateTime |
#		| DateLearningStarted     | 2018-05-00T09:01:00Z | Could not convert string to DateTime |
#		| DateLearningStarted     | 2018-05-32T09:01:00Z | Could not convert string to DateTime |
#
#@learningprogressions
#Scenario: Post learning progression with future timestamped value for DateProgressionRecorded
#	Given I post a Learning Progression record with the following details V3:
#		| Field                     | Value   |
#		| DateProgressionRecorded   | Now +1H |
#		| CurrentLearningStatus     | 99      |
#		| CurrentQualificationLevel | 99      |
#	Then there should be a 422 response
#	And the error message should be "DateProgressionRecorded must be less than or equal to now"
#	And the number of errors returned should be 1
#
#@learningprogressions
#Scenario: Post learning progression with future dated value for DateProgressionRecorded
#	Given I post a Learning Progression record with the following details V3:
#		| Field                     | Value   |
#		| DateProgressionRecorded   | Now +1D |
#		| CurrentLearningStatus     | 99      |
#		| CurrentQualificationLevel | 1       |
#	Then there should be a 422 response
#	And the response body should include DateProgressionRecorded must be less than or equal to now.
#
#@learningprogressions
#Scenario: Post learning progression with future timestamped value for DateLearningStarted
#	Given I post a Learning Progression record with the following details V3:
#		| Field                     | Value    |
#		| DateProgressionRecorded   | Now      |
#		| CurrentLearningStatus     | 2        |
#		| CurrentQualificationLevel | 1        |
#		| DateLearningStarted       | Now + 1H |
#	Then there should be a 422 response
#	And the response body should include DateLearningStarted must be less than or equal to now.
#
#@learningprogressions
#Scenario: Post learning progression with future dated value for DateLearningStarted
#	Given I post a Learning Progression record with the following details V3:
#		| Field                     | Value   |
#		| DateProgressionRecorded   | Now     |
#		| CurrentLearningStatus     | 3       |
#		| CurrentQualificationLevel | 99      |
#		| DateLearningStarted       | Now +1D |
#	Then there should be a 422 response
#	And the response body should include DateLearningStarted must be less than or equal to now.
#
#@learningprogressions
#Scenario: Post learning progression with future timestamped value for DateQualificationLevelAchieved
#	Given I post a Learning Progression record with the following details:
#		| Field                          | Value    |
#		| DateProgressionRecorded        | Now      |
#		| CurrentLearningStatus          | 3        |
#		| CurrentQualificationLevel      | 1        |
#		| DateQualificationLevelAchieved | Now + 1H |
#	Then there should be a 422 response
#	And the response body should include DateQualificationLevelAchieved must be less than or equal to now
#
#@learningprogressions
#Scenario: Post learning progression with future dated value for DateQualificationLevelAchieved
#	Given I post a Learning Progression record with the following details V3:
#		| Field                          | Value   |
#		| DateProgressionRecorded        | Now     |
#		| CurrentLearningStatus          | 2       |
#		| CurrentQualificationLevel      | 1       |
#		| DateQualificationLevelAchieved | Now +1D |
#	Then there should be a 422 response
#	And the response body should include DateQualificationLevelAchieved must be less than or equal to now.
#
#@learningprogressions
#Scenario: Post learning progression with In Learning status and no value for LearningHours
#	Given I post a Learning Progression record with the following details V3:
#		| Field                     | Value |
#		| DateProgressionRecorded   | Now   |
#		| CurrentLearningStatus     | 1     |
#		| DateLearningStarted       | Today |
#		| CurrentQualificationLevel | 99    |
#	#	| LearningHours             |       |
#	Then there should be a 422 response
#	And the response body should include LearningHours must have a value when Current Learning Status is InLearning
#	And the number of errors returned should be 1
#
#@learningprogressions
#Scenario: Post learning progression with In Learning status and invalid value for LearningHours
#	Given I post a Learning Progression record with the following details V3:
#		| Field                     | Value |
#		| DateProgressionRecorded   | Now   |
#		| CurrentLearningStatus     | 99    |
#		| CurrentQualificationLevel | 99    |
#		| DateLearningStarted       | Today |
#		| LearningHours             | 93    |
#	Then there should be a 422 response
#	And the response body should include LearningHours must have a valid Learning Hours value.
#
#@learningprogressions
#Scenario: Post learning progression with In Learning status and no value for DateLearningStarted
#	Given I post a Learning Progression record with the following details V3:
#		| Field                     | Value |
#		| DateProgressionRecorded   | Now   |
#		| CurrentLearningStatus     | 1     |
#		| CurrentQualificationLevel | 99    |
#		| LearningHours             | 1     |
#		| DateLearningStarted       |       |
#	Then there should be a 422 response
#	And the error message should be "DateLearningStarted must have a value when Current Learning Status is InLearning"
#	And the number of errors returned should be 1
#
#@learningprogressions
#Scenario: Post learning progression with In Learning status and future value for DateLearningStarted
#	Given I post a Learning Progression record with the following details V3:
#		| Field                     | Value   |
#		| DateProgressionRecorded   | Now     |
#		| CurrentLearningStatus     | 1       |
#		| CurrentQualificationLevel | 99      |
#		| LearningHours             | 1       |
#		| DateLearningStarted       | Now +1H |
#	Then there should be a 422 response
#	And the response body should include DateLearningStarted must be less than or equal to now.
#
#@learningprogressions
#Scenario: Post learning progression with a Current Qualification and no value for DateQualificationLevelAchieved
#	Given I post a Learning Progression record with the following details V3:
#		| Field                          | Value |
#		| DateProgressionRecorded        | Now   |
#		| CurrentLearningStatus          | 99    |
#		| CurrentQualificationLevel      | 1     |
#		| DateQualificationLevelAchieved |       |
#	Then there should be a 422 response
#	And the response body should include DateQualificationLevelAchieved is required when QualificationLevel < NoQualification (99).
#
#@learningprogressions
#Scenario: Post learning progression with a Current Qualification and future value for DateQualificationLevelAchieved
#	Given I post a Learning Progression record with the following details V3:
#		| Field                          | Value   |
#		| DateProgressionRecorded        | Now     |
#		| CurrentLearningStatus          | 99      |
#		| CurrentQualificationLevel      | 8       |
#		| DateQualificationLevelAchieved | Now +1H |
#	Then there should be a 422 response
#	And the response body should include DateQualificationLevelAchieved must be less than or equal to now
#
#@learningprogressions
#Scenario:Post learning progression missing CurrentLearningStatus
#	Given I post a Learning Progression record with the following details V3:
#		| Field                      | Value    |
#		| DateProgressionRecorded    | Now      |
#		| CurrentLearningStatus      |          |
#		| DateLearningStarted        | Today    |
#		| CurrentQualificationLevel  | 99       |
#		| LastLearningProvidersUKPRN | 00000000 |
#	Then there should be a 422 response
#	And the response body should include The CurrentLearningStatus field is required
#
#@learningprogressions
#Scenario:Post learning progression missing CurrentQualification
#	Given I post a Learning Progression record with the following details V3:
#		| Field                      | Value    |
#		| DateProgressionRecorded    | Now      |
#		| CurrentLearningStatus      | 99       |
#		| DateLearningStarted        | Today    |
#		| CurrentQualificationLevel  |          |
#		| LastLearningProvidersUKPRN | 00000000 |
#	Then there should be a 422 response
#	And the response body should include The CurrentQualificationLevel field is required.
#
#@learningprogressions
#Scenario:Post learning progression missing DateProgressionRecorded
#	Given I post a Learning Progression record with the following details V3:
#		| Field                      | Value    |
#		| DateProgressionRecorded    |          |
#		| CurrentLearningStatus      | 99       |
#		| CurrentQualificationLevel  | 99       |
#		| DateLearningStarted        | Today    |
#		| LastLearningProvidersUKPRN | 00000000 |
#	Then there should be a 201 response
#	And the date field DateProgressionRecorded should hold a recent value