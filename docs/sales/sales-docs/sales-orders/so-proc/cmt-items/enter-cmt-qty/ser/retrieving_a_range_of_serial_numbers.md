---
title: Retrieve a Range of Serial Numbers
---

# Retrieve a Range of Serial Numbers


You can attach serialized inventory only from 'stock' type of stock  areas to a sales order/invoice.


{:.steps}
To retrieve a range of serial numbers into  a sales order/invoice, do the following:

- From the **Sales Order/Sales Invoice** profile, select  **Options &gt; Attach / Retrieve Serial 
 # &gt; Serial # Range**. You will see the **Retrieve 
 Serial Numbers** dialog box.
- Specify the  starting and ending serial numbers to be attached to the sales order/invoice  in the **Serial # From** and **Serial # To** fields and click **Apply**.



The serial numbers are attached to the line item. You will be prompted  with a message that the item does not exist on the document when you attach  a serial number of an item that is not present on the sales order or invoice.  Click **Yes** to attach the item to  the document.


{:.note}
This prompt is received only if the option **Prompt 
 when trying to retrieve and serialize an item that is not already present 
 in a document** (path: **File &gt; 
 Setup &gt; Preferences &gt; Flow Control &gt; Documents &gt; Miscellaneous 
 &gt; Others &gt; Others 2** tab) is selected.


**Everest** allows you to select  serial numbers from stock areas for the logged in location only, if you  select the **Allow Users to access only 
 those stock areas in the logged in location** check box (path: **File &gt; Set up &gt; Preferences &gt; Flow 
 Control &gt; Other Flow Control &gt; General** tab).


The serial numbers  can also be scanned into the system using your bar code scanner.


Select the [**History**]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/ser/retrieving_individual_serial_numbers.html#history_retrieve_attach_serial_nos_sales) ![]({{site.sp_baseurl}}/img/sales_history_button.gif) button to  view details of the serial numbers attached to the item. These details  will be displayed in the lower half of the **Retrieve 
 Serial Numbers** dialog box.


{:.note}
Once you select **Close**,  the **Retrieve Serial Numbers** dialog  box closes and you cannot access this information again.


{:.see_also}
See also
: [Flow  Control - Documents]({{site.bp_chm}}/flow-ctrl/ctrl/doc-frm/misc/flow_control_setup_dialog_box_miscellaneous_tab_con.html) [Serialized  Items]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/ser/serialized_items_entering_committed_quantity.html)
