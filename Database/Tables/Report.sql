CREATE TABLE Report (
    Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    CreatedAt DATETIME NOT NULL,
    UserId INT NOT NULL references Team(Id)
);