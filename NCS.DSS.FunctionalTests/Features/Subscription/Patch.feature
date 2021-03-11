Feature: SubscriptionPatch

Background: Prepare test
	Given I post a Customer with the following details:
		| Field                      | Value              |
		| GivenName                  | Bobby              |
		| FamilyName                 | SubPatch           |
	And I post a subscription with the following details:
		| Field        | Value      |
		| TouchpointId | 9111111111 |
		| Subscribe    | true       |

@subscriptions @smoke
Scenario: Patch Minimum
	Given I patch a subscription with the following details:
		| Field        | Value      |
		| TouchPointId | 9111111111 |
		| Subscribe    | false      |
	Then there should be a 200 response
	And the response body should contain:
		| Field        | Value      |
		| TouchPointId | 9111111111 |
		| Subscribe    | false      |