﻿Feature: EmploymentProgressionPostV3

Background: Create Adviser
	Given I post an adviser with the following details V2:
		| Field                | Value          |
		| AdviserName          | BillyAdviser   |
		| AdviserContactNumber | 98798678967967 |
	And I post a Customer with the following details V3:
		| Field          | Value    |
		| GivenName      | Bob      |
		| FamilyName     | Customer |
		| PriorityGroups | 1,3      |

@employmentprogressions  @smoke
Scenario:Post employment progression with all values
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
	Then there should be a 201 response
	And the response body should contain:
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
	#And the "employmentprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 10 Seconds
	Then there should be a record in the dss-employmentprogressions table with EmploymentProgressionId

#And there should be a record in the employmentprogressions-history ChangeFeed table
@employmentprogressions
Scenario:Post employment progression with mandatory values
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 10                   |
		| EconomicShockStatus     | 1                    |
	Then there should be a 201 response
	And the response body should contain:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 10                   |
		| EconomicShockStatus     | 1                    |
	#And the "employmentprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-employmentprogressions table with EmploymentProgressionId

#And there should be a record in the employmentprogressions-history ChangeFeed table
@employmentprogressions
Scenario Outline: Post Employment progression with valid values for DateProgressionRecorded
	Given I want to send <Field> with value Translate Date To <Value>
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value |
		| CurrentEmploymentStatus | 99    |
		| EconomicShockStatus     | 1     |
	Then there should be a 201 response
	And the response body should contain:
		| Field                   | Value |
		| CurrentEmploymentStatus | 99    |
	#And the response body value for DateProgressionRecorded should match the last request
	#And the "employmentprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-employmentprogressions table with EmploymentProgressionId

	#And there should be a record in the employmentprogressions-history ChangeFeed table
	Examples:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| DateProgressionRecorded | Today                |
		| DateProgressionRecorded | Now -1H              |

@employmentprogressions
Scenario Outline: Post Employment progression with invalid values for DateProgressionRecorded
	Given I want to send <Field> with value <Value> in the following request
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EconomicShockStatus     | 1                    |
	Then there should be a 422 response
	And the response body should include <ErrorMessage>

	Examples:
		| Field                   | Value                | ErrorMessage                         |
		| DateProgressionRecorded | 2018-00-19T09:01:00Z | Could not convert string to DateTime |
		| DateProgressionRecorded | 2018-13-19T09:01:00Z | Could not convert string to DateTime |
		| DateProgressionRecorded | 2018-05-00T09:01:00Z | Could not convert string to DateTime |
		| DateProgressionRecorded | 2018-05-32T09:01:00Z | Could not convert string to DateTime |

@employmentprogressions
Scenario Outline: Post Employment progression with future value for DateProgressionRecorded
	Given I want to send <Field> with value Translate Date To <Value>
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value |
		| CurrentEmploymentStatus | 99    |
		| EconomicShockStatus     | 1     |
	Then there should be a 422 response
	And the response body should include <ErrorMessage>

	Examples:
		| Field                   | Value     | ErrorMessage                                              |
		| DateProgressionRecorded | Today +1D | DateProgressionRecorded must be less than or equal to now |
		| DateProgressionRecorded | Now +1H   | DateProgressionRecorded must be less than or equal to now |

#@employmentprogressions
#Scenario: Post Employment progression with no value for DateProgressionRecorded
#	Given I post a Employment Progression record with the following details V3:
#		| Field                   | Value |
#		| DateProgressionRecorded |       |
#		| CurrentEmploymentStatus | 99    |
#		| EconomicShockStatus     | 1     |
#	Then there should be a 201 response
#	And the date field DateProgressionRecorded should hold a recent value
#
###########################################################################################################################################
##	CurrentEmploymentStatus	enum	Y		A valid EmploymentStatus reference data item	See DSS Reference Data Resource for values  ##
###########################################################################################################################################
@employmentprogressions
Scenario Outline: Post Employment progression with valid values for CurrentEmploymentStatus
	Given I want to send <Field> with value <Value> in the following request
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
		| EconomicShockStatus     | 1                    |
	Then there should be a 201 response
	And the response body should contain:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
	#And the "employmentprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-employmentprogressions table with EmploymentProgressionId

	#And there should be a record in the employmentprogressions-history ChangeFeed table
	Examples:
		| Field                   | Value |
		| CurrentEmploymentStatus | 1     |
		| CurrentEmploymentStatus | 2     |
		| CurrentEmploymentStatus | 3     |
		| CurrentEmploymentStatus | 4     |
		| CurrentEmploymentStatus | 5     |
		| CurrentEmploymentStatus | 6     |
		| CurrentEmploymentStatus | 7     |
		| CurrentEmploymentStatus | 8     |
		| CurrentEmploymentStatus | 9     |
		| CurrentEmploymentStatus | 10    |
		| CurrentEmploymentStatus | 11    |
		| CurrentEmploymentStatus | 12    |
		| CurrentEmploymentStatus | 13    |
		| CurrentEmploymentStatus | 99    |

