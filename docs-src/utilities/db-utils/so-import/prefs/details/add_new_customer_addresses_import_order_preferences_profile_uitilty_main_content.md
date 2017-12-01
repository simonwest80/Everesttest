---
title: Add a New Customer Profile
---

# Add a New Customer Profile


**Customer** profiles are created  based on the preferences set in the [**Sales Order Import Preferences** profile **- Customers** tab]({{site.utl_baseurl}}/db-utils/so-import/set-prefs/prefs-profile/orders_import_preferences_profile_preferences_1_utility.html) (path: **Utility**  > **Import** > **Sales 
 Orders** > **Preferences**  > **Sales Order Import Preferences**  profile > **Customers** tab). During  import, the system automatically creates a new Customer profile unless  an existing billing address in the **Everest**  database matches one of the following selected options:

- **E-mail 
 ID** – If the E-mail ID of the customer billing address entered in  the online store matches the existing billing address in the **Everest**  database, do not create a new customer. If this field is blank in **Everest** and in the imported data, the  system creates a new customer.
- **Street 
 Address, Zip, and E-Mail ID** – If the Street Address, Zip, and E-mail  ID fields of the customer billing address entered in the online store  match the existing billing address in the **Everest**  database, do not create a new customer. If any one of these fields does  not match, the system creates a new customer.
- **Street 
 Address, Zip, E-Mail ID and Telephone-1** – If the Street Address,  Zip, E-mail ID, and Telephone-1 fields of the customer billing address  entered in the online store match the existing billing address in the  **Everest** database, do not create  a new customer. If any one of these fields does not match, the system  creates a new customer.



For all of the above options, fields match if they contain identical  values. A field with a value does not match a blank field.


All information populated in the Customer's profile is derived from  the Orders file. New Customer profiles are also automatically created  when they do not exist in the **Everest**  database. You can view the new Customer profiles from **Invoicing**  > **Customers** > **Options**  > **Edit** > **In 
 New Window**.


![]({{site.utl_baseurl}}/img/lens.gif)[Create  a New Customer Unless Billing Address Found with Matching]({{site.utl_baseurl}}/misc/add_new_customer_preference_orders_import_preferences_profile_preference_2_tab.html)


{:.see_also}
See also
: [Sales  Order Import Preferences Profile - Customers]({{site.utl_baseurl}}/db-utils/so-import/set-prefs/prefs-profile/orders_import_preferences_profile_preferences_1_utility.html)
: [Sales  Order Import Preferences Details]({{site.utl_baseurl}}/db-utils/so-import/prefs/details/order_import_preferences_details_yahoo_import_utility_content.html)
