/* ============================================================================
   JusAbPOS  -  02_AddCheckoutProcedures.sql
   Run this (safe to re-run any number of times) on the EXISTING abejar database.
   It only adds / refreshes stored procedures (checkout, receipts, customers, users & roles);
   no tables or data are touched.
   ============================================================================ */
USE abejar;
GO
SET QUOTED_IDENTIFIER ON;
GO
/* ===================== ADDED FOR CHECKOUT / RECEIPTS (READ side) ===================== */
CREATE OR ALTER PROCEDURE dbo.usp_Customer_List
AS
BEGIN
    SET NOCOUNT ON;
    SELECT CustomerId, FullName, Phone FROM dbo.Customers ORDER BY FullName;
END
GO
CREATE OR ALTER PROCEDURE dbo.usp_Order_Get @OrderId INT      -- two result sets: header, then lines (used to print the receipt)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT o.OrderId, o.OrderNumber, o.OrderDate, o.Subtotal, o.TaxAmount, o.DiscountAmount, o.Total,
           o.PaymentMethod, o.AmountPaid, o.ChangeDue, u.FullName AS CashierName
    FROM dbo.Orders o JOIN dbo.Users u ON u.UserId = o.UserId
    WHERE o.OrderId = @OrderId;

    SELECT p.Name AS ProductName, d.Quantity, d.UnitPrice, d.LineTotal
    FROM dbo.OrderDetails d JOIN dbo.Products p ON p.ProductId = d.ProductId
    WHERE d.OrderId = @OrderId
    ORDER BY d.OrderDetailId;
END
GO
/* ===================== ADDED FOR CUSTOMERS + USERS & ROLES ===================== */
CREATE OR ALTER PROCEDURE dbo.usp_Customer_Create @FullName NVARCHAR(100), @Phone NVARCHAR(30) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    IF LTRIM(RTRIM(ISNULL(@FullName, N''))) = N'' THROW 50030, N'Customer name is required.', 1;
    INSERT dbo.Customers (FullName, Phone) VALUES (LTRIM(RTRIM(@FullName)), NULLIF(LTRIM(RTRIM(@Phone)), N''));
    SELECT CAST(SCOPE_IDENTITY() AS INT) AS CustomerId;
END
GO
CREATE OR ALTER PROCEDURE dbo.usp_Role_List
AS
BEGIN
    SET NOCOUNT ON;
    SELECT RoleId, RoleName FROM dbo.Roles ORDER BY RoleId;
END
GO
CREATE OR ALTER PROCEDURE dbo.usp_User_List
AS
BEGIN
    SET NOCOUNT ON;
    SELECT u.UserId, u.Username, u.FullName, u.RoleId, r.RoleName, u.IsActive, u.LastLoginAt   -- hash and salt are never returned
    FROM dbo.Users u JOIN dbo.Roles r ON r.RoleId = u.RoleId
    ORDER BY u.Username;
END
GO
CREATE OR ALTER PROCEDURE dbo.usp_User_Create
    @Username NVARCHAR(50), @PasswordHash VARCHAR(64), @Salt VARCHAR(32), @FullName NVARCHAR(100), @RoleId INT
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM dbo.Users WHERE Username = @Username) THROW 50031, N'That username is already taken.', 1;
    IF NOT EXISTS (SELECT 1 FROM dbo.Roles WHERE RoleId = @RoleId) THROW 50032, N'Unknown role.', 1;
    INSERT dbo.Users (Username, PasswordHash, Salt, FullName, RoleId) VALUES (@Username, @PasswordHash, @Salt, @FullName, @RoleId);
    SELECT CAST(SCOPE_IDENTITY() AS INT) AS UserId;
END
GO
CREATE OR ALTER PROCEDURE dbo.usp_User_Update @UserId INT, @FullName NVARCHAR(100), @RoleId INT
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM dbo.Roles WHERE RoleId = @RoleId) THROW 50032, N'Unknown role.', 1;
    UPDATE dbo.Users SET FullName = @FullName, RoleId = @RoleId WHERE UserId = @UserId;
    IF @@ROWCOUNT = 0 THROW 50033, N'User not found.', 1;
END
GO
CREATE OR ALTER PROCEDURE dbo.usp_User_SetActive @UserId INT, @IsActive BIT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.Users SET IsActive = @IsActive WHERE UserId = @UserId;
    IF @@ROWCOUNT = 0 THROW 50033, N'User not found.', 1;
END
GO
CREATE OR ALTER PROCEDURE dbo.usp_User_ResetPassword @UserId INT, @PasswordHash VARCHAR(64), @Salt VARCHAR(32)
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.Users SET PasswordHash = @PasswordHash, Salt = @Salt WHERE UserId = @UserId;
    IF @@ROWCOUNT = 0 THROW 50033, N'User not found.', 1;
END
GO