@employmentprogressions
Scenario Outline: Post Employment progression with invalid values for CurrentEmploymentStatus
	Given I want to send <Field> with value <Value> in the following request
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| EconomicShockStatus     | 1                    |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
	Then there should be a 422 response
	And the error message should be "CurrentEmploymentStatus must have a valid Employment Status"
	And the number of errors returned should be 1

	Examples:
		| Field                   | Value |
		| CurrentEmploymentStatus | -1    |
		| CurrentEmploymentStatus | 14    |
		| CurrentEmploymentStatus | 98    |
		| CurrentEmploymentStatus | 100   |

@employmentprogressions
Scenario: Post Employment progression with no value for CurrentEmploymentStatus
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| EconomicShockStatus     | 1                    |
		| CurrentEmploymentStatus |                      |
	Then there should be a 422 response
	And the error message should be "The CurrentEmploymentStatus field is required"
	And the number of errors returned should be 1

######################################################################################################################################
#	EconomicShockStatus	enum	Y		A valid EconomicShockStatus reference data item	See DSS Reference Data Resource for values. ##
######################################################################################################################################
@employmentprogressions
Scenario Outline: Post Employment progression with invalid values for EconomicShockStatus
	Given I want to send <Field> with value <Value> in the following request
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EconomicShockCode       | Some Text            |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
	Then there should be a 422 response
	And the error message should be "EconomicShockStatus must have a valid Economic Shock Status."

	Examples:
		| Field               | Value |
		| EconomicShockStatus | -1    |
		| EconomicShockStatus | 0     |
		| EconomicShockStatus | 4     |
		| EconomicShockStatus | 99    |

#@employmentprogressions
#Scenario: Post Employment progression with no value for EconomicShockStatus
@employmentprogressions
Scenario Outline: Post Employment progression with valid values for EconomicShockStatus
	Given I want to send <Field> with value <Value> in the following request
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EconomicShockCode       | Some Text            |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
	Then there should be a 201 response
	And the response body should contain:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
	And the response body should have <Field> with value <Value>
	#And the "employmentprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-employmentprogressions table with EmploymentProgressionId

	#And there should be a record in the employmentprogressions-history ChangeFeed table
	Examples:
		| Field               | Value |
		| EconomicShockStatus | 1     |
		| EconomicShockStatus | 2     |
		| EconomicShockStatus | 3     |

############################################################################################################################
#	EconomicShockCode	string(50)				Mandatory if EconomicShockStatus = 2 - Government defined economic shock  ##
############################################################################################################################
@employmentprogressions
Scenario Outline: Post Employment progression with valid values for EconomicShockCode
	Given I want to send <Field> with value <Value> in the following request
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
		| EconomicShockStatus     | 1                    |
	Then there should be a 201 response
	And the response body should contain:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
	And the response body should have <Field> with value <Value>
	#And the "employmentprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-employmentprogressions table with EmploymentProgressionId

	#And there should be a record in the employmentprogressions-history ChangeFeed table
	Examples:
		| Field             | Value                                              |
		| EconomicShockCode | Some Text                                          |
		| EconomicShockCode | 12345678901234567890123456789012345678901234567890 |

