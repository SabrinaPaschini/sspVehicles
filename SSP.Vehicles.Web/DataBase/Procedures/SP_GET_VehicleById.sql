CREATE OR ALTER PROCEDURE SP_GET_VehicleById

(
    @VehicleId INT 
)
AS 
BEGIN
    
SELECT
    VehicleId,
    Year,
    Automaker,
    Price,
    VehicleStatusId,
    FipeCode,
    FipeFuel,
    FipeModel,
    Color,
    LicensePlate
FROM 
    Vehicles 
WHERE 
    Vehicles.vehicleID = @vehicleId
END;    
          
          
       