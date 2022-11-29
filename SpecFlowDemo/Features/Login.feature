Feature: Login

A short summary of the feature


@Sperint01
Scenario: login into religio
	Given Launch the application with valid '<URL>'
	When Enter the '<Username>' and '<Password>'
	And I click the Login button
	Then Navigate into the Dashboard
	 
Examples: 
| URL                             | UserName| Password |
| https://churchar.cmallianceuu.org | admin	| admin@cmalliance.org |
