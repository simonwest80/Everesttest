---
title: Modify a Purchase Invoice
---

# Modify a Purchase Invoice


You can modify the **Purchase Invoice** profile from the following locations:

- The **Purchase 
 Invoice** browser - Highlight the records and select **Options 
 &gt; Edit &gt; In New Window**.
- The **Purchase 
 Invoice** profile - Specify the document number of the required invoice  in the **Document #** field.



Accounting entries for purchase invoices are recorded in system Purchase  Journals. You can only modify a purchase invoice if it has not been posted.


{:.hint}
To differentiate between purchase invoices  which are posted and unposted, add the field **Is 
 Posted** to the **Purchase****Invoices** browser using the **Field** **Chooser**  option (**Options &gt; Field Chooser**).


You can edit Line Item details in a saved but unposted **Purchase 
 Invoices** profile but you cannot add new inventoried line items  after the invoice is initially saved. You can only add non-inventoried  line items to a saved purchase invoice.


If you increase or decrease the invoiced quantity, the system automatically  balances the Accrued Purchases account.


You need adequate security rights to increase or decrease the invoiced  quantity.


{:.note}
- You are allowed  to edit a previously saved purchase invoice only if you specify an account  in the Purchase Price Variance Account field (path: **File**  > **Setup** > **Accounting**  > **Posting Group** profile).
- The purchase invoice  must belong to an open or active period for you to modify it.


Whenever you edit the editable columns for a line item, and it results  in a change in the total value of the line item, certain back-end processes  occur.


![]({{site.pp_baseurl}}/img/lens.gif)[Back  End Processes - Editing a Purchase Invoice]({{site.pp_baseurl}}/purc-proc/pis/modify-a-purchase-invoice/back_end_processes_-_editing_a_purchase_invoice.html)


![]({{site.pp_baseurl}}/img/lens.gif)[Best  Practices in Modifying Costs on Purchase Documents]({{site.pp_baseurl}}/purc-proc/prs/modify-a-purchase-receipt/best_practices_in_modifying_costs_on_pur_docs_pur.html)


{:.see_also}
See also
: [Posted  Purchase Invoices]({{site.pp_baseurl}}/purc-proc/pis/modify-a-purchase-invoice/posted_purchase_invoices_pur.html)
: [Unposted  Purchase Journals]({{site.pp_baseurl}}/purc-proc/pis/modify-a-purchase-invoice/unposted_purchase_invoices_pur.html)
