
@postV2 @getV2

Feature: GetV2

@addresses @subcontractorId
	Scenario: Get Address by ID 
		Given I post a Customer with the following details:
		| Field                | Value                |
		| GivenName            | Bob                  |
		| FamilyName           | Customer             |
		And I post an Address with the following details:
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
		When I get an Address by ID
		Then there should be a 200 response
		And the response body should contain:
		| Field               | Value      |
		| Address1            | 1          |
		| Address2            | The Street |
		| Address3            | The Town   |
		| Address4            | The Area   |
		| Address5            | The County |
		| PostCode            | NW11WN     |
		| AlternativePostCode | NW22WN     |
		| Longitude           | -0.13426   |
		| Latitude            | 51.53494           |
		| EffectiveFrom       | 2018-06-19T09:01:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |
		| LastModifiedDate     | 2018-09-19T09:01:00Z |
		And the response body should contain the SubContractorId