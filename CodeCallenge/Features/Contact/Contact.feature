Feature: Contact

A short summary of the feature

@tag1
Scenario: Fill Cotact Information
	Given I Click On Home Page Link
	When I click on Contact Button
	Then I Fill the as Contact Email 'exampleEmail@gmial.com'
	Then I Fill the as Contact Name 'Juan Rodulfo Hernandez'
	Then I Fill the as Message 'Hello i would like to send a message for more information'
	When I click on Send Message Button
	When I Verify Message Error Contains 'Thanks for the message!!'