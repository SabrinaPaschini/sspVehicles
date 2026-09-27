CREATE OR ALTER PROCEDURE SP_ADD_Vehicle
          
(
    @Year INT, 
    @Automaker VARCHAR(100),
    @Price DECIMAL(18,2),
    @VehicleStatusId INT, 
    @FipeCode VARCHAR(10),
    @FipeFuel VARCHAR(10),
    @FipeModel VARCHAR(50),
    @Color VARCHAR(20),
    @LicensePlate VARCHAR(7)
)
AS 
BEGIN
    
    INSERT INTO Vehicles
    (
     Year, 
     Automaker,
     Price,
     VehicleStatusId,
     FipeCode,
     FipeFuel,
     FipeModel,
     Color,
     LicensePlate
    )
    VALUES 
    (
    @Year,
    @Automaker,
    @Price,
    @VehicleStatusId,
    @FipeCode,
    @FipeFuel,
    @FipeModel,
    @Color,
    @LicensePlate
    );    
    SELECT CAST (SCOPE_IDENTITY() AS INT) AS VehicleId;
END;    
