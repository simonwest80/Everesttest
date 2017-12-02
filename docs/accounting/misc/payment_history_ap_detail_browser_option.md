---
title: Payment History
---

# Payment History


This option displays the details of payments and refunds on the selected  document. When you select this option, you will see the **Payment 
 History** browser. You can purge, void, and reverse payments from  this browser by highlighting a record in the **Payment 
 Details** section and selecting one of the following the right-click  options:

- Purge – Purging  deletes the transaction permanently from your database. Any Unposted transaction  can be purged.
- Void – You  will see the **Void**  dialog box. Use the **Void** option  to void or void and recreate a transaction from this dialog box.

: ![]({{site.acc_baseurl}}/img/lens.gif)[Voided  Transactions Browser]({{site.acc_baseurl}}/payment-register/wizard/browser/voided-trans/voided_transactions_browser_accounting.html)

- Reverse – You  will see the **Reverse**  dialog box. Use the **Reverse**  option to create a reversal entry to offset the original transaction.  This option can only be used for transactions with printed checks or with  a Payment Status of **Outstanding**.



The following table shows the actions that can be performed on different  transaction types.


| Transaction Type | Actions |
| Void (And Optionally<br/><br/><br/>Recreate) | Reverse (And Optionally<br/><br/><br/>Recreate) | Purge |
| Unposted – Check Printed | Yes | Yes | Yes |
| Unposted – Check Not Printed | Yes |  | Yes |
| Posted – Check Printed |  | Yes |  |
| Previously Voided |  |  |  |
| Recreated for the Voided Entry (\*\*Provided the check is printed) | Yes | Yes\*\* | Yes |
| Reversed |  |  |  |
| Reversal |  |  | Yes (Unposted only) |
| Recreated for the Reversed Entry (\*\*Provided the check is printed) | Yes | Yes\*\* | Yes |
| Cleared |  |  |  |
| Reconciled |  |  |  |



{:.see_also}
See also
: [Payment  History Browser - Purchases]({{site.pp_chm}}/purc-proc/pos/po-processes/payments/payment-history/payment_history_pur.html)
: [Payment  History Browser - Sales]({{site.sp_chm}}/sales-docs/sales-orders/so-proc/pmts-refunds/payment-history/payment_history.html)
: [A/P Detail Browser]({{site.acc_baseurl}}/vendor-payments-and-refunds/accounts-payable-details/a_p_detail_browser.html)
: [A/R Detail Browser]({{site.acc_baseurl}}/customer-receipts-and-refunds/accounts-receivable-details/a_r_detail_browser.html)
