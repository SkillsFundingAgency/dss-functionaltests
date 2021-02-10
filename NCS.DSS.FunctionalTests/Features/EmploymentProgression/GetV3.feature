Feature: EmploymentProgressionGetV3

Background: Create Adviser
	Given I post an adviser with the following details:
		| Field                | Value          |
		| AdviserName          | BillyAdviser   |
		| AdviserContactNumber | 98798678967967 |
	And I post a Customer with the following details:
		| Field      | Value    |
		| GivenName  | Bob      |
		| FamilyName | Customer |

@employmentprogressions  @Smoke
Scenario:Get Employment Progression by ID
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-25T11:21:00Z |
		| CurrentEmploymentStatus | 1                    |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        | 2019-06-25T11:21:00Z |
		| LengthOfUnemployment    | 1                    |
		| DateOfLastEmployment    | 2019-06-25T11:21:00Z |
		| EconomicShockStatus     | 1                    |
		| EconomicShockCode       | Some text            |
		| EmployerName            | Emp Smith            |
		| EmployerAddress         | 123 Pete Street      |
		| EmployerPostcode        | PE12 3ST             |
	When I get a Employment Progression by ID V3
	Then there should be a 200 response
	And the response body should contain:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-25T11:21:00Z |
		| CurrentEmploymentStatus | 1                    |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        | 2019-06-25T11:21:00Z |
		| LengthOfUnemployment    | 1                    |
		| DateOfLastEmployment    | 2019-06-25T11:21:00Z |
		| EconomicShockStatus     | 1                    |
		| EconomicShockCode       | Some text            |
		| EmployerName            | Emp Smith            |
		| EmployerAddress         | 123 Pete Street      |
		| EmployerPostcode        | PE12 3ST             |

@employmentprogressions
Scenario:Get All Employment Progression records where 1 exists
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-25T11:21:00Z |
		| CurrentEmploymentStatus | 1                    |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        | 2019-06-25T11:21:00Z |
		| LengthOfUnemployment    | 1                    |
		| DateOfLastEmployment    | 2019-06-25T11:21:00Z |
		| EconomicShockStatus     | 1                    |
		| EconomicShockCode       | Some text            |
		| EmployerName            | Emp Smith            |
		| EmployerAddress         | 123 Pete Street      |
		| EmployerPostcode        | PE12 3ST             |
	When I get all Employment Progression records for a customer V3
	Then there should be a 200 response
	#And the response should contain 1 document(s)
	#And the response body should incorporate a document with the following details:
		#| Field                   | Value                |
		#| DateProgressionRecorded | 2018-06-25T11:21:00Z |
		#| CurrentEmploymentStatus | 1                    |
		#| EmploymentHours         | 1                    |
		#| DateOfEmployment        | 2019-06-25T11:21:00Z |
		#| LengthOfUnemployment    | 1                    |
		#| DateOfLastEmployment    | 2019-06-25T11:21:00Z |
		#| EconomicShockStatus     | 1                    |
		#| EconomicShockCode       | Some text            |
		#| EmployerName            | Emp Smith            |
		#| EmployerAddress         | 123 Pete Street      |
		#| EmployerPostcode        | PE12 3ST             |

@employmentprogressions
Scenario:Get Employment Progression by invalid ID
	Given I post a Employment Progression record with the following details V3:
		| Field                          | Value                |
		| DateProgressionRecorded        | 2018-06-25T11:21:00Z |
		| CurrentEmploymentStatus        | 1                    |
		| EmploymentHours                | 1                    |
		| DateEmploymentStarted          | 2019-06-25T11:21:00Z |
		| CurrentQualificationLevel      | 2                    |
		| DateQualificationLevelAchieved | 2019-07-25T11:21:00Z |
		| LastEmploymentProvidersUKPRN   | 12345678             |
	And I post a Customer with the following details:
		| Field      | Value    |
		| GivenName  | Bob      |
		| FamilyName | Customer |
	When I get a Employment Progression by ID V3
	Then there should be a 204 response
