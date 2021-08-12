Create or alter  PROCEDURE Proc_subject
@Flag	VARCHAR(100)	= NULL
,@Id	INT	= NULL
,@Subject	NVARCHAR(100)	=NULL
,@Description	NVARCHAR(255)	=NUll

AS
Begin

	If	(@Flag = 'Insert')
	BEGIN
	Insert into Tbl_Subjects
	(Subject,description)
	Values
	(@Subject,@Description)
	END

	Else If (@Flag = 'Update')
	Begin
	Update Tbl_Subjects
	Set
	Subject = @Subject
	,Description = @Description
	Where RowId = @Id
	END

	Else If	(@Flag = 'Delete')
	Begin
	Update Tbl_Subjects
	Set 
	IsActive = '0'
	Where RowId = @Id
	END

END

