---
title: Auto-serialized Items - Default Stock Area
---

# Auto-serialized Items - Default Stock Area


The stock area from which quantities are committed on the credit order  depend on the selection made in the **Prompt 
 method for selecting a stock area when auto-serializing sales document**  option (path: **File &gt; Setup &gt; Preferences 
 &gt; Flow Control &gt; Documents &gt; Prompts &gt; Sales Document &gt; 
 Sales Document 1** tab).


This field has the following options:

- **None**  - If the prompt option selected is **None**,  quantities are attached from the default stock area for auto-serialized  items specified in the **Assign inventory 
 from &gt; Credit Order** field of the **Workstation 
 Settings** dialog box (path: **File 
 &gt; Setup &gt; Preferences &gt; Workstation Settings &gt; Stock Areas 
 &gt; For Sales** tab).

: If the default stock  area in the **Workstation Settings**  is blank, quantities are attached from the default stock area specified  for assigning items on credit orders in the logged in location/sub-location  (path: **File &gt; Setup &gt; Accounting 
 &gt; Location/Sub-Location** > **Options 
 &gt; Edit &gt; In New Window** **&gt; 
 Stock Transfer &gt; Sales Document** tab).
: If default stock areas are NOT defined  in **Workstation Settings** or the  **Location** profile, the item remains  in the stock area it was in, before it was committed on the credit order.

- **Each 
 Item** - If you select **Each Item**,  you are asked to select the stock area from which the quantities should  be attached for each auto-serialized item on the credit order.
- **Once 
 for All Items** - If you select **Once 
 for All Items**, you are asked to select the stock area from which  the quantities should be attached for all the auto-serialized items contained  in the credit order.



If the quantity to be committed is greater than the quantity available  in the selected stock area, you are asked to select the stock area from  which the remaining quantity can be attached.


{:.note}
The **Stock 
 Area** field displays in the status bar when you need to select a  stock area. Select a stock area and press the **Enter**  key or **ESC** key to exit this field  and continue.


If the quantity in the selected stock area includes items to which a  manufacturer's serial numbers are assigned, you can skip such items or  auto-serialize them without being prompted. This preference must be set  in the **When an item marked as auto-serialized 
 consists of a manufacturer serial number, how do you wish to auto-serialize 
 the item** option of the **Documents** dialog box (path: **File &gt; Setup 
 &gt; Preferences &gt; Flow Control &gt; Documents &gt; Prompts &gt; Sales 
 Document &gt; Sales Document 1** tab).


![]({{site.sp_baseurl}}/img/lens.gif) [Documents  - Prompts - Sales Document - Sales Document 1]({{site.bp_chm}}/misc/prompts_sales_document_sales_document_1_steps.html)


{:.see_also}
See also
: [Auto-serialized  Items - Entering Committed Quantities]({{site.sp_baseurl}}/sales-ret-docs/cos/co-proc/cmt-items-to-co/attach-cmt-qty/auto-ser/auto_serialized_items_co.html)
: [Entering  Returned Quantities]({{site.sp_baseurl}}/sales-ret-docs/cms/cm-proc/received-quantities/entering_returned_quantities.html)
