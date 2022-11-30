Feature: Member

A short summary of the feature

@Sprint01
Scenario: Perform Login of  Application site
	Given I launch the application with URL
		| URL                                 |
		| https://churchar.cmallianceuu.org |
    Then click on Sign In
	And I enter the Username and Password
		| UserName  | Password   |
		| admin | admin@cmalliance.org |
	When I click signin button
    Then Navigate for All Menu Pages 
	Then I click signout button