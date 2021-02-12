Feature: LearningProgression_Get

Background: Create Adviser
	Given I post an adviser with the following details:
		| Field                | Value          |
		| AdviserName          | BillyAdviser   |
		| AdviserContactNumber | 98798678967967 |
	And I post a Customer with the following details:
		| Field      | Value    |
		| GivenName  | Bob      |
		| FamilyName | Customer |

@learningprogressions  @Smoke
Scenario:Get Learning Progression by ID
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	When I get a Learning Progression by ID V3
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

#
@learningprogressions
Scenario:Get All Learning Progression records where 1 exists
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	When I get all Learning Progression records for a customer V3
	Then there should be a 200 response
	And the response should contain 1 document(s)
	#Then the response body should incorporate a document with the following details:
	#	| Field                          | Value                |
	#	| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
	#	| CurrentLearningStatus          | 1                    |
	#	| LearningHours                  | 1                    |
	#	| DateLearningStarted            | 2019-06-25T11:21:00Z |
	#	| CurrentQualificationLevel      | 2                    |
	#	| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
	#	| LastLearningProvidersUKPRN     | 12345678             |
	Then the response body should contain:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |

@learningprogressions
Scenario:Get Learning Progression by invalid ID
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	And I post a Customer with the following details:
		| Field      | Value    |
		| GivenName  | Bob      |
		| FamilyName | Customer |
	When I get a Learning Progression by ID V3
	Then there should be a 204 response

@learningprogressions
Scenario:Get All Learning Progression records where none exist
	Given I post a Learning Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	And I post a Customer with the following details:
		| Field      | Value    |
		| GivenName  | Bob      |
		| FamilyName | Customer |
	When I get all Learning Progression records for a customer V3
	Then there should be a 204 response