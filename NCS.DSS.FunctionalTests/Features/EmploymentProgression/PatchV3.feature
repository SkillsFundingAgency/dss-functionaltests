﻿Feature: EmploymentProgressionPatchV3

Background:
	Given I post an adviser with the following details V2:
		| Field                | Value          |
		| AdviserName          | BillyAdviser   |
		| AdviserContactNumber | 98798678967967 |
	And I post a Customer with the following details V3:
		| Field          | Value    |
		| GivenName      | Bob      |
		| FamilyName     | Customer |
		| PriorityGroups | 1,3      |

@employmentprogressions   @smoke
Scenario:Patch Employment Progression with  all values
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 8                    |
		| EconomicShockStatus     | 2                    |
		| EconomicShockCode       | Some Text            |
		| EmployerName            | One Ltd              |
		| EmployerAddress         | 123 Peat Street      |
		| EmployerPostcode        | P01 9UX              |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        | 2019-01-23T00:00:00Z |
		| DateOfLastEmployment    | 2019-01-23T00:00:00Z |
		| LengthOfUnemployment    | 1                    |
	Given I patch the following EmploymentProgression V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-21T00:00:00Z |
		| CurrentEmploymentStatus | 1                    |
		| EconomicShockStatus     | 1                    |
		| EconomicShockCode       | Some Text2           |
		| EmployerName            | One Ltd2             |
		| EmployerAddress         | 124 Peat Street      |
		| EmployerPostcode        | DE22 4DE             |
		| EmploymentHours         | 2                    |
		| DateOfEmployment        | 2019-01-24T00:00:00Z |
		| DateOfLastEmployment    | 2019-01-25T00:00:00Z |
		| LengthOfUnemployment    | 2                    |
	Then there should be a 200 response
	#	And the response body should have <Field> with value <Value>
	And the response body should contain:
		| DateProgressionRecorded | 2019-08-21T00:00:00Z |
		| CurrentEmploymentStatus | 1                    |
		| EconomicShockStatus     | 1                    |
		| EconomicShockCode       | Some Text2           |
		| EmployerName            | One Ltd2             |
		| EmployerAddress         | 124 Peat Street      |
		| EmployerPostcode        | DE22 4DE             |
		| EmploymentHours         | 2                    |
		| DateOfEmployment        | 2019-01-24T00:00:00Z |
		| DateOfLastEmployment    | 2019-01-25T00:00:00Z |
		| LengthOfUnemployment    | 2                    |
	#And the "employmentprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 10 Seconds
	Then there should be a record in the dss-employmentprogressions table Ignoring '' with EmploymentProgressionId

#And the captured table data should include key "Longitude" with value "-1.50728"
#And the captured table data should include key "Latitude" with value "52.92878"
#And there should be a record in the employmentprogressions-history ChangeFeed table
#And the captured table data should include key "Longitude" with value "-1.50728"
#And the captured table data should include key "Latitude" with value "52.92878"
##########################################################################################################################################################################################
##	DateProgressionRecorded	DateTime	Y		ISO8601:2004.  <= datetime.now	Date the progression was recorded.  If the date and time is not supplied default this value to datetime.now().
##########################################################################################################################################################################################


@employmentprogressions
Scenario Outline: Patch Employment progression with invalid values for DateProgressionRecorded
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        |                      |
		| EconomicShockStatus     | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
	Given I want to send <Field> with value Translate Date To <Value>
	Given I patch the following EmploymentProgression V3:
		| Field                   | Value                |
	Then there should be a 422 response
	And the response body should include <ErrorMessage>

	Examples:
		| Field                   | Value                | ErrorMessage                                               |
		| DateProgressionRecorded | gtfr-06-19T09:01:00Z | Could not convert string to DateTime                       |
		| DateProgressionRecorded | 2018-00-19T09:01:00Z | Could not convert string to DateTime                       |
		| DateProgressionRecorded | 2018-13-19T09:01:00Z | Could not convert string to DateTime                       |
		| DateProgressionRecorded | 2018-05-00T09:01:00Z | Could not convert string to DateTime                       |
		| DateProgressionRecorded | 2018-05-32T09:01:00Z | Could not convert string to DateTime                       |
		| DateProgressionRecorded | Today +1D            | DateProgressionRecorded must be less than or equal to now. |
		| DateProgressionRecorded | Now +1H              | DateProgressionRecorded must be less than or equal to now. |
		| DateProgressionRecorded | Today +1Y            | DateProgressionRecorded must be less than or equal to now. |


