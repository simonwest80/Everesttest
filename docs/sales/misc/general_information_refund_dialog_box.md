---
title: General Information
---

# General Information


**Document Amount**
: The document amount is the total value of the document.  This is a display field.


**Already Paid**
: This is the amount of the document that is already  paid. In case of orders, it is the deposit received against the order.<font style="color: #ff0000;" color="#FF0000"> <span style="color: #000000;">It</span> </font>also  includes deposits that are applied to the sales invoice. Receipts whose  journal have or have not been posted are included. This is a display field.
: Click the **Already 
 Paid** label to view the **Payment 
 History**.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Payment  History]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/payment-history/payment_history.html)


**Discount Applied**
: This is the amount that was given as a discount  to the customer at the time of receipt of payment, against this SI.  This is a display field.


**Discount Call Back**
: When you give a discount to a customer on the sale  of an item, the discount is applied and displayed in the **Payment 
 Discount** field of the sales document. If the customer returns the  item and you refund an amount, a proportionate amount of discount should  be deducted from the discount originally allowed to the customer, i.e.,  the [Discount  applied]({{site.sp_baseurl}}/misc/payment_amount_details_payment_dialog.html#discount_applied). If the entire amount has been refunded, the **Discount****Call** **Back**  field displays the total amount of **Discount****Applied** on the sales invoice.  If an amount is partially refunded, this field displays a proportionate  amount.
: ![]({{site.sp_baseurl}}/img/example.gif) You create a Sales Invoice for $1000  and receive a payment of $950 and give a discount of $50 to the customer.  Thus, the Discount Applied will be $50.

- If  the customer returns the goods and refunds the full amount of $950, the  **Discount Call Back** amount is $50.
- If  the customer returns refunds half the amount, i.e., $475, the **Discount 
 Call Back** amount is $25.

: You can edit the amount in the **Discount****Call** **Back**  field. This amount cannot be greater than the total payment discount on  the document. In such a case, **Everest**  prompts you with a message.


{:.note}
The **Discount Applied**  and **Discount Call Back** fields  are visible only if there exists a payment discount in a final sales/sales  return document.


**Balance**
: The balance amount that can be refunded on the document  is displayed in this field. This is a display field. The balance is arrived  at by using the following formula:
: Balance = Already paid - Amount


{:.see_also}
See also
: [The  Refund Dialog Box - General]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/refunds-on-so/the_refund_dialog_box_general_sales.html)
