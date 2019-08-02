@PostV3 @patchV3
Feature: DiversityV3_Patch



Background: Create Adviser
	Given I post an adviser with the following details:
		| Field						 | Value				|
		| AdviserName				 | BillyAdviser			|
		| AdviserContactNumber		 | 98798678967967		|
	And I post a Customer with the following details:
		| Field                      | Value                |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
	And I post a Diversity Details record with the following details:
		| Field                                     | Value                |
		| ConsentToCollectLLDDHealth                | true                 |
		| LearningDifficultyOrDisabilityDeclaration | 1                    |
		| PrimaryLearningDifficultyOrDisability     | 4                    |
		| SecondaryLearningDifficultyOrDisability   | 5                    |
		| DateAndTimeLDDHealthConsentCollected      | 2018-06-25T11:21:00Z |
		| ConsentToCollectEthnicity                 | true                 |
		| EthnicityID                               | 32                   |
		| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |


@diversitydetails  @smoke
Scenario:Patch Diversity with all values
	When I patch the following:
	| Field                                     | Value                |
	| ConsentToCollectLLDDHealth                 | true                 |
	| LearningDifficultyOrDisabilityDeclaration | 1                    |
	| PrimaryLearningDifficultyOrDisability     | 4                    |
	| SecondaryLearningDifficultyOrDisability   | 5                    |
	| DateAndTimeLDDHealthConsentCollected      | 2018-06-25T11:21:00Z |
	| ConsentToCollectEthnicity                 | true                 |
	| EthnicityID                               | 32                   |
	| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	| LastModifiedDate                          | 2018-08-25T11:21:00Z |
	Then there should be a 200 response
	And the response body should contain:
	| Field                                     | Value                |
	| ConsentToCollectLLDDHealth                | true                 |
	| LearningDifficultyOrDisabilityDeclaration | 1                    |
	| PrimaryLearningDifficultyOrDisability     | 4                    |
	| SecondaryLearningDifficultyOrDisability   | 5                    |
	| DateAndTimeLDDHealthConsentCollected      | 2018-06-25T11:21:00Z |
	| ConsentToCollectEthnicity                 | true                 |
	| EthnicityID                               | 32                   |
	| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
	| LastModifiedDate                          | 2018-08-25T11:21:00Z |
	#And the "diversitydetails" cosmos document should include CreatedBy
	And the response body should not contain the "CreatedBy"
	#And there should be a record in the diversitydetails ChangeFeed table
	#And there should be a record in the diversitydetails-history ChangeFeed table


############################################################################################################################
##	ConsentToCollectLLDDHealth
############################################################################################################################

@diversitydetails  
Scenario Outline:Patch Diversity with valid values for ConsentToCollectLLDDHealth 

	When I patch the element <Field> with <value>:
	Then there should be a 200 response
	And the response body should have <Field> with value <Value>
	
	Examples:
	| Field                     | Value |
	| ConsentToCollectLLDDHealth | true  |
	| ConsentToCollectLLDDHealth | false |		
	
@diversitydetails  
Scenario Outline: Patch Diversity with invalid values for ConsentToCollectLLDDHealth 

	When I patch the element <Field> with <value>:
	Then there should be a 422 response
	
	Examples:
	| Field                      | Value |
	| ConsentToCollectLLDDHealth | 1     |
	| ConsentToCollectLLDDHealth | car   |	

@diversitydetails  
Scenario: Patch Diversity with no value supplied for ConsentToCollectLLDDHealth 


	When I patch the element <Field> with <value>:
	Then there should be a 422 response
	And the error message should be "The ConsentToCollectLLDDHealth field is required."

############################################################################################################################
## LearningDifficultyOrDisabilityDeclaration
############################################################################################################################

