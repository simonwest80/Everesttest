---
title: Create a New Customer Unless Billing Address Found with Matching
---

# Create a New Customer Unless Billing Address Found with Matching


Select your preference for one of the following conditions that will  not create a new **Customer** profile.  Create a new customer unless the system finds an existing billing address  in the Everest database with a matching:

- **E-mail 
 ID** – Select this option if you do not want to create a new customer  when the E-mail ID of the customer billing address entered in the online  store matches the existing billing address in the **Everest**  database. 
If this field is blank in both the imported billing address and in  the existing billing address in **Everest**,  a comparison is not possible and therefore the system creates a new Customer  profile.
- **Street 
 Address, Zip and E-mail ID** – Select this option if you do not want  to create a new customer when the Street Address, Zip, and E-mail ID fields  of the customer billing address entered in the online store match the  existing billing address in the **Everest**  database. If any one of these fields does not match, the system creates  a new customer. 
If any of these fields are blank in both the imported billing address  and in the existing billing address in **Everest**,  the system considers these field values the same for this field and does  not create a new customer profile based on this field.
- **Street 
 Address, Zip, E-mail ID and Telephone-1** – Select this option if  you do not want to create a new customer when the Street Address, Zip,  E-mail ID, and Telephone-1 fields of the customer billing address entered  in the online store match the existing billing address in the **Everest**  database. If any one of these fields does not match, the system creates  a new customer. 
If any of these fields are blank in both the imported billing address  and in the existing billing address in **Everest**,  the system considers these field values the same for this field and does  not create a new customer profile based on this field.



For all of the above options, fields match if they contain identical  values. A field with a value does not match a blank field.


![]({{site.utl_baseurl}}/img/lens.gif) [Add  a New Customer Profile]({{site.utl_baseurl}}/db-utils/so-import/prefs/details/add_new_customer_addresses_import_order_preferences_profile_uitilty_main_content.html)


{:.see_also}
See also
: [Sales  Order Import Preferences Profile - Payments]({{site.utl_baseurl}}/db-utils/so-import/set-prefs/prefs-profile/orders_import_preferences_profile_preferences_2_utility.html)
