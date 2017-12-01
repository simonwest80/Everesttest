---
title: Make Payments on a Purchase Invoice
---

# Make Payments on a Purchase Invoice


You can make a payment on a purchase invoice in any of the following  ways:

- Make a new  payment on the purchase invoice.
- Apply a debit  memo on the purchase invoice.
- Apply a deposit  on the purchase invoice.



![]({{site.pp_baseurl}}/img/steps.gif)To make a payment on a purchase invoice, do  the following:

- From the **Purchase** **Invoice** profile, select **Options**  > **Payment** > **Pay**.  You will see the [**Payment**  dialog box]({{site.pp_baseurl}}/purc-proc/pos/po-processes/payments/pmnt-dialog-box/the_payment_dialog.html).



When you click the **Pay** option,  **Everest** checks if there are pending  transactions in the **Batch Payment Process**  browser for that document. If pending transactions are found, **Everest**  prompts you whether you want to process existing batch payment(s) or receive  a new payment. The prompt also displays the total value of all pending  batch payments for the document.


Select **Process existing batch payments**  to view the **Batch Payment Process**  browser from where you can process the payment. To receive a new payment,  you should have appropriate security rights.


{:.note}
You can also set up prompt preferences to  automatically apply deposits when the order is converted to a invoice  by selecting **Automatic** in the  **Method for applying deposits paid on 
 a purchase order when converting it to a invoice** option (path:  **File** > **Setup**  > **Preferences** > **Flow****Control** > **Documents**  > **Flow** **Control****Setup** > **Prompts**  > **Purchase** tab).


![]({{site.pp_baseurl}}/img/lens.gif) [Automatically  Apply Deposits on Purchase Invoice]({{site.pp_baseurl}}/purc-proc/pos/po-processes/payments/automatically_applying_deposits_on_purchase_order.html)


{:.see_also}
See also
: [Accounting  Entries - New Payment on a Purchase Invoice]({{site.pp_baseurl}}/purc-proc/pis/pi-processes/payments/accounting-entries/accounting_entries_new_pr.html)
: [Accounting  Entries - Apply a Debit Memo on a Purchase Invoice]({{site.pp_baseurl}}/purc-proc/pis/pi-processes/payments/accounting-entries/accounting_entries_dm_pr.html)
: [Accounting  Entries - Apply a Purchase Deposit on a Purchase Invoice]({{site.pp_baseurl}}/purc-proc/pis/pi-processes/payments/accounting-entries/accounting_entries_pur_dep_pr.html)
: [Back  End Processes - Payment Against a Purchase Invoice]({{site.pp_baseurl}}/purc-proc/pis/pi-processes/payments/back-end-processes/back_end_processes_pay_pur_rec.html)
