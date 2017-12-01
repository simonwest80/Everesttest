---
title: Payment Terms
---

# Payment Terms


The **Terms** field is automatically  populated when a new sales document is created. You can modify this information  from the sales document. The due dates for the payment and the term discounts  are computed based on the payment terms selected. The **Terms**  field is disabled only when the **Override**  check box is selected and the invoice is saved.


{:.note}
You cannot change the payment terms on a sales invoice  after the journal has been posted.


The default payment term displayed on the sales document profile is  determined by the following rules:


| Terms allowed to customer | Terms displayed on the document profile |
| Only COD | COD terms specified in the **COD <br/> Terms** field of the **Customer** tab  (path: **File** > **Setup**  > **Accounting** > **Location/Sub-Location**). |
| Only Prepay | Prepay terms specified in the **Prepay <br/> Terms** field of the **Customer** tab  (path: **File** > **Setup**  > **Accounting** > **Location/Sub-Location**). |
| Only On Account | On account specified in the **Customer** profile (path: **Customer**  profile > **Payment** **Information**  tab > **Terms** field). |
| COD and Prepay | Prepay terms specified in the **Customer** tab (path: **File** > **Setup** > **Accounting**  > **Location/Sub-Location**). |
| COD and On Account | On account specified in the **Customer** profile (path: **Customer**  profile > **Payment** **Information**  tab > **Terms** field). |
| Prepay and On Account | On account specified in the **Customer** profile (path: **Customer**  profile > **Payment** **Information**  tab > **Terms** field). |
| COD, Prepay and On Account | On account specified in the **Customer** profile (path: **Customer**  profile > **Payment** **Information**  tab > **Terms** field). |



{:.note}
You can select any other payment term of the [types]({{site.mc_chm}}/customer-details/payment-information/payment_information_content.html)  allowed to the customer.


Point of sale customers (POS\_CUST) are allowed only  the Prepay term. Hence, this term is displayed by default in all sales  invoices that you create for point of sale customers.


{:.see_also}
See also
: [Process  for Checking Available Deposit for an Order with Prepaid Terms]({{site.sp_baseurl}}/misc/process_for_checking_available_deposit_for_an_order_with_prepaid_terms.html)
: [Customers  - Payment Terms]({{site.mc_chm}}/customer-details/payment-information/payment_information_content.html)
: [Payment  Terms]({{site.sc_chm}}/options/payment-information/payment-terms/payment_terms.html)
