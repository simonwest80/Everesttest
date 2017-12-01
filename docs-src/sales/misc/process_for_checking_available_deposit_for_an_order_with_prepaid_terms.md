---
title: Process for Checking Available Deposit for an Order with Prepaid Terms
---

# Process for Checking Available Deposit for an Order with Prepaid Terms


The process for checking the available deposit on a sales order with  prepay terms is elucidated below for different scenarios:


Scenario 1

- The option **Method for applying deposits collected on a 
 sales order when converting it to a sales invoice** is set to **Automatic** in the flow control preferences  (path: **File &gt; Setup &gt; Preferences 
 &gt; Flow Control &gt; Documents &gt; Prompts &gt; Sale Document 1**).
- The amount of deposit  available on the sales order is less than the invoice amount.



When you convert this sales order to an invoice, you are apprised of  the existing **Prepay** type of payment  terms. **Everest** further warns you  that since a partial payment has been made on the sales order, you can  only ship items to the extent of the available deposit.


If you choose to continue and proceed to save the sales invoice, you  are asked if you would like to override the payment terms and create the  invoice with a balance.


Scenario 2

- The option **Method for applying deposits collected on a 
 sales order when converting it to a sales invoice** is set to **Prompt** in the flow control preferences  (path: **File &gt; Setup &gt; Preferences 
 &gt; Flow Control &gt; Documents &gt; Prompts &gt; Sale Document 1**).
- The amount of deposit  available on the sales order is less than the invoice amount.



When you convert this sales order to an invoice, you are apprised of  the existing **Prepay** type of payment  terms. **Everest** further warns you  that since a partial payment has been made on the sales order, you can  only ship items to the extent of the available deposit.


If you choose to continue and proceed to save the sales invoice, you  are asked if you would like to override the payment terms and create the  invoice with a balance.


Scenario 3

- The option **Method for applying deposits collected on a 
 sales order when converting it to a sales invoice** is set to **Prompt** in the flow control preferences  (path: **File &gt; Setup &gt; Preferences 
 &gt; Flow Control &gt; Documents &gt; Prompts &gt; Sale Document 1**).
- The amount of deposit  available on the sales order is equal to or more than the invoice amount,  and you decide not to apply the available deposit to the invoice.



When you convert the sales order to an invoice and attempt to save it,  you are asked if you would like to override the payment terms and create  the invoice with a balance.


Scenario 4

- The option **Method for applying deposits collected on a 
 sales order when converting it to a sales invoice** is set to **Hold** in the flow control preferences  (path: **File &gt; Setup &gt; Preferences 
 &gt; Flow Control &gt; Documents &gt; Prompts &gt; Sale Document 1**).



When you convert the sales order to an invoice and attempt to save it,  you are asked if you would like to override the payment terms and create  the invoice with a balance.


Scenario 5


When you attempt to convert the sales order that does not have an available  deposit to an invoice, you are asked if you would like to override the  payment terms and create the invoice with a balance.


{:.see_also}
See also
: [Payment  Terms]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/tab-details/details/pmnt/payment_terms_payment_information_sales_document_contents.html)