@diversitydetails  
Scenario Outline:Patch Diversity with valid values for LearningDifficultyOrDisabilityDeclaration 

	When I patch the element <Field> with <value>:
	Then there should be a 201 response
	And the response body should contain:
	| Field                      | Value |
	| Field                      | Value |
	| ConsentToCollectLLDDHealth | true  |
	| ConsentToCollectEthnicity  | false |
	| Ethnicity                  | 99    |
	And the response body should have <Field> with value <Value>
	
	Examples:
	| Field                                     | Value |
	| LearningDifficultyOrDisabilityDeclaration | 1     |
	| LearningDifficultyOrDisabilityDeclaration | 2     |
	| LearningDifficultyOrDisabilityDeclaration | 99    |



@diversitydetails  
Scenario Outline: Patch Diversity with invalid values for LearningDifficultyOrDisabilityDeclaration 
	
	When I patch the element <Field> with <value>:
	Then there should be a 422 response
	And the error message should be "Please supply a valid Learning Difficulty Or Disability Declaration"
	
	Examples:
	| Field                                     | Value | 
	| LearningDifficultyOrDisabilityDeclaration | -1    | 
	| LearningDifficultyOrDisabilityDeclaration | 0     | 
	| LearningDifficultyOrDisabilityDeclaration | 3     |
	| LearningDifficultyOrDisabilityDeclaration | 98    | 
	| LearningDifficultyOrDisabilityDeclaration | 100   | 

@diversitydetails  
Scenario Outline: Patch Diversity with no value supplied for LearningDifficultyOrDisabilityDeclaration 

	When I patch the element <Field> with <value>:
	Then there should be a 200 response
	
	Examples:
	| Field                                     | Value |
	| LearningDifficultyOrDisabilityDeclaration |       |  

############################################################################################################################
## PrimaryLearningDifficultyOrDisability
############################################################################################################################

@diversitydetails  
Scenario Outline:Patch Diversity with valid values for PrimaryLearningDifficultyOrDisability 
	
	When I patch the element <Field> with <value>:
	Then there should be a 200 response
	And the response body should contain:
	| Field                      | Value |
	| Field                      | Value |
	| ConsentToCollectLLDDHealth | true  |
	| ConsentToCollectEthnicity  | false |
	| Ethnicity                  | 99    |
	And the response body should have <Field> with value <Value>
	
	Examples:
	| Field                                 | Value |
	| PrimaryLearningDifficultyOrDisability | 4     |
	| PrimaryLearningDifficultyOrDisability | 5     |
	| PrimaryLearningDifficultyOrDisability | 6     |
	| PrimaryLearningDifficultyOrDisability | 7     |
	| PrimaryLearningDifficultyOrDisability | 8     |
	| PrimaryLearningDifficultyOrDisability | 9     |
	| PrimaryLearningDifficultyOrDisability | 10    |
	| PrimaryLearningDifficultyOrDisability | 11    |
	| PrimaryLearningDifficultyOrDisability | 12    |
	| PrimaryLearningDifficultyOrDisability | 13    |
	| PrimaryLearningDifficultyOrDisability | 14    |
	| PrimaryLearningDifficultyOrDisability | 15    |
	| PrimaryLearningDifficultyOrDisability | 16    |
	| PrimaryLearningDifficultyOrDisability | 17    |
	| PrimaryLearningDifficultyOrDisability | 93    |
	| PrimaryLearningDifficultyOrDisability | 94    |
	| PrimaryLearningDifficultyOrDisability | 95    |
	| PrimaryLearningDifficultyOrDisability | 96    |
	| PrimaryLearningDifficultyOrDisability | 97    |
	| PrimaryLearningDifficultyOrDisability | 98    |
	| PrimaryLearningDifficultyOrDisability | 99    |



