Feature: ContactPatchV1

Background: Post Customer
	Given I post a Customer with the following details:
		| Field      | Value    |
		| GivenName  | Bob      |
		| FamilyName | Customer |

@contactdetails @smoke
Scenario: Patch PreferredContactMethod
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value        |
		| PreferredContactMethod | 1            |
		| MobileNumber           | 07676 123456 |
		| HomeNumber             | 08654 123456 |
		| AlternativeNumber      | 07564656766  |
	When I patch the following Contact:
		| Field                  | Value        |
		| PreferredContactMethod | 2            |
		| MobileNumber           | 07676 123456 |
	Then there should be a 200 response
	And the response body should contain:
		| Field                  | Value        |
		| PreferredContactMethod | 2            |
		| MobileNumber           | 07676 123456 |
		| HomeNumber             | 08654 123456 |
		| AlternativeNumber      | 07564656766  |

#And there should be a record in the contacts ChangeFeed table
#And there should be a record in the contacts-history ChangeFeed table
@contactdetails
Scenario: Patch PreferredContactMethod with invalid data
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value        |
		| PreferredContactMethod | 1            |
		| MobileNumber           | 07676 123456 |
		| HomeNumber             | 08654 123456 |
		| AlternativeNumber      | 07564656766  |
	When I patch the following Contact:
		| Field                  | Value |
		| PreferredContactMethod | 6     |
	Then there should be a 422 response

#And the error message should be "Please supply a valid Preferred Contact Method"
@contactdetails
Scenario: Patch MobileNumber
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value        |
		| PreferredContactMethod | 1            |
		| MobileNumber           | 07676 123456 |
		| HomeNumber             | 08654 123456 |
		| AlternativeNumber      | 07564656766  |
	When I patch the following Contact:
		| Field        | Value        |
		| MobileNumber | 07676 654321 |
	Then there should be a 200 response
	And the response body should contain:
		| Field                  | Value        |
		| PreferredContactMethod | 1            |
		| MobileNumber           | 07676 654321 |
		| HomeNumber             | 08654 123456 |
		| AlternativeNumber      | 07564656766  |

#And there should be a record in the contacts ChangeFeed table
#And there should be a record in the contacts-history ChangeFeed table
@contactdetails
Scenario: Patch HomeNumber
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value        |
		| PreferredContactMethod | 1            |
		| MobileNumber           | 07676 123456 |
		| HomeNumber             | 08654 123456 |
		| AlternativeNumber      | 07564656766  |
	When I patch the following Contact:
		| Field      | Value        |
		| HomeNumber | 08654 654321 |
	Then there should be a 200 response
	And the response body should contain:
		| Field                  | Value        |
		| PreferredContactMethod | 1            |
		| MobileNumber           | 07676 123456 |
		| HomeNumber             | 08654 654321 |
		| AlternativeNumber      | 07564656766  |

#And there should be a record in the contacts ChangeFeed table
#And there should be a record in the contacts-history ChangeFeed table
@contactdetails
Scenario: Patch AlternativeNumber
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value        |
		| PreferredContactMethod | 1            |
		| MobileNumber           | 07676 123456 |
		| HomeNumber             | 08654 123456 |
		| AlternativeNumber      | 08654 123457 |
	When I patch the following Contact:
		| Field             | Value        |
		| AlternativeNumber | 08654 123458 |
	Then there should be a 200 response
	And the response body should contain:
		| Field                  | Value        |
		| PreferredContactMethod | 1            |
		| MobileNumber           | 07676 123456 |
		| HomeNumber             | 08654 123456 |
		| AlternativeNumber      | 08654 123458 |

#And there should be a record in the contacts ChangeFeed table
#And there should be a record in the contacts-history ChangeFeed table
@contactdetails
Scenario: Patch EmailAddress
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value        |
		| PreferredContactMethod | 1            |
		| MobileNumber           | 07676 123456 |
		| HomeNumber             | 08654 123456 |
		| AlternativeNumber      | 07564656766  |
	When I patch the following Contact With RandomEmailAddress:
	Then there should be a 200 response
	And the response body should contain:
		| Field                  | Value        |
		| PreferredContactMethod | 1            |
		| MobileNumber           | 07676 123456 |
		| HomeNumber             | 08654 123456 |
		| AlternativeNumber      | 07564656766  |

#And there should be a record in the contacts ChangeFeed table
#And there should be a record in the contacts-history ChangeFeed table
@contactdetails
Scenario: Patch EmailAddress with invalid data
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value        |
		| PreferredContactMethod | 1            |
		| MobileNumber           | 07676 123456 |
		| HomeNumber             | 08654 123456 |
		| AlternativeNumber      | 07564656766  |
	When I patch the following Contact:
		| Field        | Value                  |
		| EmailAddress | customeratcustomer.com |
	Then there should be a 422 response

@contactdetails
Scenario: Patch new PreferredContactMethod - MobileNumber
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value        |
		| PreferredContactMethod | 1            |
		| MobileNumber           | 07676 123456 |
		| HomeNumber             | 08654 123456 |
		| AlternativeNumber      | 07564656766  |
	When I patch the following Contact:
		| Field                  | Value        |
		| PreferredContactMethod | 2            |
		| MobileNumber           | 07676 123456 |
	Then there should be a 200 response
	And the response body should contain:
		| Field                  | Value        |
		| PreferredContactMethod | 2            |
		| MobileNumber           | 07676 123456 |
		| HomeNumber             | 08654 123456 |
		| AlternativeNumber      | 07564656766  |
#And there should be a record in the contacts ChangeFeed table
#And there should be a record in the contacts-history ChangeFeed table