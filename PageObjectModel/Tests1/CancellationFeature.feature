Feature: Cancellation


Scenario: Cancellation from welcome page
	Given User has successfully Loggedin and clicked on Booked Itinerary
    When User clicks the checkbox of any orderid and clicks on cancel selected button
    Then Selected booking Are cancelled should be displayed
