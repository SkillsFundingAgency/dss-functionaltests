﻿Feature: AdviserPostV1

@adviserdetails @smoke
Scenario: Create Valid Adviser
	Given I post an adviser with the following details:
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
	Given I wait for 5 Seconds
	Then there should be a record in the dss-adviserdetails table with AdviserDetailId

@adviserdetails
Scenario: Missing AdviserName
	Given I post an adviser with the following details:
		| Field                | Value          |
		| AdviserEmailAddress  | billy@bill.com |
		| AdviserContactNumber | 98798678967967 |
	Then there should be a 422 response