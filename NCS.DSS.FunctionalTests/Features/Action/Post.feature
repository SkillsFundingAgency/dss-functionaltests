Feature: Post



	Background: Post
	Given I post an adviser with the following details:
		| Field						 | Value				|
		| AdviserName				 | BillyAdviser			|
		| AdviserContactNumber		 | 98798678967967		|
	And I post a Customer with the following details:
		| Field                      | Value                |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
	And I post an Interaction with the following details:
		| Field                    | Value                  |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z   |
		| Channel                  | 2                      |
		| InteractionType          | 2                      |
		| LastModifiedDate         | 2018-06-22T16:52:10Z   |
	And I post an ActionPlan with the following details:
		| field                          | value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |




	Scenario: Post Valid Action
		Given I post an Action with the following details:
		| field                         | value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		| LastModifiedDate              | 2018-07-30T09:00:00Z |
		Then there should be a 201 response
		And the response body should contain:
		| field                         | value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		| LastModifiedDate              | 2018-07-30T09:00:00Z |


	Scenario: Post Valid Action with only mandatory fields
		Given I post an Action with the following details:
		| field                         | value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| PersonResponsible             | 1                    |
		Then there should be a 201 response
		And the response body should contain:
		| field                         | value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| PersonResponsible             | 1                    |


	Scenario: Post Action with missing DateActionAgreed
		Given I post an Action with the following details:
		| field                         | value                |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| DateActionActuallyCompleted   | 2018-08-06T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		| LastModifiedDate              | 2018-07-30T09:00:00Z |
		Then there should be a 422 response
		And the error message should be "The DateActionAgreed field is required."


	Scenario: Post Action with missing DateActionAimsToBeCompletedBy
		Given I post an Action with the following details:
		| field                         | value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionActuallyCompleted   | 2018-08-06T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		| LastModifiedDate              | 2018-07-30T09:00:00Z |
		Then there should be a 422 response
		And the error message should be "The DateActionAimsToBeCompletedBy field is required."


	Scenario: Post Action with missing DateActionActuallyCompleted
		Given I post an Action with the following details:
		| field                         | value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		| LastModifiedDate              | 2018-07-30T09:00:00Z |
		Then there should be a 201 response
		And the response body should contain:
		| field                         | value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| DateActionActuallyCompleted   | null				   |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		| LastModifiedDate              | 2018-07-30T09:00:00Z |

	Scenario: Post Action with missing ActionSummary
		Given I post an Action with the following details:
		| field                         | value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| DateActionActuallyCompleted   | 2018-08-06T09:00:00Z |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		| LastModifiedDate              | 2018-07-30T09:00:00Z |
		Then there should be a 422 response
		And the error message should be "The ActionSummary field is required."


	Scenario: Post Action with missing ActionType
		Given I post an Action with the following details:
		| field                         | value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| DateActionActuallyCompleted   | 2018-08-06T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		| LastModifiedDate              | 2018-07-30T09:00:00Z |
		Then there should be a 422 response
		And the error message should be "The ActionType field is required."


	Scenario: Post Action with missing PersonResponsible
		Given I post an Action with the following details:
		| field                         | value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| DateActionActuallyCompleted   | 2018-08-06T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| LastModifiedDate              | 2018-07-30T09:00:00Z |
		Then there should be a 422 response
		And the error message should be "The PersonResponsible field is required."