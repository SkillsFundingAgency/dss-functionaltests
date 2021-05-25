Feature: InteractionPatch

Background: Create Adviser
	Given I post an adviser with the following details V2:
		| Field                | Value          |
		| AdviserName          | BillyAdviser   |
		| AdviserContactNumber | 98798678967967 |
	And I post a Customer with the following details V3:
		| Field      | Value    |
		| GivenName  | Bob      |
		| FamilyName | Customer |
		| PriorityGroups | 1,3  |

@interactions @smoke
Scenario: Patch Date
	Given I post an Interaction with the following details:
		| Field                    | Value                |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z |
		| Channel                  | 2                    |
		| InteractionType          | 2                    |
	When I patch the following Valid Interaction:
		| Field                    | Value                |
		| DateandTimeOfInteraction | 2018-06-26T11:21:00Z |
	Then there should be a 200 response
	And the response body should contain:
		| Field                    | Value                |
		| DateandTimeOfInteraction | 2018-06-26T11:21:00Z |
		| Channel                  | 2                    |
		| InteractionType          | 2                    |
	Given I wait for 5 Seconds
	Then there should be a record in the dss-interactions table with InteractionId

#And there should be a record in the interactions-history ChangeFeed table
@interactions
Scenario: Patch channel
	Given I post an Interaction with the following details:
		| Field                    | Value                |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z |
		| Channel                  | 2                    |
		| InteractionType          | 2                    |
	When I patch the following Valid Interaction:
		| Field   | Value |
		| Channel | 1     |
	Then there should be a 200 response
	And the response body should contain:
		| Field                    | Value                |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z |
		| Channel                  | 1                    |
		| InteractionType          | 2                    |
	Given I wait for 5 Seconds
	Then there should be a record in the dss-interactions table with InteractionId

#And there should be a record in the interactions-history ChangeFeed table
@interactions
Scenario: Patch InteractionType
	Given I post an Interaction with the following details:
		| Field                    | Value                |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z |
		| Channel                  | 2                    |
		| InteractionType          | 2                    |
	When I patch the following Valid Interaction:
		| Field           | Value |
		| InteractionType | 1     |
	Then there should be a 200 response
	And the response body should contain:
		| Field                    | Value                |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z |
		| Channel                  | 2                    |
		| InteractionType          | 1                    |
	Given I wait for 5 Seconds
	Then there should be a record in the dss-interactions table with InteractionId
#And there should be a record in the interactions-history ChangeFeed table