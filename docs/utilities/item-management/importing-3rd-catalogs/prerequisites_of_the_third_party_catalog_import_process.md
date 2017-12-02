---
title: Prerequisites of the Third Party Catalog Import Process
---

# Prerequisites of the Third Party Catalog Import Process


Before you begin the Third Party Catalog import process, ensure that  the logon account  for the database server is set to the domain account.


The process of setting the database server logon  to the domain account is detailed below for the following scenarios:

- You have installed  MS SQL Server 2000 on your system.
- You do not have  MS SQL Server 2000, but have installed SQL Server 2000 Desktop Engine  (MSDE).
- You have installed  one of the MS SQL Server 2005 editions or you are using the free MS SQL  Server 2005 Express edition.



{:.steps}
To set the database server logon  to the domain account with MS SQL Server 2000 installed, do the following:

- Select **Start** > **Programs**  > **MS SQL Server** > **Enterprise Manager**. You will see the  **SQL Server Enterprise Manager**  window.
- Select the  target server from the left panel, right-click and select **Properties**.  You will see the **SQL Server Properties 
 (Configure)** dialog box.
- From the **SQL Server Properties (Configure)** dialog  box, select the **Security** tab.
- From the **Startup service account** section of the  **Security** tab and select **This account**. Enter the domain name,  user name and password.
- Click **OK**. You will be prompted to restart  the MS SQL Server service.
- Click **Yes**.



{:.note}
If the **This 
 account** option has been previously selected, you do not have to  restart the MS SQL Server service.


{:.steps}
To set the database server logon  to the domain account with only MSDE  installed, do the following:

- Go to **Start** > **Settings**  > **Control Panel.** You will see  the **Control Panel**.
- From the **Control Panel** window, select **Administrative Tools** and from the **Administrative Tools** window, select  **Services**. You will see the **Services** window.
- Select MSSQLSERVER  from the right panel, right-click and select **Properties**.  You will see the **MSSQLSERVER 
 Properties (Local Computer)** dialog box.
- From the **MSSQLSERVER 
 Properties (Local Computer)** dialog box, select the **Log 
 On** tab.
- Select the  **This account** option. Enter your  domain name, user name and password.
- Click **OK**. You will be prompted with a message  asking you to restart MSSQLSERVER  services.
- From the **Services** window, select MSSQLSERVER,  right-click and select **Restart**.  You will be prompted to confirm that you want to restart the services.
- Click **Yes**.



{:.note}
If the **This 
 account** option has been previously selected, you do not have to  restart the MSSQLSERVER  services.


{:.steps}
To set the database server logon to the domain  account with MS SQL Server 2005 editions installed, do the following:

- Select **Start**  > **Programs** > **Microsoft 
 SQL Server 2005** > **Configuration 
 Tools** > **SQL** **Server 
 Configuration Manager**. You will see the **SQL 
 Server Configuration Manager** window.
- Select SQL Server  2005 Services from the left panel.
- Select the target  server from the right panel, right-click and select **Properties**.  You will see the **SQL Server Properties**  dialog box.
- From the SQL Server  Properties dialog box, select the **Log 
 On** tab.
- From the **Log on as** section of the **Log 
 On** tab, select This account. Enter the domain name, user name and  password.
- Click **OK**.  You will be prompted to restart the MS SQL Server service.
- Click **Yes**.



{:.note}
SQL Server Configuration Manager comes bundled  with all editions of MS SQL Server 2005 except for MS SQL Server 2005  express edition. This tool can also be made available on MS SQL Server  2005 express edition by installing the **SQL 
 Server 2005 Management Studio Express Edition**. The **SQL 
 Server 2005 Management Studio Express Edition** is free to use and  can be downloaded from Microsoft download sites.


{:.see_also}
See also
: [Import  Third Party Catalogs into Everest]({{site.utl_baseurl}}/item-management/importing-3rd-catalogs/import_third_party_catalogs_into_everest.html)
