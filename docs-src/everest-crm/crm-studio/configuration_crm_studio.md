---
title: Configuration - CRM Studio
---

# Configuration - CRM  Studio


You need to provide authentication details in order to access CRM  Studio after installation.


{:.steps}
To provide authentication details, do the  following:

- From the main  menu bar, select **CRM 
 &gt; CRM Studio 
 &gt; Configuration**. You will see the **Configuration 
 - CRM Studio** dialog box.



**User Code to be used for authentication**
: Enter the user code for using CRM  Studio to access **Everest** database.  This is required for security purpose and it prevents any unauthorized  updating of **Everest** database using  some of the events available in CRM  Studio.


**Administrator Password**
: Enter the administrator password for accessing CRM  Studio. This is required as an additional security right to access related  modules in CRM  Studio.


**CRM Studio Server Name**
: Enter the name of the **CRM 
 Studio** server. This field defaults to the last **CRM 
 Studio** server name. If you uninstall and reinstall **CRM 
 Studio**, you must change the **CRM****Studio** name to ensure proper functionality  between **Everest** and **CRM 
 Studio**.


Menu Option


**Create Application**


You can create an application for your registered company by selecting  this option. The **Create Application**  option is disabled in the following scenarios:

- The sample company  is installed.
- An application  is already installed for the logged in company.



![]({{site.crm_baseurl}}/img/steps.gif)  To  create an application, do the following:

- From the main menu  bar of the **Everest** window, select  **CRM &gt; CRM Studio &gt;Configuration**.  You will see the **Configuration - CRM 
 Studio** dialog box.
- From the **Configuration - CRM 
 Studio** dialog box, select **Options 
 &gt; Create Application**. A **Confirmation**  window appears.
- Select one of the  options:
- **Create 
 a blank application** - Select this option to create an application  without the sample events. This, however, does not affect the other activities  of CRM Studio.
- **Create 
 an application and copy sample events** - Select this option to create  an application with all the sample events.



**Install/Upgrade Sample Events**


This option allows you to install sample events or upgrade existing  sample events whenever an update is available. You can use this option  in the sample company as well as a registered company.


![]({{site.crm_baseurl}}/img/lens.gif) [Events in CRM  Studio]({{site.crm_baseurl}}/crm-studio/pre-defined_events.html)


![]({{site.crm_baseurl}}/img/steps.gif)To install/upgrade sample events using the **Install/Upgrade 
 Sample Events** option, do the following:

- From the main menu  bar of the **Everest** window, select **CRM &gt; CRM Studio &gt; Configuration**.  You will see the **Configuration - CRM 
 Studio** dialog box.
- From the **Configuration - CRM 
 Studio** dialog box, select **Options 
 &gt; Install/Upgrade Sample Events**. A **Confirmation**  window appears.
- Click **Yes**  to install/upgrade the sample events.



Whenever you upgrade **Everest**,  which has the CRM  Studio feature installed, you are prompted to install the latest sample  events as you try to access any feature of CRM  Studio. If you do not opt to upgrade the sample events, you can still  access the older version of the sample events. You can use the **Install/Upgrade 
 Sample Events** option from the menu at any point of time to install  the latest upgraded events.


{:.note}
This option will be enabled only when the  user does not have the latest sample events. This latest sample events  will be installed in the /Everest/ACRM  folder. However, the same will not be updated in CRM  Studio. Hence, in order to install the latest sample events, the user  has to either say 'Yes' when prompted or select the menu option manually.


You need to have rights to upgrade the events.
