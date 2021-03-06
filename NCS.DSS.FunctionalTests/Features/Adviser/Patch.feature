﻿Feature: AdviserPatchV1

@adviserdetails @smoke
Scenario: Patch Name
	Given I post an adviser with the following details:
		| Field                | Value          |
		| AdviserName          | Billy Smith    |
		| AdviserEmailAddress  | billy@bill.com |
		| AdviserContactNumber | 98798678967967 |
	When I patch the following Adviser:
		| Field       | Value       |
		| AdviserName | Billy Jones |
	Then there should be a 200 response
	And the response body should contain:
		| Field                | Value          |
		| AdviserName          | Billy Jones    |
		| AdviserEmailAddress  | billy@bill.com |
		| AdviserContactNumber | 98798678967967 |
	Given I wait for 5 Seconds
	Then there should be a record in the dss-adviserdetails table with AdviserDetailId

@adviserdetails
Scenario: Patch email address
	Given I post an adviser with the following details:
		| Field                | Value          |
		| AdviserName          | Billy Smith    |
		| AdviserEmailAddress  | billy@bill.com |
		| AdviserContactNumber | 98798678967967 |
	When I patch the following Adviser:
		| Field               | Value        |
		| AdviserEmailAddress | tom@bill.com |
	Then there should be a 200 response
	And the response body should contain:
		| Field                | Value          |
		| AdviserName          | Billy Smith    |
		| AdviserEmailAddress  | tom@bill.com   |
		| AdviserContactNumber | 98798678967967 |

@adviserdetails
Scenario: Patch AdviserContactNumber
	Given I post an adviser with the following details:
		| Field                | Value          |
		| AdviserName          | Billy Smith    |
		| AdviserEmailAddress  | billy@bill.com |
		| AdviserContactNumber | 98798678967967 |
	When I patch the following Adviser:
		| Field                | Value          |
		| AdviserContactNumber | 77647647476743 |
	Then there should be a 200 response
	And the response body should contain:
		| Field                | Value          |
		| AdviserName          | Billy Smith    |
		| AdviserEmailAddress  | billy@bill.com |
		| AdviserContactNumber | 77647647476743 |