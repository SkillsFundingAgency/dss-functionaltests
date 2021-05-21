Feature: TransferPatch

Background: Create Adviser
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
	Given I post a Transfer with the following details:
		| Field                   | Value                |
		| OriginatingTouchpointId | 9000000001           |
		| TargetTouchpointId      | 9111111111           |
		| Context                 | Some context text    |
		| DateandTimeOfTransfer   | 2018-06-22T16:52:10Z |
		| RequestedCallbackTime   | 2018-06-22T16:52:10Z |
	Then there should be a 201 response

@transfers @smoke
Scenario: Patch Minimum
	Given I patch a Transfer with the following details:
		| Field              | Value            |
		| TargetTouchpointId | 9000000001       |
		| Context            | Some context min |
	Then there should be a 200 response
	And the response body should contain:
		| Field                   | Value            |
		| OriginatingTouchpointId | 9000000001       |
		| Context                 | Some context min |

@transfers
Scenario: Patch All
	Given I patch a Transfer with the following details:
		| Field                         | Value                |
		| OriginatingTouchpointId       | 9000000001           |
		| TargetTouchpointId            | 9222222222           |
		| Context                       | Some context min     |
		| DateandTimeOfTransfer         | 2018-06-25T11:21:00Z |
		| DateandTimeofTransferAccepted | 2018-06-25T11:21:00Z |
		| RequestedCallbackTime         | 2018-06-25T11:21:00Z |
		| ActualCallbackTime            | 2018-06-25T11:21:00Z |
		| LastModifiedDate              | 2018-06-25T11:21:00Z |
		| LastModifiedTouchpointId      | 9000000001           |
	Then there should be a 200 response
	And the response body should contain:
		| Field                         | Value                |
		| OriginatingTouchpointId       | 9000000001           |
		| TargetTouchpointId            | 9222222222           |
		| Context                       | Some context min     |
		| DateandTimeOfTransfer         | 2018-06-25T11:21:00Z |
		| DateandTimeofTransferAccepted | 2018-06-25T11:21:00Z |
		| RequestedCallbackTime         | 2018-06-25T11:21:00Z |
		| ActualCallbackTime            | 2018-06-25T11:21:00Z |
		| LastModifiedDate              | 2018-06-25T11:21:00Z |
		| LastModifiedTouchpointId      | 9000000001           |
#@transfers
#Scenario: Patch InteractionType
#	Given I post an Interaction with the following details:
#		| Field                    | Value                |
#		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z |
#		| Channel                  | 2                    |
#		| InteractionType          | 2                    |
#	When I patch the following Valid Interaction:
#		| Field           | Value |
#		| InteractionType | 1     |
#	Then there should be a 200 response
#	And the response body should contain:
#		| Field                    | Value                |
#		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z |
#		| Channel                  | 2                    |
#		| InteractionType          | 1                    |