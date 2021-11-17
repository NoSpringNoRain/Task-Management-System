INSERT INTO dbo.Users (Email, Password, Fullname) VALUES ('nancy@gmail.com', 'nancy', 'Nancy Taylor');
INSERT INTO dbo.Users (Email, Password, Fullname) VALUES ('john@gmail.com', 'john', 'John Smith');
INSERT INTO dbo.Users (Email, Password, Fullname) VALUES ('william@gmail.com', 'william', 'William Gates');
INSERT INTO dbo.Users (Email, Password, Fullname) VALUES ('sophie@gmail.com', 'sophie', 'Sophie Johnson');
INSERT INTO dbo.Users (Email, Password, Fullname) VALUES ('emma@gmail.com', 'emma', 'Emma Brown');

INSERT INTO dbo.Tasks (UserId, Title, Description, DueDate, Priority)
VALUES (1, 'Sales', 'Build connection with 3 new customers', '20211207 00:00:00 AM', 'l')
INSERT INTO dbo.Tasks (UserId, Title, Description, DueDate, Priority)
VALUES (3, 'Marketing', 'Write marketing documents', '20211120 00:00:00 AM', 'h')
INSERT INTO dbo.Tasks (UserId, Title, Description, DueDate, Priority)
VALUES (2, 'Administration', 'Book flights for sales team', '20211120 00:00:00 AM', 'm')
INSERT INTO dbo.Tasks (UserId, Title, Description, DueDate, Priority)
VALUES (5, 'IT', 'Update salesforce system', '20211120 00:00:00 AM', 'm')
INSERT INTO dbo.Tasks (UserId, Title, Description, DueDate, Priority)
VALUES (1, 'Sales', 'Sign contract with Client A', '20211122 00:00:00 AM', 'h')
INSERT INTO dbo.Tasks (UserId, Title, Description, DueDate, Priority)
VALUES (4, 'Management', 'Make buiness plan for next month', '20211125 00:00:00 AM', 'm')
INSERT INTO dbo.Tasks (UserId, Title, Description, DueDate, Priority)
VALUES (4, 'Management', 'Hold team monthly review meeting', '20211125 00:00:00 AM', 'h')


INSERT INTO dbo.[Tasks History] (TaskId, UserId, Title, Description, DueDate, Completed)
VALUES (1, 2, 'Administration', 'Buy office supplies', '20211020 00:00:00 AM', '20211015 00:00:00 AM')
INSERT INTO dbo.[Tasks History] (TaskId, UserId, Title, Description, DueDate, Completed)
VALUES (2, 1, 'Sales', 'Write monthly sales report', '20211031 00:00:00 AM', '20211030 00:00:00 AM')
INSERT INTO dbo.[Tasks History] (TaskId, UserId, Title, Description, DueDate, Completed)
VALUES (3, 3, 'Marketing', 'Advertisement Copy Writing', '20211028 00:00:00 AM', '20211025 00:00:00 AM')
INSERT INTO dbo.[Tasks History] (TaskId, UserId, Title, Description, DueDate, Completed)
VALUES (4, 3, 'Marketing', 'Search for vendors', '20211018 00:00:00 AM', '20211015 00:00:00 AM')
INSERT INTO dbo.[Tasks History] (TaskId, UserId, Title, Description, DueDate, Completed)
VALUES (5, 4, 'Management', 'Interview sales representatives', '20211026 00:00:00 AM', '20211026 00:00:00 AM')
INSERT INTO dbo.[Tasks History] (TaskId, UserId, Title, Description, DueDate, Completed)
VALUES (6, 5, 'IT', 'Set up salesforce system', '20211010 00:00:00 AM', '20211010 00:00:00 AM')
