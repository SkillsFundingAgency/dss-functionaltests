﻿Feature: Get

Background: Prepare test
	Given I post a Customer with the following details V3:
		| Field          | Value    |
		| GivenName      | Bob      |
		| FamilyName     | Customer |
		| PriorityGroups | 1,3      |
	Then there should be a 201 response
	Given I post an Interaction with the following details:
		| Field                    | Value                  |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z   |
		| Channel                  | 2                      |
		| InteractionType          | 2                      |
		| LastModifiedDate         | 2018-06-22T16:52:10Z   |
	Then there should be a 201 response
	Given I post a webchat with the following details:
	    | Field                      | Value                |
	    | DigitalReference           | abc1234              |
	    | WebChatStartDateandTime    | 2018-07-20T13:20:00Z |
	    | WebChatEndDateandTime      | 2018-07-20T13:45:00Z |
	    | WebChatDuration            | 00:25:00             |
	    | WebChatNarrative           | some text here       |
	    | SentToCustomer             | true                 |
	    | DateandTimeSentToCustomers | 2018-07-20T13:45:00Z |
	Then there should be a 201 response

@webchats @smoke
	Scenario: Get a WebChat by ID
	When I get a WebChat by ID
	Then there should be a 200 response
	And the response body should contain:
	    | Field                      | Value                |
	    | DigitalReference           | abc1234              |
	    | WebChatStartDateandTime    | 2018-07-20T13:20:00Z |
	    | WebChatEndDateandTime      | 2018-07-20T13:45:00Z |
	    | WebChatDuration            | 00:25:00             |
	    | WebChatNarrative           | some text here       |
	    | SentToCustomer             | true                 |
	    | DateandTimeSentToCustomers | 2018-07-20T13:45:00Z |