

@postV2

Feature: PostV2withSessionDate


	Scenario: Valid Outcome
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
		| DateandTimeOfInteraction | 2018-02-01T11:21:00Z   |
		| Channel                  | 2                      |
		| InteractionType          | 2                      |
		And I post a session with the following details:
		| Field                    | Value                  |
		| DateandTimeOfSession     | 2018-02-01T11:21:00Z   |
		| VenuePostCode            | NN1 2NN                |
		And I post an ActionPlan with the following details:
		| field                          | value                |
		| DateActionPlanCreated          | 2018-02-01T11:21:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-02-01T11:21:00Z |
		| DateActionPlanSentToCustomer   | 2018-02-01T11:21:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-02-10T11:21:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		Given I post an outcome with the following details:
	    | Field                | Value				   |
	    | OutcomeType          | 1                     |
	    | OutcomeClaimedDate   | 2018-06-06T11:21:00Z  |
	    | OutcomeEffectiveDate | 2018-05-05T11:21:00Z  |
		| ClaimedPriorityGroup | 3                     |
		Then there should be a 201 response
		And there should be a record in the outcomes ChangeFeed table
		And there should be a record in the outcomes-history ChangeFeed table



@outcomes
	Scenario:  Outcome effective date earlier than Session.DateandTimeOfSession
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
		| DateandTimeOfInteraction | 2018-02-01T11:21:00Z   |
		| Channel                  | 2                      |
		| InteractionType          | 2                      |
		And I post a session with the following details:
		| Field                    | Value                  |
		| DateandTimeOfSession     | 2018-02-01T11:21:00Z   |
		| VenuePostCode            | NN1 2NN                |
		And I post an ActionPlan with the following details:
		| field                          | value                |
		| DateActionPlanCreated          | 2018-02-01T11:21:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-02-01T11:21:00Z |
		| DateActionPlanSentToCustomer   | 2018-02-01T11:21:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-02-10T11:21:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		Given I post an outcome with the following details:
	    | Field                | Value				   |
	    | OutcomeType          | 1                     |
	    | OutcomeClaimedDate   | 2018-01-01T11:21:00Z  |
	    | OutcomeEffectiveDate | 2018-01-01T11:21:00Z  |
		| ClaimedPriorityGroup | 3                    |
		Then there should be a 422 response

@outcomes
	Scenario:  Outcome effective date less than Outcome claimed date
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
		| DateandTimeOfInteraction | 2018-02-01T11:21:00Z   |
		| Channel                  | 2                      |
		| InteractionType          | 2                      |
		And I post a session with the following details:
		| Field                    | Value                  |
		| DateandTimeOfSession     | 2018-02-01T11:21:00Z   |
		| VenuePostCode            | NN1 2NN                |
		And I post an ActionPlan with the following details:
		| field                          | value                |
		| DateActionPlanCreated          | 2018-02-01T11:21:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-02-01T11:21:00Z |
		| DateActionPlanSentToCustomer   | 2018-02-01T11:21:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-02-10T11:21:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		Given I post an outcome with the following details:
	    | Field                | Value				   |
	    | OutcomeType          | 1                     |
	    | OutcomeClaimedDate   | 2018-02-02T11:21:00Z  |
	    | OutcomeEffectiveDate | 2018-02-03T11:21:00Z  |
		| ClaimedPriorityGroup | 3                    |
		Then there should be a 422 response

@outcomes
	Scenario: Outcome effective date greater than Session.DateandTimeOfSession + 12 months
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
		| DateandTimeOfInteraction | 2018-02-01T11:21:00Z   |
		| Channel                  | 2                      |
		| InteractionType          | 2                      |
		And I post a session with the following details:
		| Field                    | Value                  |
		| DateandTimeOfSession     | 2018-02-01T11:21:00Z   |
		| VenuePostCode            | NN1 2NN                |
		And I post an ActionPlan with the following details:
		| field                          | value                |
		| DateActionPlanCreated          | 2018-02-01T11:21:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-02-01T11:21:00Z |
		| DateActionPlanSentToCustomer   | 2018-02-01T11:21:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-02-10T11:21:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		Given I post an outcome with the following details:
	    | Field                | Value				   |
	    | OutcomeType          | 1                     |
	    | OutcomeEffectiveDate | 2019-02-05T11:21:00Z  |
		| ClaimedPriorityGroup | 3                     |
		Then there should be a 422 response

@outcomes
	Scenario: Outcome effective date greater than Session.DateandTimeOfSession + 12 months with outcome type 3
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
		| DateandTimeOfInteraction | 2018-02-01T11:21:00Z   |
		| Channel                  | 2                      |
		| InteractionType          | 2                      |
		And I post a session with the following details:
		| Field                    | Value                  |
		| DateandTimeOfSession     | 2018-02-01T11:21:00Z   |
		| VenuePostCode            | NN1 2NN                |
		And I post an ActionPlan with the following details:
		| field                          | value                |
		| DateActionPlanCreated          | 2018-02-01T11:21:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-02-01T11:21:00Z |
		| DateActionPlanSentToCustomer   | 2018-02-01T11:21:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-02-10T11:21:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		Given I post an outcome with the following details:
	    | Field                | Value				   |
	    | OutcomeType          | 3                     |
	    | OutcomeEffectiveDate | 2019-02-05T11:21:00Z  |
		| ClaimedPriorityGroup | 3                     |
		Then there should be a 201 response

@outcomes
	Scenario: Claimed priority group missing
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
		| DateandTimeOfInteraction | 2018-02-01T11:21:00Z   |
		| Channel                  | 2                      |
		| InteractionType          | 2                      |
		And I post a session with the following details:
		| Field                    | Value                  |
		| DateandTimeOfSession     | 2018-02-01T11:21:00Z   |
		| VenuePostCode            | NN1 2NN                |
		And I post an ActionPlan with the following details:
		| field                          | value                |
		| DateActionPlanCreated          | 2018-02-01T11:21:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-02-01T11:21:00Z |
		| DateActionPlanSentToCustomer   | 2018-02-01T11:21:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-02-10T11:21:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		Given I post an outcome with the following details:
	    | Field                | Value				   |
	    | OutcomeType          | 1                     |
	    | OutcomeClaimedDate   | 2018-06-06T11:21:00Z  |
	    | OutcomeEffectiveDate | 2018-05-05T11:21:00Z  |
		Then there should be a 422 response