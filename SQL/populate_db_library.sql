USE [db_library]
GO

CREATE PROCEDURE [dbo].[populate_db_library]
AS
BEGIN


/*****************
Creating Tables
******************/
	CREATE TABLE tbl_publisher(
	Name VARCHAR(100) PRIMARY KEY NOT NULL,
	PublisherAddress VARCHAR(100) NOT NULL,
	Phone VARCHAR(15) NOT NULL
	);

	CREATE TABLE tbl_book(
	BookId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Title VARCHAR(100) NOT NULL, 
	PublisherName VARCHAR(100) NOT NULL CONSTRAINT fk_Name FOREIGN KEY REFERENCES tbl_publisher(Name) ON UPDATE CASCADE ON DELETE CASCADE
	);
	
	
	CREATE TABLE tbl_book_authors(
	BookId INT CONSTRAINT fk_BookId FOREIGN KEY REFERENCES tbl_book(BookId) ON UPDATE CASCADE ON DELETE CASCADE,
	AuthorName VARCHAR(50) NOT NULL
	);

	CREATE TABLE tbl_library_branch(
	BranchId INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	BranchName VARCHAR(50) NOT NULL,
	BranchAddress VARCHAR(50) NOT NULL
	);
	
	CREATE TABLE tbl_borrower(
	CardNo INT PRIMARY KEY NOT NULL IDENTITY(1000,1),
	Name VARCHAR(50) NOT NULL,
	BorrowerAddress VARCHAR(50) NOT NULL,
	Phone VARCHAR(15) NOT NULL
	);


	CREATE TABLE tbl_book_loans(
	BookId INT NOT NULL CONSTRAINT fk_Book_ID FOREIGN KEY REFERENCES tbl_book(BookId) ON UPDATE CASCADE ON DELETE CASCADE,
	BranchID INT NOT NULL CONSTRAINT fk_Branch_Id FOREIGN KEY REFERENCES tbl_library_branch(BranchId) ON UPDATE CASCADE ON DELETE CASCADE,
	CardNo INT NOT NULL CONSTRAINT fk_CardNo FOREIGN KEY REFERENCES tbl_borrower(CardNo) ON UPDATE CASCADE ON DELETE CASCADE,
	DateOut DATE,
	DueDate DATE
	);


	CREATE TABLE tbl_book_copies(
	BookId INT NOT NULL CONSTRAINT fkBookId FOREIGN KEY REFERENCES tbl_book(BookId) ON UPDATE CASCADE ON DELETE CASCADE,
	BranchID INT NOT NULL CONSTRAINT fk_BranchId FOREIGN KEY REFERENCES tbl_library_branch(BranchId) ON UPDATE CASCADE ON DELETE CASCADE,
	No_Of_Copies INT NOT NULL
	);