##########################################################################################################################################################################################
##	CurrentEmploymentStatus	enum	Y		A valid EmploymentStatus reference data item	See DSS Reference Data Resource for values
##########################################################################################################################################################################################
@employmentprogressions
Scenario Outline: Patch Employment progression with invalid values for CurrentEmploymentStatus
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         | 1                    |
		| EconomicShockStatus     | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
	Given I want to send <Field> with value <Value> in the following request
	Given I patch the following EmploymentProgression V3:
		| Field                   | Value                |
	Then there should be a 422 response
	And the response body should include <ErrorMessage>

	Examples:
		| Field                   | Value | ErrorMessage                                                |
		| CurrentEmploymentStatus | -1    | CurrentEmploymentStatus must have a valid Employment Status |
		| CurrentEmploymentStatus | 0     | CurrentEmploymentStatus must have a valid Employment Status |
		| CurrentEmploymentStatus | 14    | CurrentEmploymentStatus must have a valid Employment Status |
		| CurrentEmploymentStatus | 98    | CurrentEmploymentStatus must have a valid Employment Status |
		| CurrentEmploymentStatus | 100   | CurrentEmploymentStatus must have a valid Employment Status |

@employmentprogressions
Scenario Outline: Patch Employment progression with CurrentEmploymentStatus in 1, 4, 5, 8, 9 where no value for EmploymentHours or DateOfEmployment  exists
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         |                      |
		| EconomicShockStatus     | 1                    |
		| DateOfEmployment        |                      |
	Given I want to send <Field> with value <Value> in the following request
	Given I patch the following EmploymentProgression V3:
		| Field                   | Value                |
	Then there should be a 422 response
	And the error message should be "EmploymentHours must have a value when CurrentEmploymentStatus is Apprenticeship, Employed, EmployedAndVoluntaryWork, RetiredAndVoluntaryWork or SelfEmployed"
	And the error message should be "DateOfEmployment must have a value when CurrentEmploymentStatus is Apprenticeship, Employed, EmployedAndVoluntaryWork, RetiredAndVoluntaryWork or SelfEmployed"
	And the number of errors returned should be 2

	Examples:
		| Field                   | Value |
		| CurrentEmploymentStatus | 1     |
		| CurrentEmploymentStatus | 4     |
		| CurrentEmploymentStatus | 5     |
		| CurrentEmploymentStatus | 8     |
		| CurrentEmploymentStatus | 9     |


##########################################################################################################################################################################################
##	EconomicShockStatus	enum	Y		A valid EconomicShockStatus reference data item	See DSS Reference Data Resource for values.
##########################################################################################################################################################################################
@employmentprogressions
Scenario Outline: Patch Employment progression with invalid values for EconomicShockStatus
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        |                      |
		| EconomicShockStatus     | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
	Given I want to send <Field> with value <Value> in the following request
	Given I patch the following EmploymentProgression V3:
		| Field                   | Value                |
	Then there should be a 422 response
	And the error message should be "EconomicShockStatus must have a valid Economic Shock Status"
	And the number of errors returned should be 1

	Examples:
		| Field               | Value |
		| EconomicShockStatus | -1    |
		| EconomicShockStatus | 0     |
		| EconomicShockStatus | 4     |
		| EconomicShockStatus | 98    |
		| EconomicShockStatus | 99    |

