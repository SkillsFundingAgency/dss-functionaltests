
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
		| DateandTimeOfSession     | 2018-01-21T14:45:00Z   |
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

	@Cat1
	Scenario: Valid Patch OutcomeClaimedDate with ClaimedPriorityGroup
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
		When I patch the following:
		| Field                | Value                |
		| OutcomeClaimedDate   | 2018-08-20T21:45:00Z |
		| ClaimedPriorityGroup | 5                    |
		Then there should be a 200 response

	@Cat1
	Scenario: Valid Patch remove value for OutcomeClaimedDate
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-08-20T21:45:00Z |
	    | OutcomeClaimedDate   | 2018-08-20T21:45:00Z |
	    | ClaimedPriorityGroup | 5                    |
		When I patch the following:
		| Field                | Value                |
		| OutcomeClaimedDate   |                      |
		Then there should be a 200 response
		And the response body should contain:
         | Field                | Value                |
         | OutcomeEffectiveDate | 2018-08-20T21:45:00Z |
         | OutcomeType          | 3                    |
         | OutcomeClaimedDate   |                      |
         | ClaimedPriorityGroup | 5                    |

		Scenario: Valid Patch remove value for OutcomeClaimedDate and OutcomeEffectiveDate 
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-08-20T21:45:00Z |
	    | OutcomeClaimedDate   | 2018-08-20T21:45:00Z |
	    | ClaimedPriorityGroup | 5                    |
		When I patch the following:
		| Field                | Value |
		| OutcomeClaimedDate   |       |
		| OutcomeEffectiveDate |       |
		Then there should be a 200 response
		And the response body should contain:
         | Field                | Value                |
         | OutcomeEffectiveDate |                      |
         | OutcomeType          | 3                    |
         | OutcomeClaimedDate   |                      |
         | ClaimedPriorityGroup | 5                    |


		Scenario: Valid Patch add values for OutcomeClaimedDate and OutcomeEffectiveDate 
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | ClaimedPriorityGroup | 5                    |
		When I patch the following:
		| Field                | Value                |
		| OutcomeEffectiveDate | 2018-08-20T21:45:00Z |
		| OutcomeClaimedDate   | 2018-08-20T21:46:00Z |
		Then there should be a 200 response
		And the response body should contain:
         | Field                | Value                |
         | OutcomeEffectiveDate | 2018-08-20T21:45:00Z |
         | OutcomeType          | 3                    |
         | OutcomeClaimedDate   | 2018-08-20T21:46:00Z |
         | ClaimedPriorityGroup | 5                    |

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