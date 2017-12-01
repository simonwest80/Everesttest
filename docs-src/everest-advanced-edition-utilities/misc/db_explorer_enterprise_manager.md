---
title: Enterprise Manager
---

# Enterprise Manager


This tab allows for easy enterprise-wide configuration and management  of SQL Server and constituent objects. You can administer multiple database  servers through a single interface and manage tables, views, stored procedures,  rules, defaults, and user-defined data types. The **Enterprise 
 Manager** consists of:

- **Objects 
 Panel**: This panel displays the SQL Server objects.
- **Details 
 Panel**: This panel displays the details of the selected object.



SQL Server uses the term ‘object’ to describe a database component.  Some of the common SQL Server Objects are:


**Connections**: 
 Displays the users connected to the server.****


**Tables**: 
 A table is used to store data. It is organized in a row/column manner. 
 You can retrieve, modify, and remove data from a table by using the SQL.****


**Views**: A view is a virtual table  that looks and feels like a real table. Views limit the amount of data  a user can see and modify. Views are used to control user access to data  and to simplify data presentation.


**Stored Procedures**: A stored  procedure is a compiled SQL program. Within a stored procedure, you can  embed conditional logic (if / else logic), declare variables, pass parameters,  and perform other programming tasks.


**Defaults**: Defaults are used  to populate a column with a default value when a value is not supplied.


**Rules**: A rule is used to enforce  a data constraint. Rules are column specific and cannot perform table  lookups. Generally, rules are used to enforce simple business constraints.


**User Defined Data Types**: With  a User Defined Data Type, you can create a custom reusable data type based  on an existing SQL Server Data Type. By using user-defined Data Types,  you can ensure Data Type consistency.


**Users**: A user identifier identifies  a user within a database. All permissions and ownership of objects in  the database are controlled by the user account. User accounts are specific  to a database; the xyz user account in the sales database is different  from the xyz user account in the inventory database, even though both  accounts have the same ID. User IDs are defined by members of the db\_owner  fixed database role.


A login ID by itself does not give user permissions to access objects  in any databases. A login ID must be associated with a user ID in each  database before anyone connecting with that login ID, can access objects  in the databases. If a login ID has not been explicitly associated with  any user ID in a database, it is associated with the guest user ID. If  a database has no guest user account, a login cannot access the database  unless it has been associated with a valid user account.


**User Defined Functions**: Functions  are subroutines made up of one or more Transact-SQL statements that can  be used to encapsulate code for reuse. Users can create their own user-defined  functions.


User-defined functions are created using the CREATE FUNCTION statement,  modified using the ALTER FUNCTION statement, and removed using the DROP  FUNCTION statement. Each fully qualified user-defined function name (database\_name.owner\_name.function\_name)  is unique.


You must be granted CREATE FUNCTION permissions to create, alter, or  drop user-defined functions. Users other than the owner must be granted  appropriate permissions on a function before they can use it in a Transact-SQL  statement. To create or alter tables with references to user-defined functions  in the CHECK constraint, DEFAULT clause, or computed column definition,  you must also have REFERENCES permission on the functions.


**Roles**: Fixed database roles,  which can be created, are defined at the database level and exist in each  database. You can add any valid user account (a Windows NT 4.0 or Windows  2000 user or group, or a SQL Server user or role) as a member of a fixed  database role. Each member gains the permissions applied to the fixed  database role. Any member of a fixed database role can add other users  to the role.


The following table describes the fixed database roles.

| Fixed database role | Description |
| db\_owner | Performs the activities of all database roles, as well as other maintenance  and configuration activities in the database. The permissions of this  role span all of the other fixed database roles. |
| db\_accessadmin | Adds or removes Windows NT 4.0 or Windows 2000 groups and users, and  SQL Server users in the database. |
| db\_datareader | Sees all data from all user tables in the database. |
| db\_datawriter | Adds, changes, or deletes data from all user tables in the database. |
| db\_ddladmin | Adds, modifies, or drops objects in the database (runs all DDLs). |
| db\_securityadmin | Manages roles and members of SQL Server 2000 database roles, and manages  statement and object permissions in the database. |
| db\_backupoperator | Has permission to back up the database. |
| db\_denydatareader | Denies permission to select data in the database. |
| db\_denydatawriter | Denies permission to change data in the database. |


{:.see_also}
See also
: [Database Explorer]({{site.advutl_baseurl}}/database-explorer/database_explorer.html)
