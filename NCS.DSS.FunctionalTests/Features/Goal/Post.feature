
@postV1

Feature: Post




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



@goals
Scenario: Create a Goal for existing customer with all valid values
	Given I post a goal with the following details:
	    | Field                       | Value                |
	    | DateGoalCaptured            | 2018-06-21T14:45:00Z |
	    | DateGoalShouldBeCompletedBy | 2018-06-21T14:45:00Z |
	    | GoalSummary                 | some goal text       |
	    | GoalType                    | 1                    |
	    | GoalStatus                  | 1                    |
		Then there should be a 201 response
		And the response body should contain:
	    | Field			              | Value                |
	    | DateGoalCaptured            | 2018-06-21T14:45:00Z |
	    | DateGoalShouldBeCompletedBy | 2018-06-21T14:45:00Z |
	    | GoalSummary                 | some goal text       |
	    | GoalType                    | 1                    |
	    | GoalStatus                  | 1                    |
		And there should be a record in the goals ChangeFeed table
		And there should be a record in the goals-history ChangeFeed table

@goals
	Scenario: Create a Goal with missing DateGoalCaptured
	Given I post a goal with the following details:
	    | Field                       | Value                |
	    | DateGoalShouldBeCompletedBy | 2018-06-21T14:45:00Z |
	    | GoalSummary                 | some goal text       |
	    | GoalType                    | 1                    |
	    | GoalStatus                  | 1                    |
		Then there should be a 422 response

@goals
	Scenario: Create a Goal with missing DateGoalShouldBeCompletedBy
	Given I post a goal with the following details:
	    | Field                       | Value                |
	    | DateGoalCaptured            | 2018-06-21T14:45:00Z |
	    | GoalSummary                 | some goal text       |
	    | GoalType                    | 1                    |
	    | GoalStatus                  | 1                    |
		Then there should be a 422 response

@goals
	Scenario: Create a Goal with missing GoalSummary
	Given I post a goal with the following details:
	    | Field                       | Value                |
	    | DateGoalCaptured            | 2018-06-21T14:45:00Z |
	    | DateGoalShouldBeCompletedBy | 2018-06-21T14:45:00Z |
	    | GoalType                    | 1                    |
	    | GoalStatus                  | 1                    |
		Then there should be a 422 response

@goals
	Scenario: Create a Goal with missing GoalType
	Given I post a goal with the following details:
	    | Field                       | Value                |
	    | DateGoalCaptured            | 2018-06-21T14:45:00Z |
	    | DateGoalShouldBeCompletedBy | 2018-06-21T14:45:00Z |
	    | GoalSummary                 | some goal text       |
	    | GoalStatus                  | 1                    |
		Then there should be a 422 response

@goals
	Scenario: Create a Goal with invalid GoalType
	Given I post a goal with the following details:
	    | Field                       | Value                |
	    | DateGoalCaptured            | 2018-06-21T14:45:00Z |
	    | DateGoalShouldBeCompletedBy | 2018-06-21T14:45:00Z |
	    | GoalSummary                 | some goal text       |
	    | GoalType                    | 11                   |
	    | GoalStatus                  | 1                    |
		Then there should be a 422 response

@goals
	Scenario: Create a Goal with invalid GoalStatus
	Given I post a goal with the following details:
	    | Field                       | Value                |
	    | DateGoalCaptured            | 2018-06-21T14:45:00Z |
	    | DateGoalShouldBeCompletedBy | 2018-06-21T14:45:00Z |
	    | GoalSummary                 | some goal text       |
	    | GoalType                    | 1                    |
	    | GoalStatus                  | 11                   |
		Then there should be a 422 response
