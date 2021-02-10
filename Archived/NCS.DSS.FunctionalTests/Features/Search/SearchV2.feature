@postV2 @getV2
Feature: Search V2


#@ignore
@customers @contacts @address @addresses @smoke
Scenario: Search for customer
# TEST TAGGED TO IGNORE - HAS NOT BEEN TESTED
	Given I post an adviser with the following details:
		| Field						 | Value				|
		| AdviserName				 | BillyAdviser			|
		| AdviserContactNumber		 | 98798678967967		|
	Given I post a Customer with the following details:
		| Field                      | Value                |
		| DateOfRegistration         | 2018-07-27T16:11:00Z |
		| Title                      | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Searchman            |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| DateOfTermination          |  |
		| ReasonForTermination       |                     |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |
		| LastModifiedDate           | 2018-06-21T14:45:00Z |
	Given I post a Contact with the following details:
		| Field                  | Value                        |
		| PreferredContactMethod | 1                            |
		| MobileNumber           | 07676 123456                 |
		| HomeNumber             | 08654 123456                 |
		| AlternativeNumber      | 07564656766                  |
		| EmailAddress           | customer@customer.com        |
		| LastModifiedDate       | 2018-08-20T11:46:02.4482612Z |
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
		When I search for "FamilyName: Searchman"
		Then there should be a 200 response
		And the response body should incorporate a document with the following details:
		| Field                      | Value                    |
		| DateOfRegistration         | 2018-11-30T12:07:57.705Z |
		| Title                      | 2018-07-27T16:11:00Z     |
		| GivenName                  | Bob                      |
		| FamilyName                 | Searchman                |
		| UniqueLearnerNumber        | 9876543210               |
		| DateofBirth                | 2005-07-26T13:45:00Z     |
		| Gender                     | 1                        |
		| OptInUserResearch          | true                     |
		| OptInMarketResearch        | false                    |
		| DateOfTermination          |                          |
		| ReasonForTermination       |                          |
		| IntroducedBy               | 1                        |
		| IntroducedByAdditionalInfo | additional info          |
		| LastModifiedDate           | 2018-06-21T14:45:00Z     |
		| Address1                   | 1                        |
		| PostCode                   | NW11WN                   |
		| MobileNumber               | 07676 123456             |
		| HomeNumber                 | 08654 123456             |
		| AlternativeNumber          | 07564656766              |
		| EmailAddress               | customer@customer.com    |
		#NEED TO ADD STEP TO CHECK THE CUSTOMER ID IS INCLUDED IN THE IDENTIFIED DOCUMENT

