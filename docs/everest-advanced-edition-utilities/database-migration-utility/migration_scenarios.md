---
title: Migration Scenarios
---

# Migration Scenarios


Process for Upgrading the SQL Server Version on the  Machine where the Everest Database Server is already Installed


{:.steps}
If the SQL Server instance used by the Everest  Database Server is **not**  the MSDE 2000  instance installed by Everest and the upgrade path fits into any of the  possible upgrade paths listed in the table below, follow these steps:

- Upgrade the **Everest** Database Server to version 4.0.0  or later.
- Upgrade the SQL  Server instance used by **Everest**.



{:.steps}
If the SQL Server instance used by the Everest  Database Server is the MSDE  2000 instance installed by Everest and the upgrade path **does 
 not** fit into any of the possible upgrade paths listed in the table  below, follow these steps:

- Take backups of  all the existing **Everest** company  databases using the **Utilities** >  **Database Maintenance**> **Backup** **Company**  option of **Everest**.
- Uninstall  the **Everest** Database Server.
- Optionally uninstall  the existing version of SQL Server.



{:.note}
: If the **Everest**  database server was using **MSDE 
 2000** or **SQL Server 2005 Express 
 Edition**, which was installed by **** the **Everest** installation, **** the **Everest** Database Server uninstall  process will automatically uninstall  these SQL Server instances also.

- Install the required  version of SQL Server including the latest service packs as applicable.  If the instance to be upgraded is **SQL 
 Server 2005 Express Edition**  and no other instance of either **SQL Server 
 2000** or **SQL Server 2005**  exists on that machine, the **Everest**  database server installation will automatically install **SQL 
 Server 2005 Express Edition** and hence separate installation of  SQL Server is not required.
- Install the **Everest** Database Server version 4.0.0  or later.
- Use the **Everest Database Migration utility** to restore the company database  using the backup copy created in the first step.



Process for Migrating the Everest Database Server  to a New Machine from an Existing Installation


{:.steps}
To migrate the Everest Database Server to  a new machine from an existing installation, do the following:

- If the SQL Server  to be used in the new machine is not **SQL 
 Server 2005 Express edition**, install the SQL Server in the new  machine.
- Install the **Everest** Database Server on the new machine  (if no instance of SQL Server 2000 or 2005 is found, **Everest**  will install **SQL Server 2005 Express 
 edition**).
- Use the  **Everest Database 
 Migration utility** to migrate the company database from the existing  server to the new machine.
- On successful completion  of migration, optionally uninstall  the **Everest** Database Server from  the existing machine.



{:.note}
: By default, the **sa**  password in **SQL Server 2000** is  case-insensitive. While installing the **Everest**  Database Server, if someone has entered the **sa** password  in a different case than what was assigned to SQL Server, **Everest** will work fine and it will use the password as entered  during **Everest** installation. For  example, if the actual **sa**  password is **unknown**, if someone  types it as **Unknown** or **UNKNOWN**,  it will work fine with SQL Server 2000. In the case of **SQL 
 Server 2005**, the password is always case-sensitive. After upgrading  from SQL Server 2000 to 2005, if there is any case difference between  the actual sa  password assigned and the sa  password entered while installing **Everest**,  the **Everest** login  will fail. In this scenario, use the **Change 
 Login Password** (ChangeLoginPassword.exe)  **utility** of **Everest**  to reset the sa  password to reflect the exact case.


| Upgrade From | Supported Upgrade Path |
| SQL Server 2000 Enterprise Edition SP3 or later | SQL Server 2005 Enterprise Edition |
| SQL Server 2000 Developer Edition SP3 or later | SQL Server 2005 Developer Edition |
| SQL Server 2000 Standard Edition SP3 or later | SQL Server 2005 Enterprise Edition<br/><br/><br/>SQL Server 2005 Developer Edition<br/><br/><br/>SQL Server 2005 Standard Edition |
| SQL Server 2000 Workgroup Edition | SQL Server 2005 Enterprise Edition<br/><br/><br/>SQL Server 2005 Developer Edition<br/><br/><br/>SQL Server 2005 Standard Edition<br/><br/><br/>SQL Server 2005 Workgroup Edition |
| SQL Server 2000 Evaluation Edition SP3 or later | SQL Server 2005 Evaluation Edition |
| SQL Server Desktop Engine (MSDE) 2000\* | SQL Server 2005 Workgroup Edition<br/><br/><br/>SQL Server 2005 Express Edition |
| SQL Server 2005 Developer Edition | SQL Server 2005 Enterprise Edition<br/><br/><br/>SQL Server 2005 Standard Edition<br/><br/><br/>SQL Server 2005 Workgroup Edition |
| SQL Server 2005 Standard Edition | SQL Server 2005 Enterprise Edition<br/><br/><br/>SQL Server 2005 Developer Edition |
| SQL Server 2005 Workgroup Edition | SQL Server 2005 Enterprise Edition<br/><br/><br/>SQL Server 2005 Developer Edition<br/><br/><br/>SQL Server 2005 Standard Edition |
| SQL Server 2005 Evaluation Edition | SQL Server 2005 Enterprise Edition<br/><br/><br/>SQL Server 2005 Developer Edition<br/><br/><br/>SQL Server 2005 Standard Edition<br/><br/><br/>SQL Server 2005 Workgroup Edition<br/><br/><br/>SQL Server 2005 Express Edition |
| SQL Server 2005 Express Edition | SQL Server 2005 Enterprise Edition<br/><br/><br/>SQL Server 2005 Developer Edition<br/><br/><br/>SQL Server 2005 Standard Edition<br/><br/><br/>SQL Server 2005 Workgroup Edition |

: \*Applicable only if MSDE 2000 is installed separately  (not installed by **Everest** Database  Server setup).
: Visit  [http://msdn2.microsoft.com/en-us/library/ms143393(SQL.90).aspx](http://msdn2.microsoft.com/en-us/library/ms143393(SQL.90).aspx)  for more information on SQL Server 2005 upgrade details.


{:.see_also}
See also
: [Database  Migration Wizard]({{site.advutl_baseurl}}/database-migration-utility/wizard/database_migration_wizard_eu.html)
: [Database  Migration Utility]({{site.advutl_baseurl}}/database-migration-utility/database_migration_utility_eu.html)
