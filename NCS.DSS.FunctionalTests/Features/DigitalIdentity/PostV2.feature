@postV1
Feature: PostV2

@digitalidentity @smoke
Scenario:Post valid DigitalIdentity
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

#And there should be a record in the digitalidentities ChangeFeed table
#And there should be a record in the digitalidentities-history ChangeFeed table
@digitalidentity
Scenario: Post invalid DigitalIdentity with non existent customerId
	Given I Post a digital identity with the following details
		| Field            | Value                                |
		| IdentityStoreId  | 6973bf77-35f6-4989-a8ca-f1528d9c10a5 |
		| LegacyIdentity   | 07676 123456                         |
		| id_token         | 08654 123456                         |
		| LastModifiedDate | 2018-08-20T11:46:02.4482612+00:00    |
		| CustomerId       | 6973bf77-35f6-4989-a8ca-f1528d9c10a5 |
	Then there should be a 422 response

@digitalidentity
Scenario: Post invalid DigitalIdentity with closure date set
	Given I post a Customer with the following details:
		| Field      | Value    |
		| GivenName  | Bob      |
		| FamilyName | Customer |
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 012345678901234567890        |
		| AlternativeNumber      | 07564656766                  |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
		| DateOfClosure          | 2018-08-20T11:46:02.4482612Z |
	Then there should be a 422 response

Scenario:Post Valid Digital identity Digital identity Already Exists for Customer
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
	Given I Post a digital identity with the following details
		| Field            | Value                                |
		| IdentityStoreId  | 6973bf77-35f6-4989-a8ca-f1528d9c10a5 |
		| LegacyIdentity   | 07676 123456                         |
		| id_token         | 08654 123456                         |
		| LastModifiedDate | 2018-08-20T11:46:02.4482612+00:00    |
	Then there should be a 422 response

Scenario:Post Invalid Digital identity without a contact
	Given I post a Customer with the following details:
		| Field      | Value    |
		| GivenName  | Bob      |
		| FamilyName | Customer |
	Given I Post a digital identity with the following details
		| Field            | Value                                |
		| IdentityStoreId  | 6973bf77-35f6-4989-a8ca-f1528d9c10a5 |
		| LegacyIdentity   | 07676 123456                         |
		| id_token         | 08654 123456                         |
		| LastModifiedDate | 2018-08-20T11:46:02.4482612+00:00    |
	Then there should be a 422 response
#	@postV3 @patchV3
#Scenario:Post Digital Identity for Customer that is Terminated
#	Given I post a Contact with the following details with unique email address:
#		| Field                  | Value                        |
#		| PreferredContactMethod | 1                            |
#		| MobileNumber           | 07676 123456                 |
#		| HomeNumber             | 08654 123456                 |
#		| AlternativeNumber      | 07564656766                  |
#		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
#	Then there should be a 201 response
#	And Email the response email is correct
#	And the response body should contain:
#		| Field                  | Value        |
#		| PreferredContactMethod | 1            |
#		| MobileNumber           | 07676 123456 |
#		| HomeNumber             | 08654 123456 |
#		| AlternativeNumber      | 07564656766  |
#	When I Set DateOfTermination of a Customer:
#		| Field             | Value                |
#		| DateOfTermination | 2018-08-27T14:45:00Z |
#	Given I Post a digital identity with the following details
#		| Field            | Value                                |
#		| IdentityStoreId  | 6973bf77-35f6-4989-a8ca-f1528d9c10a5 |
#		| LegacyIdentity   | 07676 123456                         |
#		| id_token         | 08654 123456                         |
#		| LastModifiedDate | 2018-08-20T11:46:02.4482612+00:00    |
#	Then there should be a 422 response 