
@postV3 @patchV3

Feature: PatchV3




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

@outcomes @smoke	@Cat1
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
		And the response body should not contain the "CreatedBy"
		And there should be a record in the outcomes ChangeFeed table
		And there should be a record in the outcomes-history ChangeFeed table

@outcomes	@Cat1
	Scenario: Valid Patch remove value for OutcomeClaimedDate
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-08-20T21:45:00Z |
	    | OutcomeClaimedDate   | 2018-08-20T21:45:00Z |
	    | ClaimedPriorityGroup | 5                    |
		When I patch the following via a different touchpoint
		| Field                | Value                |
		| OutcomeClaimedDate   |                      |
		Then there should be a 200 response
		And the response body should not contain the "CreatedBy"
		And the response body should have different LastUpdatedBy
		And the response body should contain:
         | Field                | Value                |
         | OutcomeEffectiveDate | 2018-08-20T21:45:00Z |
         | OutcomeType          | 3                    |
         | OutcomeClaimedDate   |                      |
         | ClaimedPriorityGroup | 5                    |
		And there should be a record in the outcomes ChangeFeed table
		And there should be a record in the outcomes-history ChangeFeed table

@outcomes
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
		And there should be a record in the outcomes ChangeFeed table
		And there should be a record in the outcomes-history ChangeFeed table

@outcomes
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
		And there should be a record in the outcomes ChangeFeed table
		And there should be a record in the outcomes-history ChangeFeed table

@outcomes
	Scenario: Patch OutcomeClaimedDate without ClaimedPriorityGroup
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
		When I patch the following:
		| Field                | Value				  |
	    | OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
		Then there should be a 422 response

@outcomes
	Scenario: Patch invalid OutcomeType
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
		When I patch the following:
		| Field                | Value				  |
	    | OutcomeType          | 7                    |
		Then there should be a 422 response



@outcomes
	Scenario:  Patch Outcome effective date earlier than Session.DateandTimeOfSession
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
		When I patch the following:
		| Field                | Value                |
		| OutcomeEffectiveDate | 2017-07-20T21:45:00Z |
		Then there should be a 422 response

@outcomes
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

@outcomes
	Scenario: Patch Outcome effective date greater than Session.DateandTimeOfSession + 12 months
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 1                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
		When I patch the following:
		| Field                | Value                |
	    | OutcomeEffectiveDate | 2019-01-22T22:45:00Z |
		Then there should be a 422 response

@outcomes
	Scenario: Patch Outcome effective date greater than Session.DateandTimeOfSession + 13 months
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
		When I patch the following:
		| Field                | Value                |
	    | OutcomeEffectiveDate | 2019-02-22T22:45:00Z |
		Then there should be a 422 response


### NEW TEST FOR SDD-4 Allow the removal of Outcome Claimed Date for duplicate Customers

#######################
## Termination Reasons
#######################
#1 - Customer choice
#2 - Deceased
#3 - Duplicate
#99 - Other
#######################


@outcomes
	Scenario: Customer is terminated with reason 1 - Customer Choice, patch to Outcome is received
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
	    | OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
	    | ClaimedPriorityGroup | 99                   |
		When I patch "Customers" with the following details:
		 | Field                | Value                |
		 | DateOfTermination    | 2018-07-20T21:45:00Z |
		 | ReasonForTermination | 1                    |
		And I patch the following:
		 | Field                | Value |
		 | OutcomeEffectiveDate |       |
		 | OutcomeClaimedDate   |       |
		Then there should be a 403 response

@outcomes
	Scenario: Customer is terminated with reason 2 - Deceased, patch to Outcome is received
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
	    | OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
	    | ClaimedPriorityGroup | 99                   |
		When I patch "Customers" with the following details:
		 | Field                | Value                |
		 | DateOfTermination    | 2018-07-20T21:45:00Z |
		 | ReasonForTermination | 2                    |
		And I patch the following:
		 | Field                | Value |
		 | OutcomeEffectiveDate |       |
		 | OutcomeClaimedDate   |       |
		Then there should be a 403 response

