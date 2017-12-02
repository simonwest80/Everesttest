---
title: Payment Information
---

# Payment Information


**Customer's PO # and Date**
: Use this option to specify the customer's invoice  number and the date of invoice. This information acts as a reference to  the customer document enabling verification and audits. The due date for  payment is computed from the date of customer's invoice.
: If an invoice number has been duplicated for a customer,  **Everest** displays the **Confirm**  window. Click **Yes** to confirm that  you want to use the same invoice number again. Click **No**  to enter another invoice number.


**Terms**
: The default payment term specified in the **Customer** profile (path: **Invoicing**  > **Customers** > **Options**  > **Edit** > **In 
 New Window**) is displayed by default in this field. You may select  another payment term for the transaction.
: The due date is computed based on the number of  days specified in the payment term and the transaction date in the case  of manual sales journals.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Payment  Terms Applicable - Customers]({{site.mc_chm}}/customer-details/payment-information/payment_term_applicable.html)
: ![]({{site.acc_baseurl}}/img/example.gif)  If  a customer's payment terms is 'N30' that defines the due date as 30 days  from the date of the invoice and the date of the transaction is 1st April  2001. The due date computed will be 1st May 2001.


**Due Date**
: The date by which the payment is due from the customer  is displayed in this field. For manual sales journals the due date is  computed:

- From the transaction  date.
- Automatically  based on the payment terms specified (in the **Terms** field) for the journal.



**Jurisdiction**
: This field identifies the sales jurisdiction. Sales  taxes are calculated for the taxes applicable in the jurisdiction. When  you create a manual Sales Journal, the sales tax amount has to be entered  manually.


{:.see_also}
See also
: [Payment  Details]({{site.acc_baseurl}}/misc/payment_details_mansaljrnl.html)
: [Sales  Journal Profile - General]({{site.acc_baseurl}}/sales/manual-sales/creating-a-manual-sales-journal/sales_journal_profile_general.html)
