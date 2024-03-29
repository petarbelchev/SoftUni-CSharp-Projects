CREATE TABLE Students (
	StudentID INT NOT NULL UNIQUE,
	[Name] NVARCHAR(50) NOT NULL,
)

CREATE TABLE Exams (
	ExamID INT NOT NULL UNIQUE,
	[Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE StudentsExams (
	StudentID INT NOT NULL,
	ExamID INT NOT NULL
)

INSERT INTO Students
	 VALUES (1, 'Mila'),
			(2, 'Toni'),
			(3, 'Ron')

INSERT INTO Exams
	 VALUES (101, 'SpringMVC'),
			(102, 'Neo4j'),
			(103, 'Oracle 11g')

INSERT INTO StudentsExams
	 VALUES (1, 101),
			(1, 102),
			(2, 101),
			(3, 103),
			(2, 102),
			(2, 103)

   ALTER TABLE Students
ADD CONSTRAINT PK_Students
   PRIMARY KEY (StudentID)

   ALTER TABLE Exams
ADD CONSTRAINT PK_Exams
   PRIMARY KEY (ExamID)

   ALTER TABLE StudentsExams
ADD CONSTRAINT PK_StudentsExams
   PRIMARY KEY (StudentID, ExamID)

   ALTER TABLE StudentsExams
ADD CONSTRAINT FK_StudentsExams_Students
   FOREIGN KEY (StudentID)
	REFERENCES Students (StudentID)

   ALTER TABLE StudentsExams
ADD CONSTRAINT FK_StudentsExams_Exams
   FOREIGN KEY (ExamID)
	REFERENCES Exams (ExamID)