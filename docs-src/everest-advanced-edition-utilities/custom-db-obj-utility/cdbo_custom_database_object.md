---
title: Custom Database Object
---

# Custom Database Object


When you create a company in **Everest**,  a company database which has all the details pertaining to that company  is created automatically. The system database contains common data required  for the smooth functioning of all the company databases. You can create  your own database objects using the **MS 
 SQL Query Analyzer**.


During the database update process, **Everest**  will delete the database objects created by you as it is not present in  the new version. To avoid this, **Everest**  provides you with the **Custom Database 
 Object Utility**. The **Custom Database 
 Object** utility is used to specify the names of the database objects  that you have created. This data is stored in a custom database repository.


{:.note}
If the custom database object created using  the query analyzer is in the ‘**U_&lt;object 
 name&gt;**’format that is, if the name of the database object begins  with ‘**U_**’,  then it need not be specified using this utility.


If **Everest** identifies a database  object that does not exist in the custom database repository nor is in  the ‘**U_&lt;object 
 name&gt;**’format, then the object is deleted. Otherwise, **Everest**  leaves the database object intact and the update process is completed.


{:.note}
The **Database 
 Update** process updates the system and company databases. When you  install a new version of **Everest**,  the default databases are updated. The system database and the company  databases are not updated.


![]({{site.advutl_baseurl}}/img/lens.gif) [Database  Update Utility]({{site.advutl_baseurl}}/database-update-utility/dbupdate_database_update_utility.html)


You may access the Custom Database Object Utility:

- From a standalone  configuration.
- From a shared  client.



![]({{site.advutl_baseurl}}/img/refer.gif) Sections  **Stand-alone Configuration** and  **Shared Client** in **Everest 
 Advanced Edition** Installation Guide.


{:.steps}
To access the Custom Database Object Utility  from a standalone configuration, do the following:

- Run the **CustomDBOUtility.exe**file. You will see the **Custom 
 Dbo Utility**  dialog box.



{:.note}
Unless you specified another path during **Everest** installation, this file is available  by default in C:\Program  Files\Icode\Everest\Client\Utilities.


{:.steps}
To access the Custom Database Object Utility  from a shared client, do the following:

- Share the program  files folder on the network server on which **Everest 
 Advanced Edition** is installed.
- From the Client  system, map to the shared program files folder on the network server.
- Run **&lt;Mapped 
 Drive&gt;:\Client\Utilities\CustomDBOUtility.exe**.  You will see the **Custom Dbo 
 Utility** dialog box.



{:.see_also}
See also
: [Custom Dbo  Utility]({{site.advutl_baseurl}}/custom-db-obj-utility/cdbo_custom_dbo_utility.html)
