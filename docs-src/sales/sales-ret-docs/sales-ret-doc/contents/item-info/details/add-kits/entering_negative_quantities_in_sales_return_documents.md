---
title: Enter Negative Quantities in Sales Return Documents
---

# Enter Negative Quantities in Sales Return Documents


Negative quantities can be entered in all sales return documents.


Credit Quote


Negative quantities can be entered directly in the **Quantity**  column of the credit quote.


Credit Order/Memo


Negative quantities can be entered directly in the **Requested**  column of the credit order. Entering negative quantities on credit memos  or committing negative quantities on a credit order is categorized under  the following:

- **Non-Inventoried 
 Items** - Enter the quantity prefixed with a negative (-) sign.
- **Inventoried 
 Items** - You can directly enter the quantity prefixed with a negative  sign, in the **Committed** column  of credit order, only if the option **Use 
 default stock area to assign quantity for non-serialized items in Sales 
 Documents** (path:**File** >  **Setup** > **Accounting**  > **Location**/**Sub-Location**  > **Options** > **New**  > **Location** > **In 
 New Window** > **Stock** **Transfer** > **Miscellaneous**  tab) is selected for the logged  in location or sub-location. If the above option is not selected, the  **Attach Quantity** dialog box is  displayed, listing all 'STOCK' type of stock areas, when committing negative  quantities. The stock is automatically retrieved from the default stock  area specified for sales return documents in the **Location**  profile of the logged in location or sub-location. If no stock areas are  defined for this location, the stock area defined for the default location  is used.

: You can scan and enter the Invoice # or Gift Receipt  to process returns.
: ![]({{site.sp_baseurl}}/img/lens.gif)[Return  Process]({{site.sp_baseurl}}/sales-docs/docs-profile/options/ret-proc/return_process_common_browser_options_sales_docs_contents_sal.html)
: You can attach negative quantities in a credit memo  by selecting **Options &gt; Attach/Retrieve 
 Serial # &gt; Show/Attach Area wise stock**. You will see the **Attach Quantity** dialog box. Select **Toggle Area Type** button. Attach quantities  from STOCK type of areas.


![]({{site.sp_baseurl}}/img/lens.gif) [Locations  and Sub-Location]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)


{:.note}
If adequate stock of the item does not exist  in the default stock area, **Everest** searches  for stock in other stock areas provided you have selected the "Search  in other stock area" options in the **Location**  profile > **Stock** **Transfer**  > **Miscellaneous** tab.
: If the option **Use 
 default stock area to assign quantity for non-serialized items in sales 
 documents** is NOT selected in the **Location**  profile, negative quantities are entered in the **Attach****Quantity** profile (<font style="font-family: Verdana;" face="Verdana">path:<span style="font-size: 11pt;"> </span></font>Sales  **Order/Invoice profile &gt; Options &gt; 
 Attach/Retrieve Serial # &gt; Show/Attach area wise stock**). Click  on the **Toggle Area Type** button  and enter the required quantity in the appropriate stock area.


![]({{site.sp_baseurl}}/img/lens.gif) [Attach  Quantity Profile]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/non-ser/the_attach_quantity_profile.html)

- **Serialized 
 Items** - Enter the appropriate serial number of the item. Depending  on the document type, negative quantities can be attached from 'Stock'  or 'Out' type of stock areas. If on a sales return document, serial numbers  from 'Stock' type of stock areas are attached, they are treated as negative  quantities. On sales documents if items belonging to 'Out' type of stock  areas are attached, they are treated as negative quantities.



![]({{site.sp_baseurl}}/img/example.gif) While  creating a credit memo if the customer also purchases an item, you can  scan in the serial number of the item. Negative quantities can be attached  on a credit memo only from 'Stock' type of stock areas. The stock area  type of all other items attached to the invoice will be 'Out'.


{:.note}
To attach negative quantities in a credit  memo, use the option **Attach/Retrieve 
 Serial # &gt; Serial #**. Select the serial numbers to be attached  from the 'Stock' type of stock areas.

- **Auto-serialized 
 Items** - Negative quantities CANNOT be automatically assigned for  auto-serialized type of items. The serial numbers have to be manually  retrieved from 'Out' or 'Stock' type of stock areas depending on the document  type.



{:.see_also}
See also
: [Negative  Quantities in Sales and Sales Return Documents]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/details/add-kits/negative_quantities_in_sales_and_return_documents.html)
: [Add  an Item to a Sales Return Document]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/contents/item-info/details/add-kits/add_an_item_to_a_sales_return_document.html)
