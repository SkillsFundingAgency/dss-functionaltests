﻿Feature: Post V3 Outcome

Background: Prepare test
	Given I post an adviser with the following details V2:
		| Field                | Value          |
		| AdviserName          | BillyAdviser   |
		| AdviserContactNumber | 98798678967967 |
	And I post a Customer with the following details V3:
		| Field      | Value		|
		| GivenName  | Bob			|
		| FamilyName | Customer		|
		| PriorityGroups | 1,3      |
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

@outcomes @smoke
Scenario: Create an outcome with minimum valid values
	Given I post an outcome with the following details V3:
		| Field       | Value |
		| OutcomeType | 3     |
	Then there should be a 201 response
	#And the "outcomes" cosmos document should include CreatedBy
	And the response body should contain:
		| Field       | Value |
		| OutcomeType | 3     |
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-outcomes table with OutcomeId

@outcomes	@subcontractorId
Scenario: Create an outcome with all valid values
	Given I post an outcome with the following details V3:
		| Field                | Value                |
		| OutcomeType          | 3                    |
		| OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
		| OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
		| IsPriorityCustomer   | true                 |
	Then there should be a 201 response
	#And the "outcomes" cosmos document should include CreatedBy
	And the response body should contain:
		| Field                | Value                |
		| OutcomeType          | 3                    |
		| OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
		| OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
		| IsPriorityCustomer   | true                 |
	#And the response body should contain the SubContractorId
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-outcomes table with OutcomeId

@outcomes
Scenario: Create an outcome with invalid OutcomeType
	Given I post an outcome with the following details V3:
		| Field                | Value                |
		| OutcomeType          | 6                    |
		| OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
		| OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
		| IsPriorityCustomer   | true                 |
	Then there should be a 422 response

@outcomes
Scenario: Create an outcome with missing ClaimedPriorityGroup
	Given I post an outcome with the following details V3:
		| Field                | Value                |
		| OutcomeType          | 6                    |
		| OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
		| OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
		| IsPriorityCustomer   | true                 |
	Then there should be a 422 response

@outcomes
Scenario: Create an outcome with missing OutcomeEffectiveDate
	Given I post an outcome with the following details V3:
		| Field              | Value                |
		| OutcomeType        | 6                    |
		| OutcomeClaimedDate | 2018-07-20T21:45:00Z |
		| IsPriorityCustomer | true                 |
	Then there should be a 422 response

@outcomes
Scenario: Create an outcome with OutcomeClaimedDate earlier than OutcomeEffectiveDate
	Given I post an outcome with the following details V3:
		| Field                | Value                |
		| OutcomeType          | 6                    |
		| OutcomeClaimedDate   | 2018-07-19T21:45:00Z |
		| OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
		| IsPriorityCustomer   | true                 |
	Then there should be a 422 response