
@patchV1
@postV1

Feature: Patch


	Background: Post Customer
	Given I post a Customer with the following details:
		| Field                | Value                |
		| GivenName            | Bob                  |
		| FamilyName           | Customer             |

@addresses
	Scenario: Patch Address1
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
		When I patch the following:
		| Field                | Value                |
		| Address1			   | 2                    |
		Then there should be a 200 response
		And the response body should contain:
		| Field                | Value                |
		| Address1             | 2                    |
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

@addresses
	Scenario: Patch Address2
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
	  When I patch the following:
		| Field                | Value                |
		| Address2			   | Changed              |
		Then there should be a 200 response
		And the response body should contain:
		| Field                | Value                |
		| Address1             | 1                    |
		| Address2             | Changed              |
		| Address3             | The Town             |
		| Address4             | The Area             |
		| Address5             | The County           |
		| PostCode             | NW11WN               |
		| AlternativePostCode  | NW22WN               |
		| Longitude            | -98.50812            |
		| Latitude             | 52.40121             |
		| EffectiveFrom        | 2018-06-19T09:01:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |

@addresses
	Scenario: Patch Address3
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
	  When I patch the following:
		| Field                | Value                |
		| Address3			   | Changed              |
		Then there should be a 200 response
		And the response body should contain:
		| Field                | Value                |
		| Address1             | 1                    |
		| Address2             | The Street           |
		| Address3			   | Changed              |
		| Address4             | The Area             |
		| Address5             | The County           |
		| PostCode             | NW11WN               |
		| AlternativePostCode  | NW22WN               |
		| Longitude            | -98.50812            |
		| Latitude             | 52.40121             |
		| EffectiveFrom        | 2018-06-19T09:01:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |

@addresses
	Scenario: Patch Address4
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
	  When I patch the following:
		| Field                | Value                |
		| Address4			   | Changed              |
		Then there should be a 200 response
		And the response body should contain:
		| Field                | Value                |
		| Address1             | 1                    |
		| Address2             | The Street           |
		| Address3             | The Town             |
		| Address4			   | Changed              |
		| Address5             | The County           |
		| PostCode             | NW11WN               |
		| AlternativePostCode  | NW22WN               |
		| Longitude            | -98.50812            |
		| Latitude             | 52.40121             |
		| EffectiveFrom        | 2018-06-19T09:01:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |

@addresses
	Scenario: Patch Address5
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
	  When I patch the following:
		| Field                | Value                |
		| Address5			   | Changed              |
		Then there should be a 200 response
		And the response body should contain:
		| Field                | Value                |
		| Address1             | 1                    |
		| Address2             | The Street           |
		| Address3             | The Town             |
		| Address4             | The Area             |
		| Address5			   | Changed              |
		| PostCode             | NW11WN               |
		| AlternativePostCode  | NW22WN               |
		| Longitude            | -98.50812            |
		| Latitude             | 52.40121             |
		| EffectiveFrom        | 2018-06-19T09:01:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |

@addresses
	Scenario: Patch PostCode
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
	  When I patch the following:
		| Field                | Value                |
		| PostCode             | NW11WW               |
		Then there should be a 200 response
		And the response body should contain:
		| Field                | Value                |
		| Address1             | 1                    |
		| Address2             | The Street           |
		| Address3             | The Town             |
		| Address4             | The Area             |
		| Address5             | The County           |
		| PostCode             | NW11WW               |
		| AlternativePostCode  | NW22WN               |
		| Longitude            | -98.50812            |
		| Latitude             | 52.40121             |
		| EffectiveFrom        | 2018-06-19T09:01:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |

@addresses
	Scenario: Patch AlternativePostCode
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
	  When I patch the following:
		| Field                | Value                |
		| AlternativePostCode  | NW22WW               |
		Then there should be a 200 response
		And the response body should contain:
		| Field                | Value                |
		| Address1             | 1                    |
		| Address2             | The Street           |
		| Address3             | The Town             |
		| Address4             | The Area             |
		| Address5             | The County           |
		| PostCode             | NW11WN               |
		| AlternativePostCode  | NW22WW               |
		| Longitude            | -98.50812            |
		| Latitude             | 52.40121             |
		| EffectiveFrom        | 2018-06-19T09:01:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |

@addresses
	Scenario: Patch Longitude
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
	  When I patch the following:
		| Field                | Value                |
		| Longitude            | -98.50813            |
		Then there should be a 200 response
		And the response body should contain:
		| Field                | Value                |
		| Address1             | 1                    |
		| Address2             | The Street           |
		| Address3             | The Town             |
		| Address4             | The Area             |
		| Address5             | The County           |
		| PostCode             | NW11WN               |
		| AlternativePostCode  | NW22WN               |
		| Longitude            | -98.50813            |
		| Latitude             | 52.40121             |
		| EffectiveFrom        | 2018-06-19T09:01:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |

@addresses
	Scenario: Patch Latitude
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
	  When I patch the following:
		| Field                | Value                |
		| Latitude             | 52.40122             |
		Then there should be a 200 response
		And the response body should contain:
		| Field                | Value                |
		| Address1             | 1                    |
		| Address2             | The Street           |
		| Address3             | The Town             |
		| Address4             | The Area             |
		| Address5             | The County           |
		| PostCode             | NW11WN               |
		| AlternativePostCode  | NW22WN               |
		| Longitude            | -98.50812            |
		| Latitude             | 52.40122             |
		| EffectiveFrom        | 2018-06-19T09:01:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |

@addresses
	Scenario: Patch EffectiveFrom
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
	  When I patch the following:
		| Field                | Value                |
		| EffectiveFrom        | 2018-06-19T09:02:00Z |
		Then there should be a 200 response
		And the response body should contain:
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
		| EffectiveFrom        | 2018-06-19T09:02:00Z |
		| EffectiveTo          | 2018-06-21T13:12:00Z |

@addresses
	Scenario: Patch EffectiveTo
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
	  When I patch the following:
		| Field                | Value                |
		| EffectiveTo          | 2018-06-21T13:13:00Z |
		Then there should be a 200 response
		And the response body should contain:
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
		| EffectiveTo          | 2018-06-21T13:13:00Z |

