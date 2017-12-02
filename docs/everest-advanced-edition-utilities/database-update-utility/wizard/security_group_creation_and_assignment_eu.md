---
title: Security Group Creation and Assignment
---

# Security Group Creation and Assignment


You will see the **Security Group Creation 
 and Assignment** section of the wizard if you are updating to an  application version that contains new security rights.  Use  the **Security Group Creation and Assignment**  section to allow the system to create a group with all of the new security  rights assigned to it.  All  existing users are automatically assigned to this group.  If  you prefer, you can manually assign the security rights later.


{:.note}
The option for Security Group Creation and  Assignment is available only when updating from one version to another  and not while applying hot fixes.


**Yes, create user group <group name>, and  assign new security rights to it.**
: Select this option to allow the system to automatically  create a group with all of the new security rights assigned to it.  The  Group name contains information on the version you are upgrading to.  On  the **Security Group Creation and Assignment**  screen, <group name> is replaced by the actual name of the group  to be created.


{:.example}
If you are upgrading from version 3.0.0 to  4.0.0, the group name displays as 400SEC.  See  the **Security Group Creation and Assignment**  screen for the actual name of the group to be created.


**No, I will assign new security rights after the  database update is complete.**
: Select this option if you want to assign the new  security rights manually after the database update is complete.


After you make your security selection, click **Next**.  You will see the [Database Backup]({{site.advutl_baseurl}}/database-update-utility/wizard/dbupdate_database_backup.html) section.


{:.see_also}
See also
: [Database  Update Utility]({{site.advutl_baseurl}}/database-update-utility/dbupdate_database_update_utility.html)
