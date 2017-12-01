---
title: Attach/Retrieve Serial #
---

# Attach/Retrieve Serial #


The submenu options under the **Attach/Retrieve**  option (path: **Point of Sale (sales invoice**)  profile **&gt; Options &gt; Attach/Retrieve 
 Serial #**) allow you to attach serial numbers of the item to a Point  of Sale (sales invoice) document. The submenu options are:

- **Serial 
 #** - Use this option to retrieve serial numbers of the item one  at a time.



**![]({{site.pos_baseurl}}/img/lens.gif) [Retrieve  Individual Serial Numbers]({{site.pos_baseurl}}/misc/retrieving_individual_serial_numbers_pos.html)**

- **Serial 
 # Range** - use this option to retrieve serial numbers of the item  as a range.



![]({{site.pos_baseurl}}/img/lens.gif) [Retrieve  a Range of Serial Numbers]({{site.pos_baseurl}}/misc/retrieve_a_range_of_serial_numbers_pos.html)

- **Mfg. 
 Serial** - Use this option to retrieve serial numbers of the item  by manufacturer's serial number.



**![]({{site.pos_baseurl}}/img/lens.gif)  [Retrieve  Manufacturer's Serial Number]({{site.pos_baseurl}}/misc/retrieve_manufacturer_s_serial_number_pos.html)**


{:.note}
When you attach a serial number of an item not present  on the POS (sales invoice) document, you are asked whether you want to  serialize the item that does not exist on the order. Click **Yes**  to attach the item on the Point of Sale (sales invoice) document.


This prompt is displayed only if the option **Prompt 
 when trying to retrieve and serialize an item that is not already present 
 in a document** in the **Documents** dialog box dialog box (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Documents**  > **Miscellaneous** > **Others** > **Others 
 2** tab) is selected.


If you retrieve the same item more than once into a document, and retrieve  or scan a range of serial numbers into the system, the serial numbers  are first assigned to the highlighted line item in the Item Details Grid.  Additional serial numbers are attached to the remaining line items.


| ![]({{site.pos_baseurl}}/img/example.gif) | The item details contained in sales order # 1001 are  detailed below:<br/><br/>| Item Code | Quantity Column | Line # |<br/>| Item 1 | 2 | 1 |<br/>| Item 2 | 1 | 2 |<br/>| Item 1 | 3 | 3 |<br/><br/><br/>If you scan serial numbers 1, 2, 3, 4 and 5 while line  #1 is highlighted, serial numbers 1 and 2 are assigned to line 1 while  the remaining are assigned to line 3. If the serial numbers are scanned  into the system when line 3 is highlighted, serial numbers 1, 2 and 3  are assigned to line 3 while the remaining are assigned to line 1. |


- **Transfer 
 / Attach area wise stock** - This option allows you to attach negative  quantities to a POS (sales invoice) document. When you select this option,  you will see the **Assign Quantity**  dialog box.
- **Show/Assign 
 New Stock** - This option allows you to assign non-serialized items  contained in only ‘stock’ type of stock areas to a Point of Sale (sales  invoice) document. When you select this option, you will see the **Attach 
 Quantity** profile.



{:.see_also}
See also
: [Point  of Sale Document Options]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-si-profile/options/point_of_sale_invoice_options.html)
