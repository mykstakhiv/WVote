                                                    Main logic
-Develop a voting app that will allow you to register and will store your data on the SQL server: Email, Full Name and Password. 
-Once the user is registered they can log in and access the voting page. 
-The user can choose their vote and once they do it, their vote should be written under their name in the SQL Server.
-When the user closes the page and logs in again with their details they should be able to see their vote.

I would create class with Email, Full Name and Password properties
class with Pokemon’s name.
I need to connect to the SQL server and once it is connected I can copy input from Fullname and Email and Password to the database. 
Login process should check if the user exists and if yes, open voting page 
Once a vote was chosen, it should be saved in the database.
When the vote is saved, VoterID and PokemonID(that the user voted for) should be saved to the Result table.

                                                      HOW
check the id of the current user and add this id to the Result table.
check the id of the pokemon that the user has voted for and add this id to the Result table next to VoterId.

Use SQL to save data that the user voted for and display the same vote with the current user.

                                                      SSUE
When the user registers but doesn't vote and someone who is already registered logs in and tries to vote - voterId and PokemonId can't be inserted. It is probably because method AddVote doesn't assign pokemon id separately but assigns voter id instead.

PokemonId is added separately now. When we assign pokemon as a vote, the id of that pokemon is read and converted into int32. One more parameter was added to the method and when the method is called, the third parameter is pokemon id.

PokemonId is not assigned properly.

					                                          Left to do
implement password to the logic database and encrypt it with an algorithm.
One more column at the database, change form design and make sure password is written to that column once the user creates password.

Retrieve the data when the user is logging in and check if he has voted already. If the vote has been created, then display the current vote and make sure that ability to vote is blocked.

		
                                                        How
Check if the user that logged in existes.
Check by id in the Result table if the user has been assigned a pokemon.
	
If he has, check what pokemon.
Make this pokemon checked on the forms display.

                                              How to set SQL database

Using SQL server, create a database.
Create table Voter, Pokemon and Result(in order to have relations between these tables) - file(create-tables) + diagram.
