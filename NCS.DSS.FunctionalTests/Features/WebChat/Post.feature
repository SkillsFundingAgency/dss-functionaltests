Feature: WebChatPost

Background: Prepare test
	Given I post a Customer with the following details:
		| Field      | Value    |
		| GivenName  | Bob      |
		| FamilyName | Customer |
	And I post an Interaction with the following details:
		| Field                    | Value                |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z |
		| Channel                  | 2                    |
		| InteractionType          | 2                    |
		| LastModifiedDate         | 2018-06-22T16:52:10Z |

@webchats @smoke
Scenario: Create a webchat with all valid values
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
	And the response body should contain:
		| Field                      | Value                |
		| DigitalReference           | abc1234              |
		| WebChatStartDateandTime    | 2018-07-20T13:20:00Z |
		| WebChatEndDateandTime      | 2018-07-20T13:45:00Z |
		| WebChatDuration            | 00:25:00             |
		| WebChatNarrative           | some text here       |
		| SentToCustomer             | true                 |
		| DateandTimeSentToCustomers | 2018-07-20T13:45:00Z |
	And there should be a record in the dss-webchats table with WebchatId

#And there should be a record in the WebChats-history ChangeFeed table
@webchats
Scenario: Create a webchat supplying lastmodifieddate
	Given I post a webchat with the following details:
		| Field                      | Value                |
		| DigitalReference           | abc1234              |
		| WebChatStartDateandTime    | 2018-07-20T13:20:00Z |
		| WebChatEndDateandTime      | 2018-07-20T13:45:00Z |
		| WebChatDuration            | 00:25:00             |
		| WebChatNarrative           | some text here       |
		| SentToCustomer             | true                 |
		| DateandTimeSentToCustomers | 2018-07-20T13:45:00Z |
		| lastmodifieddate           | 2018-07-19T12:45:00Z |
	Then there should be a 201 response
	And the response body should contain:
		| Field                      | Value                |
		| DigitalReference           | abc1234              |
		| WebChatStartDateandTime    | 2018-07-20T13:20:00Z |
		| WebChatEndDateandTime      | 2018-07-20T13:45:00Z |
		| WebChatDuration            | 00:25:00             |
		| WebChatNarrative           | some text here       |
		| SentToCustomer             | true                 |
		| DateandTimeSentToCustomers | 2018-07-20T13:45:00Z |
		| LastModifiedDate           | 2018-07-19T12:45:00Z |
	And there should be a record in the dss-webchats table with WebchatId

#And there should be a record in the WebChats-history ChangeFeed table
@webchats
Scenario: Create a webchat with only mandatory values
	Given I post a webchat with the following details:
		| Field                   | Value                |
		| WebChatStartDateandTime | 2018-07-20T13:20:00Z |
		| WebChatEndDateandTime   | 2018-07-20T13:45:00Z |
		| WebChatNarrative        | some text here       |
	Then there should be a 201 response
	And the response body should contain:
		| Field                   | Value                |
		| WebChatStartDateandTime | 2018-07-20T13:20:00Z |
		| WebChatEndDateandTime   | 2018-07-20T13:45:00Z |
		| WebChatNarrative        | some text here       |
	And there should be a record in the dss-webchats table with WebchatId
#And there should be a record in the WebChats-history ChangeFeed table