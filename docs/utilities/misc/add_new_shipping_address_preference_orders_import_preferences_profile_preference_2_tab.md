---
title: Create a New Shipping Address Unless Shipping Address Found with Matching
---

# Create a New Shipping Address Unless Shipping Address Found with Matching


Select your preference for the condition that will not create a new  shipping address for a customer. The system automatically creates a new  shipping address unless it finds an existing shipping address in the **Everest** database with a matching:

- **Telephone-1**  – Select this option if you do not want to create a new shipping address  when the Telephone-1 field of the customer shipping address entered in  the online store matches the existing shipping address in the **Everest**  database. 
If this field is blank in both the imported shipping address and in  the existing shipping address in **Everest**,  a comparison is not possible and therefore the system creates a new shipping  address.
- **Street 
 Address and Telephone-1** – Select this option if you do not want  to create a new shipping address when the Street Address and Telephone-1  fields of the customer shipping address entered in the online store match  the existing shipping address in the **Everest**  database. If any one of these fields does not match, the system creates  a new shipping address. 
If any of these fields are blank in both the imported shipping address  and in the existing shipping address in Everest, the system considers  these field values the same for this field and does not create a new shipping  address based on this field.
- **Street 
 Address, Zip and Telephone-1** – Select this option if you do not  want to create a new shipping address when the Street Address, Zip, and  Telephone-1 fields of the customer shipping address entered in the online  store match the existing shipping address in the Everest database. If  any one of these fields does not match, the system creates a new shipping  address. 
If any of these fields are blank in both the imported shipping address  and in the existing shipping address in Everest, the system considers  these field values the same for this field and does not create a new shipping  address based on this field.



For all of the above options, fields match if they contain identical  values. A field with a value does not match a blank field.


![]({{site.utl_baseurl}}/img/lens.gif)[Add  New Shipping Address]({{site.utl_baseurl}}/db-utils/so-import/prefs/details/add_new_shipping_address_import_order_preferences_profile_utility_main_content.html)


{:.see_also}
See also
: [Sales  Order Import Preferences Profile - Payments]({{site.utl_baseurl}}/db-utils/so-import/set-prefs/prefs-profile/orders_import_preferences_profile_preferences_2_utility.html)
