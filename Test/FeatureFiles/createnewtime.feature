Feature: createnewtime
	In order to manage time and materials
	As a admin
	I want to create, edit, read and delete time& merterial records

@mytag
Scenario: Create a Time record with valid inputs
	Given I have logged in to Turn Up portal
	And I have navigated to Time and Material page
	When I have clicked on the create button and filled all the information in the form
	Then I should be able to create a time record sucessfully

