---
title: Add a New Shipping Address
---

# Add a New Shipping Address


Shipping addresses are created based on the preferences set in the [**Sales Order Import Preferences** profile **&gt; Customers** tab]({{site.utl_baseurl}}/db-utils/so-import/set-prefs/prefs-profile/orders_import_preferences_profile_preferences_2_utility.html). A new shipping  address is automatically created in **Everest**  (during import) based on the preferences you set, whenever the shipping  address of the customer entered on the online store differs from that  existing in the **Everest** database  for an existing customer. The shipping addresses for a customer can be  viewed in the **Customer** profile  (path: **Invoicing** > **Customers**  > **Options** > **Edit**  > **In New Window**).


During import, the system automatically creates a new shipping address  unless a shipping address already present in the **Everest**  database matches one of the following selected options:

- **Telephone-1**  - If the Telephone-1 field of the customer shipping address entered in  the online store matches the existing shipping address in the **Everest**  database, do not create a new shipping address. If this field is blank  in **Everest** and in the imported  data, the system creates a new shipping address.
- **Street 
 Address and Telephone-1** - If the Street Address and Telephone-1  fields of the customer shipping address entered in the online store match  the existing shipping address in the **Everest**  database, do not create a new shipping address. If any one of these fields  does not match, the system creates a new shipping address.
- **Street 
 Address, Zip and Telephone-1** - If the Street Address, Zip, and  Telephone-1 fields of the customer shipping address entered in the online  store match the existing shipping address in the **Everest**  database, do not create a new shipping address. If any one of these fields  does not match, the system creates a new shipping address.



For all of the above options, fields match if they contain identical  values. A field with a value does not match a blank field.


![]({{site.utl_baseurl}}/img/lens.gif)[Create  a New Shipping Address Unless Shipping Address Found with Matching]({{site.utl_baseurl}}/misc/add_new_shipping_address_preference_orders_import_preferences_profile_preference_2_tab.html)


{:.see_also}
See also
: [Sales  Order Import Preferences Profile - Customers]({{site.utl_baseurl}}/db-utils/so-import/set-prefs/prefs-profile/orders_import_preferences_profile_preferences_1_utility.html)
: [Sales  Order Import Preferences Details]({{site.utl_baseurl}}/db-utils/so-import/prefs/details/order_import_preferences_details_yahoo_import_utility_content.html)
