Feature: AdviserGetV2

@adviserdetails @smoke
Scenario: Get Adviser by ID
	Given I post an adviser with the following details V2:
		| Field                | Value          |
		| AdviserName          | BillyAdviser   |
		| AdviserEmailAddress  | billy@bill.com |
		| AdviserContactNumber | 98798678967967 |
	When I get an Adviser by ID V2
	Then there should be a 200 response
	And the response body should contain:
		| Field                | Value          |
		| AdviserName          | BillyAdviser   |
		| AdviserEmailAddress  | billy@bill.com |
		| AdviserContactNumber | 98798678967967 |

@adviserdetails	@subcontractorId
Scenario: Get Adviser with SubcontractorId
	Given I post an adviser with the following details V2:
		| Field                | Value          |
		| AdviserName          | BillyAdviser   |
		| AdviserEmailAddress  | billy@bill.com |
		| AdviserContactNumber | 98798678967967 |
	When I get an Adviser by ID V2
	Then there should be a 200 response
	And the response body should contain:
		| Field                | Value          |
		| AdviserName          | BillyAdviser   |
		| AdviserEmailAddress  | billy@bill.com |
		| AdviserContactNumber | 98798678967967 |
	#And the response body should contain the SubContractorId