Feature: UserManagement

The porpuse of this feature is created the test cases to test login, fails user , Sign up the users


@TC001 @US001
Scenario: 001_UserFailLogin
	Given I login Scenario With User 'wrongPassword' and Password 'wrongPassword'
	When I Verify Message Error Contains 'User does not exist.'
	Then I click on Close Modal 

@TC002 @US001
Scenario: 002_UserSuccessLogin
	Given I login Scenario With User 'admin' and Password 'admin'
	Then I Verify if Welcome Message is showing on the page as 'admin' user 

Scenario: 003_User_Sign_Up
	Given I login Scenario With User 'admin' and Password 'admin'
	Then I Verify if Welcome Message is showing on the page as 'admin' user 
	
	
