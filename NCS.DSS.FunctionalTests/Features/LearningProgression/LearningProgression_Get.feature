@postV3 @getV3
Feature: LearningProgression_Get


Background: Create Adviser
	Given I post an adviser with the following details:
		| Field						 | Value				|
		| AdviserName				 | BillyAdviser			|
		| AdviserContactNumber		 | 98798678967967		|
	And I post a Customer with the following details:
		| Field                      | Value                |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
	

@learningprogressions  @Smoke
Scenario:Get Learning Progression by ID

	Given I post a Learning Progression record with the following details:
			| Field                          | Value                |
			| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
			| CurrentLearningStatus          | 1                    |
			| LearningHours                  | 1                    |
			| DateLearningStarted            | 2019-06-25T11:21:00Z |
			| CurrentQualificationLevel      | 2                    |
			| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
			| LastLearningProvidersUKPRN     | 12345678             |
	When I get a Learning Progression by ID
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



#@learningprogressions @subcontractorId
#Scenario:Get Learning Progression by ID with subcontractorId
#
#	Given I post a Learning Progression record with the following details:
#		| Field                          | Value                |
#		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
#		| CurrentLearningStatus          | 1                    |
#		| LearningHours                  | 1                    |
#		| DateLearningStarted            | 2019-06-25T11:21:00Z |
#		| CurrentQualificationLevel      | 2                    |
#		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
#		| LastLearningProvidersUKPRN     | 12345678             |
#	When I get a Learning Progression by ID
#	Then there should be a 200 response
#		And the response body should contain:
#		| Field                          | Value                |
#		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
#		| CurrentLearningStatus          | 1                    |
#		| LearningHours                  | 1                    |
#		| DateLearningStarted            | 2019-06-25T11:21:00Z |
#		| CurrentQualificationLevel      | 2                    |
#		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
#		| LastLearningProvidersUKPRN     | 12345678             |
#		| SubcontractorId                |                      |

@learningprogressions
Scenario:Get All Learning Progression records where 1 exists
	Given I post a Learning Progression record with the following details:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |
	When I get all Learning Progression records for a customer
	Then there should be a 200 response
	And the response should contain 1 document(s)
	And the response body should incorporate a document with the following details:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentLearningStatus          | 1                    |
		| LearningHours                  | 1                    |
		| DateLearningStarted            | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastLearningProvidersUKPRN     | 12345678             |


#@learningprogressions
#Scenario:Get All Learning Progression records where 2 exist
#	Given I post a Learning Progression record with the following details:
#		| Field                          | Value                |
#		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
#		| CurrentLearningStatus          | 1                    |
#		| LearningHours                  | 1                    |
#		| DateLearningStarted            | 2019-06-25T11:21:00Z |
#		| CurrentQualificationLevel      | 2                    |
#		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
#		| LastLearningProvidersUKPRN     | 12345678             |
#	And I post a Learning Progression record with the following details:
#		| Field                          | Value                |
#		| DateProgressionRecorded        | 2019-06-25T11:21:00Z |
#		| CurrentLearningStatus          | 2                    |
#		| LearningHours                  | 2                    |
#		| DateLearningStarted            | 2019-07-25T11:21:00Z |
#		| CurrentQualificationLevel      | 3                    |
#		| DateQualificationLevelAchieved | 2019-07-26T11:21:00Z |
#		| LastLearningProvidersUKPRN     | 12345679             |
#	When I get all Learning Progression records for a customer
#	Then there should be a 200 response
#	And the response should contain 2 document(s)
#	And the response body should incorporate a document with the following details:
#		| Field                          | Value                |
#		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
#		| CurrentLearningStatus          | 1                    |
#		| LearningHours                  | 1                    |
#		| DateLearningStarted            | 2019-06-25T11:21:00Z |
#		| CurrentQualificationLevel      | 2                    |
#		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
#		| LastLearningProvidersUKPRN     | 12345678             |
#		| SubcontractorId                |                      |
#	And the response body should incorporate a document with the following details:
#		| Field                          | Value                |
#		| DateProgressionRecorded        | 2019-06-25T11:21:00Z |
#		| CurrentLearningStatus          | 2                    |
#		| LearningHours                  | 2                    |
#		| DateLearningStarted            | 2019-07-25T11:21:00Z |
#		| CurrentQualificationLevel      | 3                    |
#		| DateQualificationLevelAchieved | 2019-07-26T11:21:00Z |
#		| LastLearningProvidersUKPRN     | 12345679             |


