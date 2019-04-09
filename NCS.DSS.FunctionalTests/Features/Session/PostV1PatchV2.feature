
@postV1 @patchV2


Feature: PostV1PatchV2


	Background: Create Adviser and Customer and Interaction
	Given I post an adviser with the following details:
		| Field						 | Value			  |
		| AdviserName				 | BillyAdviser		  |
		| AdviserContactNumber		 | 9879867896796	  |
	And I post a Customer with the following details:
		| Field                      | Value              |
		| GivenName                  | Bob                |
		| FamilyName                 | Customer           |
	And I post an Interaction with the following details:
		| Field                    | Value                |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z |
		| Channel                  | 2                    |
		| InteractionType          | 2                    |
		| LastModifiedDate         | 2018-06-22T16:52:10Z |



	Scenario: Patch DateandTimeOfSession
		Given I post a session with the following details:
	    | field                    | value                          |
		| DateandTimeOfSession     | 2018-06-21T14:45:00Z           |
		| VenuePostCode            |NN1 2NN                         |
		| SessionAttended          |true                            |
		When I patch the following:
		| Field                    | Value                          |
		| DateandTimeOfSession     | 2018-06-22T14:45:00Z           |
		Then the response body should contain:
		| Field                    | Value                          |
		| DateandTimeOfSession     | 2018-06-22T14:45:00Z           |
		| VenuePostCode            | NN1 2NN                        |
		| SessionAttended          | true                           |


	@subcontractorId
	Scenario: Patch DateandTimeOfSession with SubcontractorId
		Given I post a session with the following details:
	    | field                    | value                          |
		| DateandTimeOfSession     | 2018-06-21T14:45:00Z           |
		| VenuePostCode            |NN1 2NN                         |
		| SessionAttended          |true                            |
		When I patch the following:
		| Field                    | Value                          |
		| DateandTimeOfSession     | 2018-06-22T14:45:00Z           |
		Then the response body should contain:
		| Field                    | Value                          |
		| DateandTimeOfSession     | 2018-06-22T14:45:00Z           |
		| VenuePostCode            | NN1 2NN                        |
		| SessionAttended          | true                           |
		And the response body should contain the SubContractorId
	Scenario: Patch VenuePostCode
		Given I post a session with the following details:
	    | field                    | value                          |
		| DateandTimeOfSession     | 2018-06-21T14:45:00Z           |
		| VenuePostCode            | NN1 2NN                        |
		| SessionAttended          | true                           |
		When I patch the following:
		| Field                    | Value                          |
		| VenuePostCode            | NN1 2NQ                        |
		Then there should be a 200 response
		And the response body should contain:
		| Field                    | Value                          |
		| DateandTimeOfSession     | 2018-06-21T14:45:00Z           |
		| VenuePostCode            | NN1 2NQ                        |
		| SessionAttended          | true                           |


	Scenario: Patch SessionAttended
		Given I post a session with the following details:
	    | field                    | value                          |
		| DateandTimeOfSession     | 2018-06-21T14:45:00Z           |
		| VenuePostCode            | NN1 2NN                        |
		| SessionAttended          | true                           |
		When I patch the following:
		| Field                    | Value                          |
		| SessionAttended          | false                          |
		Then there should be a 200 response
		And the response body should contain:
		| Field                | Value                |
		| DateandTimeOfSession | 2018-06-21T14:45:00Z |
		| VenuePostCode        | NN1 2NN              |
		| SessionAttended      | false                |  
