﻿Feature: Patch

Background: Prepare test
	Given I post a Customer with the following details V3:
		| Field          | Value    |
		| GivenName      | Bob      |
		| FamilyName     | Customer |
		| PriorityGroups | 1,3      |
	Then there should be a 201 response
	Given I post an Interaction with the following details:
		| Field                    | Value                |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z |
		| Channel                  | 2                    |
		| InteractionType          | 2                    |
		| LastModifiedDate         | 2018-06-22T16:52:10Z |
	Then there should be a 201 response

@webchats @smoke
Scenario: Patch DigitalReference
	Given I post a webchat with the following details:
		| Field                      | Value                |
		| DigitalReference           | abc1234              |
		| WebChatStartDateandTime    | 2018-07-20T13:20:00Z |
		| WebChatEndDateandTime      | 2018-07-20T13:45:00Z |
		| WebChatDuration            | 00:25:00             |
		| WebChatNarrative           | some text here       |
		| SentToCustomer             | true                 |
		| DateandTimeSentToCustomers | 2018-07-20T13:45:00Z |
	When I patch the following:
		| Field            | Value    |
		| DigitalReference | abc12345 |
	Then there should be a 200 response
	And the response body should contain:
		| Field                      | Value                |
		| DigitalReference           | abc12345             |
		| WebChatStartDateandTime    | 2018-07-20T13:20:00Z |
		| WebChatEndDateandTime      | 2018-07-20T13:45:00Z |
		| WebChatDuration            | 00:25:00             |
		| WebChatNarrative           | some text here       |
		| SentToCustomer             | true                 |
		| DateandTimeSentToCustomers | 2018-07-20T13:45:00Z |
	Given I wait for 5 Seconds
	#		And the last updated time should be later than the request time
	Then there should be a record in the dss-webchats table with WebchatId

#And there should be a record in the WebChats-history ChangeFeed table
@webchats
Scenario: Patch WebChatStartDateandTime
	# Duration in expected response data is incorrect to cater for bug CDS-1620
	Given I post a webchat with the following details:
		| Field                      | Value                |
		| DigitalReference           | abc1234              |
		| WebChatStartDateandTime    | 2018-07-20T13:20:00Z |
		| WebChatEndDateandTime      | 2018-07-20T13:45:00Z |
		| WebChatDuration            | 00:25:00             |
		| WebChatNarrative           | some text here       |
		| SentToCustomer             | true                 |
		| DateandTimeSentToCustomers | 2018-07-20T13:45:00Z |
	When I patch the following:
		| Field                   | Value                |
		| WebChatStartDateandTime | 2018-07-20T13:00:00Z |
	Then there should be a 200 response
	And the response body should contain:
		| Field                   | Value                |
		| DigitalReference        | abc1234              |
		| WebChatStartDateandTime | 2018-07-20T13:00:00Z |
		| WebChatEndDateandTime   | 2018-07-20T13:45:00Z |
		#| WebChatDuration            | 00:45:00             |
		| WebChatNarrative           | some text here       |
		| SentToCustomer             | true                 |
		| DateandTimeSentToCustomers | 2018-07-20T13:45:00Z |
	#		And the last updated time should be later than the request time
	Given I wait for 5 Seconds
	Then there should be a record in the dss-webchats table with WebchatId

#And there should be a record in the WebChats-history ChangeFeed table
@webchats
Scenario: Patch WebChatEndDateandTime
	# Duration in expected response data is incorrect to cater for bug CDS-1620
	Given I post a webchat with the following details:
		| Field                      | Value                |
		| DigitalReference           | abc1234              |
		| WebChatStartDateandTime    | 2018-07-20T13:20:00Z |
		| WebChatEndDateandTime      | 2018-07-20T13:45:00Z |
		| WebChatDuration            | 00:25:00             |
		| WebChatNarrative           | some text here       |
		| SentToCustomer             | true                 |
		| DateandTimeSentToCustomers | 2018-07-20T13:45:00Z |
	When I patch the following:
		| Field                 | Value                |
		| WebChatEndDateandTime | 2018-07-20T14:45:00Z |
	Then there should be a 200 response
	And the response body should contain:
		| Field                   | Value                |
		| DigitalReference        | abc1234              |
		| WebChatStartDateandTime | 2018-07-20T13:20:00Z |
		| WebChatEndDateandTime   | 2018-07-20T14:45:00Z |
		#| WebChatDuration            | 01:25:00             |
		| WebChatNarrative           | some text here       |
		| SentToCustomer             | true                 |
		| DateandTimeSentToCustomers | 2018-07-20T13:45:00Z |
	#And the last updated time should be later than the request time
	Given I wait for 5 Seconds
	Then there should be a record in the dss-webchats table with WebchatId

