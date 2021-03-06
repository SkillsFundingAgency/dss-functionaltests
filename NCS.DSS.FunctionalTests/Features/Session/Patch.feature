﻿Feature: SessionPatchV1

Background: Create Adviser and Customer and Interaction
	Given I post an adviser with the following details:
		| Field                | Value          |
		| AdviserName          | BillyAdviser   |
		| AdviserContactNumber | 98798678967967 |
	Then there should be a 201 response
	Given I post a Customer with the following details:
		| Field      | Value    |
		| GivenName  | Bob      |
		| FamilyName | Customer |
	Then there should be a 201 response
	Given I post an Interaction with the following details:
		| Field                    | Value                |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z |
		| Channel                  | 2                    |
		| InteractionType          | 2                    |
		| LastModifiedDate         | 2018-06-22T16:52:10Z |

@sessions @smoke
Scenario: Patch DateandTimeOfSession
	Given I post a session with the following details:
		| field                | value                |
		| DateandTimeOfSession | 2018-06-21T14:45:00Z |
		| VenuePostCode        | NN1 2NN              |
		| SessionAttended      | true                 |
	Then there should be a 201 response
	When I patch the following Session:
		| Field                | Value                |
		| DateandTimeOfSession | 2018-06-22T14:45:00Z |
	Then there should be a 200 response
	And the response body should contain:
		| Field                | Value                |
		| DateandTimeOfSession | 2018-06-22T14:45:00Z |
		| VenuePostCode        | NN1 2NN              |
		| SessionAttended      | true                 |
	Given I wait for 5 Seconds
	Then there should be a record in the dss-sessions table with SessionId

#And there should be 2 records in the dss-sessions-history table with SessionId
@sessions
Scenario: Patch VenuePostCode
	Given I post a session with the following details:
		| field                | value                |
		| DateandTimeOfSession | 2018-06-21T14:45:00Z |
		| VenuePostCode        | NN1 2NN              |
		| SessionAttended      | true                 |
	Then there should be a 201 response
	When I patch the following Session:
		| Field         | Value   |
		| VenuePostCode | NN1 2NQ |
	Then there should be a 200 response
	And the response body should contain:
		| Field                | Value                |
		| DateandTimeOfSession | 2018-06-21T14:45:00Z |
		| VenuePostCode        | NN1 2NQ              |
		| SessionAttended      | true                 |

@sessions
Scenario: Patch SessionAttended
	Given I post a session with the following details:
		| field                | value                |
		| DateandTimeOfSession | 2018-06-21T14:45:00Z |
		| VenuePostCode        | NN1 2NN              |
		| SessionAttended      | true                 |
	Then there should be a 201 response
	When I patch the following Session:
		| Field           | Value |
		| SessionAttended | false |
	Then there should be a 200 response
	And the response body should contain:
		| Field                | Value                |
		| DateandTimeOfSession | 2018-06-21T14:45:00Z |
		| VenuePostCode        | NN1 2NN              |
		| SessionAttended      | false                |