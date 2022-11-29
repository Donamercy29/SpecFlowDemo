Feature: Member

A short summary of the feature

@Sprint01
Scenario: login into religio
	Given Launch the valid url:
	| URL                               |
	| https://churchar.cmallianceuu.org |
	When i click the Sign In Button
	And I enter the valid credentials:
    | UserName  | Password   |
    | Donamercy	| Donamercy1 |
	When I click the Login
	Then I click the Admin Dashboard
	And I click the Section



@Sprint01
Scenario: Add Main Section
Given i click the Add button
When i Type the details '<sectionname>' and '<description>'

Then I click the Save button
Examples: 
| sectionname | description                               |
| Association | Assiociation is such as Groups of members |