#@learningprogressions
#Scenario:Get All Learning Progression records where many exist
#	Given I post a Learning Progression record with the following details:
#		| Field                          | Value                |
#		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
#		| CurrentLearningStatus          | 1                    |
#		| LearningHours                  | 1                    |
#		| DateLearningStarted            | 2019-06-25T11:21:00Z |
#		| CurrentQualificationLevel      | 2                    |
#		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
#		| LastLearningProvidersUKPRN     | 12345678             |
#	And I post a Learning Progression record with the following details:
#		| Field                          | Value                |
#		| DateProgressionRecorded        | 2018-07-25T11:21:00Z |
#		| CurrentLearningStatus          | 2                    |
#		| LearningHours                  | 2                    |
#		| DateLearningStarted            | 2019-07-25T11:21:00Z |
#		| CurrentQualificationLevel      | 3                    |
#		| DateQualificationLevelAchieved | 2019-07-26T11:21:00Z |
#		| LastLearningProvidersUKPRN     | 12345679             |
#	And I post a Learning Progression record with the following details:
#		| Field                          | Value                |
#		| DateProgressionRecorded        | 2018-08-25T11:21:00Z |
#		| CurrentLearningStatus          | 1                    |
#		| LearningHours                  | 1                    |
#		| DateLearningStarted            | 2019-06-25T11:21:00Z |
#		| CurrentQualificationLevel      | 4                    |
#		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
#		| LastLearningProvidersUKPRN     | 12345678             |
#	And I post a Learning Progression record with the following details:
#		| Field                          | Value                |
#		| DateProgressionRecorded        | 2018-09-25T11:21:00Z |
#		| CurrentLearningStatus          | 2                    |
#		| LearningHours                  | 2                    |
#		| DateLearningStarted            | 2018-07-25T11:21:00Z |
#		| CurrentQualificationLevel      | 5                    |
#		| DateQualificationLevelAchieved | 2019-07-26T11:21:00Z |
#		| LastLearningProvidersUKPRN     | 12345679             |
#	And I post a Learning Progression record with the following details:
#		| Field                          | Value                |
#		| DateProgressionRecorded        | 2018-10-25T11:21:00Z |
#		| CurrentLearningStatus          | 1                    |
#		| LearningHours                  | 1                    |
#		| DateLearningStarted            | 2019-06-25T11:21:00Z |
#		| CurrentQualificationLevel      | 6                    |
#		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
#		| LastLearningProvidersUKPRN     | 12345678             |
#	When I get all Learning Progression records for a customer
#	Then there should be a 200 response
#	And the response should contain 5 document(s)
#	And the response body should incorporate a document with the following details:
#		| Field                          | Value                |
#		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
#		| CurrentLearningStatus          | 1                    |
#		| LearningHours                  | 1                    |
#		| DateLearningStarted            | 2019-06-25T11:21:00Z |
#		| CurrentQualificationLevel      | 2                    |
#		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
#		| LastLearningProvidersUKPRN     | 12345678             |
#	And the response body should incorporate a document with the following details:
#		| Field                          | Value                |
#		| DateProgressionRecorded        | 2018-07-25T11:21:00Z |
#		| CurrentLearningStatus          | 2                    |
#		| LearningHours                  | 2                    |
#		| DateLearningStarted            | 2019-07-25T11:21:00Z |
#		| CurrentQualificationLevel      | 3                    |
#		| DateQualificationLevelAchieved | 2019-07-26T11:21:00Z |
#		| LastLearningProvidersUKPRN     | 12345679             |
#	And the response body should incorporate a document with the following details:
#		| Field                          | Value                |
#		| DateProgressionRecorded        | 2018-08-25T11:21:00Z |
#		| CurrentLearningStatus          | 1                    |
#		| LearningHours                  | 1                    |
#		| DateLearningStarted            | 2019-06-25T11:21:00Z |
#		| CurrentQualificationLevel      | 4                    |
#		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
#		| LastLearningProvidersUKPRN     | 12345678             |
#	And the response body should incorporate a document with the following details:
#		| Field                          | Value                |
#		| DateProgressionRecorded        | 2018-09-25T11:21:00Z |
#		| CurrentLearningStatus          | 2                    |
#		| LearningHours                  | 2                    |
#		| DateLearningStarted            | 2018-07-25T11:21:00Z |
#		| CurrentQualificationLevel      | 5                    |
#		| DateQualificationLevelAchieved | 2019-07-26T11:21:00Z |
#		| LastLearningProvidersUKPRN     | 12345679             |
#	And the response body should incorporate a document with the following details:
#		| Field                          | Value                |
#		| DateProgressionRecorded        | 2018-10-25T11:21:00Z |
#		| CurrentLearningStatus          | 1                    |
#		| LearningHours                  | 1                    |
#		| DateLearningStarted            | 2019-06-25T11:21:00Z |
#		| CurrentQualificationLevel      | 6                    |
#		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
#		| LastLearningProvidersUKPRN     | 12345678             |


@learningprogressions  
Scenario:Get Learning Progression by invalid ID
	Given I post a Learning Progression record with the following details:
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
	When I get a Learning Progression by ID
	Then there should be a 404 response

@learningprogressions
Scenario:Get All Learning Progression records where none exist

	Given I post a Learning Progression record with the following details:
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
	When I get all Learning Progression records for a customer
	Then there should be a 404 response