#And there should be a record in the WebChats-history ChangeFeed table
@webchats @Ignore
Scenario: Patch WebChatDuration
	Given I post a webchat with the following details:
		| Field                      | Value                |
		| DigitalReference           | abc1234              |
		| WebChatStartDateandTime    | 2018-07-20T13:20:00Z |
		| WebChatEndDateandTime      | 2018-07-20T13:45:00Z |
		| WebChatDuration            | 00:25:00             |
		| WebChatNarrative           | some text here       |
		| SentToCustomer             | true                 |
		| DateandTimeSentToCustomers | 2018-07-20T13:45:00Z |
	When I patch the following:
		| Field           | Value    |
		| WebChatDuration | 00:25:01 |
	Then there should be a 200 response
	And the response body should contain:
		| Field                      | Value                |
		| DigitalReference           | abc1234              |
		| WebChatStartDateandTime    | 2018-07-20T13:20:00Z |
		| WebChatEndDateandTime      | 2018-07-20T13:45:00Z |
		| WebChatDuration            | 00:25:01             |
		| WebChatNarrative           | some text here       |
		| SentToCustomer             | true                 |
		| DateandTimeSentToCustomers | 2018-07-20T13:45:00Z |
	#And the last updated time should be later than the request time
	Given I wait for 5 Seconds
	Then there should be a record in the dss-webchats table with WebchatId

#And there should be a record in the WebChats-history ChangeFeed table
@webchats
Scenario: Patch LastModifiedDate
	Given I post a webchat with the following details:
		| Field                      | Value                |
		| DigitalReference           | abc1234              |
		| WebChatStartDateandTime    | 2018-07-20T13:20:00Z |
		| WebChatEndDateandTime      | 2018-07-20T13:45:00Z |
		| WebChatDuration            | 00:25:00             |
		| WebChatNarrative           | some text here       |
		| SentToCustomer             | true                 |
		| DateandTimeSentToCustomers | 2018-07-20T13:45:00Z |
	When I patch the following:
		| Field            | Value                |
		| LastModifiedDate | 2018-08-21T11:45:00Z |
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
		| LastModifiedDate           | 2018-08-21T11:45:00Z |
	#		And the last updated time should be later than the request time
	Given I wait for 5 Seconds
	Then there should be a record in the dss-webchats table with WebchatId

#And there should be a record in the WebChats-history ChangeFeed table
@webchats
Scenario: Patch LastModifiedDate and WebChatEndDateandTime
	Given I post a webchat with the following details:
		| Field                      | Value                |
		| DigitalReference           | abc1234              |
		| WebChatStartDateandTime    | 2018-07-20T13:20:00Z |
		| WebChatEndDateandTime      | 2018-07-20T13:45:00Z |
		| WebChatDuration            | 00:25:00             |
		| WebChatNarrative           | some text here       |
		| SentToCustomer             | true                 |
		| DateandTimeSentToCustomers | 2018-07-20T13:45:00Z |
	When I patch the following:
		| Field                 | Value                |
		| WebChatEndDateandTime | 2018-07-20T14:45:00Z |
		| LastModifiedDate      | 2018-08-21T11:45:00Z |
	Then there should be a 200 response
	And the response body should contain:
		| Field                   | Value                |
		| DigitalReference        | abc1234              |
		| WebChatStartDateandTime | 2018-07-20T13:20:00Z |
		| WebChatEndDateandTime   | 2018-07-20T14:45:00Z |
		#| WebChatDuration            | 01:25:00             |
		| WebChatNarrative           | some text here       |
		| SentToCustomer             | true                 |
		| DateandTimeSentToCustomers | 2018-07-20T13:45:00Z |
		| LastModifiedDate           | 2018-08-21T11:45:00Z |
	#		And the last updated time should be later than the request time
	Given I wait for 5 Seconds
	Then there should be a record in the dss-webchats table with WebchatId

#And there should be a record in the WebChats-history ChangeFeed table
@webchats
Scenario: Patch WebChatNarrative
	Given I post a webchat with the following details:
		| Field                      | Value                |
		| DigitalReference           | abc1234              |
		| WebChatStartDateandTime    | 2018-07-20T13:20:00Z |
		| WebChatEndDateandTime      | 2018-07-20T13:45:00Z |
		| WebChatDuration            | 00:25:00             |
		| WebChatNarrative           | some text here       |
		| SentToCustomer             | true                 |
		| DateandTimeSentToCustomers | 2018-07-20T13:45:00Z |
	When I patch the following:
		| Field            | Value        |
		| WebChatNarrative | updated text |
	Then there should be a 200 response
	And the response body should contain:
		| Field                      | Value                |
		| DigitalReference           | abc1234              |
		| WebChatStartDateandTime    | 2018-07-20T13:20:00Z |
		| WebChatEndDateandTime      | 2018-07-20T13:45:00Z |
		| WebChatDuration            | 00:25:00             |
		| WebChatNarrative           | updated text         |
		| SentToCustomer             | true                 |
		| DateandTimeSentToCustomers | 2018-07-20T13:45:00Z |
	#	    And the last updated time should be later than the request time
	Given I wait for 5 Seconds
	Then there should be a record in the dss-webchats table with WebchatId

