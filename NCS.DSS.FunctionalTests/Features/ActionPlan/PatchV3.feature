﻿Feature: ActionPlanPatchV3

Background: Post
	Given I post an adviser with the following details V2:
		| Field                | Value          |
		| AdviserName          | BillyAdviser   |
		| AdviserContactNumber | 98798678967967 |
	Given I post a Customer with the following details V3:
		| Field          | Value    |
		| GivenName      | Bob      |
		| FamilyName     | Customer |
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

@actionplans @smoke
Scenario: Patch Valid CustomerCharterShownToCustomer
	Given I post an ActionPlan with the following details V3:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | false                |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
	When I patch the following ActionPlan V3:
		| Field                          | Value |
		| CustomerCharterShownToCustomer | true  |
	Then there should be a 200 response
	And the response body should contain:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| CurrentSituation               | looking for work     |
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-actionplans table with ActionPlanId

#And there should be a record in the ActionPlans ChangeFeed table
#And there should be a record in the ActionPlans-history ChangeFeed table
#@actionplans
#Scenario: Patch Valid DateAndTimeCharterShown
#	Given I post an ActionPlan with the following details:
#		| Field                          | Value                |
#		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
#		| CustomerCharterShownToCustomer | true                 |
#		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
#		| ActionPlanDeliveryMethod       | 1                    |
#		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
#		| PriorityCustomer               | 1                    |
#		| CurrentSituation               | looking for work     |
#	When I patch the following via a different touchpoint
#		| Field                   | Value                |
#		| DateAndTimeCharterShown | 2018-07-30T09:00:00Z |
#	Then there should be a 200 response
#	And the response body should contain:
#		| Field                          | Value                |
#		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
#		| CustomerCharterShownToCustomer | true                 |
#		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
#		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
#		| ActionPlanDeliveryMethod       | 1                    |
#		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
#		| PriorityCustomer               | 1                    |
#		| CurrentSituation               | looking for work     |
#	And the response body should not contain the "CreatedBy"
#	And the response body should have different LastUpdatedBy
#	And there should be a record in the ActionPlans ChangeFeed table
#	And there should be a record in the ActionPlans-history ChangeFeed table
@actionplans
Scenario: Patch Valid DateActionPlanCreated
	Given I post an ActionPlan with the following details V3:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-29T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
	When I patch the following ActionPlan V3:
		| Field                 | Value                |
		| DateActionPlanCreated | 2018-07-30T09:00:00Z |
	Then there should be a 200 response
	And the response body should contain:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| CurrentSituation               | looking for work     |

@actionplans
Scenario: Patch Valid DateActionPlanSentToCustomer
	Given I post an ActionPlan with the following details V3:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
	When I patch the following ActionPlan V3:
		| Field                        | Value                |
		| DateActionPlanSentToCustomer | 2018-07-31T09:00:00Z |
	Then there should be a 200 response
	And the response body should contain:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-31T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| CurrentSituation               | looking for work     |

@actionplans
Scenario: Patch Valid DateActionPlanAcknowledged
	Given I post an ActionPlan with the following details V3:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
	When I patch the following ActionPlan V3:
		| Field                      | Value                |
		| DateActionPlanAcknowledged | 2018-07-31T09:00:00Z |
	Then there should be a 200 response
	And the response body should contain:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-31T09:00:00Z |
		| CurrentSituation               | looking for work     |

@actionplans
Scenario: Patch Valid ActionPlanDeliveryMethod
	Given I post an ActionPlan with the following details V3:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
	When I patch the following ActionPlan V3:
		| Field                    | Value |
		| ActionPlanDeliveryMethod | 2     |
	Then there should be a 200 response
	And the response body should contain:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 2                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| CurrentSituation               | looking for work     |

@actionplans
Scenario: Patch Valid PriorityCustomer
	Given I post an ActionPlan with the following details V3:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
	When I patch the following ActionPlan V3:
		| Field            | Value |
		| PriorityCustomer | 2     |
	Then there should be a 200 response
	And the response body should contain:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| CurrentSituation               | looking for work     |

@actionplans
Scenario: Patch Valid CurrentSituation
	Given I post an ActionPlan with the following details V3:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| CurrentSituation               | looking for work     |
	When I patch the following ActionPlan V3:
		| Field            | Value         |
		| CurrentSituation | still looking |
	Then there should be a 200 response
	And the response body should contain:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| CurrentSituation               | still looking        |

@actionplans
@subcontractorId
Scenario: Patch with SubcontractorId
	Given I post an ActionPlan with the following details V3:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
	When I patch the following ActionPlan V3:
		| Field            | Value         |
		| CurrentSituation | still looking |
	Then there should be a 200 response
	And the response body should contain:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| CurrentSituation               | still looking        |
	And the response body should contain the SubContractorId

@actionplans
Scenario: Patch invalid DateActionPlanCreated
	Given I post an ActionPlan with the following details V3:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-29T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
	When I patch the following ActionPlan V3:
		| Field                 | Value                |
		| DateActionPlanCreated | 2018-07-31T09:00:00Z |
	Then there should be a 422 response

@actionplans
Scenario: Patch invalid CustomerCharterShownToCustomer
	Given I post an ActionPlan with the following details V3:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
	When I patch the following ActionPlan V3:
		| Field                          | Value |
		| CustomerCharterShownToCustomer | 1     |
	Then there should be a 422 response

@actionplans
# THIS RULE HAS BEEN RELAXED (CDS-1511-RemoveValidationForDateAndTimeCharterShown-v2
# So changed expected outcome from 422 to 200
Scenario: Patch invalid DateAndTimeCharterShown
	Given I post an ActionPlan with the following details V3:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
	When I patch the following ActionPlan V3:
		| Field                   | Value                |
		| DateAndTimeCharterShown | 2018-07-29T09:00:00Z |
	Then there should be a 200 response

@actionplans
Scenario: Patch invalid DateActionPlanSentToCustomer
	Given I post an ActionPlan with the following details V3:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
	When I patch the following ActionPlan V3:
		| Field                        | Value                |
		| DateActionPlanSentToCustomer | 2018-07-29T09:00:00Z |
	Then there should be a 422 response

@actionplans
Scenario: Patch invalid DateActionPlanAcknowledged
	Given I post an ActionPlan with the following details V3:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
	When I patch the following ActionPlan V3:
		| Field                      | Value                |
		| DateActionPlanAcknowledged | 2018-07-29T09:00:00Z |
	Then there should be a 422 response

@actionplans
Scenario: Patch invalid ActionPlanDeliveryMethod
	Given I post an ActionPlan with the following details V3:
		| Field                          | Value                |
		| DateActionPlanCreated          | 2018-07-30T09:00:00Z |
		| CustomerCharterShownToCustomer | true                 |
		| DateAndTimeCharterShown        | 2018-07-30T09:00:00Z |
		| DateActionPlanSentToCustomer   | 2018-07-30T09:00:00Z |
		| ActionPlanDeliveryMethod       | 1                    |
		| DateActionPlanAcknowledged     | 2018-07-30T09:00:00Z |
		| PriorityCustomer               | 1                    |
		| CurrentSituation               | looking for work     |
	When I patch the following ActionPlan V3:
		| Field                      | Value                |
		| DateActionPlanAcknowledged | 2018-07-29T09:00:00Z |
	Then there should be a 422 response