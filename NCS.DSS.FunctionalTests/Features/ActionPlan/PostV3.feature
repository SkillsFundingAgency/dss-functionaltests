
@postV3

Feature: PostV3



	Background: Post
	Given I post an adviser with the following details:
		| Field						 | Value				|
		| AdviserName				 | BillyAdviser			|
		| AdviserContactNumber		 | 98798678967967		|
	Given I post a Customer with the following details:
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

@actionplans @smoke
	Scenario: Post Valid ActionPlan with all fields
		Given I post an ActionPlan with the following details:
		| field                          | value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		Then there should be a 201 response
	    And the "actionplans" cosmos document should include CreatedBy
		And the response body should contain:
		| field                          | value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		And the response body should contain the SessionId 
		And the response body should not contain the "CreatedBy"
		And there should be a record in the ActionPlans ChangeFeed table
		And there should be a record in the ActionPlans-history ChangeFeed table

	
@actionplans	@subcontractorId
	Scenario: Post Valid ActionPlan with all fields and SubContractorId
		Given I post an ActionPlan with the following details:
		| field                          | value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		Then there should be a 201 response
	    And the "actionplans" cosmos document should include CreatedBy
		And the response body should contain:
		| field                          | value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		And the response body should not contain the "CreatedBy"
		And the response body should contain the SessionId 
		And the response body should contain the SubContractorId 

@actionplans
	Scenario: Post Valid ActionPlan with only mandatory fields
		Given I post an ActionPlan with the following details:
		| field                          | value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| PriorityCustomer               | 1                    |
		Then there should be a 201 response
		And the response body should contain:
		| field                          | value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| ActionPlanDeliveryMethod       | null                 |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | null			        |
		And the response body should contain the SessionId 

	
@actionplans	@subcontractorId
	Scenario: Post Valid ActionPlan with only mandatory fields and SubcontractorId
		Given I post an ActionPlan with the following details:
		| field                          | value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| PriorityCustomer               | 1                    |
		Then there should be a 201 response
		And the response body should contain:
		| field                          | value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| ActionPlanDeliveryMethod       | null                 |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | null			        |
		And the response body should contain the SessionId 
		And the response body should contain the SubContractorId 

@actionplans
	Scenario: Changed feed for Post ActionPlan
#		Given I post an adviser with the following details:
#		| Field						 | Value				|
#		| AdviserName				 | BillyAdviser			|
#		| AdviserContactNumber		 | 98798678967967		|
#		And I post a Customer with the following details:
#		| Field                      | Value                |
#		| GivenName                  | Bob                  |
#		| FamilyName                 | Customer             |
#		And I post an Interaction with the following details:
#		| Field                    | Value                  |
#		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z   |
#		| Channel                  | 2                      |
#		| InteractionType          | 2                      |
#		| LastModifiedDate         | 2018-06-22T16:52:10Z   |
#		And I post a session with the following details:
#		| Field                    | Value                  |
#		| DateandTimeOfSession     | 2018-06-21T14:45:00Z   |
#		| VenuePostCode            | NN1 2NN                |
		Given I post an ActionPlan with the following details:
		| field                          | value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		Then there should be a 201 response
		And there should be a record in the ActionPlans ChangeFeed table
		And there should be a record in the ActionPlans-history ChangeFeed table

@actionplans
	Scenario: Post ActionPlan with missing DateActionPlanCreated
		Given I post an ActionPlan with the following details:
		| field                          | value                |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		Then there should be a 422 response

@actionplans
	Scenario: Post ActionPlan with invalid DateActionPlanCreated
		Given I post an ActionPlan with the following details:
		| field                          | value                |
		| DateActionPlanCreated          | 2058-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		Then there should be a 422 response

@actionplans
	Scenario: Post ActionPlan with DateActionPlanCreated earlier than Session.DateandTimeOfSession
		Given I post an ActionPlan with the following details:
		| field                          | value                |
		| DateActionPlanCreated          | 2017-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		Then there should be a 422 response

@actionplans @ignore
Scenario: Post ActionPlan with DateAndTimeCharterShown earlier than DateActionPlanCreated
		Given I post an ActionPlan with the following details:
		| field                          | value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-29T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		Then there should be a 422 response

@actionplans
	Scenario: Post ActionPlan with DateActionPlanSentToCustomer earlier than DateActionPlanCreated
		Given I post an ActionPlan with the following details:
		| field                          | value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-29T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		Then there should be a 422 response

@actionplans
	Scenario: Post ActionPlan with DateActionPlanAcknowledged earlier than DateActionPlanCreated
		Given I post an ActionPlan with the following details:
		| field                          | value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-29T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		Then there should be a 422 response

@actionplans
	Scenario: Post ActionPlan with missing CustomerCharterShownToCustomer
		Given I post an ActionPlan with the following details:
		| field                          | value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		Then there should be a 422 response

@actionplans
	Scenario: Post ActionPlan with invalid CustomerCharterShownToCustomer
		Given I post an ActionPlan with the following details:
		| field                          | value                |
		| DateActionPlanCreated          | 2058-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | 3                    |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		Then there should be a 422 response


