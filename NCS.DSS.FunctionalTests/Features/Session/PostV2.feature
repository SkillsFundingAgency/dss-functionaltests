﻿Feature: SessionPostV2

Background: Create Adviser and Customer and Interaction
	Given I post an adviser with the following details V2:
		| Field                | Value          |
		| AdviserName          | BillyAdviser   |
		| AdviserContactNumber | 98798678967967 |
	And I post a Customer with the following details V3:
		| Field      | Value    |
		| GivenName  | Bob      |
		| FamilyName | Customer |
		| PriorityGroups | 1,3      |
	And I post an Interaction with the following details:
		| Field                    | Value                |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z |
		| Channel                  | 2                    |
		| InteractionType          | 2                    |
		| LastModifiedDate         | 2018-06-22T16:52:10Z |

@sessions  @Ignore
Scenario: Create a Session for with venue postcode that reports wrong location when Country paraneters is not passed to geocoding
	Given I post a session with the following details V2:
		| Field                | Value                |
		| DateandTimeOfSession | 2018-06-21T14:45:00Z |
		| VenuePostCode        | S46 8SE              |
	Then there should be a 201 response
	#And the "sessions" cosmos document should include CreatedBy
	#And the "sessions" cosmos document should include "Longitude" with value "-1.43018"
	#And the "sessions" cosmos document should include "Latitude" with value "53.25289"
	And the response body should contain:
		| Field                  | Value                |
		| DateandTimeOfSession   | 2018-06-21T14:45:00Z |
		| VenuePostCode          | S46 8SE              |
		| SessionAttended        |                      |
		| ReasonForNonAttendance | 99                   |
	And the response body should not contain the "CreatedBy"
	And the response body should not contain the "Longitude"
	And the response body should not contain the "Latitude"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-sessions table with SessionId

#And there should be a record in the sessions ChangeFeed table
#And there should be a record in the sessions-history ChangeFeed table
@sessions @smoke
Scenario: Change feed for Post Session
	Given I post an adviser with the following details V2:
		| Field                | Value          |
		| AdviserName          | BillyAdviser   |
		| AdviserContactNumber | 98798678967967 |
	And I post a Customer with the following details V3:
		| Field      | Value		|
		| GivenName  | Bob			|
		| FamilyName | Customer		|
		| PriorityGroups | 1,3      |
	And I post an Interaction with the following details:
		| Field                    | Value                |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z |
		| Channel                  | 2                    |
		| InteractionType          | 2                    |
		| LastModifiedDate         | 2018-06-22T16:52:10Z |
	Given I post a session with the following details V2:
		| Field                | Value                |
		| DateandTimeOfSession | 2018-06-21T14:45:00Z |
		| VenuePostCode        | NN1 2NN              |
	Then there should be a 201 response
	#And the "sessions" cosmos document should include CreatedBy
	#And the "sessions" cosmos document should include "Longitude" with value "-1.00181"
	#And the "sessions" cosmos document should include "Latitude" with value "52.12814"
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-sessions table with SessionId

#And the captured table data should include key "Longitude" with value "-1.00181"
#And the captured table data should include key "Latitude" with value "52.12814"
#And there should be a record in the sessions-history ChangeFeed table
#And the captured table data should include key "Longitude" with value "-1.00181"
#And the captured table data should include key "Latitude" with value "52.12814"
@sessions
Scenario: Create a Session for existing customer with incorrect format for date and time of session
	Given I post a session with the following details V2:
		| Field                | Value       |
		| DateandTimeOfSession | 21-065-2012 |
		| VenuePostCode        | NN1 2NN     |
	Then there should be a 422 response

@sessions
Scenario: Create a Session for existing customer with incorrect format for venue post code
	Given I post a session with the following details V2:
		| Field                | Value      |
		| DateandTimeOfSession | 21-06-2018 |
		| VenuePostCode        | NN76N N1     |
	Then there should be a 422 response