#And there should be a record in the WebChats-history ChangeFeed table
@webchats
Scenario: Patch SentToCustomer
	Given I post a webchat with the following details:
		| Field                      | Value                |
		| DigitalReference           | abc1234              |
		| WebChatStartDateandTime    | 2018-07-20T13:20:00Z |
		| WebChatEndDateandTime      | 2018-07-20T13:45:00Z |
		| WebChatDuration            | 00:25:00             |
		| WebChatNarrative           | some text here       |
		| SentToCustomer             | true                 |
		| DateandTimeSentToCustomers | 2018-07-20T13:45:00Z |
	When I patch the following:
		| Field          | Value |
		| SentToCustomer | false |
	Then there should be a 200 response
	And the response body should contain:
		| Field                      | Value                |
		| DigitalReference           | abc1234              |
		| WebChatStartDateandTime    | 2018-07-20T13:20:00Z |
		| WebChatEndDateandTime      | 2018-07-20T13:45:00Z |
		| WebChatDuration            | 00:25:00             |
		| WebChatNarrative           | some text here       |
		| SentToCustomer             | false                |
		| DateandTimeSentToCustomers | 2018-07-20T13:45:00Z |
	#		And the last updated time should be later than the request time
	Given I wait for 5 Seconds
	Then there should be a record in the dss-webchats table with WebchatId

#And there should be a record in the WebChats-history ChangeFeed table
@webchats
Scenario: Patch DateandTimeSentToCustomers
	Given I post a webchat with the following details:
		| Field                      | Value                |
		| DigitalReference           | abc1234              |
		| WebChatStartDateandTime    | 2018-07-20T13:20:00Z |
		| WebChatEndDateandTime      | 2018-07-20T13:45:00Z |
		| WebChatDuration            | 00:25:00             |
		| WebChatNarrative           | some text here       |
		| SentToCustomer             | true                 |
		| DateandTimeSentToCustomers | 2018-07-20T13:45:00Z |
	When I patch the following:
		| Field                      | Value                |
		| DateandTimeSentToCustomers | 2018-07-21T13:45:00Z |
	Then there should be a 200 response
	And the response body should contain:
		| Field                      | Value                |
		| DigitalReference           | abc1234              |
		| WebChatStartDateandTime    | 2018-07-20T13:20:00Z |
		| WebChatEndDateandTime      | 2018-07-20T13:45:00Z |
		| WebChatDuration            | 00:25:00             |
		| WebChatNarrative           | some text here       |
		| SentToCustomer             | true                 |
		| DateandTimeSentToCustomers | 2018-07-21T13:45:00Z |
	#		And the last updated time should be later than the request time
	Given I wait for 5 Seconds
	Then there should be a record in the dss-webchats table with WebchatId
#And there should be a record in the WebChats-history ChangeFeed table
#@webchats
#	Scenario: Patch webchat with a different touchpoint
#	Given I post a webchat with the following details:
#	    | Field                      | Value                |
#	    | DigitalReference           | abc1234              |
#	    | WebChatStartDateandTime    | 2018-07-20T13:20:00Z |
#	    | WebChatEndDateandTime      | 2018-07-20T13:45:00Z |
#	    | WebChatDuration            | 00:25:00             |
#	    | WebChatNarrative           | some text here       |
#	    | SentToCustomer             | true                 |
#	    | DateandTimeSentToCustomers | 2018-07-20T13:45:00Z |
#	When I patch the following via a different touchpoint
#		| Field                    | Value                  |
#	    | DateandTimeSentToCustomers | 2018-07-21T13:45:00Z |
#		Then there should be a 200 response
#		And the response body should contain:
#		| Field                      | Value                |
#		| DigitalReference           | abc1234              |
#	    | WebChatStartDateandTime    | 2018-07-20T13:20:00Z |
#	    | WebChatEndDateandTime      | 2018-07-20T13:45:00Z |
#	    | WebChatDuration            | 00:25:00             |
#	    | WebChatNarrative           | some text here       |
#	    | SentToCustomer             | true                 |
#	    | DateandTimeSentToCustomers | 2018-07-21T13:45:00Z |
##		And the last updated time should be later than the request time
#		And the response body should have different LastUpdatedBy
#		#And there should be a record in the WebChats ChangeFeed table
#		#And there should be a record in the WebChats-history ChangeFeed table