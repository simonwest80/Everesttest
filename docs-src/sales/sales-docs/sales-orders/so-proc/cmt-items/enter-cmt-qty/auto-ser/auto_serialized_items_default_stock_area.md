---
title: Auto-serialized Items - Default Stock Area
---

# Auto-serialized Items - Default Stock Area


The stock area from which quantities are committed on the sales order  depend on the selection made for the **Prompt 
 method for selecting a stock area when auto-serializing sales document**  option (path: **File &gt; Setup &gt; Preferences 
 &gt; Flow Control &gt; Documents &gt; Prompts &gt; Sales Document &gt; 
 Sales Document 1** tab).


The following options are available:

- **None**  - If the prompt option selected is **None**,  quantities are attached from the default stock area for auto-serialized  items specified in the **Assign inventory 
 from &gt; Sales Order** field of the **Workstation 
 Settings** dialog box (path: **File 
 &gt; Setup &gt; Preferences &gt; Workstation Settings &gt; Stock Areas 
 &gt; For Sales** tab) of the user creating the sales document.

: If the default stock area in the **Workstation Settings** is blank, quantities  are attached from the default stock area specified for assigning items  on sales orders in the logged in location/sub-location (path: **File**  > **Setup** > **Accounting**  > **Location**/**Sub-Location**  > **Options** > **Edit**  > **In New Window** > **Stock** **Transfer**  > **Sales** **Document**  tab).


{:.note}
**Everest** automatically  looks for stock in other stock areas when items are committed in sales  orders and invoices if there is insufficient stock in the default stock  area. This is done if you have selected the options to search in other  areas in the **Location** profile  (path: **File &gt; Setup &gt; Accounting 
 &gt; Location/Sub-Location &gt; Location** profile **&gt; Stock transfer** tab **&gt; Miscellaneous**  tab).

- **Each 
 item** - If the prompt option selected is **Each 
 Item**, you are asked to select the stock area from which the quantities  must be attached for each auto-serialized item on the sales order.
- **Once 
 for all items** - If the prompt option selected is **Once 
 for all items**, you are asked to select the stock area from which  the quantities must be attached for all the auto-serialized items contained  in the sales order.



If the quantities to be committed are greater than the quantities available  in the selected stock area, you are asked to select the stock area from  which the remaining quantity must be attached.


{:.note}
The **Stock 
 Area** field displays in the status bar when you need to select a  stock area. Select a stock area and press the **Enter**  key or **ESC** key to exit this field  and continue.


When you select the option **When an 
 item marked as auto-serialized consists of a manufacturer serial number, 
 how do you wish to auto-serialize the item** in the **Documents**  dialog box (path: **File &gt; Setup &gt; 
 Preferences &gt; Flow Control &gt; Documents &gt; Prompts &gt; Sales Document 
 &gt; Sales Document 1** tab), you can set one of the following preferences:

- Auto-serialize  without prompt
- Skip such items
- Prompt user



![]({{site.sp_baseurl}}/img/lens.gif) [Documents  - Prompts - Sales Documents]({{site.bp_chm}}/flow-ctrl/ctrl/doc-frm/prompts/sales-prompts/flow_control_setup_dialog_box_prompts_sales_tab_con_businesss_process_in_everest_content.html)


{:.see_also}
See also
: [Auto-serialized  Items - Entering Committed Quantities]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/auto-ser/auto_serialized_items_entering_committed_quantity.html)
: [Entering  Shipped Quantities]({{site.sp_baseurl}}/sales-docs/sis/sales-invoice-processes/shipped-quantities/entering_shipped_quantities.html)
