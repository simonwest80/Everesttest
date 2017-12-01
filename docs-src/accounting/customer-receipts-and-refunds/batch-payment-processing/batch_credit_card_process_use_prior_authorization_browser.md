---
title: Batch Payment Process - Use Prior-Authorization Browser
---

# Batch Payment Process - Use Prior-Authorization Browser


Credit card transactions with type "Capture", "Ship"  or "Voice" are recorded in the **Batch 
 Payment Process – Prior Authorizations** browser (path: **Accounting**  > **Accounts** **Receivable**  > **Batch** **Payment****Processing** > **Use****Prior** **Authorization**).


![]({{site.acc_baseurl}}/img/lens.gif)  [CC  Transaction Types]({{site.acc_baseurl}}/misc/cc_transaction_types_batch_credit_card_process_browsers.html)


In other words, authorizations that are received in advance are recorded  in this browser.


![]({{site.acc_baseurl}}/img/example.gif)  Mail  order transactions where the customer will make payments only after the  receipt of the goods. The transaction will be recorded as goods have already  been sent but the payment will be received only at a later date.


When a "Pre-authorization" type of transaction is processed  from the **Batch Payment Process – New 
 Authorizations** browser, the credit card transactions are transferred  to this browser.


The following transactions are also displayed in this browser:

- Transactions  recorded on your eStorefront  shop, if the real time processing options are selected.
- Web orders  whose payment method is associated with a ICVerify  processor.
- Sales Orders  that are imported with the payment preference set to "No payment  has been processed".



![]({{site.acc_baseurl}}/img/lens.gif) [Sales  Order Import Preference - Payments tab]({{site.utl_chm}}/db-utils/so-import/set-prefs/prefs-profile/orders_import_preferences_profile_preferences_2_utility.html)


Process Transactions


When you process these transactions (path: **Batch****Payment Process** browser > **Options** > **Process**),  the funds are captured and transferred to your account.


Once the transactions have been processed, journal entries will be generated  in the relevant journals and the transaction will not be visible in the  **Batch** **Payment 
 Process** – **Prior Authorization** browser. If however, you reduce the **Payment 
 Amount**, and the document continues to have a balance after the  transaction is processed, the transaction type of the remaining payment  amount changes to “Sale” and is displayed in the **Batch 
 Payment Process – New Sale or Refund** browser so that you can  process it later.


{:.example}
If the prior authorization transaction is  for $1000, and you process only $750 due to lack of funds, the accounting  entry is created for $750. The transaction with a payment amount of $250  (1000-750) is displayed in the **Batch 
 Payment Process – New Sale or Refund** browser.


{:.see_also}
See also
: [Batch  Payment Process Browser]({{site.acc_baseurl}}/customer-receipts-and-refunds/batch-payment-processing/batch_credit_card_process_browsers.html)
: [Batch  Payment Process Browser - Options]({{site.acc_baseurl}}/customer-receipts-and-refunds/batch-payment-processing/batch_credit_card_process_browser_options.html)
