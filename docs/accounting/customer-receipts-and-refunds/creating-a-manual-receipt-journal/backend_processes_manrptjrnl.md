---
title: Back End Processes - Receipt Journals
---

# Back End Processes - Receipt Journals


The processes that occur in the back end when a receipt journal is created  are:

- If you receive  a customer receipt, then the customer's unposted  amount and net balance reduces. If you make a customer refund, then the  customer's unposted  amount and net balance increases.
- If the receipt  was against an existing sales invoice, sales order or credit memo, the  amount paid on the document gets updated.



**![]({{site.acc_baseurl}}/img/lens.gif) [Back  End Processes - Receipts on Sales Invoices]({{site.sp_chm}}/sales-docs/sales-orders/so-proc/pmts-refunds/pmts-on-so/rcpt-dlg/back_end_processes_receipt_on_a_sales_invoice.html)**

- If the receipt  has an entry type miscellaneous deposit, then **Everest**  creates a manual sales order. The document number is prefixed with an  M to denote  that it is a manual sales order. The sequence number for manual sales  orders that has been specified for the login location or the parent location  of the login sub-location is used. The sequence numbers are specified  in the **Location** profile (path:  **File** > **Setup**  > **Accounting** > **Location**/  **Sub-Location**> **Options**  > **Edit** > **In 
 New Window** > **Invoicing**  tab > **Manual Order #** field).



**If sequence numbers are not defined for  the login location or the parent location of the login sub-location, the  sequence number assigned to the default location is assigned to the document.  The default location is specified in the **Accounting** dialog box (path: **File** > **Setup** > **Preferences** > **Defaults** > **Accounting** > **Miscellaneous** tab **** >**Default Location** field).**


**![]({{site.acc_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)**


{:.see_also}
See also
: [Creating  a Receipt Journal]({{site.acc_baseurl}}/customer-receipts-and-refunds/creating-a-manual-receipt-journal/creating_a_manual_receipts_journal.html)
