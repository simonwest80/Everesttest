---
title: Attach Committed Quantities - Serialized Items
---

# Attach Committed Quantities - Serialized Items


Serial numbers of the item to be attached to the debit order or memo  may be retrieved in any of the following ways:

- [One  by one]({{site.pp_baseurl}}/return-proc/dos/do-processes/attaching-items-do/serialized-items/retrieving_individual_serial_numbers_pur_ret_do.html)
- [As  a range]({{site.pp_baseurl}}/return-proc/dos/do-processes/attaching-items-do/serialized-items/retrieving_a_range_of_serial_numbers_pur_ret_do.html)
- [By  manufacturer's serial number]({{site.pp_baseurl}}/return-proc/dos/do-processes/attaching-items-do/serialized-items/retrieving_manufacturer_s_serial_number_debit_memo_order_pr_content.html)



If you retrieve the same item more than once into a document, and retrieve  or scan a range of serial numbers into the system, the serial numbers  are first assigned to the highlighted line item in the Item Details Grid.  Additional serial numbers are attached to the remaining line items.


| ![]({{site.pp_baseurl}}/img/example.gif) | The item details contained in debit order # 1001 are detailed below:<br/><br/><br/>| Item Code | Quantity | Column Line # |<br/>| Item 1 | 2 | 1 |<br/>| Item 2 | 1 | 2 |<br/>| Item 1 | 3 | 3 |<br/><br/><br/><br/>If you scan serial numbers 1, 2, 3, 4 and 5 while line #1 is highlighted,  serial numbers 1 and 2 are assigned to line 1 while the remaining are  assigned to line 3. If the serial numbers are scanned into the system  when line 3 is highlighted, serial numbers 1, 2 and 3 are assigned to  line 3 while the remaining are assigned to line 1. |



If you scan additional serial numbers (i.e., more than the quantity  entered in the **Quantity** column),  **Everest** asks you to confirm that  the serial numbers have to be committed to the order. If you confirm this,  the additional serial numbers are attached to the highlighted line item.


{:.example}
**In the above example if you also scan serial  numbers 6 and 7 while line #1 is highlighted, the additional serial numbers  are assigned to line #1.**


If the serial number attached is purchased from a vendor other than  the one selected on the debit order, you will be prompted to confirm that  you want to attach the serial number.


If the actual cost of the serial number differs from the price specified  for the line item, you will be prompted if you want to attach the serial  number to a new line.


{:.example}
**If the price for return of an item is $125  and the actual cost of one of the serial numbers attached is $100, you  may want to add the same item with price of $100 and attach the serial  number to it.**


When the serial number is attached to a debit order or a memo, an entry  is made in the history of the serial number. The **Serial****Number** **History**  (path: **Debit** **Order**/**Memo** profile > **Options**  > **Serial** **Number****History**)browser displays the history  of the stock areas and the documents to which a serial number was assigned.


{:.see_also}
See also
: [Attach  Committed Quantities]({{site.pp_baseurl}}/return-proc/dos/do-processes/attaching-items-do/attaching_items_to_the_debit_order.html)
