
@postV1 @getV1

Feature: Search


@customers
	Scenario: Search without searchterm
		Given I post a Customer with the following details:
		| Field                      | Value               |
		| GivenName                  | Bob                 |
		| FamilyName                 | Binks               |
		When I search for:
		| Field                      | Value               |
		| parameter1                 |				       |
		| parameter2                 |		               |
		Then there should be a 204 response

@customers
	Scenario: Get Customer by FamilyName
		Given I post a Customer with the following details:
		| Field                      | Value               |
		| GivenName                  | Bob                 |
		| FamilyName                 | Binks               |
		When I search for:
		| Field                      | Value               |
		| parameter1                 | FamilyName          |
		| parameter2                 | Binks               |
		Then there should be a 200 response
		And all returned Customers should contain:
		| Field                      | Value               |
		| FamilyName                 | Binks               |

@customers
	Scenario: Get Customer by GivenName
		Given I post a Customer with the following details:
		| Field                      | Value               |
		| GivenName                  | Thomas                 |
		| FamilyName                 | Binks               |
		When I search for:
		| Field                      | Value               |
		| parameter1                 | GivenName          |
		| parameter2                 | Thomas               |
		Then there should be a 200 response
		And all returned Customers should contain:
		| Field                      | Value               |
		| GivenName                 | Thomas               |

@customers
	Scenario: Get Customer by uln
		Given I post a Customer with the following details:
		| Field                      | Value               |
		| GivenName                  | Thomas                 |
		| FamilyName                 | Binks               |
		| UniqueLearnerNumber | 7538571268 |
		When I search for:
		| Field                      | Value               |
		| parameter1                 | UniqueLearnerNumber          |
		| parameter2                 | 7538571268               |
		Then there should be a 200 response
		And all returned Customers should contain:
		| Field                      | Value               |
		| UniqueLearnerNumber                 | 7538571268               |

@customers
	Scenario: Get Customer by dob
		Given I post a Customer with the following details:
		| Field               | Value      |
		| GivenName           | Edward     |
		| FamilyName          | Binks      |
		| DateofBirth                | 2005-07-26 |
		When I search for:
		| Field                      | Value               |
		| parameter1                 | DateofBirth	       |
		| parameter2                 | 2005-07-26              |
		Then there should be a 200 response
		And all returned Customers should contain:
		| Field                      | Value               |
		| DateofBirth                | 2005-07-26T13:45:00Z |

@customers
	Scenario: Search for partial GivenName
		Given I post a Customer with the following details:
		| Field                      | Value               |
		| GivenName                  | Edward              |
		| FamilyName                 | Binks               |
		When I search for:
		| Field                      | Value               |
		| parameter1                 | GivenName	       |
		| parameter2                 | Edw	               |
		Then there should be a 200 response
		And all returned Customers should contain:
		| Field                      | Value               |
		| GivenName                  | Edw                 |

@customers
	Scenario: Search for partial FamilyName
		Given I post a Customer with the following details:
		| Field                      | Value               |
		| GivenName                  | Edward              |
		| FamilyName                 | Binks               |
		When I search for:
		| Field                      | Value               |
		| parameter1                 | FamilyName	       |
		| parameter2                 | Bin	               |
		Then there should be a 200 response
		And all returned Customers should contain:
		| Field                      | Value               |
		| FamilyName                 | Bin                 |

@customers
	Scenario: Search for partial GivenName and Full FamilyName
		Given I post a Customer with the following details:
		| Field                      | Value               |
		| GivenName                  | Edward              |
		| FamilyName                 | Binks               |
		When I search for:
		| Field                      | Value               |
		| parameter1                 | GivenName	       |
		| parameter2                 | Edw	               |
		| parameter3                 | FamilyName	       |
		| parameter4                 | Binks               |
		Then there should be a 200 response
		And all returned Customers should contain:
		| Field                      | Value               |
		| GivenName                  | Edw                 |
		| FamilyName                 | Binks               |

@customers
	Scenario: Search for partial GivenName and Partial FamilyName
		Given I post a Customer with the following details:
		| Field                      | Value               |
		| GivenName                  | Edward              |
		| FamilyName                 | Binks               |
		When I search for:
		| Field                      | Value               |
		| parameter1                 | GivenName	       |
		| parameter2                 | Edw	               |
		| parameter3                 | FamilyName	       |
		| parameter4                 | Binks               |
		Then there should be a 200 response
		And all returned Customers should contain:
		| Field                      | Value               |
		| GivenName                  | Edw                 |
		| FamilyName                 | Bin                 |

