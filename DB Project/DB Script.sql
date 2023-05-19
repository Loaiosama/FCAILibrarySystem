CREATE TABLE [STUDENT] (
  [studentID] int,
  [firstName] varchar(50),
  [lastName] varchar(50),
  [email] varchar(50),
  PRIMARY KEY ([studentID])
);

CREATE TABLE [AUTHOR] (
  [authorID] int,
  [authorName] varchar(50),
  PRIMARY KEY ([authorID])
);

CREATE TABLE [ADMIN] (
  [adminID] int,
  [firstName] varchar(50),
  [lastName] varchar(50),
  [email] varchar(50),
  PRIMARY KEY ([adminID])
);

CREATE TABLE [PUBLISHER] (
  [street] varchar(50),
  [city] varchar(50),
  [phoneNum] varchar(11),
  [publisherID] int PRIMARY KEY
);

CREATE TABLE [BOOKS] (
  [bookID] int,
  [title] varchar(50),
  [authorID] int FOREIGN KEY REFERENCES AUTHOR (authorID),
  [available] varchar(50),
  [category] varchar(50),
  [publicationDate] varchar(50),
  [adminID] int FOREIGN KEY REFERENCES ADMIN (adminID),
  PRIMARY KEY ([bookID]),
  publisherID int FOREIGN KEY REFERENCES PUBLISHER (publisherID),
);

CREATE TABLE [SYSTEM] (
  [bookID] int FOREIGN KEY REFERENCES BOOKS (bookID),
  [StudentID] int FOREIGN KEY REFERENCES STUDENT (studentID),
  [borrowDate] varchar(50),
  [returnDate] varchar(50),
  
);

CREATE TABLE [STUDENT_PH] (
  [studentID] int FOREIGN KEY REFERENCES STUDENT (studentID),
  [personalPhone] varchar(11),
  [homePhone] varchar(8)
);



