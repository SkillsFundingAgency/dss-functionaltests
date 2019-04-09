	@postV1
	@patchV1
	Feature: Patch


	Background: Post Customer
	Given I post a Customer with the following details:
		| Field                | Value                |
		| GivenName            | Bob                  |
		| FamilyName           | Customer             |


	Scenario: Patch PreferredContactMethod
		Given I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customer@customer.com        |
		When I patch the following:
		| Field                  | Value                        |
		| PreferredContactMethod | 2                            |
		Then there should be a 200 response
		And the response body should contain:
		| Field                  | Value                        |
		| PreferredContactMethod | 2                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customer@customer.com        |


	Scenario: Patch PreferredContactMethod with invalid data
		Given I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customer@customer.com        |
		When I patch the following:
		| Field                  | Value                        |
		| PreferredContactMethod | 6                            |
		Then there should be a 422 response
		#And the error message should be "Please supply a valid Preferred Contact Method"
		
		
	Scenario: Patch MobileNumber
		Given I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customer@customer.com        |
		When I patch the following:
		| Field                  | Value                        |
		| MobileNumber           | 07676 654321                 |
		Then there should be a 200 response
		And the response body should contain:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 654321                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customer@customer.com        |



	Scenario: Patch HomeNumber
		Given I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customer@customer.com        |
		When I patch the following:
		| Field                  | Value                        |
		| HomeNumber             | 08654 654321                 |
		Then there should be a 200 response
		And the response body should contain:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 654321                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customer@customer.com        |



	Scenario: Patch AlternativeNumber
		Given I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 08654 123457                 |
		| EmailAddress           | customer@customer.com        |
		When I patch the following:
		| Field                  | Value                        |
		| AlternativeNumber      | 08654 123458                 |
		Then there should be a 200 response
		And the response body should contain:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 08654 123458                 |
		| EmailAddress           | customer@customer.com        |



	Scenario: Patch EmailAddress
		Given I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customer@customer.com        |
		When I patch the following:
		| Field                  | Value                        |
		| EmailAddress           | customer@update.com          |
		Then there should be a 200 response
		And the response body should contain:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customer@update.com          |


	Scenario: Patch EmailAddress with invalid data
		Given I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customer@customer.com        |
		When I patch the following:
		| Field                  | Value                        |
		| EmailAddress           | customeratcustomer.com       |
		Then there should be a 422 response


	Scenario: Patch new PreferredContactMethod - MobileNumber
		Given I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customer@customer.com        |
		When I patch the following:
		| Field                  | Value                        |
		| PreferredContactMethod | 2                            |
		Then there should be a 200 response
		And the response body should contain:
		| Field                  | Value                        |
		| PreferredContactMethod | 2                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customer@customer.com        |

#	Scenario: Patch new preferredContactMethod - HomeNumber
#
#
#	Scenario: Patch new preferredContactMethod - SMS
#
#
#	Scenario: Patch new preferredContactMethod - EmailAddress
#
#
#	Scenario: Patch new preferredContactMethod - invalid MobileNumber
#
#
#	Scenario: Patch new preferredContactMethod - invalid HomeNumber
#
#
#	Scenario: Patch new preferredContactMethod - invalid SMS
#
#
#	Scenario: Patch new preferredContactMethod - invalid EmailAddress
#
#
#	Scenario: Patch new preferredContactMethod - missing MobileNumber
#
#
#	Scenario: Patch new preferredContactMethod - missing HomeNumber
#
#
#	Scenario: Patch new preferredContactMethod - missing SMS
#
#
#	Scenario: Patch new preferredContactMethod - missing EmailAddress
#
#
#	Scenario: Patch - remove data
#
#
#
#
#	patch method & delete together
#
#	patch to method where no data