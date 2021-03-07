INSERT INTO Books(AuthorId, ShelfId, Title, Origin, Status, NumberOfCopies) VALUES
  (1, 1, 'Lolita', 'Russia', 'New', 1),
  (2, 2, 'If Only It Were True', 'France', 'New', 4),
  (2, 2, 'Vous Revoir', 'France', 'New', 4)

INSERT INTO BookAuthors(AuthorName, Gender, Nationality) VALUES
  ('Vladimir Nabokov', 'Male', 'Russian'),
  ('Marc Levy', 'Male', 'French')

INSERT INTO Shelves(GenreName, NumberOfBooks) VALUES
  ('Classic', 100),
  ('Romance', 100)

INSERT INTO Borrowers(StudentName, Class, StudentAddress, PhoneNumber) VALUES
   ('Le Ngoc Chau Anh', 'GCD0808', '2/25 Ng Don Tiet, Thuan Phuoc, Hai Chau, Da Nang', '0844713102')
INSERT INTO BookLoans(BookId, ShelfId, StudentId, Duration, DateOut, DateIn, Quantity) VALUES
   (1, 1, 1, '1 week', '01-03-2021', '07-03-2021', 1)

   SELECT BookId, BookAuthors.AuthorName AS Author, Shelves.GenreName AS Genre, Title, Origin, Status, NumberOfCopies 
FROM Books
INNER JOIN BookAuthors ON Books.AuthorId = BookAuthors.AuthorId
INNER JOIN Shelves ON Books.ShelfId = Shelves.ShelfId

SELECT * FROM Borrowers
SELECT * FROM BookLoans

DBCC CHECKIDENT (Books, RESEED, 3)

CREATE PROC dbo.ViewLibrary
AS
   SELECT BookId, BookAuthors.AuthorName AS Author, Shelves.GenreName AS Genre, Title, Origin, Status, NumberOfCopies 
   FROM Books
   INNER JOIN BookAuthors ON Books.AuthorId = BookAuthors.AuthorId
   INNER JOIN Shelves ON Books.ShelfId = Shelves.ShelfId
GO

EXEC dbo.ViewLibrary

ALTER PROC dbo.AddBook(@Title VARCHAR(50), @Author VARCHAR(50), @Genre VARCHAR(50), @Origin VARCHAR(50), @Status VARCHAR(50), @NoOfCopies INT)
AS
BEGIN
  IF EXISTS (SELECT AuthorName FROM BookAuthors WHERE AuthorName = @Author)
    BEGIN
	     WAITFOR DELAY '00:00:00'
    END
  ELSE 
    BEGIN
	     INSERT INTO BookAuthors(AuthorName) VALUES (@Author)
    END
  IF EXISTS (SELECT GenreName FROM Shelves WHERE GenreName = @Genre)
    BEGIN
	     WAITFOR DELAY '00:00:00'
    END
  ELSE 
    BEGIN
	     INSERT INTO Shelves(GenreName) VALUES (@Genre)
    END
  INSERT INTO Books(AuthorId, ShelfId, Title, Origin, Status, NumberOfCopies)
  SELECT BookAuthors.AuthorId, Shelves.ShelfId, @Title, @Origin, @Status, @NoOfCopies
  FROM BookAuthors, Shelves
  WHERE BookAuthors.AuthorName = @Author
  AND Shelves.GenreName = @Genre
END
BEGIN
  WITH CTE AS (
    SELECT Title, Origin, Status, NumberOfCopies,
        RN = ROW_NUMBER() OVER (PARTITION BY Title ORDER BY Title)
    FROM Books
)
DELETE FROM CTE WHERE RN > 1;
END
 
EXEC dbo.AddBook 'Shadow Thief', 'Marc Levy', 'Romance', 'France', 'New', 1



DELETE FROM Books WHERE BookId > 3

SELECT AuthorName FROM BookAuthors

CREATE PROC dbo.SearchLibrary(@Title VARCHAR(50), @Author VARCHAR(50), @Genre VARCHAR(50))
AS
   SELECT BookId, BookAuthors.AuthorName AS Author, Shelves.GenreName AS Genre, Title, Origin, Status, NumberOfCopies 
   FROM Books
   INNER JOIN BookAuthors ON Books.AuthorId = BookAuthors.AuthorId
   INNER JOIN Shelves ON Books.ShelfId = Shelves.ShelfId
   WHERE Title = @Title OR BookAuthors.AuthorName = @Author OR Shelves.GenreName = @Genre 

