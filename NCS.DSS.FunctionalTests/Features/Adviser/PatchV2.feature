﻿Feature: AdviserPatchV2

@adviserdetails @smoke
Scenario: Patch Name
	Given I post an adviser with the following details V2:
		| Field                | Value          |
		| AdviserName          | Billy Smith    |
		| AdviserEmailAddress  | billy@bill.com |
		| AdviserContactNumber | 98798678967967 |
	When I patch the following Adviser V2:
		| Field       | Value       |
		| AdviserName | Billy Jones |
	Then there should be a 200 response
	And the response body should contain:
		| Field                | Value          |
		| AdviserName          | Billy Jones    |
		| AdviserEmailAddress  | billy@bill.com |
		| AdviserContactNumber | 98798678967967 |
	And the response body should not contain the "CreatedBy"

#And there should be a record in the adviserDetails ChangeFeed table
#And there should be a record in the adviserDetails-history ChangeFeed table
#@adviserdetails	@subcontractorId
#Scenario: Patch With SubcontractorId
#	Given I post an adviser with the following details V2:
#		| Field                | Value          |
#		| AdviserName          | Billy Smith    |
#		| AdviserEmailAddress  | billy@bill.com |
#		| AdviserContactNumber | 98798678967967 |
#	#When I patch the following via a different touchpoint
#	#	| Field       | Value       |
#	#	| AdviserName | Billy Jones |
#	Then there should be a 200 response
#	And the response body should not contain the "CreatedBy"
#	And the response body should have different LastUpdatedBy
#	And the response body should contain:
#		| Field                | Value          |
#		| AdviserName          | Billy Jones    |
#		| AdviserEmailAddress  | billy@bill.com |
#		| AdviserContactNumber | 98798678967967 |
#	And the response body should contain the SubContractorId
@adviserdetails
Scenario: Patch email address
	Given I post an adviser with the following details V2:
		| Field                | Value          |
		| AdviserName          | Billy Smith    |
		| AdviserEmailAddress  | billy@bill.com |
		| AdviserContactNumber | 98798678967967 |
	When I patch the following Adviser V2:
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
	Given I post an adviser with the following details V2:
		| Field                | Value          |
		| AdviserName          | Billy Smith    |
		| AdviserEmailAddress  | billy@bill.com |
		| AdviserContactNumber | 98798678967967 |
	When I patch the following Adviser V2:
		| Field                | Value          |
		| AdviserContactNumber | 77647647476743 |
	Then there should be a 200 response
	And the response body should contain:
		| Field                | Value          |
		| AdviserName          | Billy Smith    |
		| AdviserEmailAddress  | billy@bill.com |
		| AdviserContactNumber | 77647647476743 |