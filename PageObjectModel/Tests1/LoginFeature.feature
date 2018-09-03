Feature: Login
	
    Scenario: Unsuccessful Login
	Given User is in Login Page
	When User enters incorrect login credentials
	Then error message is displayed

    Scenario: Successful Login
    Given User is in Login Page
    When User enters correct login credentials 'sampleuser101' and 'passuser1'
    Then Welcome to AdactIn Group of Hotels is displayed