@employmentprogressions
Scenario Outline: Post Employment progression with invalid values for EconomicShockCode
	Given I want to send <Field> with value <Value> in the following request
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| CurrentEmploymentStatus | 99                   |
		| CurrentEmploymentStatus | 1                    |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
		| EconomicShockStatus     | 1                    |
	Then there should be a 422 response
	And the error message should be "The field EconomicShockCode must be a string with a maximum length of 50"

	Examples:
		| Field             | Value                                               |
		| EconomicShockCode | 123456789012345678901234567890123456789012345678901 |

@employmentprogressions
Scenario: Post Employment progression with no value for EconomicShockCode where EconomicShockStatus is 2 - Government defined economic shock
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
		| EconomicShockStatus     | 2                    |
		| EconomicShockCode       |                      |
	Then there should be a 422 response
	And the error message should be "EconomicShockCode must have a value when Government Defined Economic Shock."
	And the number of errors returned should be 1

@employmentprogressions
Scenario Outline: Post Employment progression with no value for EconomicShockCode where EconomicShockStatus is not 2 - Government defined economic shock
	Given I want to send <Field> with value <Value> in the following request
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
		| EconomicShockCode       | Some Text            |
	Then there should be a 201 response
	And the response body should contain:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
		| EconomicShockCode       | Some Text            |
	#And the "employmentprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-employmentprogressions table with EmploymentProgressionId

	#And there should be a record in the employmentprogressions-history ChangeFeed table
	Examples:
		| Field               | Value |
		| EconomicShockStatus | 1     |
		| EconomicShockStatus | 3     |

#############################################################################################################################################
##	EmployerName	string(200)																											   ##
#############################################################################################################################################
@employmentprogressions
Scenario Outline: Post Employment progression with valid values for EmployerName
	Given I want to send <Field> with value <Value> in the following request
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
		| EconomicShockStatus     | 1                    |
	Then there should be a 201 response
	And the response body should contain:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
	And the response body should have <Field> with value <Value>
	#And the "employmentprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-employmentprogressions table with EmploymentProgressionId

	#And there should be a record in the employmentprogressions-history ChangeFeed table
	Examples:
		| Field        | Value                                                                                                                                                                                                    |
		| EmployerName | Some Value                                                                                                                                                                                               |
		| EmployerName | 12345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890 |

@employmentprogressions
Scenario Outline: Post Employment progression with invalid values for EmployerName
	Given I want to send <Field> with value <Value> in the following request
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
		| EconomicShockStatus     | 1                    |
	Then there should be a 422 response
	And the error message should be "The field EmployerName must be a string with a maximum length of 200"
	And the number of errors returned should be 1

	Examples:
		| Field        | Value                                                                                                                                                                                                     |
		| EmployerName | 123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901 |

@employmentprogressions
Scenario: Post Employment progression with no value for EmployerName
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
		| EconomicShockStatus     | 1                    |
		| EmployerName            |                      |
	Then there should be a 201 response
	And the response body should contain:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmployerName            |                      |
	#And the "employmentprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"

#And there should be a record in the employmentprogressions ChangeFeed table
#And there should be a record in the employmentprogressions-history ChangeFeed table
############################################################################################################################
##	EmployerAddress	string(500)																							  ##
############################################################################################################################
@employmentprogressions
Scenario Outline: Post Employment progression with valid values for EmployerAddress
	Given I want to send <Field> with value <Value> in the following request
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
		| EconomicShockStatus     | 1                    |
	Then there should be a 201 response
	And the response body should contain:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
	And the response body should have <Field> with value <Value>
	#And the "employmentprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-employmentprogressions table with EmploymentProgressionId

	#And there should be a record in the employmentprogressions-history ChangeFeed table
	Examples:
		| Field           | Value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
		| EmployerAddress | Some Value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
		| EmployerAddress | 12345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890 |

@employmentprogressions
Scenario Outline: Post Employment progression with invalid values for EmployerAddress
	Given I want to send <Field> with value <Value> in the following request
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
		| EconomicShockStatus     | 1                    |
	Then there should be a 422 response
	And the error message should be "The field EmployerAddress must be a string with a maximum length of 500"
	And the number of errors returned should be 1

	Examples:
		| Field           | Value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
		| EmployerAddress | 123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901 |

@employmentprogressions
Scenario: Post Employment progression with no value for EmployerAddress
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
		| EconomicShockStatus     | 1                    |
		| EmployerAddress         |                      |
	Then there should be a 201 response
	And the response body should contain:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmployerAddress         |                      |
	#And the "employmentprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-employmentprogressions table with EmploymentProgressionId

