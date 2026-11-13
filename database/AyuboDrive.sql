-- AyoboDrive sample database (SQL Server)
-- Recreates the three tables the app uses plus the original sample rows.
-- Source: AyuboDrive.bak (full backup taken 2022-09-20).
--
-- Usage (LocalDB example):
--   sqlcmd -S "(localdb)\MSSQLLocalDB" -E -i AyuboDrive.sql
-- Then build the app. If you use this script instead of the bundled .mdf, point the
-- connection string in AyoboDrive/App.config at the database "AyuboDrive".

IF DB_ID('AyuboDrive') IS NULL CREATE DATABASE AyuboDrive;
GO
USE AyuboDrive;
GO

CREATE TABLE dbo.newDriver (
    driverId     int          NOT NULL,
    driverName   varchar(50)  NOT NULL,
    age          int          NOT NULL,
    gender       varchar(10)  NOT NULL,
    address      varchar(100) NOT NULL,
    mobileNumber varchar(50)  NOT NULL,
    driverRate   varchar(50)  NULL
);

CREATE TABLE dbo.newPackage (
    packageId       int         NOT NULL,
    packageName     varchar(50) NOT NULL,
    packageRate     int         NULL,
    maximumDistance float       NULL,
    maximumDuration float       NULL
);

CREATE TABLE dbo.newVehicle (
    vehicleId       int         NOT NULL,
    vehicleName     varchar(50) NOT NULL,
    vehicleType     varchar(50) NULL,
    licenceNumber   varchar(50) NOT NULL,
    numberOfSeats   int         NOT NULL,
    dayRate         int         NULL,
    weekRate        int         NULL,
    monthRate       int         NULL,
    driverRate      int         NULL,
    previousReading int         NULL
);
GO

INSERT INTO dbo.newDriver VALUES (1, 'Aladdin', 28, 'Male', '200, Peradeniya Road, Kandy', '0778897722', '3000');
INSERT INTO dbo.newDriver VALUES (2, 'Jasmin', 25, 'Female', '122, Kandy Road, Matale.', '0754040281', '2500');

INSERT INTO dbo.newPackage VALUES (1, 'In-Town Package', 1000, 10, 1);
INSERT INTO dbo.newPackage VALUES (2, 'In-District Package', 5000, 50, 5);
INSERT INTO dbo.newPackage VALUES (3, 'Airport Drop Package', 8000, 100, 2);

INSERT INTO dbo.newVehicle VALUES (1, 'Prius', 'Car', 'CP CDR-9001', 5, 500, 2000, 8000, 500, 120092);
INSERT INTO dbo.newVehicle VALUES (2, 'KDH', 'VAN', 'CP VPP-9102', 12, 2000, 8000, 15000, 2000, 5003);
GO
