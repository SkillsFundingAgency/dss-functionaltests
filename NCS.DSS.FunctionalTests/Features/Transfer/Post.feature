Feature: PostTransfer

#Background: Set up test
@transfers @smoke
Scenario: Post Transfer
	Given I post a Customer with the following details:
		| Field      | Value    |
		| GivenName  | Bob      |
		| FamilyName | Customer |
	Then there should be a 201 response
	Given I post an Interaction with the following details:
		| Field                    | Value                |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z |
		| Channel                  | 2                    |
		| InteractionType          | 2                    |
		| LastModifiedDate         | 2018-06-22T16:52:10Z |
	Then there should be a 201 response
	Given I post a Transfer with the following details:
		| Field                   | Value                |
		| OriginatingTouchpointId | 9000000001           |
		| TargetTouchpointId      | 9111111111           |
		| Context                 | Some context text    |
		| DateandTimeOfTransfer   | 2018-06-22T16:52:10Z |
		| RequestedCallbackTime   | 2018-06-22T16:52:10Z |
	Then there should be a 201 response
	And the response body should contain:
		| Field                   | Value             |
		| OriginatingTouchpointId | 9000000001        |
		| TargetTouchpointId      | 9111111111        |
		| Context                 | Some context text |
	Given I wait for 5 Seconds
	Then there should be a record in the dss-transfers table with TransferId
#And there should be a record in the transfers-history ChangeFeed table