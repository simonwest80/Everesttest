---
title: Apply/Refund Credit Order
---

# Apply/Refund Credit Order


Select this option if the deposit made to a customer on a credit order  has to be applied to a credit memo or another credit order or is being  refunded by the customer.


If you apply the deposit made on the credit order to a credit memo,  the Customer Deposit will be credited and the Accounts Receivable account  will be debited. If you receive a refund, the Bank Account associated  with the selected payment method is debited and the Customer Deposit account  is credited.


When this entry type is selected:

- The **Credit 
 Order** number must be specified in the **Document 
 #** column of the **Transaction Entries**  section.



{:.hint}
When you select the **Apply/Refund 
 Credit Order** option to apply the payment to another document, you  will have to follow it with a transaction entry of type [Refund  Credit Memo]({{site.acc_baseurl}}/misc/refund_credit_memo_entry_types_rptjrnl.html) or [Deposit  on Credit Order]({{site.acc_baseurl}}/misc/deposit_on_credit_order_entry_types_receipt_journals.html).

- The **Customer 
 Deposit** account specified in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting 
 &gt; Control Accounts** tab) can only be credited.
- The **Credit** column automatically displays the amount of deposit made  on the selected credit order that has not yet been applied to other documents.



{:.see_also}
See also
: [Entry  Types - Details]({{site.acc_baseurl}}/customer-receipts-and-refunds/receipt-jrnl-dtls/transaction-entries/entry_types_details_receipt_jrnl.html)
