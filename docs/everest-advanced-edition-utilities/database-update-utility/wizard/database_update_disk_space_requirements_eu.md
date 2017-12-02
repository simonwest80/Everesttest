---
title: Database Update Disk Space Requirements
---

# Database Update Disk Space Requirements


Use the following formulas to determine the amount of disk space that  will be required for your database upgrade:

- If you select **Yes, I wish to backup the data** then  the amount of disk space required is 3.15 times the size of the database:



(2 \* Database Size) + (1 \* Database Size) + (.15 \* Database Size) =  3.15 \* Database Size


This consists of:


| ![]({{site.advutl_baseurl}}/img/bullet.gif) | A copy of the database for the system to use in case the original database  update is not successful and additional space needed for processing –  This is approximately 2 times the database size. (The copy of the database  is removed after a successful update.) |
| ![]({{site.advutl_baseurl}}/img/bullet.gif) | A backup copy of the database – This is your backup copy and it will  not be removed after a successful update. You can move this to another  drive to save space. This is approximately 1 times the database size. |
| ![]({{site.advutl_baseurl}}/img/bullet.gif) | An MS SQL Server TempDB of approximately 15% of your database size in  the directory where your MS SQL Server is installed |



{:.example}
Example 1: Your original database is 1 GB and is located in the following  directory:


C:\Program Files\Icode\Everest\Data (example **Everest**  Database Server path)


You decide to back up the database to the same directory. You will need  approximately 3 GB in that directory to complete the update. You will  also need approximately 0.15 GB for a temporary MS SQL Server TempDB in  the directory where your MS SQL Server is installed.


2.00  GB – Used by the system during the database update


**+1.00 
 GB** – A backup copy of the database made at your request


****3.00 GB**  – Approximate disk space required in the C:\Program Files\Icode\Everest\Data  directory (example Everest Database Server path)**


****+****0.15 
 GB** – Approximate disk space required in the directory where your  MS SQL Server is installed**


****3.15 GB – Approximate 
 total of the disk space required for the update****


{:.example}
Example 2: You determine that you do not have enough disk space on the  C: drive and you decide to place the backup copy of the database on the  D: drive. In this situation, you will need approximately 2 GB in the directory  on the C: drive and 1 GB in the directory on the D: drive. You will also  need approximately 0.15 GB for a temporary MS SQL Server TempDB in the  directory where your MS SQL Server is installed.


****2.00 GB**  – Used by the system during the database update – Approximate disk space  required in the C:\Program Files\Icode\Everest\Data directory (example  Everest Database Server path)**


****1.00 GB**  – A backup copy of the database made at your request (Approximate total  of the disk space required for database backup on the D: drive)**


****+****0.15 
 GB** – Approximate disk space required in the directory where your  MS SQL Server is installed**


****3.15 GB – Approximate 
 total of the disk space required for the update****

- If you select **No, I do not wish to backup the data**  then the amount of disk space required is 2.15 times the size of the database:



(2 \* Database Size) + (.15 \* Database Size) = 2.15 \* Database Size


This consists of:


| ![]({{site.advutl_baseurl}}/img/bullet.gif) | A copy of the database for the system to use in case the original database  update is not successful and additional space needed for processing –  This is approximately 2 times the database size. (The copy of the database  is removed after a successful update.) |
| ![]({{site.advutl_baseurl}}/img/bullet.gif) | An MS SQL Server TempDB of approximately 15% of your database size in  the directory where your MS SQL Server is installed |



{:.example}
Your original database is 1 GB and is located in the following directory:


C:\Program Files\Icode\Everest\Data (example Everest Database Server  path)


You decide NOT to back up the database since your company does regular  tape backups of the directory. You will need approximately 2 GB in that  directory to complete the update. You will also need approximately 0.15  GB for a temporary MS SQL Server TempDB in the directory where your MS  SQL Server is installed.


****2.00 GB**  – Used by the system during the database update – Approximate disk space  required in the C:\Program Files\Icode\Everest\Data directory (example  Everest Database Server path)**


****+****0.15 
 GB** – Approximate disk space required in the directory where your  MS SQL Server is installed**


****2.15 GB – Approximate 
 total of the disk space required for the update****


{:.see_also}
See also
: [Database  Update Utility]({{site.advutl_baseurl}}/database-update-utility/dbupdate_database_update_utility.html)
: [Database  Backup]({{site.advutl_baseurl}}/database-update-utility/wizard/dbupdate_database_backup.html)
