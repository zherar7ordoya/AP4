CREATE PROCEDURE ABM_StudentCourses @StudentId     INTEGER,
                                    @StudentName   VARCHAR(50),
								    @CourseId      INTEGER,
                                    @CourseName    VARCHAR(50),
                                    @StatementType NVARCHAR(20)
AS
	BEGIN
		DECLARE @Student_Id int
		DECLARE @Course_Id int

		IF @StatementType = 'Insert'
			BEGIN
				INSERT Students(StudentName)
				SELECT DISTINCT @StudentName
				FROM Students
				WHERE NOT EXISTS (SELECT * FROM Students WHERE StudentId = @StudentId)

				IF @StudentId = 0
					BEGIN
						SELECT @Student_Id = SCOPE_IDENTITY()
					END
				ELSE
					BEGIN
						SELECT @Student_Id = @StudentId
					END

				INSERT Courses(CourseName)
				SELECT DISTINCT @CourseName
				FROM Courses
				WHERE NOT EXISTS (SELECT * FROM Courses WHERE CourseId = @CourseId)

				IF @CourseId = 0
					BEGIN
						SELECT @Course_Id = SCOPE_IDENTITY()
					END
				ELSE
					BEGIN
						SELECT @Course_Id = @CourseId
					END

				INSERT INTO StudentCourses
				VALUES (@Student_Id, @Course_Id)
			END

      IF @StatementType = 'Select'
        BEGIN
            SELECT StudentName, CourseName
			FROM Courses
			JOIN StudentCourses ON Courses.CourseId = StudentCourses.CourseId
			JOIN Students ON Students.StudentId = StudentCourses.StudentId
			WHERE Students.StudentId = @StudentId
        END

      --NOTA SOBRE UPDATE
	  --https://stackoverflow.com/questions/9334766/updating-in-a-many-to-many-relationship
	  --Estrategia recomendada:
	  --Delete all roles and re-insert. This is a straight-forward approach.
	  --Remove all the roles for the user and just re-insert.

	  --////////////////////////////////////////////////////////////////////////
	  --RECORDATORIO: Students luego serán órdenes y Courses, productos (ítems).
	  --////////////////////////////////////////////////////////////////////////

	  IF @StatementType = 'Update'
        BEGIN
			--BORRADO
			DELETE FROM Students
            WHERE  StudentId = @StudentId

			--REINSERCIÓN
			INSERT Students(StudentName)
				SELECT DISTINCT @StudentName
				FROM Students
				WHERE NOT EXISTS (SELECT * FROM Students WHERE StudentId = @StudentId)

				SELECT @Student_Id = SCOPE_IDENTITY()

				INSERT Courses(CourseName)
				SELECT DISTINCT @CourseName
				FROM Courses
				WHERE NOT EXISTS (SELECT * FROM Courses WHERE CourseId = @CourseId)

				SELECT @Course_Id = SCOPE_IDENTITY()

				INSERT INTO StudentCourses
				VALUES (@Student_Id, @Course_Id)
        END

      IF @StatementType = 'Delete'
        BEGIN
            DELETE FROM Students
            WHERE  StudentId = @StudentId
        END
	END