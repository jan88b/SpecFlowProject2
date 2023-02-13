Feature: PlanAJourney
Test the plan a journey widget in TFL site
@TFL-PlanAJourney
Scenario: Verify that a valid journey can be planned using the widget.
	Given Open the Tfl website 
	And Accept Cookie settings 
	When Select the Plan a Journey tab
	Then Provide From and To details and check the result
	@TFL-PlanAJourney
	Scenario: Verify that the widget is unable to provide results when an invalid journey is planned.
	Given Open the Tfl website 
	And Accept Cookie settings 
	When Select the Plan a Journey tab
	Then Provide invalid From and To details and check the result
	@TFL-PlanAJourney
	Scenario: Verify that the widget is unable to plan a journey if no locations are entered into the widget.
	Given Open the Tfl website 
	And Accept Cookie settings 
	When Select the Plan a Journey tab
	Then Provide no details in the  From and To fields and check the result
	@TFL-PlanAJourney
	Scenario: Verify that a journey can be amended by using the “Edit Journey” button.
	Given Open the Tfl website 
	And Accept Cookie settings 
	When Select the Plan a Journey tab
	Then Provide From and To details and check the result
	@TFL-PlanAJourney
	Scenario: Verify that the “Recents” tab on the widget displays a list of recently planned journeys.
	Given Open the Tfl website 
	And Accept Cookie settings 
	When Select the Plan a Journey tab
	Then Provide From and To details and check the result