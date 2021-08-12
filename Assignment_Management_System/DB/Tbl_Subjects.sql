Create table Tbl_Subjects
(
RowId			BigInt		IDENTITY(1,1)	NOT NULL
,[Subject]		NVARCHAR(100)	NOt null
,[Description]	NVARCHAR(100)	NOT NULL
)	


alter table tbl_Subjects
Add	IsActive	BIT	 Default '1' Not NULL