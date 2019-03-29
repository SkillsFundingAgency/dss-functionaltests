
@postV1 @patchV2 @getV2

Feature: PostV1PatchV2




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
	And I post a session with the following details:
		| Field                    | Value                  |
		| DateandTimeOfSession     | 2018-01-21T14:45:00Z   |
		| VenuePostCode            | NN1 2NN                |


	@session
	Scenario: Valid Patch OutcomeClaimedDate with ClaimedPriorityGroup
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
		| OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
		When I patch the following:
		| Field                | Value                |
		| OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
		| ClaimedPriorityGroup | 5                    |
		Then there should be a 200 response

	Scenario: Patch OutcomeClaimedDate without ClaimedPriorityGroup
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
		When I patch the following:
		| Field                | Value				  |
	    | OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
		Then there should be a 422 response


	Scenario: Patch invalid OutcomeType
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
		When I patch the following:
		| Field                | Value				  |
	    | OutcomeType          | 7                    |
		Then there should be a 422 response




	Scenario:  Patch Outcome effective date earlier than Session.DateandTimeOfSession
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
		When I patch the following:
		| Field                | Value                |
		| OutcomeEffectiveDate | 2017-07-20T21:45:00Z |
		Then there should be a 422 response


	Scenario:  Patch Outcome effective date less than Outcome claimed date
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
		When I patch the following:
		| Field                | Value                |
		| OutcomeClaimedDate   | 2018-07-19T21:45:00Z |
		| ClaimedPriorityGroup | 5                    |
		Then there should be a 422 response

	Scenario: Patch Outcome effective date greater than Session.DateandTimeOfSession + 12 months
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 1                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
		When I patch the following:
		| Field                | Value                |
	    | OutcomeEffectiveDate | 2019-01-22T22:45:00Z |
		Then there should be a 422 response


	Scenario: Patch Outcome effective date greater than Session.DateandTimeOfSession + 13 months
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
		When I patch the following:
		| Field                | Value                |
	    | OutcomeEffectiveDate | 2019-02-22T22:45:00Z |
		Then there should be a 422 response

#	@sessionId
#	Scenario: Patch OutcomeType
#	Given I post an outcome with the following details:
#	    | Field                | Value                |
#	    | OutcomeType          | 1                    |
#	    | OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
#	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
#		When I patch the following:
#		| Field                | Value				  |
#	    | OutcomeType          | 2                    |
#		Then there should be a 200 response
#		And the response body should contain:
#		| Field                | Value                |
#	    | OutcomeType          | 2                    |
#	    | OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
#	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
#
#
#
#	Scenario: Patch OutcomeType with SubcontractorId
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
#	    | OutcomeType          | 2                    |
#	    | OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
#	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
#		And the response body should contain the SubContractorId
#
#
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
#		| Field                    | Value                                |
#	    | OutcomeType          | 3                    |
#	    | OutcomeClaimedDate   | 2018-07-21T21:45:00Z |
#	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
#
#
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
#		| Field                    | Value                                |
#	    | OutcomeType          | 3                    |
#	    | OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
#	    | OutcomeEffectiveDate | 2018-07-20T22:45:00Z |