@diversitydetails  
Scenario Outline: Patch Diversity with invalid values for PrimaryLearningDifficultyOrDisability 
	
	When I patch the element <Field> with <value>:
	Then there should be a 422 response
	And the error message should be "Please supply a valid Primary Learning Difficulty Or Disability"
	
	Examples:
	| Field                                 | Value |
	| PrimaryLearningDifficultyOrDisability |-1     |
	| PrimaryLearningDifficultyOrDisability | 1     |
	| PrimaryLearningDifficultyOrDisability | 2     |
	| PrimaryLearningDifficultyOrDisability | 3     |
	| PrimaryLearningDifficultyOrDisability | 18     |
	| PrimaryLearningDifficultyOrDisability | 20     |
	| PrimaryLearningDifficultyOrDisability | 20     |
	| PrimaryLearningDifficultyOrDisability | 90     |
	| PrimaryLearningDifficultyOrDisability | 92     |
	| PrimaryLearningDifficultyOrDisability | 100     |
#	| PrimaryLearningDifficultyOrDisability | a     |

@diversitydetails  
Scenario Outline: Patch Diversity with no value supplied for PrimaryLearningDifficultyOrDisability 

	When I patch the element <Field> with <value>:
	Then there should be a 200 response
	
	Examples:
	| Field                                 | Value |
	| PrimaryLearningDifficultyOrDisability |       |

############################################################################################################################
## SecondaryLearningDifficultyOrDisability
############################################################################################################################

@diversitydetails  
Scenario Outline:Patch Diversity with valid values for SecondaryLearningDifficultyOrDisability 
	
	When I patch the element <Field> with <value>:
	Then there should be a 200 response
	And the response body should have <Field> with value <Value>
	
	Examples:
	| Field                                   | Value |
	| SecondaryLearningDifficultyOrDisability | 4     |
	| SecondaryLearningDifficultyOrDisability | 5     |
	| SecondaryLearningDifficultyOrDisability | 6     |
	| SecondaryLearningDifficultyOrDisability | 7     |
	| SecondaryLearningDifficultyOrDisability | 8     |
	| SecondaryLearningDifficultyOrDisability | 9     |
	| SecondaryLearningDifficultyOrDisability | 10    |
	| SecondaryLearningDifficultyOrDisability | 11    |
	| SecondaryLearningDifficultyOrDisability | 12    |
	| SecondaryLearningDifficultyOrDisability | 13    |
	| SecondaryLearningDifficultyOrDisability | 14    |
	| SecondaryLearningDifficultyOrDisability | 15    |
	| SecondaryLearningDifficultyOrDisability | 16    |
	| SecondaryLearningDifficultyOrDisability | 17    |
	| SecondaryLearningDifficultyOrDisability | 93    |
	| SecondaryLearningDifficultyOrDisability | 94    |
	| SecondaryLearningDifficultyOrDisability | 95    |
	| SecondaryLearningDifficultyOrDisability | 96    |
	| SecondaryLearningDifficultyOrDisability | 97    |
	| SecondaryLearningDifficultyOrDisability | 98    |
	| SecondaryLearningDifficultyOrDisability | 99    |



@diversitydetails  
Scenario Outline: Patch Diversity with invalid values for SecondaryLearningDifficultyOrDisability 
	
	When I patch the element <Field> with <value>:
	Then there should be a 422 response
	And the error message should be "Please supply a valid Secondary Learning Difficulty Or Disability"
	
	Examples:
	| Field                                 | Value |
	| SecondaryLearningDifficultyOrDisability |-1     |
	| SecondaryLearningDifficultyOrDisability | 1     |
	| SecondaryLearningDifficultyOrDisability | 2     |
	| SecondaryLearningDifficultyOrDisability | 3     |
	| SecondaryLearningDifficultyOrDisability | 18     |
	| SecondaryLearningDifficultyOrDisability | 20     |
	| SecondaryLearningDifficultyOrDisability | 20     |
	| SecondaryLearningDifficultyOrDisability | 90     |
	| SecondaryLearningDifficultyOrDisability | 92     |
	| SecondaryLearningDifficultyOrDisability | 100     |
#	| PrimaryLearningDifficultyOrDisability | a     |

