---
title: Retrieving Manufacturer\'s Serial Number
---

# Retrieving Manufacturer's Serial Number


You can attach serialized inventory only from 'stock' type of stock  areas to a sales order/invoice for positive quantities. To attach serial  numbers for negative quantities, select the serial number from 'Out' type  of stock areas.


{:.steps}
To retrieve items using a manufacturer's  serial numbers into a sales order/invoice, do the following:

- From the **Sales Order/Sales Invoice** profile, select  **Options &gt; Attach/Retrieve Serial # 
 &gt; Mfg. Serial**.  You will see the **Retrieve Serial Numbers**  dialog box.
- Specify the  manufacturer's serial number of the item in the **Manufacturer's****Serial** **N****umber** field and click **Apply**.



The serial number is attached to the line item. You are prompted that  the item does not exist on the document when you attach a serial number  of an item that is not present on the sales order or invoice. Click **Yes** to attach the item to the document.


{:.note}
This prompt is received only if the option **Prompt 
 when trying to retrieve and serialize an item that is not already present 
 in a document** (path: **File**  > **Setup** > **Preferences**  > **Flow Control &gt; Documents &gt; 
 Miscellaneous &gt; Others &gt; Others 2** tab) is selected.


**Everest** allows you to select  serial numbers from stock areas for the logged in location if you select  the **Allow Users to access only those 
 stock areas in the logged in location** check box (path: **File 
 &gt; Set up &gt; Preferences &gt; Flow Control &gt; Other Flow Control 
 &gt; General** tab).


Select the [**History**]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/ser/retrieving_individual_serial_numbers.html#history_retrieve_attach_serial_nos_sales) ![]({{site.sp_baseurl}}/img/sales_history_button.gif) button to  view details of the serial numbers attached to the item. These details  will be displayed in the lower half of the **Retrieve****Serial** **Numbers**  dialog box.


{:.note}
Once you select **Close**,  the **Retrieve Serial Numbers** dialog  box closes and you cannot access this information again.


In case the manufacturer's serial number is assigned to more than one  serial number, when the item is retrieved into the document using the  manufacturer's serial number, the **Serial 
 Numbers** browser is displayed. This browser displays a list of serial  numbers that bear the same manufacturer serial number. Select the required  serial number from this browser.


{:.see_also}
See also
: [Flow  Control - Documents]({{site.bp_chm}}/flow-ctrl/ctrl/doc-frm/misc/flow_control_setup_dialog_box_miscellaneous_tab_con.html)
: [Serialized  Items]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/ser/serialized_items_entering_committed_quantity.html)
: [Manufacturer's  Serial Number]({{site.wm_chm}}/serial-num-trk/manufacturer-s-serial-numbers/manufacturer_s_serial_numbers_wm.html)
