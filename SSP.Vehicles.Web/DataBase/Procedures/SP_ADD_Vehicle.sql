CREATE OR ALTER PROCEDURE SP_ADD_Vehicle
          
(
    @Year INT, 
    @Automaker VARCHAR(100),
    @Price DECIMAL(18,2),
    @VehicleStatusId INT, 
    @FipeCode VARCHAR(10),
    @FipeFuel VARCHAR(10),
    @FipeModel VARCHAR(50),
    @Color VARCHAR(20)
)
AS BEGIN
    SET NOCOUNT ON;
    
    INSERT INTO Vehicles
    (
     Year, 
     Automaker,
     Price,
     VehicleStatusId,
     FipeCode,
     FipeFuel,
     FipeModel,
     Color
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
    @Color
    );    
    SELECT SCOPE_IDENTITY() AS VehicleId;
END;    
