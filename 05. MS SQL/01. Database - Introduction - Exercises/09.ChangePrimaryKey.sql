-- Problem 9.	Change Primary Key
ALTER TABLE [Users]
DROP CONSTRAINT PK__Users__3214EC07AD2174C9
ADD CONSTRAINT [PK_Users] PRIMARY KEY ([Id], [Username])