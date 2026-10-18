CREATE OR ALTER PROCEDURE SP_ADD_Provider

(
    @Name VARCHAR(50), 
    @Email VARCHAR(100),
    @Phone VARCHAR(50),
    @Address VARCHAR(100),   
    @City VARCHAR(100),
    @State VARCHAR(50),
    @Zip VARCHAR(50),
    @Country VARCHAR(50)
)
AS 
BEGIN
    INSERT INTO Providers 
    (
    Name,
    Email,
    Phone,
    Address,
    City,
    State,
    Zip,
    Country    
    ) 
    VALUES
    (
    @Name,    
    @Email,   
    @Phone,   
    @Address,
    @City,    
    @State,   
    @Zip,     
    @Country  
    ) SELECT CAST(SCOPE_IDENTITY() AS INT) AS ProviderId
END;

    