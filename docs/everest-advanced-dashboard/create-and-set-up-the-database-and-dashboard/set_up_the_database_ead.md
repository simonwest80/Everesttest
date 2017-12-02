---
title: Set Up the Database
---

# Set Up the Database


After entering a valid license key, if the data warehouse does not exist,  the **Setup Data Warehouse** dialog  box (Path: **Utility &gt; Data Warehouse 
 &gt; Setup**) is displayed for you to create the data warehouse.  After the data warehouse has been setup, you can access this dialog box  at any time to view the information and to make changes.


{:.note}
The data warehouse should be created outside  of peak production times because it is process intensive and could impact  the overall performance of **Everest**.


**Database Server Name\***
: This field defaults to the **Everest**  database server configuration information. To change the name of the Database  Server that will be used to host the data warehouse, enter the database  server name or browse to locate it. The field validation is based on Microsoft  Server naming rules. This is a required field.


{:.note}
It is recommended, but not required, that  you run the data warehouse server on a separate server than the one used  for **Everest**.


**Database Name\***
: Enter the name for your **Everest**  Data Warehouse database. This is a required field.


**Connect Using:**


**SQL Authentication**
: Select **SQL Authentication**  if you choose to connect using this authentication type.


**Windows Authentication**
: Select **Windows 
 Authentication** if you choose to connect using this authentication  type.


{:.note}
Most users will connect using Windows authentication.


**User Name\***
: If you choose to connect using SQL Authentication,  enter the SQL database System Administrator user name. The field validation  is based on MS authentication user naming rules. This is a required field.


**Password\***
: If you choose to connect using SQL Authentication,  enter the SQL database System Administrator user password. The field validation  is based on MS authentication password naming rules. This is a required  field.


{:.note}
If you have multiple companies, you can create  a data warehouse for each company.


{:.see_also}
See also
: [Create  the Data Warehouse]({{site.db_baseurl}}/create-and-set-up-the-database-and-dashboard/create_the_data_warehouse_ead.html)
