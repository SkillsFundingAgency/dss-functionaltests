﻿Feature: AddressPatchV2

Background: Post Customer
	Given I post a Customer with the following details V3:
		| Field          | Value    |
		| GivenName      | Bob      |
		| FamilyName     | Customer |
		| PriorityGroups | 1,3      |

@addresses @smoke @subcontractorId
Scenario: Patch Address1 (V2)
	Given I post an Address with the following details V2:
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
	When I patch the following Address V2:
		| Field    | Value |
		| Address1 | 2     |
		| Address2 | Changed2 |
		| Address3 | Changed3 |
		| Address4 | Changed4 |
		| Address5 | Changed5 |
	Then there should be a 200 response
	And the response body should contain:
		| Field               | Value                |
		| Address1            | 2                    |
		| Address2		      | Changed2 |
		| Address3			  | Changed3 |
		| Address4			  | Changed4 |
		| Address5			  | Changed5 |
		| PostCode            | NW11WN               |
		| AlternativePostCode | NW22WN               |
		| Longitude           | -98.50812            |
		| Latitude            | 52.40121             |
		| EffectiveFrom       | 2018-06-19T09:01:00Z |
		| EffectiveTo         | 2018-06-21T13:12:00Z |
	Given I wait for 5 Seconds
	Then there should be a record in the dss-addresses table with AddressId



@addresses
Scenario: Patch PostCode (V2)
	Given I post an Address with the following details V2:
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
	When I patch the following Address V2:
		| Field    | Value  |
		| PostCode | NW22WW |
	Then there should be a 200 response
	And the response body should contain:
		| Field               | Value                |
		| Address1            | 1                    |
		| Address2            | The Street           |
		| Address3            | The Town             |
		| Address4            | The Area             |
		| Address5            | The County           |
		| PostCode            | NW22WW               |
		| AlternativePostCode | NW22WN               |
		| Longitude           | -98.50812            |
		| Latitude            | 52.40121             |
		| EffectiveFrom       | 2018-06-19T09:01:00Z |
		| EffectiveTo         | 2018-06-21T13:12:00Z |

@addresses
Scenario: Patch AlternativePostCode (V2)
	Given I post an Address with the following details V2:
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
	When I patch the following Address V2:
		| Field               | Value  |
		| AlternativePostCode | NW22WW |
	Then there should be a 200 response
	And the response body should contain:
		| Field               | Value                |
		| Address1            | 1                    |
		| Address2            | The Street           |
		| Address3            | The Town             |
		| Address4            | The Area             |
		| Address5            | The County           |
		| PostCode            | NW11WN               |
		| AlternativePostCode | NW22WW               |
		| Longitude           | -98.50812            |
		| Latitude            | 52.40121             |
		| EffectiveFrom       | 2018-06-19T09:01:00Z |
		| EffectiveTo         | 2018-06-21T13:12:00Z |

@addresses
Scenario: Patch Longitude (V2)
	Given I post an Address with the following details V2:
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
	When I patch the following Address V2:
		| Field     | Value     |
		| Longitude | -98.50813 |
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
		| Longitude           | -98.50813            |
		| Latitude            | 52.40121             |
		| EffectiveFrom       | 2018-06-19T09:01:00Z |
		| EffectiveTo         | 2018-06-21T13:12:00Z |

@addresses
Scenario: Patch Latitude (V2)
	Given I post an Address with the following details V2:
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
	When I patch the following Address V2:
		| Field    | Value    |
		| Latitude | 52.40122 |
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
		| Latitude            | 52.40122             |
		| EffectiveFrom       | 2018-06-19T09:01:00Z |
		| EffectiveTo         | 2018-06-21T13:12:00Z |

@addresses
Scenario: Patch EffectiveFrom (V2)
	Given I post an Address with the following details V2:
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
	When I patch the following Address V2:
		| Field         | Value                |
		| EffectiveFrom | 2018-06-19T09:02:00Z |
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
		| EffectiveFrom       | 2018-06-19T09:02:00Z |
		| EffectiveTo         | 2018-06-21T13:12:00Z |

@addresses
Scenario: Patch EffectiveTo (V2)
	Given I post an Address with the following details V2:
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
	When  I patch the following Address V2:
		| Field       | Value                |
		| EffectiveTo | 2018-06-21T13:13:00Z |
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
		| EffectiveTo         | 2018-06-21T13:13:00Z |
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-addresses table with AddressId