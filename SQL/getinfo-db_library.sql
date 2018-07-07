USE [db_library]
GO

CREATE PROCEDURE [dbo].[get_info]
AS
BEGIN
/*Copies of book "The Lost Tribe" owned by "Sharpstown"*/
SELECT No_Of_Copies FROM tbl_book_copies
Where BookId=1
AND
BranchId=1

/* Copies of book "The Lost Tribe" owned by each branch*/
SELECT No_Of_Copies,BranchName FROM tbl_book_copies
INNER JOIN tbl_library_branch ON tbl_library_branch.BranchId=tbl_book_copies.BranchId
Where BookId=1

/*Names of borrowers who do not have books checked out*/


SELECT NAME FROM tbl_borrower WHERE NOT EXISTS(SELECT * FROM tbl_book_loans WHERE tbl_borrower.CardNo=tbl_book_loans.CardNo)

/*Book that is loaned from Sharpstown, Due Date is today, retrieve book title, borrower's name, and borrower's address*/

SELECT tbl_book.Title, tbl_borrower.Name, tbl_borrower.BorrowerAddress FROM tbl_book
INNER JOIN tbl_book_loans ON tbl_book.BookId=tbl_book_loans.BookId
INNER JOIN tbl_borrower ON tbl_borrower.CardNo=tbl_book_loans.CardNo
INNER JOIN tbl_library_branch ON tbl_library_branch.BranchId=tbl_book_loans.BranchID
WHERE tbl_library_branch.BranchName='Sharpstown'
AND DueDate='2018-07-06'


/*For each library branch, branch name and total number of books loaned from that branch*/

SELECT tbl_library_branch.BranchName, Count(*) FROM tbl_book_loans
INNER JOIN tbl_library_branch ON tbl_library_branch.BranchId=tbl_book_loans.BranchID
GROUP BY tbl_library_branch.BranchName

/*Retrieve names, addresses, and number of books checked out for all borrowers who have more than 5 books checked out*/
SELECT tbl_borrower.Name, tbl_borrower.BorrowerAddress, COUNT(tbl_book_loans.CardNo) as '# Books Checked Out' FROM tbl_borrower
INNER JOIN tbl_book_loans ON tbl_book_loans.CardNo=tbl_borrower.CardNo
GROUP BY Name, BorrowerAddress
HAVING COUNT(tbl_book_loans.CardNo)>5

/*Book authored by Stephen King, title, number of copies owned by Central*/
SELECT tbl_book.Title, tbl_book_copies.No_Of_Copies FROM tbl_book
INNER JOIN tbl_book_copies ON tbl_book.BookId=tbl_book_copies.BookId
INNER JOIN tbl_book_authors ON tbl_book.BookId=tbl_book_authors.BookId
INNER JOIN tbl_library_branch ON tbl_book_copies.BranchID=tbl_library_branch.BranchId
WHERE AuthorName='Stephen King'
AND BranchName = 'Central'

END
GO

