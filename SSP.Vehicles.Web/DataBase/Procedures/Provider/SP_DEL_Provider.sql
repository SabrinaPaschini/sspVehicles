CREATE OR ALTER PROCEDURE SP_DEL_Provider
    
(
@ProviderId INT    
)
AS 
BEGIN
DELETE 
    FROM Providers 
    WHERE 
    @providerId = providerId
END
          
          
          
          