@employmentprogressions
Scenario: Patch Employment progression field EconomicShockStatus to value GovernmentDefinedShock where no value has been set for EconomicShockStatus
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         | 1                    |
		| EconomicShockStatus     | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
	Given I want to send <Field> with value <Value> in the following request
	Given I patch the following EmploymentProgression V3:
		| Field                   | Value                |
	Then there should be a 422 response
	And the response body should include EconomicShockCode must have a value when Government Defined Economic Shock

	Examples:
		| Field               | Value |
		| EconomicShockStatus | 2     |

##########################################################################################################################################################################################
##	EconomicShockCode	string(50)				Mandatory if EconomicShockStatus = 2 - Government defined economic shock
##########################################################################################################################################################################################
@employmentprogressions
Scenario Outline: Patch Employment progression with invalid values for EconomicShockCode
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        |                      |
		| EconomicShockStatus     | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
	Given I want to send <Field> with value <Value> in the following request
	Given I patch the following EmploymentProgression V3:
		| Field                   | Value                |
	Then there should be a 422 response
	And the error message should be "The field EconomicShockCode must be a string with a maximum length of 50"
	And the number of errors returned should be 1

	Examples:
		| Field             | Value                                               |
		| EconomicShockCode | 123456789012345678901234567890123456789012345678901 |

##########################################################################################################################################################################################
##	EmployerName	string(200)
##########################################################################################################################################################################################

@employmentprogressions
Scenario Outline: Patch Employment progression with invalid values for EmployerName
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        |                      |
		| EconomicShockStatus     | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
	Given I want to send <Field> with value <Value> in the following request
	Given I patch the following EmploymentProgression V3:
		| Field                   | Value                |
	Then there should be a 422 response
	And the error message should be "The field EmployerName must be a string with a maximum length of 200."
	And the number of errors returned should be 1

	Examples:
		| Field        | Value                                                                                                                                                                                                     |
		| EmployerName | 123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901 |

##########################################################################################################################################################################################
##	EmployerAddress	string(500)
##########################################################################################################################################################################################
@employmentprogressions
Scenario Outline: Patch Employment progression with invalid values for EmployerAddress
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        |                      |
		| EconomicShockStatus     | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
	Given I want to send <Field> with value <Value> in the following request
	Given I patch the following EmploymentProgression V3:
		| Field                   | Value                |
	Then there should be a 422 response
	And the error message should be "The field EmployerAddress must be a string with a maximum length of 500"
	And the number of errors returned should be 1

	Examples:
		| Field           | Value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
		| EmployerAddress | 1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901123456789012345678901234567890123456789012345678901 |

##########################################################################################################################################################################################
##	EmployerPostcode	string(10)
##########################################################################################################################################################################################
@employmentprogressions
Scenario Outline: Patch Employment progression with invalid values for EmployerPostcode
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         | 1                    |
		| EconomicShockStatus     | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
	Given I want to send <Field> with value <Value> in the following request
	Given I patch the following EmploymentProgression V3:
		| Field                   | Value                |
	Then there should be a 422 response
	And the response body should include <ErrorMessage>

	Examples:
		| Field            | Value     | ErrorMessage                  |
		| EmployerPostcode | DE22 4def | Please enter a valid postcode |