@outcomes
	Scenario: Customer is terminated with reason 99 - Other, patch to  Claimed date and Effective date is received
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
	    | OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
	    | ClaimedPriorityGroup | 99                   |
		When I patch "Customers" with the following details:
		 | Field                | Value                |
		 | DateOfTermination    | 2018-07-20T21:45:00Z |
		 | ReasonForTermination | 99                    |
		And I patch the following:
		 | Field                | Value |
		 | OutcomeEffectiveDate |       |
		 | OutcomeClaimedDate   |       |
		Then there should be a 403 response

@outcomes
	Scenario: Customer is terminated with reason 3 - Duplicate, patch to Claimed date and Effective date is received
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
	    | OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
	    | ClaimedPriorityGroup | 99                   |
		When I patch "Customers" with the following details:
		 | Field                | Value                |
		 | DateOfTermination    | 2018-07-20T21:45:00Z |
		 | ReasonForTermination | 3                    |
		And I patch the following:
		 | Field                | Value |
		 | OutcomeEffectiveDate |       |
		 | OutcomeClaimedDate   |       |
		Then there should be a 200 response
		And the response body should contain:
         | Field                | Value |
         | OutcomeType          | 3     |
         | OutcomeClaimedDate   |       |
         | OutcomeEffectiveDate |       |
		And there should be a record in the outcomes ChangeFeed table
		And there should be a record in the outcomes-history ChangeFeed table

@outcomes
	Scenario: Customer is terminated with reason 3 - Duplicate, patch to Claimed date is received
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
	    | OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
	    | ClaimedPriorityGroup | 99                   |
		When I patch "Customers" with the following details:
		 | Field                | Value                |
		 | DateOfTermination    | 2018-07-20T21:45:00Z |
		 | ReasonForTermination | 3                    |
		And I patch the following:
		 | Field                | Value |
		 | OutcomeClaimedDate   |       |
		Then there should be a 200 response
		And the response body should contain:
         | Field                | Value |
         | OutcomeType          | 3     |
         | OutcomeClaimedDate   |       |
		And there should be a record in the outcomes ChangeFeed table
		And there should be a record in the outcomes-history ChangeFeed table

@outcomes
	Scenario: Customer is terminated with reason 3 - Duplicate, patch to Effective date is received
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
	    | OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
	    | ClaimedPriorityGroup | 99                   |
		When I patch "Customers" with the following details:
		 | Field                | Value                |
		 | DateOfTermination    | 2018-07-20T21:45:00Z |
		 | ReasonForTermination | 3                    |
		And I patch the following:
		 | Field                | Value |
		 | OutcomeEffectiveDate |       |
		Then there should be a 422 response

@outcomes		
	Scenario: Customer is terminated with reason 3 - Duplicate, patch to ClaimedPriorityGroup is received
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
	    | OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
	    | ClaimedPriorityGroup | 99                   |
		When I patch "Customers" with the following details:
		 | Field                | Value                |
		 | DateOfTermination    | 2018-07-20T21:45:00Z |
		 | ReasonForTermination | 3                    |
		And I patch the following:
		 | Field                | Value |
		 | ClaimedPriorityGroup |   1    |
		Then there should be a 403 response
		And the error message should be "Duplicate Customer: This resource is read only. You may only remove values for Outcome Claimed and Effective date"
       
@outcomes
		Scenario: Customer is terminated with reason 3 - Duplicate, patch to OutcomeType is received
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
	    | OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
	    | ClaimedPriorityGroup | 99                   |
		When I patch "Customers" with the following details:
		 | Field                | Value                |
		 | DateOfTermination    | 2018-07-20T21:45:00Z |
		 | ReasonForTermination | 3                    |
		And I patch the following:
		 | Field       | Value |
		 | OutcomeType | 1     |
		Then there should be a 403 response
		And the error message should be "Duplicate Customer: This resource is read only. You may only remove values for Outcome Claimed and Effective date"
       
