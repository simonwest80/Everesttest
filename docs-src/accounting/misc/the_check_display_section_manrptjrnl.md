---
title: The Check Display Section
---

# The Check Display Section


The various sections of the check display area in the **Receipt 
 Journal** profile are displayed below:


![]({{site.acc_baseurl}}/img/receipts_journal_ck_display_section_acc.jpg)


**Company Address**
: The name and address of your company is displayed  in this section. You cannot change this address.


**Customer Name**
: The customer name displays the account name specified  in the customer's profile.
: ![]({{site.acc_baseurl}}/img/lens.gif) [The  Customer Profile]({{site.mc_chm}}/creating-a-customer/the_customer_profile_steps.html)
: It identifies the customer from whom the payment  is being received or to whom the refund is made.
: When the customer is selected, the customer's address  is automatically displayed in the **Payer 
 Information** section.


**Payer Information**
: The billing address of the customer selected in  the previous field is automatically displayed in this section. You can  modify this address if required. If payment has been received on behalf  of the customer from a third party, enter the payer's address. If a refund  is being made to the customer, enter the payee's name and address.


**Date**
: This section is used to specify the date on which  the receipt or refund takes effect. The default date displayed is the  transaction date.


**Amount**
: The amount of receipt or refund is specified here.  This is the total amount that the bank account is debited or credited  for.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Overpayment  on a Receipt Journal]({{site.acc_baseurl}}/misc/over_payments_on_receipt_journals.html)


**Amount in Words**
: The amount in words is displayed in this section.  This field cannot be edited, and reflects the changes in the **Amount** section.


**[]()Reference  Number**
: The reference number is the reference for the receipt  or refund. Based on the payment method specified in the **Payment 
 type** field, this section displays the type of check (whether computer  or manual or others) by default. Use this section to specify additional  reference information for the receipt or refund.
: ![]({{site.acc_baseurl}}/img/example.gif)  In  case you are issuing a manual check as refund to a customer, specify the  check number in this section.


| **Receipt Methods** | **Description** |
| **Cash, Checks, Credit Card and Others** | The reference number depends on the payment type. The reference number  for cash payments is normally the cash voucher number. The reference for  credit card payments may be the approval number. For other payment methods  like wire transfers, the reference number would be the appropriate authorization  for the payment.<br/><br/><br/>If the same check number is duplicated for a bank, **Everest**  displays the **Confirm** window. Click  **Yes** if you want to use the same  check to receive payments or make refunds to the customer. Click **No** to enter another check number. |
| **Receipts** | The reference for receipts is the document on the basis of which the  receipt is being accounted.<br/><br/><br/>![]({{site.acc_baseurl}}/img/example.gif) Reference for receipt checks would be the check number  issued by the customer. |
| **Refunds** | In the case of refunds, if the payment method is a check payment, the  default value displayed is **Computerized <br/> Check**. If the reference number in a document payment is left blank,  it is presumed to be a Computerized Check.<br/><br/><br/>To make a manual check payment, the check number has to be entered. |

: This field displays the following values when one  document is applied to another from the **Payment** dialog box. For such a transaction, the check is automatically  marked as printed.


| **Value** | **This value is displayed <br/> when:** |
| CO Applied | The deposit on a credit order is applied to a credit memo. |
| SO Applied | The deposit on a sales order is applied to a sales invoice or a credit  memo. |
| SI Applied | The amount receivable on a sales invoice is set off against the amount  due on a credit memo. |
| CM Applied | The amount payable on a credit memo is set off against the amount receivable  on a sales invoice or sales order. |



{:.see_also}
See also
: [Transactions]({{site.acc_baseurl}}/misc/transactions_manrptjrnl.html)