#And there should be a record in the employmentprogressions-history ChangeFeed table
#############################################################################################################
#	EmployerPostcode	string(10)
#############################################################################################################
@employmentprogressions
Scenario Outline: Post Employment progression with valid values for EmployerPostcode
	Given I want to send <Field> with value <Value> in the following request
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
		| EconomicShockStatus     | 1                    |
	Then there should be a 201 response
	And the response body should contain:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
	And the response body should have <Field> with value <Value>
	#And the "employmentprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-employmentprogressions table Ignoring '' with EmploymentProgressionId

	#And the captured table data should include key "Longitude" with value "-1.50728"
	#And the captured table data should include key "Latitude" with value "52.92878"
	#And there should be a record in the employmentprogressions-history ChangeFeed table
	#And the captured table data should include key "Longitude" with value "-1.50728"
	#And the captured table data should include key "Latitude" with value "52.92878"
	Examples:
		| Field            | Value    |
		| EmployerPostcode | DE22 4DE |
		| EmployerPostcode | DE224DE  |

@employmentprogressions
Scenario Outline: Post Employment progression with invalid values for EmployerPostcode
	Given I want to send <Field> with value <Value> in the following request
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
		| EconomicShockStatus     | 1                    |
	Then there should be a 422 response
	And the error message should be "Please enter a valid postcode"
	And the number of errors returned should be 1

	Examples:
		| Field            | Value     |
		| EmployerPostcode | DE22 4def |

@employmentprogressions
Scenario: Post Employment progression with no value for EmployerPostcode
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
		| EconomicShockStatus     | 1                    |
		| EmployerPostcode        |                      |
	Then there should be a 201 response
	And the response body should contain:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmployerPostcode        |                      |
	#And the "employmentprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-employmentprogressions table with EmploymentProgressionId

#And there should be a record in the employmentprogressions-history ChangeFeed table
@employmentprogressions
Scenario Outline: Post Employment progression with valid values for EmploymentHours
	Given I want to send <Field> with value <Value> in the following request
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EconomicShockStatus     | 1                    |
	Then there should be a 201 response
	And the response body should contain:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
	And the response body should have <Field> with value <Value>
	#And the "employmentprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-employmentprogressions table with EmploymentProgressionId

	#And there should be a record in the employmentprogressions-history ChangeFeed table
	Examples:
		| Field           | Value |
		| EmploymentHours | 1     |
		| EmploymentHours | 2     |
		| EmploymentHours | 98    |
		| EmploymentHours | 99    |

@employmentprogressions
Scenario Outline: Post Employment progression with invalid values for EmploymentHours
	Given I want to send <Field> with value <Value> in the following request
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| EconomicShockStatus     | 1                    |
		| CurrentEmploymentStatus | 99                   |
	Then there should be a 422 response
	And the error message should be "EmploymentHours must be a valid employment hours"
	And the number of errors returned should be 1

	Examples:
		| Field           | Value |
		| EmploymentHours | 0     |
		| EmploymentHours | -1    |
		| EmploymentHours | 3     |
		| EmploymentHours | 97    |
		| EmploymentHours | 100   |

@employmentprogressions
Scenario Outline: Post Employment progression with no value for EmploymentHours and CurrentEmploymentStatus in 1, 4, 5, 8, 9
	Given I want to send <Field> with value <Value> in the following request
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         |                      |
		| EconomicShockStatus     | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
	Then there should be a 422 response
	And the error message should be "EmploymentHours must have a value when CurrentEmploymentStatus is Apprenticeship, Employed, EmployedAndVoluntaryWork, RetiredAndVoluntaryWork or SelfEmployed."
	And the number of errors returned should be 1

	Examples:
		| Field                   | Value |
		| CurrentEmploymentStatus | 1     |
		| CurrentEmploymentStatus | 4     |
		| CurrentEmploymentStatus | 5     |
		| CurrentEmploymentStatus | 8     |
		| CurrentEmploymentStatus | 9     |

