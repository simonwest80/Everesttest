---
title: Customer Layaways through POS
---

# Customer Layaways through POS


In customer layaways, the customer reserves one or more items from your  store after paying an initial amount as a guarantee. The customer then  pays in installments and after the amount is fully paid, takes delivery  of the items.


{:.steps}
To handle customer layaways, do the following:

- Create a sales  order for the items that the customer intends to buy and commit the items  to the order.



| ![]({{site.pos_baseurl}}/img/lens.gif) | [Create  a Sales Order]({{site.sp_chm}}/sales-docs/sales-orders/create-a-sales-order/create-a-new-sales-order/creating_a_new_sales_order.html)<br/><br/><br/>[Commit  Items to a Sales Order]({{site.sp_chm}}/sales-docs/sales-orders/so-proc/cmt-items/committing_items_to_the_sales_order.html) |


- As and when  you receive payments from the customer for the layaway, account for it  as customer deposits against the sales order.



![]({{site.pos_baseurl}}/img/lens.gif) [Accepting  Deposits on Sales Orders]({{site.sp_chm}}/sales-docs/recur-billing/recur-so-proc/recv-pmts/payments_on_sales_orders.html)

- When the customer  comes to pay the last installment, detach the items from the sales order  created for the layaway.
- Create a **POS Invoice** for the same customer and  add the items with the required quantities in the item details grid. Save  the **POS Invoice**.
- In the **Payment Details** dialog box, apply the  deposits received from the customer for the layaway and receive the final  installment. The sales order will be displayed in the **Advance 
 Documents Available** section of the **Apply 
 Advances** tab.



![]({{site.pos_baseurl}}/img/lens.gif) [Payment  Amount Details - Advance Applied]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-receipts/payment-dlg/payment_amount_details_payment_details_dialog_pos_receipts.html)

- Open the sales  order created for the layaway and mark it closed (**Sales 
 Order** profile **&gt; Options &gt; 
 Process &gt; Mark Close/Open**).



![]({{site.pos_baseurl}}/img/lens.gif) [Close  a Sales Order]({{site.sp_chm}}/sales-docs/sales-orders/so-proc/mark-close-open/mark_complete_so.html)


{:.see_also}
See also
: [Customer Layaways]({{site.pos_baseurl}}/pos-trans/create-pos-doc/customer-layaways/customer_layaways_pos.html)