@customers
	Scenario: Search for full GivenName and Full FamilyName
		Given I post a Customer with the following details:
		| Field                      | Value               |
		| GivenName                  | Edward              |
		| FamilyName                 | Binks               |
		When I search for:
		| Field                      | Value               |
		| parameter1                 | GivenName	       |
		| parameter2                 | Edward              |
		| parameter3                 | FamilyName	       |
		| parameter4                 | Binks               |
		Then there should be a 200 response
		And all returned Customers should contain:
		| Field                      | Value               |
		| GivenName                  | Edward              |
		| FamilyName                 | Binks               |

@customers
	Scenario: Search for full GivenName and Partial FamilyName
		Given I post a Customer with the following details:
		| Field                      | Value               |
		| GivenName                  | Edward              |
		| FamilyName                 | Binks               |
		When I search for:
		| Field                      | Value               |
		| parameter1                 | GivenName	       |
		| parameter2                 | Edward              |
		| parameter3                 | FamilyName	       |
		| parameter4                 | Bin                 |
		Then there should be a 200 response
		And all returned Customers should contain:
		| Field                      | Value               |
		| GivenName                  | Edward              |
		| FamilyName                 | Bin               |

@customers
	Scenario: Search for partial GivenName and uln
		Given I post a Customer with the following details:
		| Field               | Value      |
		| GivenName           | Edward     |
		| FamilyName          | Binks      |
		| UniqueLearnerNumber | 9753113579 |
		When I search for:
		| Field                      | Value               |
		| parameter1                 | GivenName	       |
		| parameter2                 | Edw              |
		| parameter3                 | UniqueLearnerNumber	       |
		| parameter4                 | 9753113579                 |
		Then there should be a 200 response
		And all returned Customers should contain:
		| Field                      | Value               |
		| GivenName                  | Edward              |
		| FamilyName                 | Bin                 |
		| UniqueLearnerNumber		 | 9753113579		   |

@customers
	Scenario: Search for partial GivenName and DoB
		Given I post a Customer with the following details:
		| Field               | Value      |
		| GivenName           | Edward     |
		| FamilyName          | Binks      |
		| DateofBirth                | 2005-07-26 |
		When I search for:
		| Field                      | Value               |
		| parameter1                 | GivenName	       |
		| parameter2                 | Edw              |
		| parameter3                 | DateofBirth	       |
		| parameter4                | 2005-07-26 |
		Then there should be a 200 response
		And all returned Customers should contain:
		| Field                      | Value               |
		| GivenName                  | Edward              |
		| FamilyName                 | Bin                 |
		| DateofBirth                | 2005-07-26T13:45:00Z |

@customers
		Scenario: Get Customer by uln & DoB
		Given I post a Customer with the following details:
		| Field                      | Value               |
		| GivenName                  | Thomas                 |
		| FamilyName                 | Binks               |
		| DateofBirth                | 2005-07-26 |
		| UniqueLearnerNumber | 7538571268 |
		When I search for:
		| Field                      | Value               |
		| parameter1                 | UniqueLearnerNumber          |
		| parameter2                 | 7538571268               |
		| parameter3                 | DateofBirth	       |
		| parameter4                 | 2005-07-26              |
		Then there should be a 200 response
		And all returned Customers should contain:
		| Field                      | Value               |
		| DateofBirth                 | 2005-07-26               |
		| UniqueLearnerNumber                 | 7538571268               |

@customers
		Scenario: Get Customer by firstName & uln & DoB
		Given I post a Customer with the following details:
		| Field                      | Value               |
		| GivenName                  | Thomas                 |
		| FamilyName                 | Binks               |
		| DateofBirth                | 2005-07-26 |
		| UniqueLearnerNumber | 7538571268 |
		When I search for:
		| Field                      | Value               |
		| parameter1                 | GivenName          |
		| parameter2                 | Thomas               |
		| parameter3                 | UniqueLearnerNumber	       |
		| parameter4                 | 7538571268              |
		| parameter5                 | DateofBirth	       |
		| parameter6                 | 2005-07-26              |
		Then there should be a 200 response
		And all returned Customers should contain:
		| Field                      | Value               |
		| GivenName                  | Thomas                 |
		| DateofBirth                 | 2005-07-26               |
		| UniqueLearnerNumber                 | 7538571268               |


