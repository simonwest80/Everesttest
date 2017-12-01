---
title: Retrieving Manufacturer\'s Serial Number
---

# Retrieving Manufacturer's Serial Number


Serialized inventory contained only in 'out' type of stock areas can  be attached to a credit order/memo.


{:.steps}
To retrieve items using a manufacturer's  serial number into a credit order/memo, do the following:

- From the **Credit Order/Credit Memo** profile, select  **Options &gt; Attach/Retrieve Serial # 
 &gt; Mfg. Serial**.  You will see the **Retrieve Serial Numbers**  dialog box.
- Specify the  manufacturer's serial number of the item in the **Manufacturer's****serial** # field and click **Apply**.



The serial number is attached to the line item. You are prompted with  a message that the item does not exist on the document when you attach  a serial number of an item that is not present on the sales order or invoice.  Click **Yes** to attach the item to  the document.


{:.note}
This prompt is received if the **Prompt 
 when trying to retrieve and serialize an item that is not already present 
 on a document** option (path: **File 
 &gt; Setup &gt; Preferences &gt; Flow Control &gt; Documents &gt; Miscellaneous 
 &gt; Others &gt; Others 2** tab) is selected.


You can select serial numbers from stock areas for the logged in location  only, if you select the **Allow Users to 
 access only those stock areas in the logged in location** check box  (path: **File &gt; Set up &gt; Preferences 
 &gt; Flow Control &gt; Other Flow Control &gt; General** tab).


Select the [**History**]({{site.sp_baseurl}}/sales-ret-docs/cos/co-proc/cmt-items-to-co/attach-cmt-qty/ser/retrieving_individual_serial_numbers_co.html#history_retrieve_attach_serial_nos_sales_return) ![]({{site.sp_baseurl}}/img/sales_history_button.gif) button to  view details of the serial numbers attached to the item. These details  are displayed in the lower half of the **Retrieve 
 Serial Numbers** dialog box.


{:.note}
Once you select **Close**,  the **Retrieve Serial Numbers** dialog  box closes and you cannot access this information again.


In case the manufacturer's serial number is assigned to more than one  serial number, when the item is retrieved into the document using the  manufacturer's serial number the **Serial 
 Numbers** browser is displayed. This browser displays a list of serial  numbers that bear the serial number of the manufacturer. Select the required  serial number from this browser.


{:.see_also}
See also
: [Flow  Control - Documents]({{site.bp_chm}}/flow-ctrl/ctrl/doc-frm/misc/flow_control_setup_dialog_box_miscellaneous_tab_con.html)
: [Serialized  Items]({{site.sp_baseurl}}/sales-ret-docs/cos/co-proc/cmt-items-to-co/attach-cmt-qty/ser/serialized_items_attaching_committed_qty_co.html)
: [Manufacturer's  Serial Number]({{site.wm_chm}}/serial-num-trk/manufacturer-s-serial-numbers/manufacturer_s_serial_numbers_wm.html)
