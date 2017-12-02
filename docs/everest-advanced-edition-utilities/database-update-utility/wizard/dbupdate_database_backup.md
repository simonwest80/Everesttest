---
title: Database Backup
---

# Database Backup


This section of the wizard is used to specify the backup details for  the database.


**Yes, I wish to backup the data**
: Select this option if you want to take a backup  of your database before updating it.


{:.note}
The **Backup 
 file name** option is enabled only when the **Yes, 
 I wish to backup the data** option is selected.


**System Backup file name**
: **Everest's**  database is stored in this path. The path and name of the backup file  is displayed here. Click the ![ext_browse_button.gif]({{site.advutl_baseurl}}/img/ext_browse_button.gif) button to specify another  path. You can specify another name for the backup file.


**Company Backup file name**
: Your company's database is stored in this path.  The path and name of the backup file is displayed here. Click the ![ext_browse_button.gif]({{site.advutl_baseurl}}/img/ext_browse_button.gif) button to specify another path. You can specify another name  for the backup file.


**No, I do not wish to backup the data**
: Select this option if you do not want to take a  backup of your database.


**Error Log File Name**
: The path and name of the log file is displayed here.  Click the ![ext_browse_button.gif]({{site.advutl_baseurl}}/img/ext_browse_button.gif) button to specify another path. You can specify  another name for the log file.


{:.note}
The log file displays errors that occurred  during the update process. It also shows information regarding your security  selection from the **Security Group Creation 
 and Assignment** section.


Click **Next**. The system checks  to see if the necessary disk space is available. Your old database is  not removed until the new database has been successfully updated. Because  of this safety feature, additional disk space is required.
: ![]({{site.advutl_baseurl}}/img/lens.gif)[Database  Update Disk Space Requirements]({{site.advutl_baseurl}}/database-update-utility/wizard/database_update_disk_space_requirements_eu.html)


If the required amount of space is not available, a message displays  with additional information and instructions. If the required amount of  space is available, you will see the [Comparing  System Database with Everest Defaults]({{site.advutl_baseurl}}/database-update-utility/wizard/dbu_update_comparing_company_database_with_everest_defaults.html) section.


{:.see_also}
See also
: [Database  Update Utility]({{site.advutl_baseurl}}/database-update-utility/dbupdate_database_update_utility.html)
