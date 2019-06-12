

@postV2 @patchV2

Feature: PatchV2


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

@actions
	Scenario: Patch DateActionAimsToBeCompletedBy
		Given I post an Action with the following details:
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		When I patch the following:
		| Field                         | Value                |
		| DateActionAimsToBeCompletedBy | 2018-09-08T09:00:00Z |
		Then there should be a 200 response
		And the response body should contain:
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-09-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		And there should be a record in the actions ChangeFeed table
		And there should be a record in the actions-history ChangeFeed table

@actions
	Scenario: Patch ActionSummary
		Given I post an Action with the following details:
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		When I patch the following:
		| Field                         | Value                |
		| ActionSummary                 | A New Summary        |
		Then there should be a 200 response
		And the response body should contain:
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| ActionSummary                 | A New Summary        |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |

@actions
	Scenario: Patch SignpostedTo
		Given I post an Action with the following details:
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		When I patch the following:
		| Field                         | Value                |
		| SignpostedTo                  | Updated Details      |
		Then there should be a 200 response
		And the response body should contain:
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Updated Details      |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |

@actions
	Scenario: Patch ActionType
		Given I post an Action with the following details:
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		When I patch the following:
		| Field                         | Value                |
		| ActionType                    | 2                    |
		Then there should be a 200 response
		And the response body should contain:
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 2                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |

@actions
	Scenario: Patch ActionStatus
		Given I post an Action with the following details:
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		When I patch the following:
		| Field                         | Value                |
		| ActionStatus                  | 2                    |
		Then there should be a 200 response
		And the response body should contain:
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 2                    |
		| PersonResponsible             | 1                    |

@actions
	Scenario: Patch PersonResponsible
		Given I post an Action with the following details:
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		When I patch the following:
		| Field                         | Value                |
		| PersonResponsible             | 2                    |
		Then there should be a 200 response
		And the response body should contain:
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 2                    |

@actions
	Scenario: Patch with invalid ActionType
		Given I post an Action with the following details:
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		When I patch the following:
		| Field                         | Value                |
		| ActionType                    | 33                   |
		Then there should be a 422 response

		Scenario: Patch with invalid ActionStatus
		Given I post an Action with the following details:
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		When I patch the following:
		| Field                         | Value                |
		| ActionStatus                  | 33                   |
		Then there should be a 422 response

@actions
		Scenario: Patch with invalid PersonResponsible
		Given I post an Action with the following details:
		| Field                         | Value                |
		| DateActionAgreed              | 2018-07-30T09:00:00Z |
		| DateActionAimsToBeCompletedBy | 2018-08-08T09:00:00Z |
		| ActionSummary                 | A Summary            |
		| SignpostedTo                  | Some Details         |
		| ActionType                    | 1                    |
		| ActionStatus                  | 1                    |
		| PersonResponsible             | 1                    |
		When I patch the following:
		| Field                         | Value                |
		| PersonResponsible             | 33                   |
		Then there should be a 422 response

