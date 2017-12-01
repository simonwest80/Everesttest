---
title: Stock Transfer - Miscellaneous
---

# Stock Transfer - Miscellaneous


Use this tab to specify the default stock bins to use when you create  various purchase and sales documents, and when you commit items. You can  also use this tab to define the order in which the system searches other  stock bins if sufficient stock is not found in the default bin.


Stock Bin Selection


**Use default stock bin to receive items when creating  a new purchase receipt / invoice**
: Select this check box to automatically receive items  into the default stock bin when you create a purchase receipt or invoice.  You define the default stock bin on the **Purchase 
 Document** tab. If you clear this check box, the system displays  the **Assign Quantity** window on  the purchase receipt or invoice where you can manually specify the bin  in which to receive the items.
: You might select this check box if you always want  to use the same bin for receiving items on a purchase document.


**<font color="#000000" class="hcp2">Use default stock bin to 
 receive items when creating a new credit memo</font>**
: Select this check box to automatically receive items  into the default stock bin when you create a credit memo. You define the  default stock bin on the **Sales Document**  tab. If you clear this check box, the system displays the **Assign 
 Quantity** window on the credit memo where you can specify the bin  in which to receive the items.
: You might select this check box if you always want  to use the same bin for receiving items when customers return items to  you before you transfer those items elsewhere.


**<font color="#000000" class="hcp2">Use default stock bin to 
 assign quantity for non-serialized items in debit Documents</font>**
: Select this check box to automatically transfer  non-serialized items into the default stock bin when you create a debit  document. You define the default stock bin on the **Purchase Document** tab. You might select this check box if you always  use the same stock bin to store items that are being returned to a vendor.
: If you clear this check box, the system displays  the **Assign Quantity** window on  the debit document where you can specify the bin from which to assign  item quantities that you are returning to a vendor.


Stock Bin Selection for sales and credit documents


**Use default stock bin to commit quantity in sales  documents for inventoried and auto-serialized items not tracked for lots.**
: Select this check box to use the default stock bin  to commit item quantities in sales documents for inventoried and auto-serialized  items that are not set up for lot tracking. You define the default stock  bin on the **Purchase Document** tab  in the **Purchase Receipt / Invoice**  field.
: You might select this check box, for example, if  you always use the same stock bin from which to pull inventoried and auto-serialized  items to fill sales orders.


**Search other stock bins if inventory does not  exist in default stock bin while committing in Sales Orders.**
: Select this check box to have the system automatically  search for stock in other stock bins of type Out if insufficient inventory  exists (for inventoried items that are not lot tracked or auto-serialized  items) in the default stock bin when you commit items on the sales order.  You define the other stock bins in the table at the bottom of this screen.  This field is relevant only if you use a default stock bin for sales documents.
: You might select this check box to commit items  on a sales order more efficiently by having the system automatically pull  items from another stock bin, rather than having to manually search for  and commit available items. If non-serialized items are tracked for lots,  the **Attach Quantity** dialog box  is displayed on the sales order irrespective of the preference option  you select here. If you set up your Flow Control preferences to allow  users to access only those stock areas that reside in the location in  which the user is logged, only the stock areas of the login location are  searched.


**Search other stock bins if inventory does not  exist in default stock bin while committing in Sales Invoices.**
: Select this check box to have the system automatically  search for stock in other stock bins of type Out if insufficient inventory  exists (for inventoried items that are not lot tracked or auto-serialized  items) in the default stock bin when you commit items on the sales invoice.  You define the other stock bins in the table at the bottom of this screen.  This field is relevant only if you use a default stock bin for sales documents.
: You might select this check box to commit items  on a sales invoice more efficiently by having the system automatically  pull items from another stock bin, rather than having to manually search  for and commit available items.
: If non-serialized items are tracked for lots, the  **Attach Quantity** dialog box is  displayed on the sales invoice irrespective of the preference option you  select here. If you set up your Flow Control preferences to allow users  to access only those stock areas that reside in the location in which  the user is logged, only the stock areas of the login location are searched.


**Use default stock bin to commit quantity in credit  orders and credit memos for inventoried and auto-serialized items not  tracked for lots.**
: Select this check box to use the default stock bin  to commit item quantities in credit documents for inventoried and auto-serialized  items that are not set up for lot tracking. You define the default stock  bin on the **Sales Document** tab  in the **Sales Invoice** field.
: You might select this check box, for example, if  you always use the same stock bin to commit inventoried and auto-serialized  items that a customer returns to you before you transfer the items elsewhere.


**Search other out stock bins if inventory does  not exist in default stock bin while committing in credit orders or credit  memos.**
: Select this check box to have the system automatically  search for stock in other stock bins of type Out if insufficient inventory  exists (for inventoried items that are not lot tracked or auto-serialized  items) in the default stock bin when you commit items on the credit documents.  You define the other stock bins in the table at the bottom of this screen.  This field is relevant only if you select to use a default stock bin for  credit documents.
: If non-serialized items are tracked for lots, the  **Attach Quantity** dialog box is  displayed on the credit document irrespective of the preference option  you select here. If you set up your Flow Control preferences to allow  users to access only those stock areas that reside in the location in  which the user is logged, only the stock areas of the login location are  searched.


**Stock bin search order for committing inventory**
: This section allows you to define the sequence in  which the system searches other stock bins when the default stock bin  is unavailable. The system uses this sequence table only when you select  one of the check boxes on this screen that allows the system to search  other stock bins when committing items.
: All stock bins of type Normal are listed here. You  can change the order of the stock bins by using the **Up**  and **Down** arrow buttons.


{:.note}
: If you select the **Allow 
 users to access only those stock bins in the logged in location**  (path: **File &gt; Setup &gt; Preferences 
 &gt; Flow Control &gt; Other Flow Control &gt; Genera**l tab) check  box, only the stock areas of the login location are searched.


{:.see_also}
See also
: [The  **Location** Profile - Stock Transfer]({{site.sc_baseurl}}/options/locations-and-sub-locations/set-up-locations/the_location_profile_stock_transfer.html)
: [Stock Transfer  Information]({{site.sc_baseurl}}/options/locations-and-sub-locations/location-details/stock-transfer-information/stock_transfer_information.html)
: [Stock Areas]({{site.sc_baseurl}}/options/miscellaneous-set-up/stock-areas/stock_areas_setup.html)
