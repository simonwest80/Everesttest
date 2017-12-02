---
title: Point of Sale Receipts
---

# Point of Sale Receipts


When you save the Point of Sale (sales invoice) document, the [**Payment Details** dialog box]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-receipts/payment-dlg/the_payment_details_dialog_box_pos_receipts.html) is automatically  displayed. You can account for payment through more than one type of tender  in this dialog box.


You CANNOT receive **partial payments**  from Point of Sale customers (POS\_CUST). You can save the Point of Sale  document only after you receive full payment from such customers.


However, if you select any other customer in the **Customer**  field, you can receive partial payments and even make a credit sale. When  you receive a partial amount from the customer, **Everest**  prompts you that there is a balance to be received on the document. You  can take any of the two actions:

- **Let 
 me apply additional payments** - If you select this option, you will  return to the **Payment** **Details**  dialog box. This option ensures that you receive full payment from your  customer; you cannot collect partial payments.
- **Forward 
 the balance of &lt; &gt; to the customer’s account with payment terms**  - If you select this option, the balance amount receivable from the customer  is transferred to the customer’s account. The default payment term for  the customer is retrieved from the **Customer**  profile (path: I**nvoicing &gt; Customer 
 &gt; Options &gt; New &gt; In New Window &gt; Payment Information**  tab). You can modify the payment term.



When a customer makes an overpayment at a POS terminal, **Everest**  displays the **Over Payment** dialog  box. The following options are available in the dialog box:

- **Give 
 the Customer &lt; &nbsp;&gt; 
 Change** - This option allows you to return the change due to the  customer. When you click **OK**, the  change due is displayed after the POS processing is complete.



{:.note}
If your preferences are set to print receipts (path:  **File** > **Setup** > **Preferences** > **Flow Control** > **Documents** > **Miscellaneous**  tab > **Others** tab > **Others 1** tab - **Auto-print 
 invoice in point of sale document** selected), the receipt prints  before the change due is displayed.

- **Apply 
 the overpayment as a customer deposit** - This option allows you  to apply the overpayment as a customer deposit. **Everest**  credits the Customer Deposit Account specified in your **Accounting 
 Defaults** (path: **File** >  **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Control Accounts** tab) with  the amount of overpayment. The POS internal report displays this amount  as a credit to the customer.

