CREATE PROCEDURE SP_InsertIntoStudentCourses @StudentName NVARCHAR(50),
                                             @CourseName  NVARCHAR(50)
AS
  BEGIN
      DECLARE @StudentId INT
      DECLARE @CourseId INT

      SELECT @StudentId = Id
      FROM   Students
      WHERE  StudentName = @StudentName

      SELECT @CourseId = Id
      FROM   Courses
      WHERE  CourseName = @CourseName

      IF ( @StudentId IS NULL )
        BEGIN
            INSERT INTO Students
            VALUES     (@StudentName)

            SELECT @StudentId = SCOPE_IDENTITY()
        END

      IF ( @CourseId IS NULL )
        BEGIN
            INSERT INTO Courses
            VALUES     (@CourseName)

            SELECT @CourseId = SCOPE_IDENTITY()
        END

      INSERT INTO StudentCourses
      VALUES     (@StudentId,
                  @CourseId)
  END 