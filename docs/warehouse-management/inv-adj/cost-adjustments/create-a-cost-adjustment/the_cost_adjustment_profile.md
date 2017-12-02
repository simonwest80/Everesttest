---
title: The Cost Adjustment Profile
---

# The Cost Adjustment Profile


**![wh_notes_icon.gif]({{site.wm_baseurl}}/img/wh_notes_icon.gif) (Document Notes)**
: Click ![wh_notes_icon.gif]({{site.wm_baseurl}}/img/wh_notes_icon.gif) to attach notes to the document.  You will see the **Document** **Notes** dialog box where you can enter  the relevant information.


**Document #**
: When you save a document, the system automatically  generates the document number.


**Document Date**
: The login  date is automatically displayed in this field when you create the document.  You cannot change this date.


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Document  Information]({{site.wm_baseurl}}/misc/document_information_inv_adj_details.html)


Item Grid Information


**Line Number**
: This column displays the line number of the Item  Details Grid.


**Item Code**
: Specify the code of the item for which you want  to make cost adjustments. This is a mandatory field.


**Description**
: This field displays the item description. You cannot  modify this field.


**Type**
: This field displays the inventory type of the item.


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Item  Information]({{site.wm_baseurl}}/misc/item_information_inv_adj_details.html)


**Current Stock**
: The total quantity of the selected item available  from all the stock bins is displayed in this column. The current stock  is shown in the stock measure. You cannot edit this column.


{:.note}
**Everest** displays  the current stock from only those stock areas for the logged in location,  depending upon your flow control preferences (path: **File 
 &gt; Set up &gt; Preferences &gt; Flow Control &gt; Other Flow Control 
 &gt; General** tab **&gt; Allow Users 
 to access only those stock areas in the logged in location** check  box). If you select the above-mentioned check box, only the current stock  in the stock areas of the logged-in location is displayed.


**UM**
: This field displays the stock measure for the item.  You cannot modify this field.


**Quantity**
: Enter the quantity of the item for which cost is  being adjusted. You have to attach serial numbers to the serialized or  auto-serialized items for which the cost is being adjusted.
: The quantity is shown in the stock measure. The  quantity defaults to 1 with the decimal accuracy of the measure. With  the appropriate security rights, you can increase the quantity decimal  accuracy up to 6.


{:.example}
Your stock measure is KG and the KG decimal  accuracy is 2. The quantity is shown as 1.00, but you can enter 1.123  or 1.12345.


{:.steps}
To attach serial number of the item, do the  following:

- From the **Cost Adjustments** profile, select **Options &gt; Line &gt; Attach Serial #**.  You will see the **Retrieve Serial Numbers**  dialog box.
- Specify the  serial number of the item to which you want to make cost adjustments.
- Click **OK**.



If the item selected is non-serialized, you will have to enter the quantity  to be adjusted from the **Attach Quantity**  dialog box. This quantity cannot exceed the total quantity available in  the stock.


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Calculation  of Inventory Adjustment Amounts]({{site.wm_baseurl}}/inv-adj/cost-adjustments/calculation_of_inventory_adjustment_amounts_cost_adj.html)


**Cost**
: Enter the new cost, based on the stock measure,  in this field. The cost adjustment is made with the value you enter in  this field. The average cost of the item is the average cost for its stock  measure.
: You can enter the cost in the cost price decimal  accuracy of the item. If you have the appropriate security rights, you  can increase the cost price decimal accuracy up to 6.


**IA Account**
: When you specify an item code, the default Inventory  Adjustment account for that item is displayed. If you want, you can specify  a new Inventory Adjustment account for each line item. This is a mandatory  field.
: The Inventory Adjustment Account defined in the  Posting Group assigned to the line item is considered first. If no Inventory  Adjustment Account is defined for the item, the control account defined  for the category to which the line item belongs is used. If the Inventory  Adjustment Account is not defined for either the item or the category,  the Inventory Adjustment Account of the document’s location is taken into  consideration.
: You can choose any other inventory adjustment account.


**Inventory Acnt**
: The Inventory Control Account defined in the Posting  Group assigned to the line item is considered first. If no Inventory Control  Account is defined for the item, the control account defined for the category  to which the line item belongs is used. If the Inventory Control Account  is not defined for either the item or the category, the Inventory Control  Account of the stock area’s location from where the item is assigned is  taken into consideration. The user may however override this account by  selecting another account.


**Previous Cost**
: This field displays the average cost of the line  item (based on the stock measure) before making the cost adjustments.  The previous cost is shown in the cost price decimal accuracy of the item.


**New Cost**
: This field displays the average cost of the line  item (based on the stock measure) after making the cost adjustments. The  new cost is shown in the cost price decimal accuracy of the item.


**IA Amount**
: The inventory adjustment amount is calculated and  displayed in this column. It is in the decimal accuracy defined in the  currency profile.


{:.see_also}
See also
: [Details  Tab]({{site.wm_baseurl}}/misc/details_tab_cost_adjustments_steps.html)
: [Multimedia  Tab]({{site.wm_baseurl}}/misc/multimedia_tab_cost_adj_steps.html)
: [Custom  Fields Tab ]({{site.wm_baseurl}}/misc/custom_fields_tab_stck_trnsfr_profile_steps.html)
: [Accounting  Entries Tab]({{site.wm_baseurl}}/misc/accounting_entries_tab_cost_adj_steps.html)
: [Transaction  History Tab]({{site.wm_baseurl}}/misc/transaction_history_tab_cost_adj_steps.html)
: [Status  Bar Information]({{site.wm_baseurl}}/misc/status_bar_information_cost_adj_steps.html)
: [Create a  Cost Adjustment Document]({{site.wm_baseurl}}/inv-adj/cost-adjustments/create-a-cost-adjustment/create_a_cost_adjustment.html)
: [Editing  Accounts in Inventory Adjustment Documents]({{site.wm_baseurl}}/misc/editing_accounts_in_inventory_adjustment_documents.html)