@employmentprogressions
Scenario Outline: Post Employment progression with no value for EmploymentHours and CurrentEmploymentStatus not in 1, 4, 5, 8, 9
	Given I want to send <Field> with value <Value> in the following request
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| EmploymentHours         |                      |
		| EconomicShockStatus     | 1                    |
	Then there should be a 201 response
	And the response body should contain:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| EmploymentHours         |                      |
		| EconomicShockStatus     | 1                    |
	And the response body should have <Field> with value <Value>
	#And the "employmentprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-employmentprogressions table with EmploymentProgressionId

	#And there should be a record in the employmentprogressions-history ChangeFeed table
	Examples:
		| Field                   | Value |
		| CurrentEmploymentStatus | 2     |
		| CurrentEmploymentStatus | 3     |
		| CurrentEmploymentStatus | 6     |
		| CurrentEmploymentStatus | 7     |
		| CurrentEmploymentStatus | 10    |
		| CurrentEmploymentStatus | 11    |
		| CurrentEmploymentStatus | 12    |
		| CurrentEmploymentStatus | 13    |
		| CurrentEmploymentStatus | 99    |

@employmentprogressions
Scenario Outline: Post Employment progression with valid values for DateOfEmployment
	Given I want to send <Field> with value Translate Date To <Value>
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EconomicShockStatus     | 1                    |
	Then there should be a 201 response
	And the response body should contain:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
	#And the response body value for DateOfLastEmployment should match the last request
	#And the "employmentprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-employmentprogressions table with EmploymentProgressionId

	#And there should be a record in the employmentprogressions-history ChangeFeed table
	Examples:
		| Field            | Value                |
		| DateOfEmployment | Today                |
		| DateOfEmployment | Now                  |
		| DateOfEmployment | 2019-08-20T00:00:00Z |

@employmentprogressions
Scenario Outline: Post Employment progression with invalid values for DateOfEmployment
	Given I want to send <Field> with value Translate Date To <Value>
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| EconomicShockStatus     | 1                    |
		| CurrentEmploymentStatus | 99                   |
	Then there should be a 422 response
	And the response body should include <ErrorMessage>
	And the number of errors returned should be 1

	Examples:
		| Field            | Value      | ErrorMessage                                       |
		| DateOfEmployment | Today +1D  | DateOfEmployment must be less than or equal to now |
		| DateOfEmployment | Now +1H    | DateOfEmployment must be less than or equal to now |
		| DateOfEmployment | 2019-13-01 | Could not convert string to DateTime               |

@employmentprogressions
Scenario Outline: Post Employment progression with no value for DateOfEmployment and CurrentEmploymentStatus not in 1, 4, 5, 8, 9
	Given I want to send <Field> with value <Value> in the following request
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| DateOfEmployment        |                      |
		| EconomicShockStatus     | 1                    |
	Then there should be a 201 response
	And the response body should contain:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| DateOfEmployment        |                      |
		| EconomicShockStatus     | 1                    |
	And the response body should have <Field> with value <Value>
	#And the "employmentprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-employmentprogressions table with EmploymentProgressionId

	#And there should be a record in the employmentprogressions-history ChangeFeed table
	Examples:
		| Field                   | Value |
		| CurrentEmploymentStatus | 2     |
		| CurrentEmploymentStatus | 3     |
		| CurrentEmploymentStatus | 6     |
		| CurrentEmploymentStatus | 7     |
		| CurrentEmploymentStatus | 10    |
		| CurrentEmploymentStatus | 11    |
		| CurrentEmploymentStatus | 12    |
		| CurrentEmploymentStatus | 13    |
		| CurrentEmploymentStatus | 99    |

@employmentprogressions
Scenario Outline: Post Employment progression with no value for DateOfEmployment and CurrentEmploymentStatus in 1, 4, 5, 8, 9
	Given I want to send <Field> with value <Value> in the following request
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        |                      |
		| EconomicShockStatus     | 1                    |
	Then there should be a 422 response
	And the error message should be "DateOfEmployment must have a value when CurrentEmploymentStatus is Apprenticeship, Employed, EmployedAndVoluntaryWork, RetiredAndVoluntaryWork or SelfEmployed."
	And the number of errors returned should be 1

	Examples:
		| Field                   | Value |
		| CurrentEmploymentStatus | 1     |
		| CurrentEmploymentStatus | 4     |
		| CurrentEmploymentStatus | 5     |
		| CurrentEmploymentStatus | 8     |
		| CurrentEmploymentStatus | 9     |

