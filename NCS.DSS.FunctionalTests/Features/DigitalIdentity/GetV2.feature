Feature: DigitalIdentityGetV2

@digitalidentity @smoke
Scenario: Post valid DigitalIdentity and Get By CustomerId
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
	And the response body should contain:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
	Given I Post a digital identity with the following details V2:
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
	Given I get a DigitalIdentity by CustomerID V2
	Then there should be a 200 response
	And the response body should contain:
		| Field            | Value                                |
		| IdentityStoreId  | 6973bf77-35f6-4989-a8ca-f1528d9c10a5 |
		| LegacyIdentity   | 07676 123456                         |
		| id_token         | 08654 123456                         |
		| LastModifiedDate | 2018-08-20T11:46:02.4482612+00:00    |

Scenario: Get Digital Identity for Customer that Does not have a Digital Identity Returns Error
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
	And the response body should contain:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
	Given I get a DigitalIdentity by CustomerID V2
	Then there should be a 204 response

Scenario: Get Digital Identity By DigitalIdentityId for Customer that Does not have a Digital Identity Returns Error
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
	And the response body should contain:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
	Given I get a DigitalIdentity by DigitalIdentityID V2
	Then there should be a 204 response

Scenario: Post valid DigitalIdentity and Get By DigitalIdentityId
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
	And the response body should contain:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
	Given I Post a digital identity with the following details V2:
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
	Given I get a DigitalIdentity by DigitalIdentityID V2
	Then there should be a 200 response
	And the response body should contain:
		| Field            | Value                                |
		| IdentityStoreId  | 6973bf77-35f6-4989-a8ca-f1528d9c10a5 |
		| LegacyIdentity   | 07676 123456                         |
		| id_token         | 08654 123456                         |
		| LastModifiedDate | 2018-08-20T11:46:02.4482612+00:00    |