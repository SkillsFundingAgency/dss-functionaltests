﻿Feature: GetV2

Background: Prepare test
	Given I post a Customer with the following details V3:
		| Field					| Value    |
		| GivenName				| Bob      |
		| FamilyName			| Customer |
		| PriorityGroups        | 1,3    |
	And I post an Interaction with the following details:
		| Field                    | Value                |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z |
		| Channel                  | 2                    |
		| InteractionType          | 2                    |
		| LastModifiedDate         | 2018-06-22T16:52:10Z |
	And I post a session with the following details V2:
		| Field                | Value                |
		| DateandTimeOfSession | 2018-06-21T14:45:00Z |
		| VenuePostCode        | NN1 2NN              |
	And I post an ActionPlan with the following details V3:
		| field                          | value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
	And I post a goal with the following details V2:
		| Field                       | Value                |
		| DateGoalCaptured            | 2018-06-21T14:45:00Z |
		| DateGoalShouldBeCompletedBy | 2018-06-21T14:45:00Z |
		| GoalSummary                 | some goal text       |
		| GoalType                    | 1                    |
		| GoalStatus                  | 1                    |

@goals @smoke
Scenario: Get Goal by ID
	When I get a Goal by ID V2
	Then there should be a 200 response
	And the response body should contain:
		| Field                       | Value                |
		| DateGoalCaptured            | 2018-06-21T14:45:00Z |
		| DateGoalShouldBeCompletedBy | 2018-06-21T14:45:00Z |
		| GoalSummary                 | some goal text       |
		| GoalType                    | 1                    |
		| GoalStatus                  | 1                    |