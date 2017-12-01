---
title: Apply/Refund Debit Order
---

# Apply/Refund Debit Order


Select this option if the deposit received from the vendor on a debit  order has to be applied to a debit memo or another debit order or has  to be refunded to the vendor.<font style="color: #ff0000;" color="#FF0000"> </font>


If you apply the deposit made on the debit order to a debit memo, the  Vendor Deposit will be debited and the Accounts Payable account will be  credited. If you refund the payment to the vendor, the Bank Account associated  with the selected payment method is credited and the Vendor Deposit account  is debited.


When this entry type is selected:

- The **Debit 
 Order** number should be specified in the **Document 
 #** column of the **Transaction Entries**  section.



{:.hint}
When you select the **Apply/Refund 
 Debit Order** option to apply the payment to another document, you  will have to follow it with a transaction entry of type [Refund  Debit Memo]({{site.acc_baseurl}}/misc/refund_debit_memo_entry_type_pmtjrnl.html)<font style="color: #008000;" color="#008000"> </font>or [Deposit  on Debit Order]({{site.acc_baseurl}}/misc/deposit_on_debit_order_entry_types_payment_journals.html).

- The **Vendor 
 Deposit** account specified in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting 
 &gt; Accounts** tab) can only be debited.
- The **Debit** column automatically displays the amount of deposit received  on the selected debit order that has not yet been applied to other documents.



{:.see_also}
See also
: [Entry Types -  Details]({{site.acc_baseurl}}/vendor-payments-and-refunds/payment-jrnl-dtls/transaction-entries/entry_types_details.html)
