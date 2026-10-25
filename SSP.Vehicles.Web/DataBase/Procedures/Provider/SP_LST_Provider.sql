CREATE OR ALTER PROCEDURE SP_LST_Provider
      AS BEGIN    
      
SELECT 
   -- TODO 6: Retornar tambem ProviderId para montar o link de edicao de cada fornecedor.
   Providers.Name, 
   Providers.Email, 
   Providers.Address
FROM
    Providers 
ORDER BY    
    Providers.Name
END 
       