GO

EXEC dbo.SearchLibrary 'Lolita', '', ''

ALTER PROC dbo.UpdateBook(@Id INT, @Title VARCHAR(50), @Author VARCHAR(50), @Genre VARCHAR(50), @Origin VARCHAR(50), @Status VARCHAR(50), @NoOfCopies INT)
AS 
BEGIN
    IF EXISTS (SELECT AuthorName FROM BookAuthors WHERE AuthorName = @Author)
    BEGIN
	     WAITFOR DELAY '00:00:00'
    END
  ELSE 
    BEGIN
	     INSERT INTO BookAuthors(AuthorName) VALUES (@Author)
    END
  IF EXISTS (SELECT GenreName FROM Shelves WHERE GenreName = @Genre)
    BEGIN
	     WAITFOR DELAY '00:00:00'
    END
  ELSE 
    BEGIN
	     INSERT INTO Shelves(GenreName) VALUES (@Genre)
    END
  UPDATE Books SET Title = @Title, Origin = @Origin, NumberOfCopies = @NoOfCopies WHERE BookId = @Id
  UPDATE Books SET AuthorId = BookAuthors.AuthorId FROM Books INNER JOIN BookAuthors ON BookAuthors.AuthorName = @Author WHERE BookId = @Id
  UPDATE Books SET ShelfId = Shelves.ShelfId FROM Books JOIN Shelves ON Shelves.GenreName = @Genre  WHERE BookId = @Id
END


EXEC dbo.ViewLibrary

EXEC dbo.UpdateBook 5, 'Narutard', 'Masashi Kusanagi', 'Mangu', 'Japorn', 'New', 69

DELETE FROM Shelves WHERE ShelfId > 2

SELECT * FROM BookLoans

CREATE PROC dbo.ViewLoans
AS
   SELECT TicketId, Books.Title AS Title, Shelves.GenreName AS Genre, Borrowers.StudentName AS Student, Duration, DateOut, DateIn, Quantity 
   FROM BookLoans
   INNER JOIN Books ON BookLoans.BookId = Books.BookId 
   INNER JOIN Shelves ON BookLoans.ShelfId = Shelves.ShelfId
   INNER JOIN Borrowers ON BookLoans.StudentId = Borrowers.StudentId
GO

CREATE PROC dbo.SearchLoan(@Title VARCHAR(50), @Genre VARCHAR(50), @Student VARCHAR(50))
AS
   SELECT TicketId, Books.Title AS Title, Shelves.GenreName AS Genre, Borrowers.StudentName AS Student, Duration, DateOut, DateIn, Quantity 
   FROM BookLoans
   INNER JOIN Books ON BookLoans.BookId = Books.BookId 
   INNER JOIN Shelves ON BookLoans.ShelfId = Shelves.ShelfId
   INNER JOIN Borrowers ON BookLoans.StudentId = Borrowers.StudentId
   WHERE Title = @Title OR Shelves.GenreName = @Genre OR Borrowers.StudentName = @Student
GO

EXEC dbo.ViewLoans

ALTER PROC dbo.AddLoan(@Title VARCHAR(50), @Genre VARCHAR(50), @Student VARCHAR(50), @Duration VARCHAR(50), @DateOut DATE, @DateIn DATE, @Quantity INT)
AS
BEGIN
  IF EXISTS (SELECT Title FROM Book WHERE Title = @Title)
    BEGIN
	     WAITFOR DELAY '00:00:00'
    END
  ELSE 
    BEGIN
	     PRINT 'Book doesnt exist'
		 RETURN
    END
  IF EXISTS (SELECT GenreName FROM Shelves WHERE GenreName = @Genre)
    BEGIN
	     WAITFOR DELAY '00:00:00'
    END
  ELSE 
    BEGIN
	     PRINT 'Shelf doesnt exist'
		 RETURN
    END
  IF EXISTS (SELECT StudentName FROM Borrowers WHERE StudentName = @Student)
    BEGIN
	     WAITFOR DELAY '00:00:00'
    END
  ELSE 
    BEGIN
	     INSERT INTO Borrowers(StudentName) VALUES (@Student)
    END
  INSERT INTO BookLoans(BookId, ShelfId, StudentId, Duration, DateOut, DateIn, Quantity)
  SELECT Books.BookId, Shelves.ShelfId, Borrowers.StudentId, @Duration, @DateOut, @DateIn, @Quantity
  FROM Books, Shelves, Borrowers
  WHERE Books.Title = @Title
  AND Shelves.GenreName = @Genre
  AND Borrowers.StudentName = @Student
