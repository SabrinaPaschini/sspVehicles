CREATE OR ALTER PROCEDURE SP_DEL_Vehicle
          
(
    @VehicleId INT
)
AS 
BEGIN
    DELETE FROM Vehicles 
           WHERE VehicleId = @VehicleId
END;    
