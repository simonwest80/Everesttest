---
title: Retrieving Individual Serial Numbers
---

# Retrieving Individual Serial Numbers


You can attach serialized inventory only from 'stock' type of stock  areas to a sales order/invoice.


{:.steps}
To retrieve individual serial numbers into  a sales order/invoice, do the following:

- From the **Sales Order/Sales Invoice** profile, select  **Options &gt; Attach/Retrieve Serial # 
 &gt; Serial #**. You will see the **Retrieve Serial Numbers**  dialog box.
- Specify the  serial number of the item in the **Serial 
 #** field and click **Apply**.



The serial number is attached to the line item. You will be prompted  with a message that the item does not exist on the document when you attach  a serial number of an item that is not present on the sales order or invoice.  Click **Yes** to attach the item to  the document.


{:.note}
This prompt is received if the option **Prompt 
 when trying to retrieve and serialize an item that is not already present 
 in a document** (path: **File**  > **Setup** > **Preferences**  > **Flow** **Control**  > **Documents** > **Miscellaneous**  > **Others &gt; Others 2** tab)  is selected.


**Everest** allows you to select  serial numbers from stock areas for the logged in location if you select  the **Allow Users to access only those 
 stock areas in the logged in location** check box (path: **File 
 &gt; Set up &gt; Preferences &gt; Flow Control &gt; Other Flow Control 
 &gt; General** tab).


The serial numbers can also be scanned into the system using your bar  code scanner.


[]()History


While retrieving serial numbers, if you select the **History**![]({{site.sp_baseurl}}/img/sales_history_button.gif) button, you will see the details of the serial numbers  displayed in the lower half of the **Retrieve 
 Serial Numbers** dialog box. The following details are displayed  in the lower half of the **Retrieve Serial 
 Numbers** dialog box:

- Action type


- Added - A serialized  item not present on the document is added.
- Assigned - A serial  number is attached to an item.
- Negative - A negative  quantity is added.
- Skipped - The serial  number is already assigned (and thus cannot be re-assigned).


- The serial  numbers that are retrieved.
- The manufacturer's  serial number if any.
- The item code  and description.
- The stock area  from where the item is released.



{:.note}
Once you select **Close**,  the **Retrieve Serial Numbers** dialog  box closes and you cannot access this information again.


{:.see_also}
See also
: [Flow  Control - Documents]({{site.bp_chm}}/flow-ctrl/ctrl/doc-frm/misc/flow_control_setup_dialog_box_miscellaneous_tab_con.html)
: [Serialized  Items]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/ser/serialized_items_entering_committed_quantity.html)
