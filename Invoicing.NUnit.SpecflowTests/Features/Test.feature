Feature: Sum of Invoice Rows 
    The Amount of Invoice should equal to the sum of Invoice Rows
    
@mytag
Scenario: I have two invoice rows with correct sum 
    Given I have invoice row with amount 50
    And I have invoice row with amount 40
    When I read invoice amount
    Then the amount of the invoice must be 90
