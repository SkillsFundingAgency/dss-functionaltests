
@postV1

Feature: Post

	Background: Post Customer
	Given I post a Customer with the following details:
		| Field                | Value                |
		| GivenName            | Bob                  |
		| FamilyName           | Customer             |


@addresses @smoke
	Scenario:Post valid address
	Given I post an Address with the following details:
		| Field                | Value                |
		| Address1             | 1                    |
		| Address2             | The Street           |
		| Address3             | The Town             |
		| Address4             | The Area             |
		| Address5             | The County           |
		| PostCode             | NW11WN               |
		| AlternativePostCode  | NW22WN               |
		| Longitude            | -98.50812            |
		| Latitude             | 52.40121             |
		| EffectiveFrom        | 2018-06-19T09:01:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |
		| LastModifiedDate     | 2018-09-19T09:01:00Z |
		Then there should be a 201 response
		And the response body should contain:
		| Field                | Value				  |
		| Address1             | 1                    |
		| Address2             | The Street           |
		| Address3             | The Town             |
		| Address4             | The Area             |
		| Address5             | The County           |
		| PostCode             | NW11WN               |
		| AlternativePostCode | NW22WN               |
		| Longitude            | -98.50812            |
		| Latitude             | 52.40121             |
		| EffectiveFrom        | 2018-06-19T09:01:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |
		| LastModifiedDate     | 2018-09-19T09:01:00Z |
		And there should be a record in the addresses ChangeFeed table
		And there should be a record in the addresses-history ChangeFeed table

@addresses
		Scenario: Post Address with only mandatory Fields
		Given I post an Address with the following details:
		| Field                | Value                |
		| Address1             | 1                    |
		| PostCode             | NW11WN               |
		Then there should be a 201 response
		And the response body should contain:
		| Field                | Value				  |
		| Address1             | 1                    |
		| Address2             | null	              |
		| Address3             | null	              |
		| Address4             | null	              |
		| Address5             | null	              |
		| PostCode             | NW11WN               |
		| AlternativePostCode  | null	              |
		| Longitude            | null	              |
		| Latitude             | null	              |
		| EffectiveFrom        | null	              |
		| EffectiveTo          | null	              |

@addresses
	Scenario: Post Address with maximum Field lengths
		Given I post an Address with the following details:
		| Field				   | Value                                                                                                |
		| Address1			   | AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghij |
		| Address3             | AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghij |
		| Address4             | AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghij |
		| Address5             | AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghij |
		| PostCode             | NW11WN               |
		| AlternativePostCode | NW22WN               |
		| Longitude            | -98.50812            |
		| Latitude             | 52.40121             |
		| EffectiveFrom        | 2018-06-19T09:01:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |
		| LastModifiedDate     | 2018-09-19T09:01:00Z |
		Then there should be a 201 response
		And the response body should contain:
		| Field				   | Value                                                                                                |
		| Address1			   | AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghij |
		| Address3             | AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghij |
		| Address4             | AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghij |
		| Address5             | AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghij |
		| PostCode             | NW11WN               |
		| AlternativePostCode | NW22WN               |
		| Longitude            | -98.50812            |
		| Latitude             | 52.40121             |
		| EffectiveFrom        | 2018-06-19T09:01:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |
		| LastModifiedDate     | 2018-09-19T09:01:00Z |

@addresses
	Scenario: Post Address with Address1 Field missing
		Given I post an Address with the following details:
		| Field                | Value                |
		| Address2             | The Street           |
		| Address3             | The Town             |
		| Address4             | The Area             |
		| Address5             | The County           |
		| PostCode             | NW11WN               |
		| AlternativePostCode | NW22WN               |
		| Longitude            | -98.50812            |
		| Latitude             | 52.40121             |
		| EffectiveFrom        | 2018-06-19T09:01:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |
		| LastModifiedDate     | 2018-09-19T09:01:00Z |
		Then there should be a 422 response
		#And the error message should be "The Address1 Field is required."

@addresses
	Scenario: Post Address with Address1 Field over character limit
		Given I post an Address with the following details:
		| Field                | Value                |
		| Address1             | AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijA|
		| Address2             | The Street           |
		| Address3             | The Town             |
		| Address4             | The Area             |
		| Address5             | The County           |
		| PostCode             | NW11WN               |
		| AlternativePostCode | NW22WN               |
		| Longitude            | -98.50812            |
		| Latitude             | 52.40100             |
		| EffectiveFrom        | 2018-06-19T09:01:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |
		| LastModifiedDate     | 2018-09-19T09:01:00Z |
		Then there should be a 422 response
		#And the error message should be "The Field Address1 must match the regular expression '[A-Za-z0-9 ~!@&amp;'\\()*+,\\-.\\/:;]{1,100}'."

