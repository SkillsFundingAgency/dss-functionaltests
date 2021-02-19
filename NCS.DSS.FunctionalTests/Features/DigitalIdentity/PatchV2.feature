Feature: DigitalIdentityPatchV2

@digitalidentity @smoke
Scenario: Patch a valid Digital Identity
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
	Given I patch the following digitalIdentity By CustomerId V2:
		| Field           | Value                                |
		| id_token        | 1234567910                           |
		| IdentityStoreId | aaf18eff-bf70-4e04-82ba-a056258f0db8 |
		| LegacyIdentity  | "test"                               |
	Then there should be a 200 response
	And the response body should contain:
		| Field           | Value                                |
		| id_token        | 1234567910                           |
		| IdentityStoreId | aaf18eff-bf70-4e04-82ba-a056258f0db8 |
		| LegacyIdentity  | "test"                               |

@digitalidentity @smoke
Scenario: Patch Digital Identity for Customer that does not exist
	Given I patch the following digitalIdentity By CustomerId V2:
		| Field           | Value                                |
		| id_token        | 1234567910                           |
		| IdentityStoreId | aaf18eff-bf70-4e04-82ba-a056258f0db8 |
		| LegacyIdentity  | "test"                               |
		| CustomerId      | e432d40a-28bc-4969-bda8-9c096c747b52 |
	Then there should be a 422 response

@digitalidentity @smoke
Scenario: Patch a Digital Identity for a customer that does not have a digital identity
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
	Given I patch the following digitalIdentity By CustomerId V2:
		| Field           | Value                                |
		| id_token        | 1234567910                           |
		| IdentityStoreId | aaf18eff-bf70-4e04-82ba-a056258f0db8 |
		| LegacyIdentity  | "test"                               |
	Then there should be a 204 response

@digitalidentity @smoke
Scenario: Patch a valid Digital Identity By Digital IdentityId
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
	Given I patch the following digitalIdentity By DigitalIdentityId V2:
		| Field           | Value                                |
		| id_token        | 1234567910                           |
		| IdentityStoreId | aaf18eff-bf70-4e04-82ba-a056258f0db8 |
		| LegacyIdentity  | "test"                               |
	Then there should be a 200 response
	And there should be a record in the dss-digitalidentities table Ignoring '' with IdentityId
	And the response body should contain:
		| Field           | Value                                |
		| id_token        | 1234567910                           |
		| IdentityStoreId | aaf18eff-bf70-4e04-82ba-a056258f0db8 |
		| LegacyIdentity  | "test"                               |

@digitalidentity @smoke
Scenario: Patch a Digital Identity By Digital IdentityId for a customer that does not have a digital identity
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
	Given I patch the following digitalIdentity By DigitalIdentityId V2:
		| Field           | Value                                |
		| id_token        | 1234567910                           |
		| IdentityStoreId | aaf18eff-bf70-4e04-82ba-a056258f0db8 |
		| LegacyIdentity  | "test"                               |
	Then there should be a 204 response