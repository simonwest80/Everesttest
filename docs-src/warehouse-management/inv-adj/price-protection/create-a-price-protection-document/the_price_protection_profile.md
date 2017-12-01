---
title: The Price Protection Profile
---

# The Price Protection Profile


**![wh_notes_icon.gif]({{site.wm_baseurl}}/img/wh_notes_icon.gif) (Document Notes)**
: Click ![wh_notes_icon.gif]({{site.wm_baseurl}}/img/wh_notes_icon.gif) to attach notes to the document.  You will see the **Document** **Notes** dialog box where you can enter  the relevant information.


**Document #**
: When you save a document, the system automatically  generates the document number.  Price  protection results in an increase or decrease in Accounts Payable. A manual  purchase document is created with the document number prefixed by ‘M’  for the inventory adjustment amount.
: If the vendor has to be credited for the increase  in purchase cost, a manual purchase invoice is created. If the vendor  has to be debited for the decrease in purchase cost, a manual debit memo  is created.


**Document Date**
: The login  date is populated in this field. You cannot change the date.


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Document  Information]({{site.wm_baseurl}}/misc/document_information_inv_adj_details.html)


**Vendor Code**
: Specify the vendor who has to be debited or credited  with the inventory adjustment amount. You cannot modify this field. This  is a mandatory field.


**Vendor Name**
: This field displays the name of the vendor from  whom the item is procured. You cannot modify this field.


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Price  Protection Details]({{site.wm_baseurl}}/inv-adj/price-protection/price_protection_details_new.html)


**Accounts Payable**
: The account displayed in this field is based on  the Vendor Posting Group assigned to the vendor of the document. You can  however select any other control account of the type Account Payable.


Item Grid Information


**Line No.**
: This column displays the line number of the Item  Details Grid.


**Item Code**
: Specify the code of the item for which you want  to make price protection. This is a mandatory field.


**Description**
: This field displays the description of the item.  You cannot modify this field.


**Type**
: Inventory type of the item is displayed in this  field. You cannot modify this field.


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Item  Information]({{site.wm_baseurl}}/misc/item_information_inv_adj_details.html)


**Current Stock**
: The total quantity of the selected item available  from all the stock areas is displayed in this column. The current stock  is shown in the default purchase measure. This quantity cannot be edited.


{:.note}
**Everest** displays  the current stock from only those stock areas for the logged in location,  depending upon your flow control preferences (path: **File 
 &gt; Set up &gt; Preferences &gt; Flow Control &gt; Other Flow Control 
 &gt; General** tab **&gt; Allow Users 
 to access only those stock areas in the logged in location** check  box). If you select the above-mentioned check box, then, only the current  stock in the stock areas of the logged-in location will<font style="font-family: Verdana;" face="Verdana"> </font>be displayed.


**UM**
: You can change the purchase unit of measure, if  necessary, to any of the purchase measures defined for the selected item.  The **Current Stock** field is updated  to the changed measure.


**Quantity**
: Enter quantity of the item, if the item specified  is non-serialized. The quantity defaults to 1 with the decimal accuracy  of the measure. With the appropriate security rights, you can increase  the quantity decimal accuracy up to 6.


{:.example}
**Your default purchase measure is KG and the  KG decimal accuracy is 2. The quantity is shown as 1.00, but you can enter  1.123 or 1.12345.**
: If you change the decimal accuracy of the purchase  unit of measure, the original quantity is retained with the decimal accuracy  of the changed measure.


{:.example}
**If your quantity is entered as 10.20 and the  decimal accuracy of the measure is changed to 0, the quantity is shown  as 10.**
: You will have to attach the serial numbers of the  item, if the item specified is serialized or auto-serialized.


{:.steps}
To attach a serial number of the item, do  the following:

- From the **Price Protection** profile, select **Options &gt; Attach Serial #**. You will  see the **Retrieve Serial Numbers**  dialog box.
- Specify the  serial number of the item.
- Click **OK**



![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Calculation  of Inventory Adjustment Amount]({{site.wm_baseurl}}/inv-adj/price-protection/calculation_of_inventory_adjustment_amounts_price_prot.html)


**Correction**
: This column shows the difference between the  Previous  Cost and the Corrected Cost. The Price Protection is made with the value  in this field.


**Inventory Acnt**
: The Inventory Control Account defined in the Posting  Group assigned to the line item is considered first. If no Inventory Control  Account is defined for the item, the control account defined for the category  to which the line item belongs is used. If the Inventory Control Account  is not defined for either the item or the category, the Inventory Control  Account of the stock area’s location from where the item is assigned is  taken into consideration. You can choose any other inventory control account  of the type Inventory Control Account.


**Previous Cost**
: This field displays the average cost of the line  item (based on purchase measure) before enabling price protection. The  previous cost is shown in the cost price decimal accuracy of the item.


**Corrected Cost**
: Enter the new cost, based on the selected measure,  in this field. The price protection is made with the value you enter in  this field. You can enter the cost in the cost price decimal accuracy  of the item. If you have the appropriate security rights, you can increase  the cost price decimal accuracy up to 6.


**Inventory Adjustment Amount**
: The amount of inventory adjustment on that line  is calculated and displayed in this column.


| ![]({{site.wm_baseurl}}/img/lens.gif) | [Inventory  Adjustment Details]({{site.wm_baseurl}}/inv-adj/the-inventory-adjustment-document/inventory_adjustment_document_details.html)<br/><br/><br/>[Price Protection  Details]({{site.wm_baseurl}}/inv-adj/price-protection/price_protection_details_new.html) |



{:.see_also}
See also
: [Details  Tab]({{site.wm_baseurl}}/misc/details_tab_price_prot_steps.html)
: [Multimedia  Tab]({{site.wm_baseurl}}/misc/multimedia_tab_price_prot_steps.html)
: [Custom  Fields Tab ]({{site.wm_baseurl}}/misc/custom_fields_tab_stck_trnsfr_profile_steps.html)
: [Accounting  Entries Tab]({{site.wm_baseurl}}/misc/accounting_entries_tab_price_prot_steps.html)
: [Transaction  History Tab]({{site.wm_baseurl}}/misc/transaction_history_tab_price_prot_steps.html)
: [Status  Bar Information]({{site.wm_baseurl}}/misc/status_bar_information_price_prot_steps.html)
: [Create Price  Protection]({{site.wm_baseurl}}/inv-adj/price-protection/create-a-price-protection-document/create_price_protection.html)
: [Editing  Accounts in Inventory Adjustment Documents]({{site.wm_baseurl}}/misc/editing_accounts_in_inventory_adjustment_documents.html)
