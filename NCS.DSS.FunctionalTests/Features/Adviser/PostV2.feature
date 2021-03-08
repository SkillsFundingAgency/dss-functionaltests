Feature: AdviserPostV2

@adviserdetails @smoke
Scenario: Create Valid Adviser
	Given I post an adviser with the following details V2:
		| Field                | Value          |
		| AdviserName          | BillyAdviser   |
		| AdviserEmailAddress  | billy@bill.com |
		| AdviserContactNumber | 98798678967967 |
	Then there should be a 201 response
	And the response body should contain:
		| Field                | Value          |
		| AdviserName          | BillyAdviser   |
		| AdviserEmailAddress  | billy@bill.com |
		| AdviserContactNumber | 98798678967967 |
	And the response body should not contain the "CreatedBy"
	Given I fetch a adviserdetails cosmos document from adviserdetails database using key AdviserDetailId
	Then the cosmos document should have property CreatedBy with value 9111111111

@adviserdetails @subcontractorId
Scenario: Create Valid Adviser with SubcontractorId
	Given I want to set the scenario touchPointId header to 9111111111
	Given I post an adviser with the following details V2:
		| Field                | Value          |
		| AdviserName          | BillyAdviser   |
		| AdviserEmailAddress  | billy@bill.com |
		| AdviserContactNumber | 98798678967967 |
	Then there should be a 201 response
	And the response body should contain:
		| Field                | Value          |
		| AdviserName          | BillyAdviser   |
		| AdviserEmailAddress  | billy@bill.com |
		| AdviserContactNumber | 98798678967967 |
	#And the response body should contain the SubContractorId
	And the response body should not contain the "CreatedBy"
	Given I fetch a adviserdetails cosmos document from adviserdetails database using key AdviserDetailId
	Then the cosmos document should have property CreatedBy with value 9111111111

@adviserdetails
Scenario: Change feed for Post Adviser
	Given I want to set the scenario touchPointId header to 9111111111
	Given I post an adviser with the following details V2:
		| Field               | Value          |
		| AdviserName         | BillyAdviser   |
		| AdviserEmailAddress | billy@bill.com |
	Then there should be a 201 response
	Given I wait for 5 Seconds
	Then there should be a record in the dss-adviserdetails table with AdviserDetailId
	And the response body should not contain the "CreatedBy"
	Given I fetch a adviserdetails cosmos document from adviserdetails database using key AdviserDetailId
	Then the cosmos document should have property CreatedBy with value 9111111111

@adviserdetails
Scenario: Missing AdviserName
	Given I post an adviser with the following details V2:
		| Field                | Value          |
		| AdviserEmailAddress  | billy@bill.com |
		| AdviserContactNumber | 98798678967967 |
	Then there should be a 422 response