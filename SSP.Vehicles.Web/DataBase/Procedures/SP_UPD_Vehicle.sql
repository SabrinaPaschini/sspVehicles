CREATE OR ALTER PROCEDURE SP_UPD_Vehicle
(
    @VehicleId INT,
    @Year INT = NULL,
    @Automaker VARCHAR(100) = NULL,
    @Price DECIMAL(18, 2) = NULL,
    @FipeCode VARCHAR(10) = NULL,
    @FipeFuel VARCHAR(10) = NULL,
    @FipeModel VARCHAR(50) = NULL,
    @Color VARCHAR(20) = NULL,
    @LicensePlate VARCHAR(7) = NULL
) 
AS BEGIN

UPDATE Vehicles
    SET
    Year = COALESCE(@Year,Year),
    Automaker = COALESCE(@Automaker,Automaker),
    Price = COALESCE(@Price, Price),
    FipeCode = COALESCE(@FipeCode,FipeCode),
    FipeFuel = COALESCE(@FipeFuel,FipeFuel),
    FipeModel = COALESCE(@FipeModel, FipeModel),
    Color = COALESCE(@Color, Color),
    LicensePlate = COALESCE(@LicensePlate,LicensePlate)
WHERE  
    VehicleId = @VehicleId
END;
