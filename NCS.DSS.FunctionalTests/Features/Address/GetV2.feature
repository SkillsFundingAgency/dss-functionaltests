Feature: AddressGetV2

@addresses @smoke @subcontractorId
Scenario: Get Address by ID
	Given I post a Customer with the following details:
		| Field      | Value    |
		| GivenName  | Bob      |
		| FamilyName | Customer |
	And I post an Address with the following details V2:
		| Field               | Value                |
		| Address1            | 1                    |
		| Address2            | The Street           |
		| Address3            | The Town             |
		| Address4            | The Area             |
		| Address5            | The County           |
		| PostCode            | NW11WN               |
		| AlternativePostCode | NW22WN               |
		| Longitude           | -98.50812            |
		| Latitude            | 52.40121             |
		| EffectiveFrom       | 2018-06-19T09:01:00Z |
		| EffectiveTo         | 2018-06-21T13:12:00Z |
		| LastModifiedDate    | 2018-09-19T09:01:00Z |
	When I get an Address by ID V2
	Then there should be a 200 response
	And the response body should contain:
		| Field               | Value                |
		| Address1            | 1                    |
		| Address2            | The Street           |
		| Address3            | The Town             |
		| Address4            | The Area             |
		| Address5            | The County           |
		| PostCode            | NW11WN               |
		| AlternativePostCode | NW22WN               |
		| Longitude           | -98.50812            |
		| Latitude            | 52.40121             |
		| EffectiveFrom       | 2018-06-19T09:01:00Z |
		| EffectiveTo         | 2018-06-21T13:12:00Z |
		| LastModifiedDate    | 2018-09-19T09:01:00Z |
	#And the response body should contain the SubContractorId
#Scenario:Get All Address records where 2 exist
#	Given I post a Customer with the following details:
#		| Field                | Value                |
#		| GivenName            | Bob                  |
#		| FamilyName           | Customer             |
#	Given I post an Address with the following details:
#		| Field               | Value                |
#		| Address1            | 1                    |
#		| Address2            | The Street           |
#		| Address3            | The Town             |
#		| Address4            | The Area             |
#		| Address5            | The County           |
#		| PostCode            | NW11WN               |
#		| AlternativePostCode | NW22WN               |
#		| Longitude           | -98.50812            |
#		| Latitude            | 52.40121             |
#		| EffectiveFrom       |                      |
#		| EffectiveTo         |                      |
#	And I post an Address with the following details:
#		| Field               | Value                |
#		| Address1            | 2                    |
#		| Address2            | That Street          |
#		| Address3            | That Town            |
#		| Address4            | That Area            |
#		| Address5            | That County          |
#		| PostCode            | NW21WN               |
#		| AlternativePostCode | NW32WN               |
#		| Longitude           | -98.50812            |
#		| Latitude            | 52.40121             |
#		| EffectiveFrom       |                      |
#		| EffectiveTo         |                      |
#		| LastModifiedDate    | 2018-09-19T09:01:00Z |
#	When I get all Address records for a customer
#	Then there should be a 200 response
#	And the response should contain 2 document(s)
#	And the response body should incorporate a document with the following details:
#		| Field               | Value                |
#		| Address1            | 1                    |
#		| Address2            | The Street           |
#		| Address3            | The Town             |
#		| Address4            | The Area             |
#		| Address5            | The County           |
#		| PostCode            | NW11WN               |
#		| AlternativePostCode | NW22WN               |
#		| EffectiveFrom       |                      |
#		| EffectiveTo         |                      |
#	And the response body should incorporate a document with the following details:
#		| Field               | Value                |
#		| Address1            | 2                    |
#		| Address2            | That Street          |
#		| Address3            | That Town            |
#		| Address4            | That Area            |
#		| Address5            | That County          |
#		| PostCode            | NW21WN               |
#		| AlternativePostCode | NW32WN               |
#		| LastModifiedDate    | 2018-09-19T09:01:00Z |