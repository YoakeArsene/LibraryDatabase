CREATE DATABASE Assignment1_Library
GO
USE Assignment1_Library
CREATE TABLE Books
(
     BookId INT IDENTITY NOT NULL,
	 AuthorId INT NOT NULL,
	 ShelfId INT NOT NULL,
	 Title VARCHAR(50) NOT NULL,
	 Origin VARCHAR(50),
	 Status VARCHAR(50) NOT NULL,
	 NumberOfCopies INT NOT NULL,
	 CONSTRAINT PK_Book PRIMARY KEY CLUSTERED (BookId)
);
CREATE TABLE BookAuthors
(
     AuthorId INT IDENTITY NOT NULL,
	 AuthorName VARCHAR(50),
	 Gender VARCHAR(50),
	 Nationality VARCHAR(50),
	 CONSTRAINT PK_BookAuthors PRIMARY KEY CLUSTERED (AuthorId)
);
CREATE TABLE Shelves
(
     ShelfId INT IDENTITY NOT NULL,
	 GenreName VARCHAR(50),
	 NumberOfBooks INT,
	 CONSTRAINT PK_Shelves PRIMARY KEY CLUSTERED (ShelfId)
);
CREATE TABLE BookLoans
(
     TicketId INT IDENTITY NOT NULL,
	 BookId INT NOT NULL,
	 ShelfId INT NOT NULL,
	 StudentId INT NOT NULL,
	 Duration VARCHAR(50) NOT NULL,
	 DateOut DATE NOT NULL,
	 DateIn DATE,
	 Quantity INT NOT NULL,
	 CONSTRAINT PK_BookLoans PRIMARY KEY CLUSTERED (TicketId)
);
CREATE TABLE Borrowers
(
     StudentId INT IDENTITY NOT NULL,
	 StudentName VARCHAR(50) NOT NULL,
	 Class VARCHAR(50),
	 StudentAddress VARCHAR(50),
	 PhoneNumber VARCHAR(50),
	 CONSTRAINT PK_Borrower PRIMARY KEY CLUSTERED (StudentId)
);
ALTER TABLE Books
ADD CONSTRAINT FK_Books_BookAuthors FOREIGN KEY (AuthorId) REFERENCES BookAuthors(AuthorId)
GO
ALTER TABLE Books
ADD CONSTRAINT FK_Books_Shelves FOREIGN KEY (ShelfId) REFERENCES Shelves(ShelfId)
GO
ALTER TABLE BookLoans
ADD CONSTRAINT FK_BooksLoan_Books FOREIGN KEY (BookId) REFERENCES Books(BookId)
GO
ALTER TABLE BookLoans
ADD CONSTRAINT FK_BooksLoan_Shelves FOREIGN KEY (ShelfId) REFERENCES Shelves(ShelfId)
GO
ALTER TABLE BookLoans
ADD CONSTRAINT FK_BooksLoan_Borrowers FOREIGN KEY (StudentId) REFERENCES Borrowers(StudentId)
GO







