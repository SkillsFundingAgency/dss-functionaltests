

@postV2 @patchV2

Feature: PatchV2


Background: Prepare test
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
		| field                          | value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |



@goals @subcontractorId
	Scenario: Patch DateGoalCaptured
		Given I post a goal with the following details:
	    | Field                       | Value                |
	    | DateGoalCaptured            | 2018-06-21T14:45:00Z |
	    | DateGoalShouldBeCompletedBy | 2018-07-21T14:45:00Z |
	    | GoalSummary                 | some goal text       |
	    | GoalType                    | 1                    |
	    | GoalStatus                  | 1                    |
		When I patch the following:
		| Field                       | Value                |
	    | DateGoalCaptured            | 2018-06-22T14:45:00Z |
		Then there should be a 200 response
		And the response body should contain:
	    | Field			              | Value                |
	    | DateGoalCaptured            | 2018-06-22T14:45:00Z |
	    | DateGoalShouldBeCompletedBy | 2018-07-21T14:45:00Z |
	    | GoalSummary                 | some goal text       |
	    | GoalType                    | 1                    |
	    | GoalStatus                  | 1                    |
		And the response body should contain the SubContractorId
		And there should be a record in the goals ChangeFeed table
		And there should be a record in the goals-history ChangeFeed table


@goals @subcontractorId
	Scenario: Patch DateGoalShouldBeCompletedBy
		Given I post a goal with the following details:
	    | Field                       | Value                |
	    | DateGoalCaptured            | 2018-06-21T14:45:00Z |
	    | DateGoalShouldBeCompletedBy | 2018-07-21T14:45:00Z |
	    | GoalSummary                 | some goal text       |
	    | GoalType                    | 1                    |
	    | GoalStatus                  | 1                    |
		When I patch the following:
		| Field                       | Value                |
	    | DateGoalShouldBeCompletedBy | 2018-07-22T14:45:00Z |
		Then there should be a 200 response
		And the response body should contain:
	    | Field			              | Value                |
	    | DateGoalCaptured            | 2018-06-21T14:45:00Z |
	    | DateGoalShouldBeCompletedBy | 2018-07-22T14:45:00Z |
	    | GoalSummary                 | some goal text       |
	    | GoalType                    | 1                    |
	    | GoalStatus                  | 1                    |
		And the response body should contain the SubContractorId

@goals
	Scenario: Patch DateGoalAchieved
		Given I post a goal with the following details:
	    | Field                       | Value                |
	    | DateGoalCaptured            | 2018-06-21T14:45:00Z |
	    | DateGoalShouldBeCompletedBy | 2018-07-21T14:45:00Z |
	    | GoalSummary                 | some goal text       |
	    | GoalType                    | 1                    |
	    | GoalStatus                  | 1                    |
		When I patch the following:
		| Field                       | Value                |
	    | DateGoalAchieved			  | 2018-07-15T14:45:00Z |
		Then there should be a 200 response
		And the response body should contain:
	    | Field			              | Value                |
	    | DateGoalCaptured            | 2018-06-21T14:45:00Z |
	    | DateGoalShouldBeCompletedBy | 2018-07-21T14:45:00Z |
	    | DateGoalAchieved			  | 2018-07-15T14:45:00Z |
	    | GoalSummary                 | some goal text       |
	    | GoalType                    | 1                    |
	    | GoalStatus                  | 1                    |

@goals
	Scenario: Patch with invalid GoalType
		Given I post a goal with the following details:
	    | Field                       | Value                |
	    | DateGoalCaptured            | 2018-06-21T14:45:00Z |
	    | DateGoalShouldBeCompletedBy | 2018-07-21T14:45:00Z |
	    | GoalSummary                 | some goal text       |
	    | GoalType                    | 1                    |
	    | GoalStatus                  | 1                    |
		When I patch the following:
		| Field                       | Value                |
	    | GoalType                    | 4                    |
		Then there should be a 422 response

@goals
	Scenario: Patch with invalid GoalStatus
		Given I post a goal with the following details:
	    | Field                       | Value                |
	    | DateGoalCaptured            | 2018-06-21T14:45:00Z |
	    | DateGoalShouldBeCompletedBy | 2018-07-21T14:45:00Z |
	    | GoalSummary                 | some goal text       |
	    | GoalType                    | 1                    |
	    | GoalStatus                  | 1                    |
		When I patch the following:
		| Field                       | Value                |
	    | GoalStatus                  | 4                    |
		Then there should be a 422 response