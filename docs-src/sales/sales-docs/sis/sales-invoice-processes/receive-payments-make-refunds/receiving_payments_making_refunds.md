---
title: Receiving Payments/Making Refunds
---

# Receiving Payments/Making Refunds


Payments may be received against a sales invoice either by applying  deposits or advance documents available or by receiving a new payment.


![]({{site.sp_baseurl}}/img/lens.gif) [Receipts  on Sales Invoices]({{site.sp_baseurl}}/sales-docs/sis/sales-invoice-processes/receive-payments-make-refunds/receiving_payments_on_sales_invoices.html)


**Method for Applying Deposits on a Sales Order  to a Sales Invoice**


To select the method for applying the deposit received on a sales order  while converting it into a sales invoice, you have to select your option  in the flow control preferences (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Documents**  > **Prompts**> **Sales 
 Document** > **Sales Document****2** tab).


![]({{site.sp_baseurl}}/img/lens.gif) [Flow  Control preference for Applying Deposits]({{site.bp_chm}}/misc/method_of_applying_deposit_collected_on_a_sales_order_at_the_time_of_converting_it_to_a_sales_invoice.html)


[Applying  Deposits Received on Sales Orders]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/pmts-on-so/automatically_applying_deposits_received_on_sales_invoices.html)


**Refunds**


You can also refund amounts paid on a sales invoice to the customer  from the **Sales Invoice** profile.


![]({{site.sp_baseurl}}/img/lens.gif) [Refunds to Customers]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/refunds-on-so/refunds_to_customers.html)


If the document is a foreign currency document, and you do not specify  a default account in the **G/L 
 account for gain/loss on settlement of foreign currency documents**  fields (path**: File &gt; Setup &gt; Preferences 
 &gt; Defaults &gt; Accounting &gt; Multicurrency 
 &gt; Accounting** tab), a message is displayed stating that payments  on foreign currency documents result in gain or loss on translation. Since  **Everest** requires a default account  to record gain or loss on foreign currency transactions, a preference  has to be set for the default G/L  accounts, to account for gain and loss on settlement of foreign currency  documents.


![]({{site.sp_baseurl}}/img/lens.gif) [Foreign  Currency Documents]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/tab-details/details/frgn-cur/foreign_currency_documents_sales_document_content.html)


[Foreign  Currency Translations]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/tab-details/details/frgn-cur/foreign_currency_translations_sales_documents_content.html)


Set a default account in EITHER the **G/L 
 account for gain on settlement for foreign currency documents** field  OR the **G/L 
 account for loss on settlement for foreign currency documents** field  to be used for both gains and losses on foreign currency transactions.
