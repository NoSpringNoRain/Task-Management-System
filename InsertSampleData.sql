INSERT INTO dbo.Users (Email, Password, Fullname) VALUES ('nancy@gmail.com', 'nancy', 'Nancy Taylor');
INSERT INTO dbo.Users (Email, Password, Fullname) VALUES ('john@gmail.com', 'john', 'John Smith');
INSERT INTO dbo.Users (Email, Password, Fullname) VALUES ('william@gmail.com', 'william', 'William Gates');
INSERT INTO dbo.Users (Email, Password, Fullname) VALUES ('sophie@gmail.com', 'sophie', 'Sophie Johnson');
INSERT INTO dbo.Users (Email, Password, Fullname) VALUES ('emma@gmail.com', 'emma', 'Emma Brown');


INSERT INTO dbo.Tasks (UserId, Title, Description, DueDate, Priority)
VALUES (1, 'Sales', 'Build connection with 3 new customers', 2021-12-07, 'l')
INSERT INTO dbo.Tasks (UserId, Title, Description, DueDate, Priority)
VALUES (3, 'Marketing', 'Write marketing documents', 2021-11-20, 'h')
INSERT INTO dbo.Tasks (UserId, Title, Description, DueDate, Priority)
VALUES (2, 'Administration', 'Book flights for sales team', 2021-11-20, 'm')
INSERT INTO dbo.Tasks (UserId, Title, Description, DueDate, Priority)
VALUES (5, 'IT', 'Update salesforce system', 2021-11-20, 'm')
INSERT INTO dbo.Tasks (UserId, Title, Description, DueDate, Priority)
VALUES (1, 'Sales', 'Sign contract with Client A', 2021-11-22, 'h')
INSERT INTO dbo.Tasks (UserId, Title, Description, DueDate, Priority)
VALUES (4, 'Management', 'Make buiness plan for next month', 2021-11-25, 'm')
INSERT INTO dbo.Tasks (UserId, Title, Description, DueDate, Priority)
VALUES (4, 'Management', 'Hold team monthly review meeting', 2021-11-25, 'h')


INSERT INTO dbo.[Tasks History] (TaskId, UserId, Title, Description, DueDate, Completed)
VALUES (1, 2, 'Administration', 'Buy office supplies', 2021-10-20, 2021-10-15)
INSERT INTO dbo.[Tasks History] (TaskId, UserId, Title, Description, DueDate, Completed)
VALUES (2, 1, 'Sales', 'Write monthly sales report', 2021-10-31, 2021-10-30)
INSERT INTO dbo.[Tasks History] (TaskId, UserId, Title, Description, DueDate, Completed)
VALUES (3, 3, 'Marketing', 'Advertisement Copy Writing', 2021-10-28, 2021-10-25)
INSERT INTO dbo.[Tasks History] (TaskId, UserId, Title, Description, DueDate, Completed)
VALUES (4, 3, 'Marketing', 'Search for vendors', 2021-10-18, 2021-10-15)
INSERT INTO dbo.[Tasks History] (TaskId, UserId, Title, Description, DueDate, Completed)
VALUES (5, 4, 'Management', 'Interview sales representatives', 2021-10-26, 2021-10-26)
INSERT INTO dbo.[Tasks History] (TaskId, UserId, Title, Description, DueDate, Completed)
VALUES (6, 5, 'IT', 'Set up salesforce system', 2021-10-10, 2021-10-10)
