Feature: CadastrarVenda
	As a salesman
	I want to enter my sales 
	In order to receive my comission payments 


Scenario: Successfuly saved
	Given I have entered the sales webpage
	And I have entered 10 into the salesman
	And the price was 10
	And the date was 10/12/2015
	When I press save
	Then a success message should appear


Scenario: Salesman field not filled
	Given I have entered the sales webpage
	And I have entered  '' into the salesman
	And the price was 10
	And the date was 10/12/2015
	When I press save
	Then an error message should appear