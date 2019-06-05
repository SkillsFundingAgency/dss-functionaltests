@postV1
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

@transfers @InteractionId
	Scenario: Post Transfer
	Given I post a Transfer with the following details:
		| Field                   | Value             |
		| OriginatingTouchpointId | TouchPoint1       |
		| TargetTouchpointId      | TouchPoint2       | 
		| Context                 | Some context text |
		| DateandTimeOfTransfer   | 2018-03-12T07:57  |
		| RequestedCallbackTime   | 2018-03-22T07:57  |
	Then there should be a 201 response
	And the response body should contain:
		| Field                   | Value             |
		| OriginatingTouchpointId | 9000000001         |
		| TargetTouchpointId      | 9111111111        |
		| Context                 | Some context text |
	And there should be a record in the transfers ChangeFeed table
	And there should be a record in the transfers-history ChangeFeed table
