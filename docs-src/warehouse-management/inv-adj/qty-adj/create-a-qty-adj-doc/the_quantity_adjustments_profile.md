---
title: The Quantity Adjustments Profile
---

# The Quantity Adjustments Profile


**![wh_notes_icon.gif]({{site.wm_baseurl}}/img/wh_notes_icon.gif) (Document Notes)**
: Click ![wh_notes_icon.gif]({{site.wm_baseurl}}/img/wh_notes_icon.gif) to attach notes to the document.  You will see the **Document** **Notes** dialog box where you can enter  the relevant information


**Document #**
: When you save a document, the system automatically  generates the document number


**Document Date**
: The login  date is automatically displayed in this field when you create the document.  You cannot change this date.


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Document  Information]({{site.wm_baseurl}}/misc/document_information_inv_adj_details.html)


Item Grid Information


**Line No.**
: This column displays the line number of the Item  Details Grid.


**Item Code**
: Specify the code of the item for which you want  to make quantity adjustments. This is a mandatory field.


**Description**
: This field displays the item description. You cannot  modify this field.


**Type**
: This field displays the inventory type of the item


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Item  Information]({{site.wm_baseurl}}/misc/item_information_inv_adj_details.html)


**Current Stock**
: The total quantity of the selected item available  from all the stock areas is displayed in this column. This quantity cannot  be edited. The total quantity of the selected item available from all  stock bins is displayed in this column. The current stock is shown in  the stock measure. You cannot edit this quantity, but you can change the  unit of measure. If you change the unit of measure, the Current Stock  field updates to the changed measure.


{:.note}
**Everest** displays  the current stock from only those stock areas for the logged in location,  depending upon your flow control preferences (path: **File 
 &gt; Set up &gt; Preferences &gt; Flow Control &gt; Other Flow Control 
 &gt; General** tab **&gt; Allow Users 
 to access only those stock areas in the logged in location** check  box). If you select the above-mentioned check box, then, only the current  stock in the stock areas of the logged-in location will<font style="font-family: Verdana;" face="Verdana"> </font>be displayed.


**UM**
: You can change the stock unit of measure, if necessary,  to any of the purchase/sales measures defined for the selected item. The  **Current Stock** field updates to  the changed measure.


**Adjustment Type**
: Select the adjustment type as add quantity or write  off quantity from the drop down list. By default, this column displays  ‘Add Quantity’.


{:.note}
You can add quantity, write off quantity or do both  in the same document.


**Quantity**
: Enter the quantity to be adjusted in this column.  The quantity is shown in the stock measure, but it updates if the unit  of measure is changed. The quantity defaults to 1 with the decimal accuracy  of the measure. With the appropriate security rights, you can increase  the quantity decimal accuracy up to 6.


{:.example}
**Your stock measure is KG and the KG decimal  accuracy is 2. The quantity is shown as 1.00, but you can enter 1.123  or 1.12345.**
: If you change the decimal accuracy of the purchase  unit of measure, the original quantity is retained with the decimal accuracy  of the changed measure and cost details update based on the changed measure.


{:.example}
**If your quantity is entered as 10.20 and the  decimal accuracy of the measure is changed to 0, the quantity is shown  as 10.**


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Calculation  of Inventory Adjustment Amount]({{site.wm_baseurl}}/inv-adj/qty-adj/calculation_of_inventory_adjustment_amounts_qty_adj.html)


**Cost**
: For additional quantities, enter the new cost based  on the measure selected. For write offs, the average cost for inventoried  items or the weighted average of the actual cost of the serial numbers  for serialized items is displayed.
: You can enter the cost in the cost price decimal  accuracy of the item. If you have the appropriate security rights, you  can increase the cost price decimal accuracy up to 6. If the unit of measure  changes, the cost updates to the changed measure.


{:.note}
The **Cost** column  can be edited only if you are adding quantity and not when you are writing  it off.


If you attach quantity to write off a serialized or  auto-serialized item, this column displays the average of the actual cost  of the serial numbers attached.


In case of non-serialized inventoried items, this column  displays the average cost specified in the **Item**  profile (path: **Inventory &gt; Items &gt; 
 Item** profile > **Inventory** tab).You  can add quantity, write off quantity or do both in the same document.


**IA Account**
: When you specify an item code, the default Inventory  Adjustment account, specified in the **Accounting**  dialog box (path: **File &gt; Setup &gt; 
 Preferences &gt; Defaults &gt; Accounting**), for that item is displayed.  If you want, you can specify a new Inventory Adjustment account for each  line item. This is a mandatory field.
: The Inventory Adjustment Account defined in the  Posting Group assigned to the line item is considered first. If no Inventory  Adjustment Account is defined for the item, the control account defined  for the category to which the line item belongs is used. If the Inventory  Adjustment Account is not defined for either the item or the category,  the Inventory Adjustment Account of the document’s location is taken into  consideration. You may however select any another inventory adjustment  account.
: For write-off of stock resolve the accounts based  on the **Item** profile or **Item 
 Category** profile or if unavailable there, then based on the account  assigned to the stock area defined in the **Inventory 
 Adjustments** tab (path: **File**  > **Setup** > **Accounting**  > **Location/Sub location &gt; New &gt; 
 Location**).


**Inventory Acnt**
: The Inventory Control Account defined in the Posting  Group assigned to the line item is considered first. If no Inventory Control  Account is defined for the item, the control account defined for the category  to which the line item belongs is used. If the Inventory Control Account  is not defined for either the item or the category, the Inventory Control  Account of the stock area’s location from where the item is assigned is  taken into consideration. You may however override this by selecting another  account of the type inventory control account.


**Previous Stock**
: The stock prior to the quantity adjustment is displayed  in this field. The previous stock is shown in the stock measure, but it  updates if the unit of measure is changed.


**New Stock**
: The stock after you make the quantity adjustment  is displayed in this field. The new stock is shown in the stock measure,  but it updates if the unit of measure is changed.


**Previous Cost**
: This field displays the average cost of the line  item (based on the selected measure) before making the quantity adjustments.  The previous cost is shown in the cost price decimal accuracy of the item.


**New Cost**
: This field displays the average cost of the line  item (based on the selected measure) after making the quantity adjustments.  The new cost is shown in the cost price decimal accuracy of the item.


**IA Amount**
: The inventory adjustment amount is calculated and  displayed in this column. It is in the decimal accuracy defined in the  currency profile.


{:.see_also}
See also
: [Quantity  Adjustments]({{site.wm_baseurl}}/inv-adj/qty-adj/quantity_adjustments_price_protection.html)
: [Details  Tab]({{site.wm_baseurl}}/misc/details_tab_quantity_adjustments_steps.html)
: [Multimedia  Tab]({{site.wm_baseurl}}/misc/multimedia_tab_quantity_adjustment.html)
: [Custom  Fields Tab ]({{site.wm_baseurl}}/misc/custom_fields_tab_stck_trnsfr_profile_steps.html)
: [Accounting  Entries Tab]({{site.wm_baseurl}}/misc/accounting_entries_tab_qty_adj_profile.html)
: [Transaction  History Tab]({{site.wm_baseurl}}/misc/transaction_history_tab_qty_adj.html)
: [Inventory  Adjustment Details]({{site.wm_baseurl}}/inv-adj/the-inventory-adjustment-document/inventory_adjustment_document_details.html)
: [Editing  Accounts in Inventory Adjustment Documents]({{site.wm_baseurl}}/misc/editing_accounts_in_inventory_adjustment_documents.html)