@customers
	Scenario: Search for partial GivenName and Partial FamilyName with space after GivenName
		Given I post a Customer with the following details:
		| Field                      | Value               |
		| GivenName                  | Edward              |
		| FamilyName                 | Binks               |
		When I search for:
		| Field                      | Value               |
		| parameter1                 | GivenName	       |
		| parameter2                 | Edw + space 	       |
		| parameter3                 | FamilyName	       |
		| parameter4                 | Binks               |
		Then there should be a 200 response
		And all returned Customers should contain:
		| Field                      | Value               |
		| GivenName                  | Edw                 |
		| FamilyName                 | Bin                 |

@customers
	Scenario: Search for partial GivenName and Partial FamilyName with double space after GivenName
		Given I post a Customer with the following details:
		| Field                      | Value               |
		| GivenName                  | Edward              |
		| FamilyName                 | Binks               |
		When I search for:
		| Field                      | Value               |
		| parameter1                 | GivenName	       |
		| parameter2                 | Edw  + space	       |
		| parameter3                 | FamilyName	       |
		| parameter4                 | Binks               |
		Then there should be a 200 response
		And all returned Customers should contain:
		| Field                      | Value               |
		| GivenName                  | Edw                 |
		| FamilyName                 | Bin                 |

@customers
	Scenario: Search for partial GivenName and DateOfBirth with space after GivenName
		Given I post a Customer with the following details:
		| Field       | Value                |
		| GivenName   | Edward               |
		| FamilyName  | Binks                |
		| DateofBirth | 1988-06-06T00:00:00Z |
		When I search for:
		| Field                      | Value               |
		| parameter1                 | GivenName	       |
		| parameter2                 | Edw + space	       |
		| parameter3                 | DateofBirth	       |
		| parameter4                 | 1988-06-06          |
		Then there should be a 200 response
		And all returned Customers should contain:
		| Field                      | Value               |
		| GivenName                  | Edw                 |
		| FamilyName                 | Bin                 |
		| DateofBirth				 | 1988-06-06		   |

@customers
	Scenario: Search for DateofBirth and GivenName with space after DoB
		Given I post a Customer with the following details:
		| Field       | Value                |
		| GivenName   | Edward               |
		| FamilyName  | Binks                |
		| DateofBirth | 1988-06-06T00:00:00Z |
		When I search for:
		| Field                      | Value               |
		| parameter1                 | DateofBirth	       |
		| parameter2                 | 1988-06-06 + space  |
		| parameter3                 | GivenName	       |
		| parameter4                 | Edward	           |
		Then there should be a 200 response
		And all returned Customers should contain:
		| Field                      | Value               |
		| GivenName                  | Edward              |
		| FamilyName                 | Binks               |
		| DateofBirth				 | 1988-06-06		   |

@customers
	Scenario: Search for ULN and GivenName with space after ULN
		Given I post a Customer with the following details:
		| Field						 | Value                |
		| GivenName					 | Edward               |
		| FamilyName				 | Binks                |
		| UniqueLearnerNumber		 | 9876543210           |
		When I search for:
		| Field                      | Value				|
		| parameter1                 | UniqueLearnerNumber  |
		| parameter2                 | 9876543210 + space	|
		| parameter3                 | GivenName			|
		| parameter4                 | Edward				|
		Then there should be a 200 response
		And all returned Customers should contain:
		| Field                      | Value               |
		| GivenName                  | Edward              |
		| FamilyName                 | Binks               |
		| UniqueLearnerNumber		 | 9876543210          |

@customers
	Scenario: Search for partial GivenName and Partial FamilyName and DateOfBirth with spaces
		Given I post a Customer with the following details:
		| Field       | Value      |
		| GivenName   | Edward     |
		| FamilyName  | Binks      |
		| DateofBirth | 1999-01-22 |
		When I search for:
		| Field      | Value       |
		| parameter1 | GivenName   |
		| parameter2 | Edw + space |
		| parameter3 | FamilyName  |
		| parameter4 | Bin + space |
		| parameter5 | DateofBirth |
		| parameter6 | 1999-01-22  |
		Then there should be a 200 response
		And all returned Customers should contain:
		| Field			| Value       |
		| GivenName     | Edw         |
		| FamilyName    | Bin         |
		| DateofBirth	| 1999-01-22  |
