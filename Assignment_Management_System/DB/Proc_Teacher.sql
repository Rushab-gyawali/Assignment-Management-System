Create or alter procedure Proc_Teacher
@Flag		NVARCHAR(100)		= NULL
,@Id		BIGINT				= NULL
,@Teacher	NVARCHAR(100)		= NULL
,@Subject	NVARCHAR(100)		= NULL

As
	BEGIN
		If	(@Flag = 'Insert')
		BEGIN
		INSERT INto Tbl_Teachers
		(TeachersName,[Subject])
		Values
		(@Teacher,@Subject)
		END

		ELSE IF	(@Flag = 'Update')
		BEGIN
		UPDATE Tbl_Teachers
		Set
		TeachersName = @Teacher
		,[Subject] = @Subject
		Where 
		RowId = @Id
		END

		Else If (@Flag = 'Delete')
		BEGIN
		Update Tbl_Teachers
		Set
		IsActive = 0
		where 
		RowId = @Id
		END
	END