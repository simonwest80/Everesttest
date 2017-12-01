---
title: Sales Order Import Wizard - Order Details
---

# Sales Order Import Wizard - Order Details


This section allows you to specify the code used to identify the online  store in the database, the source and location of the file to be imported  and the mode of import.


**Store Code**
: Select the store code that you have created in **Sales Order Import Preferences** profile.  This is also the code of the online store created and owned by you.
: ![]({{site.utl_baseurl}}/img/lens.gif) [Sales  Order Import Preferences profile]({{site.utl_baseurl}}/db-utils/so-import/set-prefs/prefs-profile/orders_import_preferences_profile_utility_content.html) ****


Source File Name and Location


**Order Header**


**<font style="font-family: Verdana;" face="Verdana">Specify the name and path of the file containing order 
 information.</font>**


**Order Details**
: Specify the name and the path of the file containing  item information of items.


**Import Mode**


| Yahoo | Select this option to import data in the Yahoo! file  format. |
| Standard | Select this option to import data in the standard format. |

: ![]({{site.utl_baseurl}}/img/lens.gif) [Sales  Order Formats]({{site.utl_baseurl}}/db-utils/so-import/wizard/orders_import_to_everest_yahoo_import_utility_content.html)


**Always Default to the above paths**
: Select this check box to default to the **Order 
 Header** and **Order Details**  fields while importing orders the next time.


Click **Next**. You will see the  see the [**Order Selection**]({{site.utl_baseurl}}/db-utils/so-import/wizard/yahoo_import_wizard_order_selection_section.html) section.


{:.note}
Before proceeding to the next screen in the  wizard, ensure that the Posting Groups for the company have been duly  defined. New customers are then created with the default Customer Posting  Group defined in the **Sales order**  preferences (path: **Utility** >  **Import** > **Sales 
 Order** > **Preferences**  > **Edit** > **In 
 New Window** > **Sales Order Preferences**  profile > **Customers** tab). If  the default customer Posting Group is not defined in the **Sales 
 order preferences** profile, the Posting Group specified for the  customer in the **Customer** profile  is considered.


{:.see_also}
See also
: [Sales  Order Import Wizard]({{site.utl_baseurl}}/db-utils/so-import/wizard/orders_import_to_everest_profile_yahoo_import_utility_content.html)
