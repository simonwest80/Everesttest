---
title: Back End Processes - Editing a Purchase Invoice
---

# Back End Processes - Editing a Purchase Invoice


You can edit Line Item details in a saved but unposted **Purchase 
 Invoice** profile. Whenever you modify the editable columns like  Invoiced Quantity, Item Cost, Discount Value, Discount %, Tax Code, and  Add-on Cost for a line item, and it results in a change in the total value  of the line item, the following back-end processes occur:

- New columns are  created that store the original values on the purchase invoice:
- Original Item  Cost
- Original Discount
- Original Tax  Amount
- Original Add-on  Cost


- The following existing  columns display the last modified cost:
- Item Cost
- Discount value
- Discount %
- Tax Code
- Job Code
- Add-on cost



On saving a modified **Purchase 
 Invoice** profile the system checks whether there is a Sales Invoice  created between the Original Date and Time when the purchase invoice was  created and the Date and Time when the purchase invoice was modified and  whether there is a difference in the Original Cost and the Cost mentioned  in the modified purchase invoice.


If system finds out any such records then those  records must be marked with \* in the **Sales 
 Commission Report** next to the Cost column.


{:.note}
- Adequate security  right is needed to modify the line item details.
- You cannot edit  the Received column on a saved Purchase Invoice profile.
- Modifying the Add-on  Cost in **Add-on Cost Distribution**  dialog box, it will reflect in Item Details grid.
- If the total value  of the Line Item edited is equal to the value that was there earlier the  system will not generate the **Cost Adjustment**  document.


{:.see_also}
See also
: [Accounting  Entries - Edit a Purchase Invoice]({{site.pp_baseurl}}/purc-proc/pis/modify-a-purchase-invoice/accounting_entries_edit_a_purchase_invoice_pur.html)
: [Modify  a Purchase Invoice]({{site.pp_baseurl}}/purc-proc/pis/modify-a-purchase-invoice/modifying_purchase_invoices_pur.html)
