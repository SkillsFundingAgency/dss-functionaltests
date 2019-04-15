
@postV2 @patchV2

Feature: PatchV2


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




@actionplans
	Scenario: Patch Valid CustomerCharterShownToCustomer
		Given I post an ActionPlan with the following details:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | false                 |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		When I patch the following:
		| Field                          | Value                |
		| CustomerCharterShownToCustomer | true				    |
		Then there should be a 200 response
		And the response body should contain:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |


@actionplans	
	Scenario: Patch Valid DateAndTimeCharterShown
		Given I post an ActionPlan with the following details:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		When I patch the following:
		| Field                          | Value                |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		Then there should be a 200 response
		And the response body should contain:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |

@actionplans
	Scenario: Patch Valid DateActionPlanCreated
		Given I post an ActionPlan with the following details:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-29T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		When I patch the following:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		Then there should be a 200 response
		And the response body should contain:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |

@actionplans
	Scenario: Patch Valid DateActionPlanSentToCustomer
		Given I post an ActionPlan with the following details:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		When I patch the following:
		| Field                          | Value                |
		| DateActionPlanSentToCustomer   | 2018-07-31T09:00:00Z |
		Then there should be a 200 response
		And the response body should contain:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-31T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |

@actionplans
	Scenario: Patch Valid DateActionPlanAcknowledged
		Given I post an ActionPlan with the following details:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		When I patch the following:
		| Field                          | Value                |
		| DateActionPlanAcknowledged     | 2018-07-31T09:00:00Z |
		Then there should be a 200 response
		And the response body should contain:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-31T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |

@actionplans
	Scenario: Patch Valid ActionPlanDeliveryMethod
		Given I post an ActionPlan with the following details:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		When I patch the following:
		| Field                          | Value                |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		Then there should be a 200 response
		And the response body should contain:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |

@actionplans
	Scenario: Patch Valid PriorityCustomer
		Given I post an ActionPlan with the following details:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		When I patch the following:
		| Field                          | Value                |
		| PriorityCustomer               | 2                    |
		Then there should be a 200 response
		And the response body should contain:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 2                    |
		| CurrentSituation               | looking for work     |

@actionplans
	Scenario: Patch Valid CurrentSituation
		Given I post an ActionPlan with the following details:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		When I patch the following:
		| Field                          | Value                |
		| CurrentSituation               | still looking        |
		Then there should be a 200 response
		And the response body should contain:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | still looking        |

@actionplans
	@subcontractorId
	Scenario: Patch with SubcontractorId
		Given I post an ActionPlan with the following details:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		When I patch the following:
		| Field                          | Value                |
		| CurrentSituation               | still looking        |
		Then there should be a 200 response
		And the response body should contain:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | still looking        |
		And the response body should contain the SubContractorId

@actionplans
	Scenario: Patch invalid DateActionPlanCreated
		Given I post an ActionPlan with the following details:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-29T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		When I patch the following:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-31T09:00:00Z |
		Then there should be a 422 response

@actionplans
	Scenario: Patch invalid CustomerCharterShownToCustomer
		Given I post an ActionPlan with the following details:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | 1					|
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		When I patch the following:
		| Field                          | Value                |
		| CustomerCharterShownToCustomer | true				    |
		Then there should be a 400 response

@actionplans
	Scenario: Patch invalid DateAndTimeCharterShown
		Given I post an ActionPlan with the following details:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		When I patch the following:
		| Field                          | Value                |
		| DateAndTimeCharterShown        | 2018-07-29T09:00:00Z |
		Then there should be a 422 response

@actionplans
	Scenario: Patch invalid DateActionPlanSentToCustomer
		Given I post an ActionPlan with the following details:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		When I patch the following:
		| Field                          | Value                |
		| DateActionPlanSentToCustomer   | 2018-07-29T09:00:00Z |
		Then there should be a 422 response


@actionplans
	Scenario: Patch invalid DateActionPlanAcknowledged
		Given I post an ActionPlan with the following details:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		When I patch the following:
		| Field                          | Value                |
		| DateActionPlanAcknowledged     | 2018-07-29T09:00:00Z |
		Then there should be a 422 response

@actionplans
	Scenario: Patch invalid ActionPlanDeliveryMethod
		Given I post an ActionPlan with the following details:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		When I patch the following:
		| Field                          | Value                |
		| DateActionPlanAcknowledged     | 2018-07-29T09:00:00Z |
		Then there should be a 422 response


@actionplans
	Scenario: Patch invalid PriorityCustomer
		Given I post an ActionPlan with the following details:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
		When I patch the following:
		| Field                          | Value                |
		| PriorityCustomer               | 7                    |
		Then there should be a 422 response




