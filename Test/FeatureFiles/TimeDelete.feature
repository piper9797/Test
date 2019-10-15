Feature: TimeDelete
	In order to delete a time row
	As an admin
	I want to delete a time row

@mytag
Scenario: delete a time row
	Given navagite the time and material row and I have clicked the deleted button
	Then the row should be deleted
