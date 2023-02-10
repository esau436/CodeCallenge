Feature: HomePage

A short summary of the feature

@HomeTC01 @US002
Scenario: 001_Validate_Nava_Buttons_UserLogin
	Given I login Scenario With User 'admin' and Password 'admin'
	When I validate if In Van-bar the 'Home' is showing
	Then I validate if In Van-bar the 'Contact' is showing
	When I validate if In Van-bar the 'About us' is showing
	Then I validate if In Van-bar the 'Cart' is showing
	When I validate if In Van-bar the 'Log out' is showing
	Then I validate if In Van-bar the 'Welcome admin' is showing
	Then I Validate If Carousel is Showing On the page

@HomeTC02 @US002
Scenario: 002_Validate_Nava_Buttons_UserNot_Login
	Given I Click On Home Page Link
	When I validate if In Van-bar the 'Home' is showing
	Then I validate if In Van-bar the 'Contact' is showing
	When I validate if In Van-bar the 'About us' is showing
	Then I validate if In Van-bar the 'Cart' is showing
	When I validate if In Van-bar the 'Log in' is showing
	Then I validate if In Van-bar the 'Sign up' is showing
	Then I Validate If Carousel is Showing On the page

	