##########################################################################################################################################################################################
##	Longitude	double				These should be hidden fields and not returned in any GET request
##	Latitude	double
###########################################################################################################################################################################################
#Scenario: Patch Employment progression with valid values for Longitude and Latitude
#Scenario: Patch Employment progression with invalid values for Longitude and Latitude
#Scenario: Patch Employment progression with no value for Longitude and Latitude
#Scenario: Patch Employment progression with valid employer postcode supplied
##########################################################################################################################################################################################
##	EmploymentHours	enum			If CurrentEmployment status = 1, 4, 5, 8, 9 then the item must be a valid EmploymentHours reference data item	See DSS Reference Data Resource for values
##########################################################################################################################################################################################
@employmentprogressions
Scenario Outline: Patch Employment progression with invalid values for EmploymentHours
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EconomicShockStatus     | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
	Given I want to send <Field> with value <Value> in the following request
	Given I patch the following EmploymentProgression V3:
		| Field                   | Value                |
	Then there should be a 422 response
	And the response body should include <ErrorMessage>

	Examples:
		| Field           | Value | ErrorMessage                                     |
		| EmploymentHours | -1    | EmploymentHours must be a valid employment hours |
		| EmploymentHours | 0     | EmploymentHours must be a valid employment hours |
		| EmploymentHours | 97    | EmploymentHours must be a valid employment hours |
		| EmploymentHours | 100   | EmploymentHours must be a valid employment hours |

##########################################################################################################################################################################################
##	DateOfEmployment	If CurrentEmployment status = 1, 4, 5, 8, 9 then the item is mandatory, ISO8601:2004 <= datetime.now	The date the customer started employment.
##						See DSS Reference Data Resource for values
##########################################################################################################################################################################################
@employmentprogressions
Scenario Outline: Patch Employment progression with invalid values for DateOfEmployment
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EconomicShockStatus     | 1                    |
	Given I want to send <Field> with value Translate Date To <Value>
	Given I patch the following EmploymentProgression V3:
		| Field                   | Value                |
	Then there should be a 422 response
	And the response body should include <ErrorMessage>

	Examples:
		| Field            | Value     | ErrorMessage                                       |
		| DateOfEmployment | Today +1D | DateOfEmployment must be less than or equal to now |
		| DateOfEmployment | Now +1H   | DateOfEmployment must be less than or equal to now |

 

##########################################################################################################################################################################################
##	DateOfLastEmployment	Date			ISO8601:2004 <= datetime.now	The date the customer was last in employment if they are retired, economically inactive or unemployed.  This field has been left optional in case the customer has never been in employment.
##########################################################################################################################################################################################
@employmentprogressions
Scenario Outline: Patch Employment progression with invalid values for DateOfLastEmployment
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EconomicShockStatus     | 1                    |
	Given I want to send <Field> with value Translate Date To <Value>
	Given I patch the following EmploymentProgression V3:
		| Field                   | Value                |
	Then there should be a 422 response
	And the response body should include <ErrorMessage>

	Examples:
		| Field                | Value                | ErrorMessage                                           |
		| DateOfLastEmployment | 2018-13-19T09:01:00Z | Could not convert string to DateTime                   |
		| DateOfLastEmployment | Today +1D            | DateOfLastEmployment must be less than or equal to now |
		| DateOfLastEmployment | Now +1H              | DateOfLastEmployment must be less than or equal to now |

##########################################################################################################################################################################################
##	LengthOfUnemployment	enum			A valid LenghtOfUnemployment reference data item	See DSS Reference Data Resource for values
##########################################################################################################################################################################################
@employmentprogressions
Scenario Outline: Patch Employment progression with invalid values for LengthOfUnemployment
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EconomicShockStatus     | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
	Given I want to send <Field> with value <Value> in the following request
	Given I patch the following EmploymentProgression V3:
		| Field                   | Value                |
	Then there should be a 422 response
	And the response body should include <ErrorMessage>

	Examples:
		| Field                | Value | ErrorMessage                                           |
		| LengthOfUnemployment | -1    | Please supply a valid value for Length Of Unemployment |
		| LengthOfUnemployment | 0     | Please supply a valid value for Length Of Unemployment |
		| LengthOfUnemployment | 7     | Please supply a valid value for Length Of Unemployment |
		| LengthOfUnemployment | 97    | Please supply a valid value for Length Of Unemployment |
		| LengthOfUnemployment | 100   | Please supply a valid value for Length Of Unemployment |