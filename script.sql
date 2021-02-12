CREATE TABLE Users
(
    Id INT NOT NULL IDENTITY(1, 1),
    FirstName VARCHAR(255),
    LastName VARCHAR(255)
)

INSERT INTO dbo.Users
VALUES
    ('UserNameExample1', 'UserSecondNameExample1'),
    ('UserNameExample2', 'UserSecondNameExample2');

SELECT [FirstName], [LastName]
FROM dbo.[Users]
WHERE Id=2;