@diversitydetails  
Scenario Outline: Patch Diversity with no value supplied for SecondaryLearningDifficultyOrDisability 

	When I patch the element <Field> with <value>:
	Then there should be a 200 response
	
	Examples:
	| Field                                   | Value |
	| SecondaryLearningDifficultyOrDisability |       |

############################################################################################################################
## DateAndTimeLDDHealthConsentCollected			MANDATORY IF CONSENT GIVEN	Date < NOW
############################################################################################################################

@diversitydetails  
Scenario Outline:Patch Diversity with valid values for DateAndTimeLDDHealthConsentCollected 
	When I patch the element <Field> with <value>:
	Then there should be a 200 response
	And the response body should have <Field> with value <Value>
	
	Examples:
	| Field                                | Value                |
	| DateAndTimeLDDHealthConsentCollected | now                  |
	| DateAndTimeLDDHealthConsentCollected | today                |
	| DateAndTimeLDDHealthConsentCollected | 2018-08-25T11:21:00Z |


@diversitydetails  
Scenario Outline: Patch Diversity with invalid values for DateAndTimeLDDHealthConsentCollected 
	
	When I patch the element <Field> with <value>:
	Then there should be a 422 response
	And the error message should be "PLACEHOLDER"
	
	Examples:
	| Field                                 | Value |
	| DateAndTimeLDDHealthConsentCollected | TODO     |


@diversitydetails  
Scenario Outline: Patch Diversity with no value supplied for SecondaryLearningDifficultyOrDisability with no consent to collect  LDD Health data given

	When I patch the element <Field> with <value>:
	Then there should be a 200 response
	
	Examples:
	| Field                                   | Value |
	| SecondaryLearningDifficultyOrDisability |       |

#@diversitydetails  
#Scenario: Patch Diversity with no value supplied for SecondaryLearningDifficultyOrDisability with consent to collect LDD Health data given
#
#	When I patch the following:
#	| Field                                     | Value                |
#	| ConsentToCollectLLDDHealth                | false                |
#	| LearningDifficultyOrDisabilityDeclaration |                      |
#	| PrimaryLearningDifficultyOrDisability     | 5                    |
#	| SecondaryLearningDifficultyOrDisability   |                      |
#	| DateAndTimeLDDHealthConsentCollected      |                      |
#	| ConsentToCollectEthnicity                 | true                 |
#	| Ethnicity                                 | 32                   |
#	| DateAndTimeEthnicityCollected             | 2018-06-25T11:22:00Z |
#	Then there should be a 422 response
#	And the error message should be "PLACEHOLDER"

############################################################################################################################
## ConsentToCollectEthnicity	MANDATORY
############################################################################################################################


@diversitydetails  
Scenario Outline:Patch Diversity with valid values for ConsentToCollectEthnicity 
	
	When I patch the element <Field> with <value>:
	Then there should be a 200 response
	And the response body should have <Field> with value <Value>
	
	Examples:
	| Field                     | Value |
	| ConsentToCollectEthnicity | true  |
	| ConsentToCollectEthnicity | false |
	

@diversitydetails  
Scenario Outline: Patch Diversity with invalid values for ConsentToCollectEthnicity 
	
	When I patch the element <Field> with <value>:
	Then there should be a 422 response
	And the error message should be "PLACEHOLDER"
	
	Examples:
	| Field                     | Value |
	| ConsentToCollectEthnicity | 1     |
	| ConsentToCollectEthnicity | abc   |

@diversitydetails  
Scenario Outline: Patch Diversity with no value supplied for ConsentToCollectEthnicity

	When I patch the element <Field> with <value>:
	Then there should be a 200 response
	
	Examples:
	| Field                     | Value |
	| ConsentToCollectEthnicity |       |

############################################################################################################################
## Ethnicity MANDATORY LOOKUP
############################################################################################################################


