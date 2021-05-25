Feature: ContactPostV1

Background: Post Customer
	Given I post a Customer with the following details V3:
		| Field          | Value    |
		| GivenName      | Bob      |
		| FamilyName     | Customer |
		| PriorityGroups | 1,3      |

@contactdetails @smoke
Scenario:Post valid contact
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
	Given I wait for 5 Seconds
	Then there should be a record in the dss-contacts table with ContactId

@contactdetails
Scenario: Post Valid ContactDetail one contact method
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value                        |
		| PreferredContactMethod | 2                            |
		| MobileNumber           | 07676 123456                 |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
	Then there should be a 201 response
	And the response body should contain:
		| Field                  | Value                        |
		| PreferredContactMethod | 2                            |
		| MobileNumber           | 07676 123456                 |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
	Given I wait for 5 Seconds
	Then there should be a record in the dss-contacts table with ContactId

@contactdetails
Scenario: Post Valid ContactDetail with ten digit phone numbers
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value                        |
		| PreferredContactMethod | 2                            |
		| MobileNumber           | 0772455294                   |
		| HomeNumber             | 0125 455294                  |
		| AlternativeNumber      | 01254 57611                  |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
	Then there should be a 201 response
	And the response body should contain:
		| Field                  | Value                        |
		| PreferredContactMethod | 2                            |
		| MobileNumber           | 0772455294                   |
		| HomeNumber             | 0125 455294                  |
		| AlternativeNumber      | 01254 57611                  |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
	Given I wait for 5 Seconds
	Then there should be a record in the dss-contacts table with ContactId

@contactdetails
Scenario: Post ContactDetail Mandatory PreferredContactMethod Field missing
	Given I post a Contact with the following details with unique email address:
		| Field             | Value                        |
		| MobileNumber      | 07676 123456                 |
		| HomeNumber        | 08654 123456                 |
		| AlternativeNumber | 07564656766                  |
		| LastModifiedDate  | 2018-08-20T11:46:02.4482612Z |
	Given I wait for 5 Seconds
	Then there should be a 422 response

#And the error message should be "The PreferredContactMethod Field is required."
@contactdetails
Scenario: Post ContactDetail with invalid PreferredContactMethod Value
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value                        |
		| PreferredContactMethod | 12                           |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
	Then there should be a 422 response

#And the error message should be "Please supply a valid Preferred Contact Method"
@contactdetails
Scenario: Post ContactDetail with Invalid MobileNumber
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 012345678901234567890        |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
	Then there should be a 422 response

#And the error message should be "The Field MobileNumber must be a string with a maximum length of 20."
@contactdetails
Scenario: Post ContactDetail with Invalid HomeNumber
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 012345678901234567890        |
		| AlternativeNumber      | 07564656766                  |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
	Then there should be a 422 response

#And the error message should be "The Field HomeNumber must be a string with a maximum length of 20."
@contactdetails
Scenario: Post ContactDetail with Invalid AlternativeNumber
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 012345678901234567890        |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
	Then there should be a 422 response

#And the error message should be "The Field AlternativeNumber must be a string with a maximum length of 20."
@contactdetails
Scenario: Post ContactDetail with Invalid EmailAddress
	Given I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customercustomer.com         |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
	Then there should be a 422 response

#And the error message should be "The Field EmailAddress must match the regular expression '^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$'"
@contactdetails
Scenario: Post ContactDetail with Invalid LastModifiedDate
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| LastModifiedDate       | 2033-08-20T11:46:02.4482612Z |
	Then there should be a 422 response

#And the error message should be "Last Modified Date must be less the current date/time"
@contactdetails
Scenario: Post ContactDetail with missing PreferredContactMethod - email
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| LastModifiedDate       | 2033-08-20T11:46:02.4482612Z |
	Then there should be a 422 response

#And the error message should be "Email Address must be supplied."
@contactdetails
Scenario: Post ContactDetail with missing PreferredContactMethod - mobile
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value                        |
		| PreferredContactMethod | 2                            |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| LastModifiedDate       | 2033-08-20T11:46:02.4482612Z |
	Then there should be a 422 response

#And the error message should be "Mobile Number must be supplied."
@contactdetails
Scenario: Post ContactDetail with missing PreferredContactMethod - phone
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value                        |
		| PreferredContactMethod | 3                            |
		| MobileNumber           | 07676 123456                 |
		| LastModifiedDate       | 2033-08-20T11:46:02.4482612Z |
	Then there should be a 422 response

#And the error message should be "Home Number must be supplied."
@contactdetails
Scenario: Post ContactDetail with missing PreferredContactMethod - SMS
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value                        |
		| PreferredContactMethod | 4                            |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| LastModifiedDate       | 2033-08-20T11:46:02.4482612Z |
	Then there should be a 422 response

#And the error message should be "Mobile Number must be supplied."
@contactdetails
Scenario: Post ContactDetail where one already exists
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value |
		| PreferredContactMethod | 1     |
	And I post a Contact with the following details with unique email address:
		| Field                  | Value        |
		| PreferredContactMethod | 2            |
		| MobileNumber           | 07676 123456 |
	Then there should be a 409 response

@contactdetails
Scenario: Post ContactDetail with email that already exists for another customer
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value |
		| PreferredContactMethod | 1     |
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value   |
		| PreferredContactMethod | 2       |
		| GivenName              | BobCust |
		| FamilyName             | CustBob |
	Given I post a Contact with the following details with unique email address:
		| Field                  | Value                    |
		| PreferredContactMethod | 1                        |
		| EmailAddress           | customer103@customer.com |
	Then there should be a 409 response