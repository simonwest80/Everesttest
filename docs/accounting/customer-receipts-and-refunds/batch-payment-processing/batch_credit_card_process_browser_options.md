---
title: Batch Payment Process Browser - Options
---

# Batch Payment Process Browser - Options


The **Batch Payment Process** browser  has the following options (path: **Batch 
 Payment Process** browser > **Options**):


**Select All**
: This is a toggle option that allows you to select  or deselect all the records in the browser.


**Payment Details**
: Select this option to display the details of payments  and refunds on the selected document. When you select this option, you  will see the **Payment History** browser.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Payment  History Browser]({{site.sp_chm}}/sales-docs/sales-orders/so-proc/pmts-refunds/payment-history/payment_history.html)


**Modify Document**
: Select this option to open the document for editing.


**Get Latest Exchange Rate**
: Select this option to retrieve the latest exchange  rate (as on the login date) in the **Rate 
 (Document Currency)**, **Rate (Bank 
 Currency)** and **Rate (Payment Currency)**  columns.


{:.hint}
To view the **Rate 
 (Document Currency)**, **Rate (Bank 
 Currency)** and **Rate (Payment Currency)**  columns, drag and drop these fields from the **Customize**  window (path: **Batch Payment Process** browser  > **Options &gt; Field Chooser**)  into the browser.
: The exchange rate is retrieved from the **Buy 
 Rate/Sell Rate** fields in the **Exchange 
 Rates** profile (path: **File &gt; 
 Setup &gt; Accounting &gt; Multi-Currency &gt; Exchange Rates &gt; Options 
 &gt; Edit &gt; In New Window**).


{:.note}
Whether the buy rate/sell rate is displayed  depends in turn, on the option you have selected in the **Rate 
 for receipts** field in the **Accounting** dialog box (path: **File &gt; Setup 
 &gt; Preferences &gt; Defaults &gt; Accounting &gt; Multi Currency &gt; 
 Exchange Rates** tab).
: You can edit these exchange rates. When the rate  columns are updated, the corresponding amounts in the **Bank 
 Amount**, **Document Amount** and  **Payment Amount** columns are also  updated.


{:.hint}
To view the **Bank 
 Amount**, **Document Amount** and  **Payment Amount** columns, drag and  drop these fields from the **Customize**  window (path: **Batch Payment Process** browser  > **Options &gt; Field Chooser**)  into the browser.


**Change Document**
: Select this option to apply the payment to another  document from the **Sales Documents**  browser. The **Sales Documents** browser  displays all unpaid documents created for the selected customer.
: Payment Amount Column


| Browser Selected From: | Payment Amount Column: |
| **Batch Payment Process – Prior Authorizations**  browser | Is automatically  replaced with the balance of the new document or the authorization amount,  whichever is lesser. |
| Any other Batch Payment Process browser | - Automatically changes  to the new document balance, if the document balance on the new document  is less that the payment amount.<br/>- If the document  balance on the new document is more than the payment amount, **Everest**  prompts you to confirm whether you want to change the payment amount to  match the new document balance. If you click **No**,  and save the browser without processing the transaction, **Everest**  displays the **Batch Payment Error**  dialog box. |

: If you select another document, the **Document 
 #** column on the browser is updated. When you process the transaction,  the payment is applied to the new document and the balance on the new  document accordingly reduces.


**Process**
: Select this option to process the receipt/refund.  If the transaction is a credit card receipt/refund, the funds are captured.  If the transaction is a cash or check payment the accounting entry is  created to account for the receipt/refund.


**Update Details**
: Select this option to save all the changes made  in the **Batch** **Payment 
 Process** browser. You must select the **Update****Details** option, to ensure that  the changes made, if any, are saved.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Columns  in the Batch Payment Process Browser]({{site.acc_baseurl}}/misc/columns_in_the_batch_credit_card_process_browser.html)


**Delete**
: Select this option to delete a record from the **Batch** **Payment 
 Process** browser. To delete the record you must first select the  record by clicking in the **Select** column.


**View Last Errors**
: Select this option to display the credit card transactions  that could not be processed in the **Batch 
 Credit Card Error Log** window.


{:.see_also}
See also
: [Process  Batch Credit Cards]({{site.acc_baseurl}}/misc/process_payment_refund_transactions_in_a_batch.html)
: [Batch  Payment Process Browser - Options]({{site.acc_baseurl}}/customer-receipts-and-refunds/batch-payment-processing/batch_credit_card_process_browser_options.html)
