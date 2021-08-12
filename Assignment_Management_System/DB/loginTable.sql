Create table Tbl_Users(
RowId	Bigint	Identity(1,1)	Not NULL
,UserName	NVARCHAR(100)	NOT NULL
,[Password]	NVARCHAR(100)	NOT NULL
)




alter table tbl_users
add UserType	NVARCHAR(100)	Not Null

--insert into Tbl_Users 
--(UserName,[Password],UserType)
--Values
--('admin','admin','Teacher')