---
title: Batch Payment Process - New Sale or Refund Browser
---

# Batch Payment Process - New Sale or Refund Browser


Credit card transactions with type "Sale", "Refund"  or "Sale or Authorize" are recorded in the **Batch 
 Payment Process - New Sale or Refund** browser (path: **Accounting**  > **Accounts** **Receivable**  > **Batch** **Payment****Processing** > **New****Sale** **or****Refund**).


![]({{site.acc_baseurl}}/img/lens.gif)  [CC  Transaction Types]({{site.acc_baseurl}}/misc/cc_transaction_types_batch_credit_card_process_browsers.html)


The following transactions are also displayed in this browser:

- Web orders  whose payment method is associated with a ICVerify  processor.
- Sales Orders  that are imported with the payment preference set to "No payment  has been processed".



![]({{site.acc_baseurl}}/img/lens.gif) [Sales  Order Import Preference - Payments tab]({{site.utl_chm}}/db-utils/so-import/set-prefs/prefs-profile/orders_import_preferences_profile_preferences_2_utility.html)


Process Transactions


When you process (path: **Batch****Payment Process** browser > **Options** > **Process**)  these transactions, they are first authorized (you will see the **Credit** **Card****Authorization** dialog box) and  the approval code is obtained. The funds are also captured immediately.


Once the transactions have been approved, journal entries are generated  in the relevant journals and the transaction will not be visible in the  **Batch** **Payment 
 Process – New Sale or Refund** browser. If however, you reduce the  **Payment Amount**, and the document  continues to have a balance after the transaction is processed, the remaining  payment amount continues to be displayed in the browser so that you can  process it later.


{:.example}
If the sale transaction is for $1000, and  you process only $750 due to lack of funds, the accounting entry is created  for $750. The transaction continues to be displayed in the browser with  a payment amount of $250 (1000-750).


{:.see_also}
See also
: [Batch  Payment Process Browser]({{site.acc_baseurl}}/customer-receipts-and-refunds/batch-payment-processing/batch_credit_card_process_browsers.html)
: [Batch  Payment Process Browser - Options]({{site.acc_baseurl}}/customer-receipts-and-refunds/batch-payment-processing/batch_credit_card_process_browser_options.html)
