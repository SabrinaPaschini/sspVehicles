CREATE OR ALTER PROCEDURE SP_LST_Provider
    
AS
BEGIN    
      
SELECT 
   Providers.ProviderId,
   Providers.Name, 
   Providers.Email, 
   Providers.Address
FROM
    Providers 
ORDER BY    
    Providers.Name
END 
       