@addresses
	Scenario: Post Address with invalid Address1
		Given I post an Address with the following details:
		| Field                | Value                |
		| Address1             | 1#                   |
		| Address2             | The Street           |
		| Address3             | The Town             |
		| Address4             | The Area             |
		| Address5             | The County           |
		| PostCode             | AA999AAA             |
		| AlternativePostCode | NW22WN               |
		| Longitude            | -98.50812            |
		| Latitude             | 52.40100             |
		| EffectiveFrom        | 2018-06-19T09:01:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |
		| LastModifiedDate     | 2018-09-19T09:01:00Z |
		Then there should be a 422 response
		#And the error message should be "The Field Address1 must match the regular expression '[A-Za-z0-9 ~!@&amp;'\\()*+,\\-.\\/:;]{1,100}'."

@addresses
	Scenario: Post Address with PostCode Field missing
		Given I post an Address with the following details:
		| Field                | Value                |
		| Address1             | 1                    |
		| Address2             | The Street           |
		| Address3             | The Town             |
		| Address4             | The Area             |
		| Address5             | The County           |
		| AlternativePostCode | NW22WN               |
		| Longitude            | -98.50812            |
		| Latitude             | 52.40100             |
		| EffectiveFrom        | 2018-06-19T09:01:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |
		| LastModifiedDate     | 2018-09-19T09:01:00Z |
		Then there should be a 422 response
		#And the error message should be "The PostCode Field is required."

@addresses
	Scenario: Post Address with invalid PostCode
		Given I post an Address with the following details:
		| Field                | Value                |
		| Address1             | 1                    |
		| Address2             | The Street           |
		| Address3             | The Town             |
		| Address4             | The Area             |
		| Address5             | The County           |
		| PostCode             | AA999AAAA            |
		| AlternativePostCode | NW22WN               |
		| Longitude            | -98.50812            |
		| Latitude             | 52.40100             |
		| EffectiveFrom        | 2018-06-19T09:01:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |
		| LastModifiedDate     | 2018-09-19T09:01:00Z |
		Then there should be a 422 response
		#And the error message should be "Please enter a valid postcode"

@addresses
	Scenario: Post Address with invalid Longitude
		Given I post an Address with the following details:
		| Field                | Value                |
		| Address1             | 1                    |
		| Address2             | The Street           |
		| Address3             | The Town             |
		| Address4             | The Area             |
		| Address5             | The County           |
		| PostCode             | NW11WN               |
		| AlternativePostCode | NW22WN               |
		| Longitude            | -981.50812           |
		| Latitude             | 52.40100             |
		| EffectiveFrom        | 2018-06-19T09:01:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |
		| LastModifiedDate     | 2018-09-19T09:01:00Z |
		Then there should be a 422 response
		#And the error message should be "The Field Longitude must match the regular expression '^(\\+|-)?(?:180(?:(?:\\.0{1,6})?)|(?:[0-9]|[1-9][0-9]|1[0-7][0-9])(?:(?:\\.[0-9]{1,6})?))$'."


@addresses
	Scenario: Post Address with invalid Latitude
		Given I post an Address with the following details:
		| Field                | Value                |
		| Address1             | 1                    |
		| Address2             | The Street           |
		| Address3             | The Town             |
		| Address4             | The Area             |
		| Address5             | The County           |
		| PostCode             | NW11WN               |
		| AlternativePostCode | NW22WN               |
		| Longitude            | -98.50812            |
		| Latitude             | 521.40100            |
		| EffectiveFrom        | 2018-06-19T09:01:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |
		| LastModifiedDate     | 2018-09-19T09:01:00Z |
		Then there should be a 422 response
		#And the error message should be "The Field Latitude must match the regular expression '^(\\+|-)?(?:180(?:(?:\\.0{1,6})?)|(?:[0-9]|[1-9][0-9]|1[0-7][0-9])(?:(?:\\.[0-9]{1,6})?))$'."

@addresses
	Scenario: Post Valid Address with invalid EffectiveFrom date
		Given I post an Address with the following details:
		| Field                | Value                |
		| Address1             | 1                    |
		| Address2             | The Street           |
		| Address3             | The Town             |
		| Address4             | The Area             |
		| Address5             | The County           |
		| PostCode             | NW11WN               |
		| AlternativePostCode | NW22WN               |
		| Longitude            | -98.50812            |
		| Latitude             | 52.40100             |
		| EffectiveFrom        | 2033-06-19T09:01:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |
		| LastModifiedDate     | 2018-09-19T09:01:00Z |
		Then there should be a 422 response
		#And the error message should be "Effective From Agreed must be less the current date/time"