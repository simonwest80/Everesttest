---
title: Generate Serial Numbers
---

# Generate Serial Numbers


You can generate serial numbers (path: **Point 
 of Sale** profile > **Options**  > **Attach/Retrieve Serial #**  > **Generate Serial #**) for items  that you want to bring into your stock from a Point of Sale document.


This feature is useful in the following scenarios:

- If you have recently  migrated to Everest, and received returns from customers for items that  were sold before switching over to Everest. The serial numbers pertaining  to such items will not exist in Everest. In order to facilitate tracking  of such items, you can use the Generate Serial # option.
- If you want to  account for the service or return of serialized items that you have not  sold but want to track. You can use this option to track the item returned  and bring it back into stock, and then assign the manufacturer's serial  number if any.



{:.example}
You are an authorized service center of a computer vendor.  Customers can come into your center to service items that they have bought  in any other store or they can even return defectives. You then return  this item to the computer vendor. In such a case, when a customer comes  in with an item for repairs or return (the serial number of which you  want to track), you can use this option to generate a new serial number.  You can the assign the manufacturer's serial number and bring the item  into stock by creating a credit memo.


{:.steps}
To  generate a serial number from a point of sale profile, do the following:

- From the **Point of Sale** profile, select **Options &gt; Attach/Retrieve Serial # &gt; 
 Generate Serial #**.
- Enter the number  of serial numbers to be generated in the **Generate 
 Quantity** column of the **Generate 
 Serial #** dialog box.



{:.note}
The quantity entered should NOT exceed the quantity  specified in the **Quantity** column  of the Item Details Grid.

- Press the **Enter** key. The required quantity gets  displayed in the Items Details Grid of the **Point 
 of Sale** profile.



{:.see_also}
See also
: [Attach/Retrieve  Serial Numbers]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-si-profile/options/attach_retrieve_serial_pos_invoice_options.html)
: [Back-end  Processes]({{site.pos_baseurl}}/misc/back-end_processes_generate_serial_numbers.html)
