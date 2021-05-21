Feature: SubscriptionGet

Background: Prepare test
	Given I post a Customer with the following details V3:
		| Field          | Value    |
		| GivenName      | Bobby    |
		| FamilyName     | SubPatch |
		| PriorityGroups | 1,3      |
	And I post a subscription with the following details:
		| Field        | Value      |
		| TouchPointId | 9111111111 |
		| Subscribe    | true       |

@subscriptions @smoke
Scenario: Get a Subscription by ID
	When I get a Subscription by ID
	Then there should be a 200 response
	And the response body should contain:
		| Field        | Value      |
		| TouchPointId | 9111111111 |
		| Subscribe    | true       |