@outcomes
		Scenario: Customer is terminated with reason 3 - Duplicate, patch Dates and invalid element: OutcomeType is received
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
	    | OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
	    | ClaimedPriorityGroup | 99                   |
		When I patch "Customers" with the following details:
		 | Field                | Value                |
		 | DateOfTermination    | 2018-07-20T21:45:00Z |
		 | ReasonForTermination | 3                    |
		And I patch the following:
		 | Field                | Value |
		 | OutcomeType          | 1     |
		 | OutcomeEffectiveDate |       |
		 | OutcomeClaimedDate   |       |
		Then there should be a 403 response
		And the error message should be "Duplicate Customer: This resource is read only. You may only remove values for Outcome Claimed and Effective date"
        
@outcomes		
		Scenario: Customer is terminated with reason 3 - Duplicate, patch Dates and invalid element: ClaimedPriorityGroup is received
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
	    | OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
	    | ClaimedPriorityGroup | 99                   |
		When I patch "Customers" with the following details:
		 | Field                | Value                |
		 | DateOfTermination    | 2018-07-20T21:45:00Z |
		 | ReasonForTermination | 3                    |
		And I patch the following:
		 | Field                | Value |
		 | ClaimedPriorityGroup | 1     |
		 | OutcomeEffectiveDate |       |
		 | OutcomeClaimedDate   |       |
		Then there should be a 403 response
		And the error message should be "Duplicate Customer: This resource is read only. You may only remove values for Outcome Claimed and Effective date"

@outcomes       
		Scenario: Customer is terminated with reason 3 - Duplicate, patch Dates and invalid element: LastModifiedDate is received
		Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
	    | OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
	    | ClaimedPriorityGroup | 99                   |
		When I patch "Customers" with the following details:
		 | Field                | Value                |
		 | DateOfTermination    | 2018-07-20T21:45:00Z |
		 | ReasonForTermination | 3                    |
		And I patch the following:
		 | Field                | Value                |
		 | LastModifiedDate     | 2018-07-20T21:45:00Z |
		 | OutcomeEffectiveDate |                      |
		 | OutcomeClaimedDate   |                      |
		Then there should be a 403 response
		And the error message should be "Duplicate Customer: This resource is read only. You may only remove values for Outcome Claimed and Effective date"

@outcomes       
	   Scenario: Patch to outcome received from another touchpoint

	   	Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
	    | OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
	    | ClaimedPriorityGroup | 99                   |
	    | TouchpointId         | 1234567890           |
		When I patch the following via a different touchpoint
		 | Field              | Value      |
		 | OutcomeClaimedDate |            |
		Then there should be a 200 response
		And the response body should contain:
         | Field                    | Value      |
         | OutcomeType              | 3          |
         | OutcomeClaimedDate       |            |
         | TouchpointId             | 9000000001 |
         | LastModifiedTouchpointId | 9111111111 |
		And there should be a record in the outcomes ChangeFeed table
		And there should be a record in the outcomes-history ChangeFeed table

@outcomes
	   Scenario:  TouchpointId is patched to a new value in requeset body

	   	Given I post an outcome with the following details:
	    | Field                | Value                |
	    | OutcomeType          | 3                    |
	    | OutcomeEffectiveDate | 2018-07-20T21:45:00Z |
	    | OutcomeClaimedDate   | 2018-07-20T21:45:00Z |
	    | ClaimedPriorityGroup | 99                   |
	    When I patch the following:
		 | Field        | Value      |
		 | TouchpointId | 1234567890 |
		Then there should be a 200 response
		And the response body should contain:
         | Field                    | Value                |
         | OutcomeType              | 3                    |
         | OutcomeEffectiveDate     | 2018-07-20T21:45:00Z |
         | OutcomeClaimedDate       | 2018-07-20T21:45:00Z |
         | ClaimedPriorityGroup     | 99                   |
         | TouchpointId             | 1234567890           |
         | LastModifiedTouchpointId | 9000000001           |
		And there should be a record in the outcomes ChangeFeed table
		And there should be a record in the outcomes-history ChangeFeed table