@diversitydetails  
Scenario Outline:Patch Diversity with valid values for Ethnicity 
	When I patch the element <Field> with <value>:
	Then there should be a 200 response
	And the response body should have <Field> with value <Value>
	
	Examples:
	| Field     | Value |
	| Ethnicity | 31    |
	| Ethnicity | 32    |
	| Ethnicity | 33    |
	| Ethnicity | 34    |
	| Ethnicity | 35    |
	| Ethnicity | 36    |
	| Ethnicity | 37    |
	| Ethnicity | 38    |
	| Ethnicity | 39    |
	| Ethnicity | 40    |
	| Ethnicity | 41    |
	| Ethnicity | 42    |
	| Ethnicity | 43    |
	| Ethnicity | 44    |
	| Ethnicity | 45    |
	| Ethnicity | 46    |
	| Ethnicity | 47    |
	| Ethnicity | 98    |
	| Ethnicity | 99    |

@diversitydetails  
Scenario Outline: Patch Diversity with invalid values for Ethnicity 
	
	When I patch the element <Field> with <value>:
	Then there should be a 422 response
	And the error message should be "PLACEHOLDER"
	
	Examples:
	| Field     | Value |
	| Ethnicity | 0     |
	| Ethnicity | 30    |
	| Ethnicity | 48    |
	| Ethnicity | 50    |
	| Ethnicity | 90    |
	| Ethnicity | 97    |
	| Ethnicity | 100   |

@diversitydetails  
Scenario Outline: Patch Diversity with no value supplied for Ethnicity

	When I patch the element <Field> with <value>:
	Then there should be a 200 response
	
	Examples:
	| Field                     | Value |
	| ConsentToCollectEthnicity |       |

############################################################################################################################
## DateAndTimeEthnicityCollected	MANDATORY if Consent is Given   :  <= Now
############################################################################################################################

@diversitydetails  
Scenario Outline:Patch Diversity with valid values for DateAndTimeEthnicityCollected 
	When I patch the element <Field> with <value>:
	Then there should be a 200 response
	And the response body should have <Field> with value <Value>
	
	Examples:
	| Field                         | Value                |
	| DateAndTimeEthnicityCollected | now                  |
	| DateAndTimeEthnicityCollected | today                |
	| DateAndTimeEthnicityCollected | 2018-08-25T11:21:00Z |




@diversitydetails  
Scenario Outline: Patch Diversity with invalid values for DateAndTimeEthnicityCollected 
	When I patch the element <Field> with <value>:
	Then there should be a 422 response
	And the error message should be "PLACEHOLDER"
	
	Examples:
	| Field                         | Value |
	| DateAndTimeEthnicityCollected | TODO  |

@diversitydetails  
Scenario Outline: Patch Diversity with no value supplied for DateAndTimeEthnicityCollected and no consent to collect  Ethnicity data given

	When I patch the element <Field> with <value>:
	Then there should be a 200 response
	
	Examples:
	| Field                         | Value |
	| DateAndTimeEthnicityCollected |       |

#@diversitydetails  
#Scenario: Patch Diversity with no value supplied for DateAndTimeEthnicityCollected with consent to collect Ethnicity data given
#
#	When I patch the following:
#	| Field                                     | Value |
#	| ConsentToCollectLLDDHealth                | false |
#	| LearningDifficultyOrDisabilityDeclaration |       |
#	| PrimaryLearningDifficultyOrDisability     | 5     |
#	| SecondaryLearningDifficultyOrDisability   |       |
#	| DateAndTimeLDDHealthConsentCollected      |       |
#	| ConsentToCollectEthnicity                 | true |
#	| DateAndTimeEthnicityCollected             |       |
#	Then there should be a 422 response
#	And the error message should be "PLACEHOLDER"


############################################################################################################################
## CreatedBy
############################################################################################################################

############################################################################################################################
## LastModifiedDate
############################################################################################################################

############################################################################################################################
## Other tests
############################################################################################################################