END
BEGIN
  WITH CTE AS (
    SELECT Duration, DateOut, DateIn, Quantity,
        RN = ROW_NUMBER() OVER (PARTITION BY Duration ORDER BY Duration)
    FROM BookLoans
)
DELETE FROM CTE WHERE RN > 1;
END

CREATE PROC dbo.UpdateLoan(@Id INT, @Title VARCHAR(50), @Genre VARCHAR(50), @Student VARCHAR(50), @Duration VARCHAR(50), @DateOut DATE, @DateIn DATE, @Quantity INT)
AS 
BEGIN
    IF EXISTS (SELECT Title FROM Books WHERE Title = @Title)
    BEGIN
	     WAITFOR DELAY '00:00:00'
    END
  ELSE 
    BEGIN
	     PRINT 'Book doesnt exist'
		 RETURN
    END
  IF EXISTS (SELECT GenreName FROM Shelves WHERE GenreName = @Genre)
    BEGIN
	     WAITFOR DELAY '00:00:00'
    END
  ELSE 
    BEGIN
	     PRINT 'Shelf doesnt exist'
		 RETURN
    END
  IF EXISTS (SELECT StudentName FROM Borrowers WHERE StudentName = @Student)
    BEGIN
	     WAITFOR DELAY '00:00:00'
    END
  ELSE 
    BEGIN
	     INSERT INTO Borrowers(StudentName) VALUES (@Student)
    END
  UPDATE BookLoans SET Duration = @Duration, DateOut = @DateOut, DateIn = @DateIn, Quantity = @Quantity WHERE TicketId = @Id 
  UPDATE BookLoans SET BookId = Books.BookId FROM BookLoans INNER JOIN Books ON Books.Title = @Title WHERE TicketId = @Id
  UPDATE BookLoans SET ShelfId = Shelves.ShelfId FROM BookLoans INNER JOIN Shelves ON Shelves.GenreName = @Genre  WHERE TicketId = @Id
END


EXEC dbo.AddLoan 'Lolita', 'Classic', 'Le Trung Duc', '3 days', '01-03-2021', '04-03-2021', 1


ALTER PROC dbo.ViewStudent
AS
   SELECT StudentId, StudentName, Class, StudentAddress, PhoneNumber
   FROM Borrowers
GO

ALTER PROC dbo.SearchStudent(@StudentName VARCHAR(50), @Class VARCHAR(50))
AS
   SELECT StudentId, StudentName, Class, StudentAddress, PhoneNumber 
   FROM Borrowers
   WHERE StudentName = @StudentName OR Class = @Class
GO

EXEC dbo.ViewStudent

CREATE PROC dbo.AddStudent(@StudentName VARCHAR(50), @Class VARCHAR(50), @Address VARCHAR(50), @PhoneNumber VARCHAR(50))
AS
BEGIN
  INSERT INTO Borrowers(StudentName, Class, StudentAddress, PhoneNumber) VALUES
  (@StudentName, @Class, @Address, @PhoneNumber)
END
BEGIN
  WITH CTE AS (
    SELECT Duration, DateOut, DateIn, Quantity,
        RN = ROW_NUMBER() OVER (PARTITION BY Duration ORDER BY Duration)
    FROM BookLoans
)
DELETE FROM CTE WHERE RN > 1;
END

CREATE PROC dbo.UpdateStudent(@Id INT, @StudentName VARCHAR(50), @Class VARCHAR(50), @Address VARCHAR(50), @PhoneNumber VARCHAR(50))
AS 
BEGIN 
  UPDATE Borrowers SET StudentName = @StudentName, Class = @Class, StudentAddress = @Address, PhoneNumber = @PhoneNumber WHERE StudentId = @Id 
END