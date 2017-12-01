---
title: Auto-serialized Items - Default Stock Area
---

# Auto-serialized Items - Default Stock Area


The stock area from which quantities are committed on the sales invoice  depend on the **Prompt method for selecting 
 a stock area when auto-serializing sales document** option specified  in the **Flow Control Preferences** (path:  **File &gt; Setup &gt; Preferences &gt; 
 Flow Control &gt; Documents &gt; Prompts &gt; Sales Document &gt; Sales 
 Document 1** tab).


The options available are:

- **None**  - If the prompt option selected is **None**,  then quantities are attached from the default stock area for auto-serialized  items specified in the **Sales Invoice** field of the **Workstation Settings** (path: **File &gt; Setup &gt; Preferences 
 &gt; Workstation Settings &gt; Stock Areas &gt; For Sales** tab)  of the user creating the sales document.



**If the default stock area in the **Workstation Settings** is blank, then  quantities are attached from the default stock area specified for assigning  items on sales invoices in the logged in location or sub-location (path:  **File** **&gt; 
 Setup &gt; Accounting &gt; Location/Sub-Location &gt; Options** >  **New** > **Location** > **In New Window** >  **Stock Transfer &gt; Sales Document** tab).  If no stock area is defined for logged in location or sub-location, the  stock area defined for the default location is used.**

- **Each 
 item** - If the prompt option selected is **Each 
 Item**, then you will be asked to select the stock area from which  the quantities have to be attached for each auto-serialized item on the  sales invoice.
- **Once 
 for all items** - If the prompt option selected is **Once 
 for all items**, then you will be asked to select the stock area  from which the quantities have to be attached for all the auto-serialized  items contained in the sales invoice.
- If the quantity to be committed is greater than  the quantity available in the selected stock area, then you will be asked  to select the stock area from which the remaining quantity has to be attached.


{:.note}
The **Stock 
 Area** field displays in the status bar when you need to select a  stock area. Select a stock area and press the **Enter**  key or **ESC** key to exit this field  and continue.
- If the quantity  in the selected stock area includes items to which a manufacturer's serial  number has been assigned, then you can choose to skip such items or auto-serialize  them without being prompted. This preference has to be set in the **When an item marked as auto-serialized consists 
 of a manufacturer serial number, how do you wish to auto-serialize the 
 item** option of the **Documents** dialog  box (path: **File &gt; Setup &gt; Preferences 
 &gt; Flow Control &gt; Documents &gt; Prompts &gt; Sales Document &gt; 
 Sales Document 1** tab).



**![]({{site.sp_baseurl}}/img/lens.gif) [Documents  Dialog Box - Prompts - Sales Document 1 tab]({{site.bp_chm}}/misc/prompts_sales_document_sales_document_1_steps.html)**


{:.see_also}
See also
: [Auto-serialized  Items - Entering Committed Quantities]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/auto-ser/auto_serialized_items_entering_committed_quantity.html)
: [Entering  Shipped Quantities]({{site.sp_baseurl}}/sales-docs/sis/sales-invoice-processes/shipped-quantities/entering_shipped_quantities.html)
