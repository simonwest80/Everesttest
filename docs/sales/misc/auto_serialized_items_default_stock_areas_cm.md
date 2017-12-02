---
title: Auto Serialized Items - Default Stock Areas
---

# Auto Serialized Items - Default Stock Areas


The stock area from which quantities are committed on the credit memo  depends on the **Prompt method for selecting 
 a stock area when auto-serializing sales document** option specified  in the **Flow Control Preferences** (path:  **File &gt; Setup &gt; Preferences &gt; 
 Flow Control &gt; Documents &gt; Prompts &gt; Sales Document &gt; Sales 
 Document 1** tab).


The following options are available:

- **None**  - If the prompt option selected is **None**,  quantities are attached from the default stock area for auto-serialized  items specified in the **Credit Memo** field  of the **Workstation Settings** (path:  **File &gt; Setup &gt; Preferences &gt; 
 Workstation Settings &gt; Stock Areas &gt; For Sales** tab).



**If the default stock area in the **Workstation Settings** dialog box is blank,  quantities are attached from the default stock area specified for assigning  items on credit memos in the stock transfer preferences of the login  location or the location of the logged in location/sub-location (path:  **File** **&gt; 
 Setup &gt; Accounting &gt; Location/Sub-Location &gt; Options &gt; Edit 
 &gt; In New Window** **&gt; Stock 
 Transfer &gt; Sales Document** tab). If no stock area is defined  for the logged in location or sub-location, the stock area defined for  the default location is used.**

- **Each 
 item** - If the prompt option selected is **Each 
 Item**, you are asked to select the stock area into which the quantities  must be received for each auto-serialized item on the credit memo.
- **Once 
 for all items** - If the prompt option selected is **Once 
 for all items**, you are asked to select the stock area into which  the quantities  must  be received for all the auto-serialized items contained in the credit  memo.



If the quantity to be committed is greater than the quantity available  in the selected stock area, you are asked to select the stock area from  which the remaining quantity must be attached.


{:.note}
The **Stock 
 Area** field displays in the status bar when you need to select a  stock area. Select a stock area and press the **Enter**  key or **ESC** key to exit this field  and continue.


If the quantity in the selected stock area includes items to which a  manufacturer's serial number is assigned, you can choose to skip such  items or auto-serialize them without being prompted. This preference has  to be set in the **When an item marked 
 as auto-serialized consists of a manufacturer serial number, how do you 
 wish to auto-serialize the item** option of the **Documents** dialog box (path: **File &gt; Setup 
 &gt; Preferences &gt; Flow Control &gt; Documents &gt; Prompts &gt; Sales 
 Document &gt; Sales Document 1** tab).


**![]({{site.sp_baseurl}}/img/lens.gif) [<font style="font-family: Verdana;" face="Verdana"><span style="font-family: Verdana, sans-serif;">Flow Control 
 Dialog Box</span> - </font>Documents - Prompts - Sales Documents tab]({{site.bp_chm}}/flow-ctrl/ctrl/doc-frm/prompts/sales-prompts/flow_control_setup_dialog_box_prompts_sales_tab_con_businesss_process_in_everest_content.html)**


{:.see_also}
See also
: [Auto-serialized  Items - Entering Committed Quantities]({{site.sp_baseurl}}/sales-ret-docs/cos/co-proc/cmt-items-to-co/attach-cmt-qty/auto-ser/auto_serialized_items_co.html)
: [Entering  Returned Quantities]({{site.sp_baseurl}}/sales-ret-docs/cms/cm-proc/received-quantities/entering_returned_quantities.html)
