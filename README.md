# JusAbPOS

Point of Sale & Inventory Management - C# WinForms, .NET Framework 4.8, SQL Server.

| Item | Value |
|---|---|
| Solution / project name | **JusAbPOS** (first 3 letters of first name `Jus` + first 2 of last name `Ab` + `POS`) |
| SQL Server database | **abejar** (last name) |
| Connection-string name | `JusAbPOS` (in `JusAbPOS.WinForms/App.config`) |

**Required modules:** 1. Login - 2. Dashboard - 3. Inventory Management (CRUD).
**Also included:** Point of Sale (checkout + receipts), Sales Analytics, Users & Roles.

## The screens (one main window with a blue sidebar)
| Sidebar item | Who sees it | What it is |
|---|---|---|
| Dashboard | everyone | metric cards + low-stock table |
| Point of Sale (F2) | everyone | scan/find products, cart, customer, discount, **CHECKOUT (F9)**, receipt |
| Inventory | Admin, Manager | product list with Add / Edit / Delete / Adjust Stock |
| Sales Analytics | Admin, Manager | daily sales, top products, sales by category |
| Users & Roles | Admin | add user, edit, activate/deactivate, reset password |
| Log out | everyone | back to the login screen |

Keys: **F2** point of sale, **F5** refresh current screen, **F9** checkout.

## Editing the screens in the Visual Studio Designer
Every form and screen has a real Designer file, so you can edit the layout visually:

| Screen | Open in the designer | Layout file | Logic file |
|---|---|---|---|
| Login | `LoginForm.cs` (double-click) | `LoginForm.Designer.cs` | `LoginForm.cs` |
| Main window + sidebar | `MainForm.cs` | `MainForm.Designer.cs` | `MainForm.cs` |
| Dashboard / POS / Inventory / Analytics / Users | `DashboardView.cs`, `PosView.cs`, `InventoryView.cs`, `AnalyticsView.cs`, `UsersView.cs` | `*.Designer.cs` | `*.cs` |
| Dialogs | `PaymentForm`, `CustomerForm`, `ProductEditorForm`, `StockAdjustForm`, `UserEditorForm` | `*.Designer.cs` | `*.cs` |

* Double-click the `.cs` file (or right-click > **View Designer**) to drag, resize, recolour or add controls.
* Do **not** type layout code in the `.Designer.cs` files by hand - the designer rewrites them. Put logic in the `.cs` file.
* To add a click handler: select the control in the designer > Properties > lightning-bolt (Events) > double-click *Click*.
* Controls keep their names (`btnCheckout`, `gridProducts`, ...) - the logic files refer to those names, so if you
  rename a control, rename it in the logic file too (right-click the name > *Rename*).
* Colours used everywhere: sidebar/headers `#1E3A78`, green buttons `#00926C`, red buttons `#CE2626`, grey `#78808C`.

## Folder structure
```
JusAbPOS
|-- Database/01_CreateDatabase.sql          full script: tables + procedures + seed data (database: abejar)
|-- Database/02_AddCheckoutProcedures.sql   ONLY for a database created earlier - adds the newer procedures (safe to re-run)
|-- JusAbPOS.Domain      Entities.cs                                    plain classes (User, Product, CartLine, ReceiptData ...)
|-- JusAbPOS.Data        Db.cs, Security.cs, Repositories.cs, SalesRepositories.cs, UserAdminRepository.cs   (all SQL)
|-- JusAbPOS.Services    Services.cs, SalesServices.cs, UserService.cs  validation + role checks
`-- JusAbPOS.WinForms    Program, MainForm, LoginForm, *View (5 screens), 5 dialogs, ReceiptPrinter, AppSettings, UiHelper, App.config
```
References: Data -> Domain; Services -> Domain, Data; WinForms -> Domain, Data, Services.
Rule from the tutorial: screens never run SQL; repositories never show message boxes.

## Setup
### A. Database
1. Open **SSMS**, connect to your SQL Server / SQL Express.
2. **New database:** open `Database/01_CreateDatabase.sql` and **Execute** (it can be run again safely).
   **Database already exists from an earlier version:** open `Database/02_AddCheckoutProcedures.sql` and **Execute** it
   instead. It adds the procedures for receipts, customers and Users & Roles and does not touch your data.
3. Check: *Databases > abejar* exists with tables Roles, Users, Categories, Products, Customers, Orders, OrderDetails, InventoryLog.

### B. Open and run
1. Open `JusAbPOS.sln` in Visual Studio 2019/2022 (workload *.NET desktop development*, .NET Framework 4.8 Developer Pack).
2. Edit `JusAbPOS.WinForms/App.config`: `Data Source=localhost` (SQL Express: `.\SQLEXPRESS`, LocalDB: `(localdb)\MSSQLLocalDB`), keep `Initial Catalog=abejar`.
3. Right-click **JusAbPOS.WinForms** > *Set as Startup Project*, press **F5**.

| Username | Password | Role | Sidebar |
|---|---|---|---|
| admin | Admin@123 | Admin | everything |
| manager | Manager@123 | Manager | no Users & Roles |
| cashier | Cashier@123 | Cashier | Dashboard + Point of Sale only |

## Test checklist
**Login** - correct login opens the main window; wrong password, unknown user and empty fields show a message (wrong user and
wrong password give the *same* text).
**Dashboard** - Today's sales, Orders today, Low-stock products, Active products, low-stock table.
**Inventory** - *Read*: grid + search + Show inactive. *Create*: + Add Product (duplicate SKU/barcode gives a friendly message).
*Update*: Edit or double-click. *Delete*: soft delete (product becomes inactive, history kept; restore via Show inactive > Edit > Active).
*Adjust Stock*: +/- with a reason (logged).
**Point of Sale** - type/scan a SKU (e.g. `BEV-001`) + Enter, or double-click a product; **+ / -** change the quantity, Remove, Clear cart;
pick a customer (**+** adds a new one), optional discount; **CHECKOUT (F9)** opens the payment window (Cash shows change; Card/Mobile pay
the exact total); the sale is saved in one database transaction, stock goes down, and you can preview/print the receipt.
**Sales Analytics** - date range with three tabs. **Users & Roles** - add a user, change name/role, deactivate/reactivate, reset password
(you cannot deactivate yourself or change your own role).

## Design notes / differences from the tutorial text
* The database is built from **SQL.docx**, renamed from `PosDB` to **abejar**. Procedures added for the screens: `usp_Category_List`,
  `usp_Product_List`, `usp_Product_Get`, `usp_Customer_List`, `usp_Customer_Create`, `usp_Order_Get`, `usp_Role_List`, `usp_User_List`,
  `usp_User_Create`, `usp_User_Update`, `usp_User_SetActive`, `usp_User_ResetPassword`.
* Passwords use the **salted SHA-256** format that SQL.docx seeds (`SHA256(Salt + Password)`), not the tutorial's PBKDF2.
* The tutorial draws its forms in code; here every form has a Designer file instead (as requested). The tutorial's menu-strip main window
  was replaced by the sidebar layout.
* Checkout follows the tutorial (cart -> payment -> receipt built from the *saved* order) but calls your `usp_Order_Create`, which takes the
  cart as XML and checks stock, prices and totals inside the database.
* Receipt business name/address/phone and the tax rate are in `<appSettings>` of `App.config`.
* Errors are logged to `%LocalAppData%\JusAbPOS\logs\error.log`; users only see safe messages.

## GitHub (tutorial Appendix E)
`.gitignore` is included. Commit `App.config.example`, never a config containing real passwords.
