Feature: Autenticacion de usuario

@AcceptTest
Scenario: Ingresar usuario y password
	Given Ingreso a la sucursal virtual	
	When Ingreso login "admin"
	And y passwrod ""
	And seleccion ingresar
	Then Ingreso a la pagina de transferencia
