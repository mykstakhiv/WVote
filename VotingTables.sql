CREATE TABLE Voter (
    VoterId INT IDENTITY(1,1) PRIMARY KEY,
    FullName VARCHAR(100),
    Email VARCHAR(100)
);

CREATE TABLE Pokemon (
    PokemonId INT IDENTITY(1,1) PRIMARY KEY,
    PokemonName VARCHAR(100)
);

CREATE TABLE Result (
    ResultId INT IDENTITY(1,1) PRIMARY KEY,
    VoterId INT,
    PokemonId INT,
    FOREIGN KEY (VoterId) REFERENCES Voter(VoterId),
    FOREIGN KEY (PokemonId) REFERENCES Pokemon(PokemonId)
);