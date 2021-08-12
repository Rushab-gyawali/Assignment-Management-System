Create table Tbl_Teachers
(
RowId	BigInt		Identity(1,1)	Not Null
,TeachersName	NVARCHAR(100)		NOT NULL
,[Subject]		NVARCHAR(100)		NOT NULL
)


Alter table Tbl_Teachers
Add IsActive	Bit  Default(1) Not Null