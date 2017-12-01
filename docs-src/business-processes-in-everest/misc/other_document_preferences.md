---
title: Other Document Preferences
---

# Other Document Preferences


**Set the quantity shipped value to zero 
 when converting the sales order to sales invoice (force you to enter the 
 quantity shipped)**
: When a sales order is converted to a sales invoice,  the quantity shipped column automatically displays the quantity ordered.  The quantity shipped may differ from the quantity ordered. If you save  the sales invoice, the discrepancy gets registered in the invoice. To  prevent such errors, check this box to set the quantity shipped to zero.  Thus, you are forced to enter the actual shipped quantity, manually.


{:.note}
This option works only for auto-serialized and inventoried (non-serialized)  items.


For serialized items,  the  shipped column always displays 'zero'. You have to manually attach the  required serial numbers.


Set the quantity received value to zero when  converting a purchase/debit order to a purchase receipt or purchase invoice/debit  memo
: When you convert a purchase order to a purchase  receipt or invoice, the Received column automatically displays the quantity  ordered. If the quantity received is less than the quantity ordered and  the purchase receipt or invoice is saved, physical quantities in stock  will not tally with the stock registered in the system. To prevent the  error, check this option to set the quantity received to zero so you must  manually enter the quantity received.
: Similarly, when a debit order is converted to a  debit memo the Quantity Debited column automatically displays the quantity  requested. Check this option to set the quantity debited to zero so you  must manually enter the quantity debited.


{:.note}
This option works only for auto-serialized and inventoried (non-serialized)  items.


For serialized items,  the  shipped column always displays 'zero'.


**Set the quantity invoiced value to zero when  converting a purchase order/receipt to a purchase invoice**
: When you convert a purchase order to a purchase  invoice, the Invoiced column automatically displays the quantity ordered  but not invoiced. When you convert a purchase receipt to a purchase invoice,  the Invoiced column automatically displays the quantity received but not  invoiced. If the quantity you intend to invoice is less than the quantity  ordered/received but not invoiced and the invoice is saved, the amount  payable to the vendor is not correct. Check this option to set the quantity  invoiced to zero so you must manually enter the quantity invoiced.


**Set quantity received value to zero when converting  a purchase order into a purchase invoice**
: Check this option to set the quantity received to  zero when you convert a purchase order to a purchase invoice. If you check  this option, the **Received** field  does not populate automatically and you must manually enter the quantity  received. This option is unchecked by default.
: If this option is unchecked, when you convert a  purchase order to a purchase invoice, the **Received**  column automatically updates with the quantity pending to be received  if the **Use default stock bin to receive 
 items when creating a new purchase receipt / invoice** option in  the **Location** profile is selected  (path: **File** > **Setup**  > **Accounting** > **Location 
 / Sub-Location** > **Location**  profile > **Stock Transfer** tab  – **Miscellaneous** tab). The **Received to Date** column updates based  on the quantity entered in the **Received**  column.


**Update received quantity to match invoiced quantity  when creating purchase invoices**
: Select this option if you want your Received quantity  to be automatically populated from your Invoiced quantity when creating  a purchase invoice. You can still make adjustments in the documents, if  necessary.


{:.note}
If you also want to set default bins when  creating a purchase receipt/invoice, select the **Use 
 the default bin to receive items when creating a new purchase receipt/invoice**  option in the **Location** profile  (path: **File** > **Setup**  > **Accounting** > **Location/Sub-Location**  > Select your location > **Edit**  > **In New Window** > **Location** profile > **Stock 
 Transfer** > **Miscellaneous**  tab). This automatically receives the stock into bins so that you will  not be prompted to select a bin when creating a new purchase receipt or  invoice.


{:.see_also}
See also
: [Others  1 Tab - Documents Dialog Box]({{site.bp_baseurl}}/misc/miscellaneous_others_others_1_steps.html)
: [Documents  Dialog Box - Miscellaneous]({{site.bp_baseurl}}/flow-ctrl/ctrl/doc-frm/misc/flow_control_setup_dialog_box_miscellaneous_tab_con.html)
: [Setting  up Flow Control Options]({{site.bp_baseurl}}/flow-ctrl/ctrl/opt/setting_flow_control_options.html)
