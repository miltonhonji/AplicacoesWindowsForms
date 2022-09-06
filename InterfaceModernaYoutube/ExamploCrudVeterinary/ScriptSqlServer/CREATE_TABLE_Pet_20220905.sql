USE VeterinaryDb
GO

CREATE TABLE Pet
(
	Pet_Id		Int				Identity(100000,1),
	Pet_Name	NVarChar(50)	Not Null,
	Pet_Type	NVarChar(50)	Not Null,
	Pet_Colour  NVarChar(50)	Not Null
)

ALTER TABLE dbo.Pet
ADD CONSTRAINT PK_Pet
PRIMARY KEY(Pet_Id)