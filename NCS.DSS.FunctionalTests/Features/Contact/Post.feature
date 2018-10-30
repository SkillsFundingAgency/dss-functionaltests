Feature: Post


	Background: Post Customer
	Given I post a Customer with the following details:
		| Field                | Value                |
		| GivenName            | Bob                  |
		| FamilyName           | Customer             |



	Scenario:Post valid contact
	Given I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customer@customer.com        |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
		Then there should be a 201 response
		And the response body should contain:
		| Field                  | Value						|
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customer@customer.com        |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |



	Scenario: Post Valid ContactDetail one contact method
		Given I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 2                            |
		| MobileNumber           | 07676 123456                 |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
		Then there should be a 201 response
		And the response body should contain:
		| Field                  | Value						|
		| PreferredContactMethod | 2                            |
		| MobileNumber           | 07676 123456                 |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |


	Scenario: Post ContactDetail Mandatory PreferredContactMethod Field missing
		Given I post a Contact with the following details:
		| Field                  | Value                        |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customer@customer.com        |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
		Then there should be a 422 response
		#And the error message should be "The PreferredContactMethod Field is required."


	Scenario: Post ContactDetail with invalid PreferredContactMethod Value
		Given I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 12                           |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customer@customer.com        |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
		Then there should be a 422 response
		#And the error message should be "Please supply a valid Preferred Contact Method"
		

	Scenario: Post ContactDetail with Invalid MobileNumber
		Given I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 012345678901234567890        |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customer@customer.com        |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
		Then there should be a 422 response
		#And the error message should be "The Field MobileNumber must be a string with a maximum length of 20."


	Scenario: Post ContactDetail with Invalid HomeNumber
		Given I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 012345678901234567890        |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customer@customer.com        |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
		Then there should be a 422 response
		#And the error message should be "The Field HomeNumber must be a string with a maximum length of 20."


	Scenario: Post ContactDetail with Invalid AlternativeNumber
		Given I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 012345678901234567890        |
		| EmailAddress           | customer@customer.com        |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
		Then there should be a 422 response
		#And the error message should be "The Field AlternativeNumber must be a string with a maximum length of 20."


	Scenario: Post ContactDetail with Invalid EmailAddress
		Given I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customercustomer.com			|
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
		Then there should be a 422 response
		#And the error message should be "The Field EmailAddress must match the regular expression '^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$'"


	Scenario: Post ContactDetail with Invalid LastModifiedDate
		Given I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customer@customer.com        |
		| LastModifiedDate       | 2033-08-20T11:46:02.4482612Z |
		Then there should be a 422 response
		#And the error message should be "Last Modified Date must be less the current date/time"


	Scenario: Post ContactDetail with missing PreferredContactMethod - email
		Given I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| LastModifiedDate       | 2033-08-20T11:46:02.4482612Z |
		Then there should be a 422 response
		#And the error message should be "Email Address must be supplied."


	Scenario: Post ContactDetail with missing PreferredContactMethod - mobile
		Given I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 2                            |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customer@customer.com        |
		| LastModifiedDate       | 2033-08-20T11:46:02.4482612Z |
		Then there should be a 422 response
		#And the error message should be "Mobile Number must be supplied."


	Scenario: Post ContactDetail with missing PreferredContactMethod - phone
		Given I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 3                            |
		| MobileNumber           | 07676 123456                 |
		| EmailAddress           | customer@customer.com        |
		| LastModifiedDate       | 2033-08-20T11:46:02.4482612Z |
		Then there should be a 422 response
		#And the error message should be "Home Number must be supplied."


	Scenario: Post ContactDetail with missing PreferredContactMethod - SMS
		Given I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 4                            |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customer@customer.com        |
		| LastModifiedDate       | 2033-08-20T11:46:02.4482612Z |
		Then there should be a 422 response
		#And the error message should be "Mobile Number must be supplied."	



	Scenario: Post ContactDetail where one already exists
		Given I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| EmailAddress           | customer@customer.com        |
		And I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 2                            |
		| MobileNumber           | 07676 123456                 |
		Then there should be a 409 response

