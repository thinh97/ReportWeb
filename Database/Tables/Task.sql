CREATE TABLE Task (
    Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(2000) NOT NULL,
    Status VARCHAR(100) NOT NULL,
    Note VARCHAR(2000) NOT NULL,
    ReportId INT NOT NULL REFERENCES Report(Id)
);