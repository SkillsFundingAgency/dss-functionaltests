﻿
@postV2

Feature: PostV3


	Background: Create Adviser and Customer and Interaction
		Given I post an adviser with the following details:
			| Field						 | Value				|
			| AdviserName				 | BillyAdviser			|
			| AdviserContactNumber		 | 98798678967967		|
		And I post a Customer with the following details:
			| Field                      | Value                |
			| GivenName                  | Bob                  |
			| FamilyName                 | Customer             |
		And I post an Interaction with the following details:
			| Field                    | Value                                |
			| DateandTimeOfInteraction | 2018-06-25T11:21:00Z                 |
			| Channel                  | 2                                    |
			| InteractionType          | 2                                    |
			| LastModifiedDate         | 2018-06-22T16:52:10Z                 |





@sessions @postV3
	Scenario: Create a Session for existing customer with all valid Values
		Given I post a session with the following details:
		| Field                    | Value                          |
		| DateandTimeOfSession     | 2018-06-21T14:45:00Z           |
		| VenuePostCode            |NN1 2NN                         |
		Then there should be a 201 response
		And the response body should contain:
		| Field                  | Value                |
		| DateandTimeOfSession   | 2018-06-21T14:45:00Z |
		| VenuePostCode          | NN1 2NN              |
		| SessionAttended        | null                 |
		| ReasonForNonAttendance | 99                   |

@sessions
	Scenario: Change feed for Post Session
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
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z	|
		| Channel                  | 2                      |
		| InteractionType          | 2                      |
		| LastModifiedDate         | 2018-06-22T16:52:10Z   |
		And I post a session with the following details:
		| Field                    | Value                  |
		| DateandTimeOfSession     | 2018-06-21T14:45:00Z   |
		| VenuePostCode            | NN1 2NN                |
		Then there should be a 201 response
		And there should be a record in the sessions ChangeFeed table
		And there should be a record in the sessions-history ChangeFeed table

@sessions
	Scenario: Create a Session for existing customer with incorrect format for date and time of session
		Given I post a session with the following details:
		| Field                | Value       |
		| DateandTimeOfSession | 21-065-2012 |
		| VenuePostCode        | NN1 2NN     |
		Then there should be a 422 response

@sessions
	Scenario: Create a Session for existing customer with incorrect format for venue post code
		Given I post a session with the following details:
		| Field                    | Value                          |
		| DateandTimeOfSession     | 21-06-2018                     |
		| VenuePostCode            |NN1                             |
		Then there should be a 422 response