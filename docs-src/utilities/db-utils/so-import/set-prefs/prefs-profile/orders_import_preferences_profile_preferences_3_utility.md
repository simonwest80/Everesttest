---
title: Sales Order Import Preferences Profile - Miscellaneous
---

# Sales Order Import Preferences Profile - Miscellaneous


The **Miscellaneous** tab allows  you to specify a default item, default delivery method, kit price item,  shipping charges item and additional details.


Default Values


**Field to base item code search on**
: Select the field to map to the **Item 
 code** field (path: **Item**  profile > **General** tab) when  sales orders are imported from your  Yahoo!  Store. The options are:

- **Product 
 ID:** Select this option to map the Yahoo! Product ID field to the  **Item code** field in **Everest**.
- **Product 
 Code:** Select this option to map the Yahoo! Product Code field to  the **Item code** field in **Everest**.



**Default Item to be used when items not found  \***
: Specify an alternate/default item code if the product  code on the online store does not match an existing item code in **Everest**.
: ![]({{site.utl_baseurl}}/img/example.gif) You want to import a sales order for the item 'Books' from  your online store. But, this item may not have been created in the **Everest** database. Specify an alternate  item which will then be imported.


**Default delivery method \***
: Specify the delivery method to be used if the delivery  method in **Everest** does not match  the one specified by the customer on the sales order.
: ![]({{site.utl_baseurl}}/img/lens.gif) [Default  Delivery Method]({{site.utl_baseurl}}/misc/default_delivery_method_default_sales_order_info_order_import_preferences_details_utility_main_content.html)


**Item to be used for Shipping Charges \***
: Select an item code to account for the freight charges  contained in the sales order to be imported. The item code must be of  a non-inventoried item.


Additional Details


**Custom field for order number**
: Order numbers are generated for the orders created  on your online store. Specify the custom field in **Everest**  that should store these numbers. Only character type custom fields are  available for selection. ****


**Custom field for storing order creation date  and time**
: Specify the custom field in **Everest**  that should store the date and time when the order was placed on the online  store. Only date type custom fields are available for selection. Depending  on the custom field selected from the drop-down list, the date and time  details will be displayed in the respective custom field in the sales  order created in **Everest**.


**Custom field for storing Referring Page Information**
: The referring page is the web page from which a  link is provided to your online store. Specify the custom field that should  store the referring page details. Only character type custom fields are  available for selection.
: ![]({{site.utl_baseurl}}/img/example.gif) You give a search for the Everest Software website in a search engine.  The web page in the search engine from which there is a link to the Everest Software  website is the referring page.


**Custom field for storing Entry Point Details**
: The entry point is the destination site that is  obtained from the referring page. Specify the custom field that should  store the entry point details. Only character type custom fields are available  for selection.
: ![]({{site.utl_baseurl}}/img/example.gif) In the earlier example, when you click the link it takes  you to the Everest Software website, and the Everest Software homepage becomes the entry point.


{:.see_also}
See also
: [Sales  Order Import Preferences Profile]({{site.utl_baseurl}}/db-utils/so-import/set-prefs/prefs-profile/orders_import_preferences_profile_utility_content.html)
