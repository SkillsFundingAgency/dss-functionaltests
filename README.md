# dss-functionaltests

## Description
This repository is responsible for running all functional tests against DSS apis, testing that the system functions as a whole. While all apis have their own
unit tests; In most cases there is more than one microservice that is being tested, a service bus & sql audit tables being checked. The original solution was wrote in full
framework (4.61), all Specflow features being migrated across into a new format with some code refactoring.

### Apis being tested
-	**dss-action** - [https://github.com/SkillsFundingAgency/dss-actions]
-	**dss-actionplan** - [https://github.com/SkillsFundingAgency/dss-actionplans]
-	**dss-address** - [https://github.com/SkillsFundingAgency/dss-address]
-	**dss-adviser** - [https://github.com/SkillsFundingAgency/dss-adviserdetails]
-	**dss-contact** - [https://github.com/SkillsFundingAgency/dss-contact]
-	**dss-customer** - [https://github.com/SkillsFundingAgency/dss-customer]
-	**dss-digitalidentity** - [https://github.com/SkillsFundingAgency/dss-digitalidentity]
-	**dss-diversity** - [https://github.com/SkillsFundingAgency/dss-diversity]
-	**dss-employmentprogression** - [https://github.com/SkillsFundingAgency/dss-employmentprogression]
-	**dss-goal** - [https://github.com/SkillsFundingAgency/dss-goals]
-	**dss-interaction** - [https://github.com/SkillsFundingAgency/dss-interaction]
-	**dss-learningprogression** - [https://github.com/SkillsFundingAgency/dss-learningprogression]
-	**dss-outcome** - [https://github.com/SkillsFundingAgency/dss-outcomes]
-	**dss-search**
-	**dss-session** - [https://github.com/SkillsFundingAgency/dss-sessions]
-	**dss-subscription** - [https://github.com/SkillsFundingAgency/dss-subscriptions]
-	**dss-transfer** - [https://github.com/SkillsFundingAgency/dss-transfer]
-	**dss-webchat** - [https://github.com/SkillsFundingAgency/dss-webchats]

### Backend Services being tested indirectly
- dss-contentenhancer - [https://github.com/SkillsFundingAgency/dss-contentenhancer]
-	**dss-changefeedlistener** - [https://github.com/SkillsFundingAgency/dss-changefeedlistener]
-	**dss-changefeedsqlprocessor** - [https://github.com/SkillsFundingAgency/dss-changefeedsqlprocessor]
	

## Prequesites
- dotnetcore3.1
- Visual studio Specflow plugin - [https://marketplace.visualstudio.com/items?itemName=TechTalkSpecFlowTeam.SpecFlowForVisualStudio]

## Developer Setup
To configure the tests to be run locally, edit the appsettings.local.json file to include the sql connection string
and the cosmos shared key and tests can be either ran from Visual Studio or the Command Prompt.

- **dotnet test**
or
- **donet test --filter "TestCategory=customers" -v detailed**   //e.g. actions, customers,actionplans etc

