---
title: Batch Payment Process - New Authorization Browser
---

# Batch Payment Process - New Authorization Browser


Credit card transactions with type "Authorize", "Book"  or "Sale or Authorize" are recorded in the **Batch 
 Payment Process – New Authorizations** browser (path: **Accounting**  > **Accounts** **Receivable**  > **Batch** **Payment****Processing** > **New****Authorization**).


![]({{site.acc_baseurl}}/img/lens.gif)  [CC  Transaction Types]({{site.acc_baseurl}}/misc/cc_transaction_types_batch_credit_card_process_browsers.html)


The following transactions are also displayed in this browser:

- Web orders  whose payment method is associated with a Payflow  Pro or Saferpay processor.
- Sales Orders  that are imported with the payment preference set to "Credit card  authorized for payment".



![]({{site.acc_baseurl}}/img/lens.gif) [Sales  Order Import Preference - Payments tab]({{site.utl_chm}}/db-utils/so-import/set-prefs/prefs-profile/orders_import_preferences_profile_preferences_2_utility.html)


Process Transactions


When you process these transactions (path: **Batch****Payment Process** browser > **Options** > **Process**),  the credit card transaction is first authorized. The transaction type  will be changed to 'Capture'.


These transactions are then displayed in the **Batch 
 Payment Process– Prior Authorizations** browser. If however, you  reduce the Payment Amount, and the document continues to have a balance  after the transaction is processed, the remaining payment amount continues  to be displayed in the browser so that you can process it later.


{:.example}
If the authorization transaction is for $1000,  and you process only $750 due to lack of funds, the transaction continues  to be displayed in the browser with a payment amount of $250 (1000-750).


No accounting entries are created when "Pre-Authorization"  type of transactions are processed.


{:.see_also}
See also
: [Batch  Payment Process Browser]({{site.acc_baseurl}}/customer-receipts-and-refunds/batch-payment-processing/batch_credit_card_process_browsers.html)
: [Batch  Payment Process Browser - Options]({{site.acc_baseurl}}/customer-receipts-and-refunds/batch-payment-processing/batch_credit_card_process_browser_options.html)
