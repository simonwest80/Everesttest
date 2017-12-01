---
title: Back End Processes - Editing a Purchase Receipt
---

# Back End Processes - Editing a Purchase Receipt


You can edit Line Item details in a saved but unposted **Purchase 
 Receipt** profile. Whenever you modify the editable columns like  Item Cost, Discount Value, Discount %, Tax Code, and Add-on Cost for a  line item, and it results in a change in the total value of the line item,  the following back-end processes occur:

- A **Cost 
 Adjustment** document shown in the original and the last modified  values is created. The date of this document is the same as the date on  which the purchase receipt is modified. You cannot edit the **Cost 
 Adjustment** document. Also, the unposted journal created for this  document can neither be deleted nor voided.
- New columns are  created that store the original values on the purchase receipt:


- Original Item  Cost
- Original Discount
- Original Tax  Amount
- Original Add-on  Cost
- The following existing  columns display the last modified cost:
- Item Cost
- Discount value
- Discount %
- Tax Code
- Add-on cost



On saving a modified **Purchase 
 Receipt** profile the system checks whether there is a Sales Invoice  created between the Original Date and Time when the Purchase Receipt was  created and the Date and Time when the Purchase Receipt was modified and  whether there is a difference in the Original Cost and the Cost mentioned  in the modified Purchase Receipt.


If system finds out any such records then those  records must be marked with “\*” in the **Sales 
 Commission Report** next to the **Cost**  column.


{:.note}
- Adequate security  right is needed to modify the line item details.
- You cannot edit  the **Received** column on a saved  **Purchase Receipt** profile.
- Modifying the Add-on  Cost in the **Add-on Costs Distribution**  dialog box will reflect in the **Item Details**  grid.
- If the total value  of the Line Item edited is equal to the value that was there earlier the  system will not generate the **Cost Adjustment**  Document.


{:.see_also}
See also
: [Modify  a Purchase Receipt]({{site.pp_baseurl}}/purc-proc/prs/modify-a-purchase-receipt/modifying_purchase_receipts.html)
: [Accounting  Entries - Edit a Purchase Receipt]({{site.pp_baseurl}}/purc-proc/prs/modify-a-purchase-receipt/accounting_entries_edit_a_purchase_receipt_pur.html)
