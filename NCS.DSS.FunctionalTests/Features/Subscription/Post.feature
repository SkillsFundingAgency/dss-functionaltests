Feature: SubscriptionPost

#	A touchpoint may subscribe to an existing customer.
#	Any updates or new resources to that customer will result in a notification to the subscribing touchpoint
#
Background: Prepare test
	Given I post an adviser with the following details V2:
		| Field                | Value         |
		| AdviserName          | BillyAdviser  |
		| AdviserContactNumber | 9879867896796 |
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
		| field                | value                |
		| DateandTimeOfSession | 2018-06-21T14:45:00Z |
		| VenuePostCode        | NN1 2NN              |
		| SessionAttended      | true                 |

@subscriptions @smoke
Scenario: Create a subscription with all valid values
	Given I post a subscription with the following details:
		| Field        | Value      |
		| TouchPointId | 9111111111 |
		| Subscribe    | true       |
	Then there should be a 201 response
	And the response body should contain:
		| Field        | Value      |
		| TouchPointId | 9111111111 |
		| Subscribe    | true       |
#And the response body should contain:
#	| Subscribe  | true  |
#And there should be a record in the subscriptions ChangeFeed table
#And there should be a record in the subscriptions-history ChangeFeed table
#And when I post an Address with the following details:
#	| Field                | Value                |
#	| Address1             | 1                    |
#	| PostCode             | NW11WN               |
#Then a new notification should be received for "Address"