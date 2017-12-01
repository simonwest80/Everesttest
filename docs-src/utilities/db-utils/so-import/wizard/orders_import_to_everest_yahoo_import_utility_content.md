---
title: Orders Import to Everest
---

# Import Sales Orders to Everest


Data from the online store must first be converted to the .CSV (comma  separated variables format) before it is imported into **Everest.** The following two .CSV files are required for importing:

- **Order 
 data File** - comprises a list of all the orders generated for the  online store along with the order number.
- **Items 
 data File** - comprises a list of all the items details (item code,  price, quantity etc.) for each order generated on the online store along  with the order number.



{:.note}
The Order data file and the Items data file  are temporary files created in the database of the company currently logged  into **Everest**. Sales orders are  created using the information in the temporary tables.


{:.steps}
To import orders from your online store into  Everest, do the following:

- From the main  menu bar, select **Utility** >  **Import** > **Sales 
 Orders** > **Import**. You  will see the [**Sales Order Import Wizard**]({{site.utl_baseurl}}/db-utils/so-import/wizard/orders_import_to_everest_profile_yahoo_import_utility_content.html).



{:.note}
Before you being actual import, you must [set Import  Preferences]({{site.utl_baseurl}}/db-utils/so-import/set-prefs/set_import_preferences_yahoo_import_utility_content.html).


When an order containing an item of type Kit  is being imported, the total kit price from the order is imported as it  is and specified against the item code for the kit. All the components  of the kit are displayed in the imported order, with price as zero.


{:.see_also}
See also
: [Sales  Order Import]({{site.utl_baseurl}}/db-utils/so-import/yahoo_import_utility_content.html)
