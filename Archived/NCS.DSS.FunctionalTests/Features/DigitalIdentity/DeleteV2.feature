﻿@postV1 @deleteV2
Feature: DeleteV2

@digitalidentity @smoke
Scenario: Delete valid DigitalIdentity
	Given I post a Customer with the following details:
		| Field      | Value    |
		| GivenName  | Bob      |
		| FamilyName | Customer |
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
	Then there should be a 201 response
	And Email the response email is correct
	And the response body should contain:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
	Given I Post a digital identity with the following details
		| Field            | Value                                |
		| IdentityStoreId  | 6973bf77-35f6-4989-a8ca-f1528d9c10a5 |
		| LegacyIdentity   | 07676 123456                         |
		| id_token         | 08654 123456                         |
		| LastModifiedDate | 2018-08-20T11:46:02.4482612+00:00    |
	Then there should be a 201 response
	And the response body should contain:
		| Field            | Value                                |
		| IdentityStoreId  | 6973bf77-35f6-4989-a8ca-f1528d9c10a5 |
		| LegacyIdentity   | 07676 123456                         |
		| id_token         | 08654 123456                         |
		| LastModifiedDate | 2018-08-20T11:46:02.4482612+00:00    |
	Given I Delete a Digital Identity
	Then there should be a 200 response


@digitalidentity @smoke
Scenario: Delete Digital identity for customer that does not have a digital identity
	Given I post a Customer with the following details:
		| Field      | Value    |
		| GivenName  | Bob      |
		| FamilyName | Customer |
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
	Then there should be a 201 response
	And Email the response email is correct
	And the response body should contain:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
	Given I Delete a Digital Identity
	Then there should be a 204 response