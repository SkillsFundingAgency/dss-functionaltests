﻿#
#@postV1 @patchV1
#
#Feature: Patch
#
#
#
#Background: Prepare test
#	Given I post an adviser with the following details:
#		| Field						 | Value				|
#		| AdviserName				 | BillyAdviser			|
#		| AdviserContactNumber		 | 98798678967967		|
#	And I post a Customer with the following details:
#		| Field                      | Value                |
#		| GivenName                  | Bob                  |
#		| FamilyName                 | Customer             |
#	And I post an Interaction with the following details:
#		| Field                    | Value                  |
#		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z   |
#		| Channel                  | 2                      |
#		| InteractionType          | 2                      |
#		| LastModifiedDate         | 2018-06-22T16:52:10Z   |
#	And I post an ActionPlan with the following details:
#		| field                          | value                |
#		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
#		| CustomerCharterShownToCustomer | true                 |
#		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
#		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
#		| ActionPlanDeliveryMethod       | 1                    |
#		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
#		| PriorityCustomer               | 1                    |
#		| CurrentSituation               | looking for work     |
#
#
#
#@outcomes @smoke
#	Scenario: Patch OutcomeType
#	Given I post an outcome with the following details:
#	    | Field                | Value                |
#	    | OutcomeType          | 3                    |
#	    | OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
#	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
#		When I patch the following:
#		| Field                | Value				  |
#	    | OutcomeType          | 2                    |
#		Then there should be a 200 response
#		And the response body should contain:
#		| Field                | Value                |
#		| OutcomeType          | 2                    |
#		| OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
#		| OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
#		And there should be a record in the outcomes ChangeFeed table
#		And there should be a record in the outcomes-history ChangeFeed table
#
#@outcomes
#	Scenario: Patch OutcomeClaimedDate
#	Given I post an outcome with the following details:
#	    | Field                | Value                |
#	    | OutcomeType          | 3                    |
#	    | OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
#	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
#		When I patch the following:
#		| Field                | Value				  |
#	    | OutcomeClaimedDate   | 2018-07-21T21:45:00Z |
#		Then there should be a 200 response
#		And the response body should contain:
#		| Field                | Value                |
#		| OutcomeType          | 3                    |
#		| OutcomeClaimedDate   | 2018-07-21T21:45:00Z |
#		| OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
#		And there should be a record in the outcomes ChangeFeed table
#		And there should be a record in the outcomes-history ChangeFeed table
#
#@outcomes
#	Scenario: Patch OutcomeEffectiveDate
#	Given I post an outcome with the following details:
#	    | Field                | Value                |
#	    | OutcomeType          | 3                    |
#	    | OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
#	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
#		When I patch the following:
#		| Field                | Value				  |
#	    | OutcomeEffectiveDate | 2018-07-20T22:45:00Z |
#		Then there should be a 200 response
#		And the response body should contain:
#		| Field                    | Value            |
#	    | OutcomeType          | 3                    |
#	    | OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
#	    | OutcomeEffectiveDate | 2018-07-20T22:45:00Z |
#		And there should be a record in the outcomes ChangeFeed table
#		And there should be a record in the outcomes-history ChangeFeed table
