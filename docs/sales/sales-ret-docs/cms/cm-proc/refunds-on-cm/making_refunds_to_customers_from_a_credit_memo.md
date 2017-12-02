---
title: Making Refunds to Customers from a Credit Memo
---

# Making Refunds to Customers from a Credit Memo


Payments may be made against a credit memo in one of the two ways:

- Making a payment  to the customer.
- Applying the  amount of the credit memo to a sales order as a deposit or an existing  sales invoice for payment.



Foreign Exchange Information


If you apply a credit memo against a sales order, the system does not  calculate foreign exchange gains or losses. Instead, the system applies  the balance of the credit memo to the sales order. If you make a payment  to a customer to settle a credit memo, the system calculates a foreign  exchange gain or loss and creates an accounting entry of Gain/Loss to  reflect the difference in exchange rate.


![]({{site.sp_baseurl}}/img/lens.gif) [Accounting  Defaults - Multicurrency]({{site.acc_chm}}/misc/accounting_defaults_multi_currency.html)


[Apply  a Credit Memo to a Sales Order]({{site.sp_baseurl}}/misc/applying_credit_memo_to_a_sales_order.html)


If you have set a default account in EITHER the **G/L 
 account for gain on settlement for foreign currency documents** field  OR the **G/L 
 account for loss on settlement for foreign currency documents** field,  it can be used for both gains and losses.


Refunds to customers from a credit memo can be made through a credit  card. A credit card payment is  processed  when you select the **Use Payment Processor**  option in the **Payment Method** profile  (path: **File &gt; Setup &gt; Accounting 
 &gt; Payment Methods &gt; Options &gt; Edit &gt; In New Window &gt;****Credit Card Processing** tab).


{:.steps}
To make refunds on a credit memo, do the  following:

- From the **Credit Memo** profile, select **Options 
 &gt; Payment &gt; Refund**. You will see the [**Refund** dialog box]({{site.sp_baseurl}}/sales-ret-docs/cos/co-proc/refunds/dlg/the_payment_dialog_box_refund_cm.html).



{:.note}
The **Refund** option  is enabled only when the refund is NOT made on the credit memo. On a new  credit memo the option is available when the credit memo is saved.


{:.see_also}
See also
: [Accounting  Entries - Refund Credit Memo]({{site.sp_baseurl}}/sales-ret-docs/cms/cm-proc/refunds-on-cm/refund-dlg/accounting_entries_refund_credit_memo.html)
: [Back  End Processes - Refund Credit Memo]({{site.sp_baseurl}}/sales-ret-docs/cms/cm-proc/refunds-on-cm/refund-dlg/back_end_processes_refund_credit_memo.html)
