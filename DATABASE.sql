USE Master
GO
DROP DATABASE Password_manager
GO
CREATE DATABASE Password_manager
GO
USE Password_manager
GO
CREATE TABLE USERS
(
USERID int not null,
USEREMAIL varchar(100) not null ,
USERPASSWORD varchar(100) not null,
PRIMARY KEY (USERID)
)
GO
CREATE TABLE SITES
(
SITEID INT NOT NULL,
SITENAME VARCHAR(100)NOT NULL,
PRIMARY KEY (SITEID)
)
go
insert into SITES values
('0','passwordmanager')
GO

alter table SITES
alter column SITEID INT IDENTITY NOT NULL
GO

CREATE TABLE USER_SAVED_PASSWORDS
(
USERID int not null,
SITEID iNT NOT NULL,
PASSWORD varchar(100) not null,
EMAIL varchar(100) not null ,
PRIMARY KEY (USERID,SITEID)
)
GO