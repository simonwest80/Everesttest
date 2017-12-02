---
title: Enter Negative Quantities in Sales Documents
---

# Enter Negative Quantities in Sales Documents


You can enter negative quantities in all sales documents.


Sales Quote


You can enter negative quantities directly in the **Quantity**  column of the sales quote.


Sales Order/Sales Invoice


You can enter negative quantities directly in the **Ordered**  column of the sales order. Entering negative quantities on sales invoices  or committing negative quantities on a sales order is categorized under  the following:

- **Non-Inventoried 
 Items** - Enter the quantity prefixed with a negative (-) sign. You  cannot commit non-inventoried items on a sales order.


- **Inventoried 
 Items** - You can directly enter the quantity prefixed with a negative  sign, in the **Committed** column  of sales order, only if the option **Use 
 default stock area to assign quantity for non-serialized items in sales 
 documents** (path: **File &gt; Setup** > **Accounting** > **Location/Sub-Location** > **Options** > **New** > **Location**  > **In New Window** > **Stock** **Transfer**  > **Miscellaneous** tab) is selected  for the logged in location or sub-location. If the above option is not  selected, the **Attach Quantity**  dialog box is displayed, listing all 'OUT' type of stock areas, when committing  negative quantities. The stock is automatically retrieved from the default  stock area specified for sales documents in the **Location**  profile of the logged in location or sub-location. If no stock areas are  defined for this location, the stock area defined for the default location  is used.

: You can scan and enter the Invoice # or Gift Receipt  to process returns.
: ![]({{site.sp_baseurl}}/img/lens.gif)[Return  Process]({{site.sp_baseurl}}/sales-docs/docs-profile/options/ret-proc/return_process_common_browser_options_sales_docs_contents_sal.html)
: You can attach negative quantities in a sales invoice  by selecting **Options &gt; Attach/Retrieve 
 Serial # &gt; Transfer/Assign new stock**. You will see the **Assign Quantity** dialog box.


**![]({{site.sp_baseurl}}/img/lens.gif) [Locations  and Sub-Location]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)**


{:.note}
If adequate stock of the item does not exist  in the default stock area, **Everest** searches  for stock in other stock areas provided you have selected the "Search  in other stock area" options in the **Location**  profile > **Stock** **Transfer**  > **Miscellaneous** tab.
: If the option **Use 
 default stock area to assign quantity for non-serialized items in sales 
 documents** is NOT selected in the **Location**  profile, negative quantities must be attached from the **Attach 
 Quantity** profile (path: **Sales 
 Order** or **Sales Invoice** profile **&gt; Options &gt; Attach/Retrieve Serial # 
 &gt; Show/Attach area wise stock**). Click on the **Toggle 
 Area Type** button and enter the required quantity in the appropriate  stock area.


**![]({{site.sp_baseurl}}/img/lens.gif) [Attach  Quantity Dialog Box]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/non-ser/the_attach_quantity_profile.html)**

- **Serialized 
 Items** - Enter the appropriate serial number of the item. Depending  on the document type, you can attach negative quantities from the 'Stock'  or 'Out' type of stock areas. On sales documents, if items belonging to  'Out' type of stock areas are attached, they are treated as negative quantities.  If on a sales return document, serial numbers from 'Stock' type of stock  areas are attached, they are treated as negative quantities.



![]({{site.sp_baseurl}}/img/example.gif) While  creating a sales invoice if an item is also returned, you can scan in  the serial number of the item. Negative quantities can be attached on  a sales invoice only from 'Out' type of stock areas. The stock area type  of all other items attached to the invoice is 'Stock'.


{:.note}
To attach negative quantities in a sales invoice,  use the option **Attach/Retrieve Serial 
 # &gt; Serial #**. Select the serial numbers to be attached from  the 'Out' type of stock areas.

- **Auto-serialized 
 Items** - Negative quantities CANNOT be automatically assigned for  auto-serialized type of items. You must retrieve the serial numbers manually  from the 'Out' or 'Stock' type of stock areas depending on the document  type.



{:.see_also}
See also
: [Negative  Quantities in Sales and Sales Return Documents]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/details/add-kits/negative_quantities_in_sales_and_return_documents.html)
: [Adding  Items to a Sales Document]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/details/add-kits/retrieving_items_item_details_grid_sales_document_content.html)
