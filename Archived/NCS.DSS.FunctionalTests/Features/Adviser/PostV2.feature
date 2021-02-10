

@postV2

Feature: PostV2

@adviserdetails @smoke
	Scenario: Create Valid Adviser
		Given I post an adviser with the following details:
			| Field                 | Value			|
			| AdviserName			| BillyAdviser	|
			| AdviserEmailAddress	| billy@bill.com|
			| AdviserContactNumber	| 98798678967967|
		Then there should be a 201 response
		And the response body should contain:
			| Field                 | Value			|
			| AdviserName			| BillyAdviser	|
			| AdviserEmailAddress	| billy@bill.com|
			| AdviserContactNumber	| 98798678967967|
		And the "adviserdetails" cosmos document should include CreatedBy
		And the response body should not contain the "CreatedBy"

@adviserdetails @subcontractorId
	Scenario: Create Valid Adviser with SubcontractorId
		Given I post an adviser with the following details:
			| Field                 | Value			|
			| AdviserName			| BillyAdviser	|
			| AdviserEmailAddress	| billy@bill.com|
			| AdviserContactNumber	| 98798678967967|
		Then there should be a 201 response
		And the response body should contain:
			| Field                 | Value			|
			| AdviserName			| BillyAdviser	|
			| AdviserEmailAddress	| billy@bill.com|
			| AdviserContactNumber	| 98798678967967|
		And the response body should contain the SubContractorId
		And the "adviserdetails" cosmos document should include CreatedBy
		And the response body should not contain the "CreatedBy"

@adviserdetails
Scenario: Change feed for Post Adviser
		Given I post an adviser with the following details:
			| Field                 | Value			|
			| AdviserName			| BillyAdviser	|
			| AdviserEmailAddress	| billy@bill.com|
		Then there should be a 201 response
		And there should be a record in the adviserDetails ChangeFeed table
		And there should be a record in the adviserDetails-history ChangeFeed table
		And the "adviserdetails" cosmos document should include CreatedBy
		And the response body should not contain the "CreatedBy"

@adviserdetails
		Scenario: Missing AdviserName
		Given I post an adviser with the following details:
			| Field                 | Value			|
			| AdviserEmailAddress	| billy@bill.com|
			| AdviserContactNumber	| 98798678967967|
		Then there should be a 422 response