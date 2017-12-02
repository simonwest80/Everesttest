---
title: Transactions Created in Everest
---

# Transactions Created in Everest


Payment/refund transactions in **Everest**  are recorded in the **Batch Payment Process** browser, if the **Batch Processing** check box is selected on the **Receipt**/**Refund**/**Collection**  dialog box. Thus the following transactions may be recorded in the **Batch Payment Process** browser:

- Receipts on  a sales order or sales invoice
- Refunds on  a sales order or sales invoice
- Refunds on  a credit order or credit memo
- Collections  on a credit order or credit memo



Credit card transactions will be added to the **Batch****Payment Process** browser only if:

- The **Batch****Processing** option is checked on  the **Receipt/Refund** dialog box  and
- The **Sale**,  **Pre-authorization**, **Use 
 Prior Authorization** or **Refund** option is selected in the **Card****Verification** dialog box.



![]({{site.acc_baseurl}}/img/lens.gif) [Card  Verification Dialog Box]({{site.sp_chm}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/cc-verify-dlg/the_card_verification_dialog_box.html)


Credit card transactions are processed using the processor attached  to the Payment Method.


![]({{site.acc_baseurl}}/img/lens.gif) [Payment  Methods - Credit Card Processing Tab]({{site.sc_chm}}/options/payment-information/payment-methods/set-up-a-payment-method/payment_method_profile_cc_authorization_tab.html)


![]({{site.acc_baseurl}}/img/note.gif)  Journal  entries are not generated when transactions are transferred to the **Batch** **Payment 
 Process** browser.


{:.see_also}
See also
: [Batch  Payment Processing]({{site.acc_baseurl}}/customer-receipts-and-refunds/batch-payment-processing/batch_payment_processing_ar.html)
: [Back  End Processes - Batch Payment Processing]({{site.acc_baseurl}}/misc/back_end_processes_batch_credit_card_processing.html)
