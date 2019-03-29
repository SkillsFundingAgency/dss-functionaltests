Feature: Post

	Background: Set up test
	Given I post a Customer with the following details:
		| Field                      | Value                |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
	And I post an Interaction with the following details:
		| Field                    | Value                  |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z   |
		| Channel                  | 2                      |
		| InteractionType          | 2                      |
		| LastModifiedDate         | 2018-06-22T16:52:10Z   |

	Scenario: Post Transfer
	Given I post a Transfer with the following details:
		| Field                   | Value             |
		| OriginatingTouchpointID | TouchPoint1       |
		| TargetTouchpointID      | TouchPoint2       | 
		| Context                 | Some context text |
		| DateandTimeOfTransfer   | 2019-09-12T07:57  |
		| RequestedCallbackTime   | 2019-09-22T07:57  |
	Then there should be a 201 response
	And the response body should contain:
		| Field                   | Value             |
		| OriginatingTouchpointID | TouchPoint1       |
		| TargetTouchpointID      | TouchPoint2       |
		| Context                 | Some context text |