@employmentprogressions
Scenario Outline: Post Employment progression with valid values for DateOfLastEmployment
	Given I want to send <Field> with value Translate Date To <Value>
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EconomicShockStatus     | 1                    |
	Then there should be a 201 response
	And the response body should contain:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
	#And the response body value for DateOfLastEmployment should match the last request
	#And the "employmentprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-employmentprogressions table with EmploymentProgressionId

	#And there should be a record in the employmentprogressions-history ChangeFeed table
	Examples:
		| Field                | Value                |
		| DateOfLastEmployment | Today                |
		| DateOfLastEmployment | Now                  |
		| DateOfLastEmployment | 2019-08-20T00:00:00Z |
		| DateOfLastEmployment |                      |

@employmentprogressions
Scenario Outline: Post Employment progression with invalid values for DateOfLastEmployment
	Given I want to send <Field> with value Translate Date To <Value>
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EconomicShockStatus     | 1                    |
	Then there should be a 422 response
	And the response body should include <ErrorMessage>

	Examples:
		| Field                | Value                | ErrorMessage                                            |
		| DateOfLastEmployment | 2018-00-19T09:01:00Z | Could not convert string to DateTime                    |
		| DateOfLastEmployment | 2018-13-19T09:01:00Z | Could not convert string to DateTime                    |
		| DateOfLastEmployment | 2018-05-00T09:01:00Z | Could not convert string to DateTime                    |
		| DateOfLastEmployment | 2018-05-32T09:01:00Z | Could not convert string to DateTime                    |
		| DateOfLastEmployment | Today +1D            | DateOfLastEmployment must be less than or equal to now. |
		| DateOfLastEmployment | Now +1H              | DateOfLastEmployment must be less than or equal to now. |

@employmentprogressions
Scenario Outline: Post Employment progression with valid values for LengthOfUnemployment
	Given I want to send <Field> with value <Value> in the following request
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EconomicShockStatus     | 1                    |
	Then there should be a 201 response
	And the response body should contain:
		| Field                   | Value                |
		| DateProgressionRecorded | 2019-08-20T00:00:00Z |
		| CurrentEmploymentStatus | 99                   |
	And the response body should have <Field> with value <Value>
	#And the "employmentprogressions" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	Given I wait for 5 Seconds
	Then there should be a record in the dss-employmentprogressions table with EmploymentProgressionId

	#And there should be a record in the employmentprogressions-history ChangeFeed table
	Examples:
		| Field                | Value |
		| LengthOfUnemployment | 1     |
		| LengthOfUnemployment | 2     |
		| LengthOfUnemployment | 3     |
		| LengthOfUnemployment | 4     |
		| LengthOfUnemployment | 5     |
		| LengthOfUnemployment | 6     |
		| LengthOfUnemployment | 98    |
		| LengthOfUnemployment | 99    |
		| LengthOfUnemployment |       |

@employmentprogressions
Scenario Outline: Post Employment progression with invalid values for LengthOfUnemployment
	Given I want to send <Field> with value <Value> in the following request
	Given I post a Employment Progression record with the following details V3:
		| Field                   | Value                |
		| DateProgressionRecorded | 2018-06-19T09:01:00Z |
		| CurrentEmploymentStatus | 99                   |
		| EmploymentHours         | 1                    |
		| DateOfEmployment        |                      |
		| EconomicShockStatus     | 1                    |
		| DateOfEmployment        | 2018-06-19T09:01:00Z |
	Then there should be a 422 response
	And the response body should include <ErrorMessage>
	And the number of errors returned should be 1

	Examples:
		| Field                | Value | ErrorMessage                                           |
		| LengthOfUnemployment | -1    | Please supply a valid value for Length Of Unemployment |
		| LengthOfUnemployment | 0     | Please supply a valid value for Length Of Unemployment |
		| LengthOfUnemployment | 97    | Please supply a valid value for Length Of Unemployment |
		| LengthOfUnemployment | 100   | Please supply a valid value for Length Of Unemployment |
		| LengthOfUnemployment | thing | Error converting value                                 |