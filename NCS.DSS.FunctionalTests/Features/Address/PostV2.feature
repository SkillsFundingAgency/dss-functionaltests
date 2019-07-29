
@postV2

Feature: PostV2


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
		| AlternativePostCode  | NW22WN               |
		| Longitude            | -0.13426            |
		| Latitude             | 51.53494             |
		| EffectiveFrom        | 2018-06-19T09:01:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |
		| LastModifiedDate     | 2018-09-19T09:01:00Z |
	    And the "addresses" cosmos document should include CreatedBy
		And the response body should not contain the "CreatedBy"
		And there should be a record in the addresses ChangeFeed table
		And there should be a record in the addresses-history ChangeFeed table


@addresses @subcontractorId
	Scenario:Post valid address with Subcontractor Id
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
		| AlternativePostCode  | NW22WN               |
		| Longitude            | -0.13426            |
		| Latitude             | 51.53494             |
		| EffectiveFrom        | 2018-06-19T09:01:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |
		| LastModifiedDate     | 2018-09-19T09:01:00Z |
		And the response body should contain the SubContractorId 
	    And the "addresses" cosmos document should include CreatedBy
		And the response body should not contain the "CreatedBy"
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
		| Longitude            | -0.13426            |
		| Latitude             | 51.53494             |
		| EffectiveFrom        | null	              |
		| EffectiveTo          | null	              |
		And there should be a record in the addresses ChangeFeed table
		And there should be a record in the addresses-history ChangeFeed table


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
		| Longitude            | -0.13426            |
		| Latitude             | 51.53494             |
		| EffectiveFrom        | 2018-06-19T09:01:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |
		| LastModifiedDate     | 2018-09-19T09:01:00Z |
		And there should be a record in the addresses ChangeFeed table
		And there should be a record in the addresses-history ChangeFeed table



@addresses
	Scenario: Post Address
#		Given I post a Customer with the following details:
#		| field						 | value                |
#		| GivenName                  | Bob                  |
#		| FamilyName                 | Customer             |
		Given I post an Address with the following details:
		| Field                | Value                |
		| Address1             | 1                    |
		| PostCode             | NW11WN               |
		Then there should be a 201 response
		And there should be a record in the addresses ChangeFeed table
		And there should be a record in the addresses-history ChangeFeed table

@addresses
	Scenario: Post Address with geocoding where postcode has no space
#		Given I post a Customer with the following details:
#		| field						 | value                |
#		| GivenName                  | Bob                  |
#		| FamilyName                 | Customer             |
		Given I post an Address with the following details:
		| Field                | Value                |
		| Address1             | 1                    |
		| PostCode             | nn12tx               |
		Then there should be a 201 response
		And the response body should contain:
		| field     | value     |
		| Address1  | 1         |
		| PostCode  | nn12tx   |
		| Longitude | -1.00181 |
		| Latitude  | 52.12814 |
		And there should be a record in the addresses ChangeFeed table
		And there should be a record in the addresses-history ChangeFeed table

@addresses 
	Scenario: Post Address with geocoding where postcode has space
###		Given I post a Customer with the following details:
#		| field						 | value                |
#		| GivenName                  | Bob                  |
#		| FamilyName                 | Customer             |
		Given I post an Address with the following details:
		| Field                | Value                |
		| Address1             | 1                    |
		| PostCode             | nn1 2tx             |
		Then there should be a 201 response
	    And the response body should contain:
		| field     | value     |
		| Address1  | 1         |
		| PostCode  | nn1 2tx   |
		| Longitude | -1.00181 |
		| Latitude  | 52.12814 |
		And there should be a record in the addresses ChangeFeed table
		And there should be a record in the addresses-history ChangeFeed table

@addresses 
	Scenario: Post Address with geocoding where postcode cannot be geocoded
#		Given I post a Customer with the following details:
#		| field						 | value                |
#		| GivenName                  | Bob                  |
#		| FamilyName                 | Customer             |
		Given I post an Address with the following details:
		| Field                | Value                |
		| Address1             | 1                    |
		| PostCode             | ze11 1ef             |
		Then there should be a 201 response
	    And the response body should contain:
		| field     | value    |
		| Address1  | 1        |
		| PostCode  | ze11 1ef |
		| Longitude |          |
		| Latitude  |          |
		And there should be a record in the addresses ChangeFeed table
		And there should be a record in the addresses-history ChangeFeed table
		


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
