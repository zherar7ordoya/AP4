--Posts: id, author, date, content
--Tags: id, name
--PostTags: post_id, tag_id

--Posts: Courses
--Tags: Students
--PostTags: StudentCourses


SELECT StudentName, CourseName
FROM Courses
JOIN StudentCourses ON Courses.CourseId = StudentCourses.CourseId
JOIN Students ON Students.StudentId = StudentCourses.StudentId
WHERE Students.StudentId = 2