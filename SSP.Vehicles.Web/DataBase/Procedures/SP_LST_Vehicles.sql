CREATE OR ALTER PROCEDURE SP_LST_Vehicles

    AS BEGIN    
    
    SELECT 
        Vehicles.VehicleId,
        Vehicles.Automaker, 
        vehicles.FipeCode,
        vehicles.Price
        
    FROM 
        Vehicles
    ORDER BY 
    Vehicles.Automaker
        
END

       
          