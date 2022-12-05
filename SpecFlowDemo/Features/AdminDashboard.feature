Feature: Admin Dashboard
Scenario: To test the Admin Dashboard functions
	Given I launch  application with URL
		| URL                                 |
		| https://churchar.cmallianceuu.org |
    Then click on SignIn
	And I enter  Username and Password
		| UserName  | Password   |
		| admin | admin@cmalliance.org |
	When I click Log in button
    Then I click Admin Dashboard menu
	Then Navigate for admin Menu Page
