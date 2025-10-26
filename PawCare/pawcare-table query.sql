create database Groom_Veterinary_Clinic;

use Groom_Veterinary_Clinic;

Create Table UserAccount 
(
	AccountID INT Primary key identity (1,1),
	Email varchar (75) NOT NULL,
	Password varchar (75) NOT null 
);


select * from UserAccount;


insert into UserAccount (Email,Password)
values ('hanjel@gmail.com','cutie');


CREATE TABLE Customer (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    MiddleName NVARCHAR(50),
    LastName NVARCHAR(50) NOT NULL,
    Suffix NVARCHAR(10),
    ContactNumber NVARCHAR(20),
    Email NVARCHAR(100),
    Created_At DATETIME DEFAULT GETDATE()
);


CREATE TABLE CustomerAddress (
    AddressID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT NOT NULL,
    Region NVARCHAR(100),
    MunicipalityCity NVARCHAR(100),
    Barangay NVARCHAR(100),
    HouseNo NVARCHAR(50),
    LotBlock NVARCHAR(50),
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
        ON DELETE CASCADE
);


CREATE TABLE Pet (
    PetID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT NOT NULL,
    PetName NVARCHAR(50) NOT NULL,
    PetType NVARCHAR(50),     
    Breed NVARCHAR(50),
    Gender NVARCHAR(10),
    DateOfBirth DATE,
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
        ON DELETE CASCADE
);

CREATE TABLE ServiceRecord (
    ServiceID INT IDENTITY(1,1) PRIMARY KEY,
    PetID INT NOT NULL,
    ServiceType NVARCHAR(50),       
    Weight DECIMAL(5,2),           
    AssignedVeterinarian NVARCHAR(100),
    Picture VARBINARY(MAX),         -- Store image as binary
    ServiceDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (PetID) REFERENCES Pet(PetID)
        ON DELETE CASCADE
);


select * from CustomerAddress;
select * from Pet;
select * from Customer;
select * from ServiceRecord;

-- NEW UPDATE MUST READ!!!
-- new table for veterinarian and services

CREATE TABLE Veterinarian (
    VeterinarianID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    MiddleName NVARCHAR(50),
    Suffix NVARCHAR(10), 
    ContactNumber NVARCHAR(20),
    Email NVARCHAR(100),    
    Specialization NVARCHAR(100)
);

-- Create Service Table
CREATE TABLE Service (
    ServiceID INT IDENTITY(1,1) PRIMARY KEY,
    ServiceName NVARCHAR(50) NOT NULL,
    Description NVARCHAR(200)
);

-- ALTER TABLE MUST READ!!
-- Alter service table 
ALTER TABLE ServiceRecord
ADD VeterinarianID INT,
    ServiceTypeID INT;   -- ID for service (service table)

-- Add Foreign Key for Veterinarian
ALTER TABLE ServiceRecord
ADD CONSTRAINT FK_ServiceRecord_Vet
    FOREIGN KEY (VeterinarianID) REFERENCES Veterinarian(VeterinarianID);

-- Add Foreign Key for Service Type
ALTER TABLE ServiceRecord
ADD CONSTRAINT FK_ServiceRecord_ServiceType
    FOREIGN KEY (ServiceTypeID) REFERENCES Service(ServiceID);

-- REMOVED OLD COLUMNS!!! MUST READ!!!
ALTER TABLE ServiceRecord
DROP COLUMN AssignedVeterinarian;

ALTER TABLE ServiceRecord
DROP COLUMN ServiceType;

ALTER TABLE Service
ADD Price DECIMAL(10,2) NOT NULL DEFAULT 0.00;

ALTER TABLE Veterinarian
ADD MiddleName NVARCHAR(100) NULL;


    select * from ServiceRecord;
    select * from Service;
    select * from Veterinarian;
    Select * from UserAccount;

-- ALTER THE USERACCOUNT TABLE FOR ADD ROLE COLUMN 
-- lagay ka na lang din ng account na naka Admin role 
-- Role (Employee and Admin)
ALTER TABLE UserAccount
ADD Role VARCHAR(50) NOT NULL DEFAULT 'Employee';
