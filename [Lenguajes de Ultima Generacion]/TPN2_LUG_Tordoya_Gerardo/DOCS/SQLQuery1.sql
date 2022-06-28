CREATE PROCEDURE SP_STUDENT_COURSES_ABM @StudentId     INTEGER,
                                        @StudentName   VARCHAR(50),
                                        @StatementType NVARCHAR(20)
AS
  BEGIN
      IF @StatementType = 'Insert'
        BEGIN
            INSERT Students(StudentName)
			SELECT DISTINCT @StudentName
			FROM Students
            WHERE NOT EXISTS (SELECT * FROM Students WHERE StudentId = @StudentId)
        END

      IF @StatementType = 'Select'
        BEGIN
            SELECT *
            FROM   Students
			WHERE  StudentId = @StudentId
        END

      IF @StatementType = 'Update'
        BEGIN
            UPDATE Students
            SET    StudentName = @StudentName
            WHERE  StudentId = @StudentId
        END

      IF @StatementType = 'Delete'
        BEGIN
            DELETE FROM Students
            WHERE  StudentId = @StudentId
        END
  END