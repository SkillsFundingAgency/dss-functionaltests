Feature: DigitalIdentityPostV2

@digitalidentity
Scenario:Post valid DigitalIdentity
	Given I post a Customer with the following details V3:
		| Field          | Value    |
		| GivenName      | Bob      |
		| FamilyName     | Customer |
		| PriorityGroups | 1,3      |
	Then there should be a 201 response
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
	And there should be a record in the dss-digitalidentities table with IdentityId

##And there should be a record in the digitalidentities-history ChangeFeed table
@digitalidentity
Scenario: Post invalid DigitalIdentity with non existent customerId
	Given I Post a digital identity with the following details V2:
		| Field            | Value                                |
		| IdentityStoreId  | 6973bf77-35f6-4989-a8ca-f1528d9c10a5 |
		| LegacyIdentity   | 07676 123456                         |
		| id_token         | 08654 123456                         |
		| LastModifiedDate | 2018-08-20T11:46:02.4482612+00:00    |
		| CustomerId       | 6973bf77-35f6-4989-a8ca-f1528d9c10a5 |
	Then there should be a 422 response

@digitalidentity
Scenario:Post Valid Digital identity Digital identity Already Exists for Customer
	Given I post a Customer with the following details V3:
		| Field          | Value    |
		| GivenName      | Bob      |
		| FamilyName     | Customer |
		| PriorityGroups | 1,3      |
	Then there should be a 201 response
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
	Given I Post a digital identity with the following details V2:
		| Field            | Value                                |
		| IdentityStoreId  | 6973bf77-35f6-4989-a8ca-f1528d9c10a5 |
		| LegacyIdentity   | 07676 123456                         |
		| id_token         | 08654 123456                         |
		| LastModifiedDate | 2018-08-20T11:46:02.4482612+00:00    |
	Then there should be a 422 response
	And the response body should include already exists.

Scenario:Post Invalid Digital identity without a contact
	Given I post a Customer with the following details V3:
		| Field          | Value    |
		| GivenName      | Bob      |
		| FamilyName     | Customer |
		| PriorityGroups | 1,3      |
	Given I Post a digital identity with the following details V2:
		| Field            | Value                                |
		| IdentityStoreId  | 6973bf77-35f6-4989-a8ca-f1528d9c10a5 |
		| LegacyIdentity   | 07676 123456                         |
		| id_token         | 08654 123456                         |
		| LastModifiedDate | 2018-08-20T11:46:02.4482612+00:00    |
	Then there should be a 422 response

Scenario:Post Digital Identity for Customer that is Terminated
	Given I post a Customer with the following details V3:
		| Field          | Value    |
		| GivenName      | Bob      |
		| FamilyName     | Customer |
		| PriorityGroups | 1,3      |
	Then there should be a 201 response
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
	Then there should be a 201 response
	And the response body should contain:
		| Field                  | Value        |
		| PreferredContactMethod | 1            |
		| MobileNumber           | 07676 123456 |
		| HomeNumber             | 08654 123456 |
		| AlternativeNumber      | 07564656766  |
	When I patch the following Customer V3:
		| Field             | Value                |
		| DateOfTermination | 2018-08-27T14:45:00Z |
	Then there should be a 200 response
	Given I Post a digital identity with the following details V2:
		| Field            | Value                                |
		| IdentityStoreId  | 6973bf77-35f6-4989-a8ca-f1528d9c10a5 |
		| LegacyIdentity   | 07676 123456                         |
		| id_token         | 08654 123456                         |
		| LastModifiedDate | 2018-08-20T11:46:02.4482612+00:00    |
	Then there should be a 422 response