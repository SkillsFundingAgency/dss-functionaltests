
@postV2

Feature: PostV2


	
	Background: Setup
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
	And I post a session with the following details:
		| Field                    | Value                  |
		| DateandTimeOfSession     | 2018-06-21T14:45:00Z   |
		| VenuePostCode            | NN1 2NN                |
	And I post an ActionPlan with the following details:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |



	@V2
	Scenario: Post Valid Action
		Given I post an Action with the following details:
		| Field                         | Value                |
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
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		| LastModifiedDate              | 2018-07-30T09:00:00Z |

	@V2
	Scenario: Post Valid Action with only mandatory Fields
		Given I post an Action with the following details:
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| PersonResponsible             | 1                    |
		Then there should be a 201 response
		And the response body should contain:
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| PersonResponsible             | 1                    |


	@V2
	Scenario: Post Action with invalid interactionId
		Given I post an Action with the following details:
		| Field                         | Value                |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| DateActionActuallyCompleted   | 2018-08-06T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		| LastModifiedDate              | 2018-07-30T09:00:00Z |
		Then there should be a 422 response

	@V2
	Scenario: Post Action with missing DateActionAgreed
		Given I post an Action with the following details:
		| Field                         | Value                |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| DateActionActuallyCompleted   | 2018-08-06T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		| LastModifiedDate              | 2018-07-30T09:00:00Z |
		Then there should be a 422 response

    @V2
	Scenario: Post Action with missing DateActionAimsToBeCompletedBy
		Given I post an Action with the following details:
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionActuallyCompleted   | 2018-08-06T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		| LastModifiedDate              | 2018-07-30T09:00:00Z |
		Then there should be a 422 response

    @V2
	Scenario: Post Action with missing DateActionActuallyCompleted
		Given I post an Action with the following details:
		| Field                         | Value                |
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
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| DateActionActuallyCompleted   | null				   |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		| LastModifiedDate              | 2018-07-30T09:00:00Z |

	@V2
	Scenario: Post Action with missing ActionSummary
		Given I post an Action with the following details:
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| DateActionActuallyCompleted   | 2018-08-06T09:00:00Z |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		| LastModifiedDate              | 2018-07-30T09:00:00Z |
		Then there should be a 422 response

    @V2
	Scenario: Post Action with missing ActionType
		Given I post an Action with the following details:
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| DateActionActuallyCompleted   | 2018-08-06T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		| LastModifiedDate              | 2018-07-30T09:00:00Z |
		Then there should be a 422 response

    @V2
	Scenario: Post Action with missing PersonResponsible
		Given I post an Action with the following details:
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| DateActionActuallyCompleted   | 2018-08-06T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| LastModifiedDate              | 2018-07-30T09:00:00Z |
		Then there should be a 422 response

	@V2
	Scenario: Post Action with DateActionAgreed later than datetime.now
		Given I post an Action with the following details:
		| Field                         | Value                |
		| DateActionAgreed              | 2028-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		| LastModifiedDate              | 2018-07-30T09:00:00Z |
		Then there should be a 422 response
     
	@V2
	Scenario: Post Action with DateActionAimsToBeCompletedBy earlier than DateActionAgreed
		Given I post an Action with the following details:
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-06-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		| LastModifiedDate              | 2018-07-30T09:00:00Z |
		Then there should be a 422 response

	Scenario: Post Action with DateActionActuallyCompleted earlier than DateActionAgreed
		Given I post an Action with the following details:
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-07-08T09:00:00Z |
		| DateActionActuallyCompleted   | 2018-06-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		| LastModifiedDate              | 2018-07-30T09:00:00Z |
		Then there should be a 422 response