CREATE OR ALTER PROCEDURE SP_GET_ProviderById
    
(
    @ProviderId INT
)
AS 
BEGIN
    SELECT 
        ProviderId,
        Name,
        Email,
        Phone,
        Address,
        City,
        State,
        Zip,
        Country,
        IsActive
    FROM 
        Providers 
    WHERE 
    Providers.providerId = @ProviderId
END          