/*********************
Populating Tables
*********************/
	
	INSERT INTO tbl_publisher
	(Name,PublisherAddress,Phone)
	VALUES
	('Picador USA', '175 5th Ave, New York, NY 10010','(800) 221-7945'),
	('Little, Brown and Company', '1290 Avenue Of The Amer Floor 6,New York, NY 10104','(212) 364-1100'),
	('Tor Books', '175 Fifth Avenue, New York, NY 10010','(646) 307-5088'),
	('Doubleday', '1745 Broadway, New York, NY 10019', '(716) 250-5700'),
	('Viking Press', '375 Hudson St, New York, NY 10014','(866) 761-6685'),
	('Penguin Random House', '1745 Broadway, New York, NY 10019', '(800) 733-3000'),
	('Simon & Schuster','1230 6th Ave, New York, NY 10020','(212) 698-7000'),
	('ESPN Books', '545 Middle St. Bristol, CT 06010', '(860) 766-2000'),
	('W. W. Norton & Company', '500 5th Ave # 6, New York, NY 10110', '(212) 354-5500'),
	('Farrar, Straus and Giroux','175 Varick St, New York, NY 10014','(212) 741-6900');

	SELECT * FROM tbl_publisher

	INSERT INTO tbl_book
	(Title,PublisherName)
	VALUES
	('The Lost Tribe','Picador USA'),
	('Outliers','Little, Brown and Company'),
	('Blink: The Power of Thinking Without Thinking','Little, Brown and Company'),
	('The Tipping Point','Little, Brown and Company'),
	('David and Goliath','Little, Brown and Company'),
	('What the Dog Saw','Little, Brown and Company'),
	('The Way of Kings', 'Tor Books'),
	('Words of Radiance', 'Tor Books'),
	('Oathbringer', 'Tor Books'),
	('The Shining', 'Doubleday'),
	('It', 'Viking Press'),
	('Enders Game', 'Tor Books'),
	('Mindset: The New Psychology of Success', 'Penguin Random House'),
	('Principles','Simon & Schuster'),
	('Ready Player One', 'Penguin Random House'),
	('Unbroken','Penguin Random House'),
	('The Book of Basketball', 'ESPN Books'),
	('Moneyball: The Art of Winning an Unfair Game', 'W. W. Norton & Company'),
	('Thinking, Fast and Slow','Farrar, Straus and Giroux'),
	('The Black Swan: The Impact of the Highly Imporbable','Penguin Random House');

	SELECT * FROM tbl_book
	
	INSERT INTO tbl_book_authors
	(BookId,AuthorName)
	Values
	(1, 'Mark Lee'),
	(2, 'Malcolm Gladwell'),
	(3, 'Malcolm Gladwell'),
	(4, 'Malcolm Gladwell'),
	(5, 'Malcolm Gladwell'),
	(6, 'Malcolm Gladwell'),
	(7, 'Brandon Sanderson'),
	(8, 'Brandon Sanderson'),
	(9, 'Brandon Sanderson'),
	(10, 'Stephen King'),
	(11, 'Stephen King'),
	(12, 'Orson Scott Card'),
	(13, 'Carol S. Dweck'),
	(14, 'Ray Dalio'),
	(15, 'Ernest Cline'),
	(16, 'Laura Hildenbrand'),
	(17, 'Bill Simmons'),
	(18, 'Michael Lewis'),
	(19, 'Daniel Kahneman'),
	(20, 'Nassim Taleb');

	SELECT * FROM tbl_book_authors

	INSERT INTO tbl_library_branch
	(BranchName,BranchAddress)
	VALUES
	('Sharpstown','308 Kirkland Ave, Kirkland, WA 98033'),
	('Central','1959 NE Pacific St, Seattle, WA 98195'),
	('West', '12315 NE 143rd St, Kirkland, WA 98034'),
	('East', '15990 NE 85th St, Redmond, WA 98052');

	SELECT * FROM tbl_library_branch

	INSERT INTO tbl_borrower
	(Name,BorrowerAddress,Phone)
	VALUES
	('Nick Waters', '335 Primrose Dr., Fort Worth, TX 76110', '(630)266-6156'),
	('Kristin Bates', '8669 Andover St.. Joliet, IL 60435', '(630)774-3968'),
	('Janice Diaz', '26 Pennington Drive, Boston, MA 02127', '(337)917-1030'),
	('Preston Montgomery', '554 Strawberry Court, Kalispell, MT 59901', '(228)868-8176'),
	('Georgia Woods', '218 Fairview Rd., Freeport, NY 11520', '(334)862-8292'),
	('Antonio Fox', '2 SE. Pumpkin Hill St., Ames, IA 50010', '(317)248-1618'),
	('Eileen Glover', '634 N. Penn Ave., North Canton, OH 44720', '(317)693-8834'),
	('Holly Perkins', '8488 3rd Lane, Des Moines, IA 50310', '(716)897-1184'),
	('Genevieve Bridges', '7810 Lake View Rd., Bay City, MI 48706', '(734)344-2179'),
	('Irvin Roy', '9860 Golden Star St., Paducah, KY 42001', '(205)452-2515'),
	('Shinji Kagawa','123 Blue Lane, Seattle, WA 30021','(123)456-7890');

	SELECT * FROM tbl_borrower

	INSERT INTO tbl_book_loans
	(BookId, BranchId, CardNo, DateOut, DueDate)
	VALUES
	(1,1,1000,'2018-06-06','2018-07-09'),
	(2,1,1000,'2018-06-06','2018-07-09'),
	(3,1,1000,'2018-06-06','2018-07-09'),
	(4,1,1000,'2018-06-06','2018-07-09'),
	(5,1,1000,'2018-06-06','2018-07-09'),
	(6,1,1000,'2018-06-06','2018-07-09'),
	(5,2,1000,'2018-06-06','2018-07-09'),
	(6,2,1001,'2018-06-10','2018-07-09'),
	(7,2,1001,'2018-06-10','2018-07-09'),
	(8,2,1001,'2018-06-10','2018-07-09'),
	(9,2,1001,'2018-06-10','2018-07-09'),
	(10,2,1001,'2018-06-10','2018-07-09'),
	(11,3,1002,'2018-06-14','2018-07-14'),
	(12,3,1002,'2018-06-14','2018-07-14'),
	(13,3,1002,'2018-06-14','2018-07-14'),
	(14,3,1002,'2018-06-14','2018-07-14'),
	(15,3,1002,'2018-06-14','2018-07-14'),
	(16,4,1003,'2018-06-18','2018-07-18'),
	(17,4,1003,'2018-06-18','2018-07-18'),
	(18,4,1003,'2018-06-18','2018-07-18'),
	(19,4,1003,'2018-06-18','2018-07-18'),
	(20,4,1003,'2018-06-18','2018-07-18'),
	(1,2,1004,'2018-06-22','2018-07-22'),
	(2,2,1004,'2018-06-22','2018-07-22'),
	(3,2,1004,'2018-06-22','2018-07-22'),
	(4,2,1004,'2018-06-22','2018-07-22'),
	(5,2,1004,'2018-06-22','2018-07-22'),
	(6,3,1005,'2018-06-26','2018-07-26'),
	(7,3,1005,'2018-06-26','2018-07-26'),
	(8,3,1005,'2018-06-26','2018-07-26'),
	(9,3,1005,'2018-06-26','2018-07-26'),
	(10,3,1005,'2018-06-26','2018-07-26'),
	(11,4,1006,'2018-06-06','2018-07-06'),
	(12,4,1006,'2018-06-06','2018-07-06'),
	(13,4,1006,'2018-06-06','2018-07-06'),
	(14,4,1006,'2018-06-06','2018-07-06'),
	(15,4,1006,'2018-06-06','2018-07-06'),
	(16,1,1007,'2018-06-06','2018-07-06'),
	(17,1,1007,'2018-06-06','2018-07-06'),
	(18,1,1007,'2018-06-06','2018-07-06'),
	(19,1,1007,'2018-06-06','2018-07-06'),
	(20,1,1007,'2018-06-06','2018-07-06'),
	(1,3,1008,'2018-06-08','2018-07-08'),
	(2,3,1008,'2018-06-08','2018-07-08'),
	(3,3,1008,'2018-06-08','2018-07-08'),
	(4,3,1008,'2018-06-08','2018-07-08'),
	(5,3,1008,'2018-06-08','2018-07-08'),
	(6,4,1009,'2018-06-13','2018-07-13'),
	(7,4,1009,'2018-06-13','2018-07-13'),
	(8,4,1009,'2018-06-13','2018-07-13'),
	(9,4,1009,'2018-06-13','2018-07-13'),
	(10,4,1009,'2018-06-13','2018-07-13');
	SELECT * FROM tbl_book_loans

	INSERT INTO tbl_book_copies
	(BookId,BranchId,No_Of_Copies)
	VALUES
	(1,1,2),
	(2,1,2),
	(3,1,2),
	(4,1,2),
	(5,1,2),
	(6,1,2),
	(7,1,2),
	(8,1,2),
	(9,1,2),
	(10,1,2),
	(11,1,2),
	(12,1,2),
	(13,1,2),
	(14,1,2),
	(15,1,2),
	(16,1,2),
	(17,1,2),
	(18,1,2),
	(19,1,2),
	(20,1,2),
	(1,2,2),
	(2,2,2),
	(3,2,2),
	(4,2,2),
	(5,2,2),
	(6,2,2),
	(7,2,2),
	(8,2,2),
	(9,2,2),
	(10,2,2),
	(11,2,2),
	(12,2,2),
	(13,2,2),
	(14,2,2),
	(15,2,2),
	(16,2,2),
	(17,2,2),
	(18,2,2),
	(19,2,2),
	(20,2,2),
	(1,3,2),
	(2,3,2),
	(3,3,2),
	(4,3,2),
	(5,3,2),
	(6,3,2),
	(7,3,2),
	(8,3,2),
	(9,3,2),
	(10,3,2),
	(11,3,2),
	(12,3,2),
	(13,3,2),
	(14,3,2),
	(15,3,2),
	(16,3,2),
	(17,3,2),
	(18,3,2),
	(19,3,2),
	(20,3,2),
	(1,4,2),
	(2,4,2),
	(3,4,2),
	(4,4,2),
	(5,4,2),
	(6,4,2),
	(7,4,2),
	(8,4,2),
	(9,4,2),
	(10,4,2),
	(11,4,2),
	(12,4,2),
	(13,4,2),
	(14,4,2),
	(15,4,2),
	(16,4,2),
	(17,4,2),
	(18,4,2),
	(19,4,2),
	(20,4,2);

	SELECT * FROM tbl_book_copies
END
GO
