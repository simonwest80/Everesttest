---
title: The Check Display Section
---

# The Check Display Section


The check display section of the **Payment 
 Journal** profile is displayed below:


![]({{site.acc_baseurl}}/img/the_check_display_section_acc.jpg)


**Company Address**
: The name and address of your company is displayed  in this section. You cannot change this address.


**Vendor Name**
: The account name specified in the **Vendor** profile is displayed in this field.
: ![]({{site.acc_baseurl}}/img/lens.gif) [The  Vendor Profile]({{site.mv_chm}}/creating/the_vendor_profile_steps_by_steps.html)
: It identifies the vendor to whom the payment is  being made or from whom the refund is received.
: When the vendor is selected, the vendor's address  is automatically displayed in the **Payee 
 Information** section.


**Payee Information**
: The account name and billing address of the vendor  is displayed by default in this section. Entries for document payments  are made with the account name and billing address of the vendor. You  may change the information if the payee is different from the vendor and  you are making the payment on behalf of the vendor to a third party. If  you receive a refund from a third party on behalf of the vendor, then  enter the payer's information.
: ![]({{site.acc_baseurl}}/img/example.gif)  If  your vendor wants the payee address to be a branch office, which has not  been set up as the billing address, you would change this information.


**Date**
: This section is used to specify the date on which  the payment or refund takes effect. The default date displayed is the  transaction date.
: ![]({{site.acc_baseurl}}/img/example.gif)  If  you want to issue a post-dated check to a vendor, the check date has to  be entered here.


**Amount**
: The amount of payment or refund is displayed here.  The amount displayed is the total amount that the bank account is debited  or credited for.


**Amount in Words**
: The amount in words is displayed in this section.  This field cannot be edited; and reflects the changes in the **Amount** section.


**[]()Reference Number**
: The reference number is the reference for the payment  or refund. Based on the payment method specified in the **Payment 
 type** field, this section displays the type of check (whether computer  or manual or others) by default. Use this section to specify additional  reference information for the payment.
: ![]({{site.acc_baseurl}}/img/example.gif)  In  case you are issuing a manual check, specify the check number in this  section.


| **Payment Methods** | : **Description** |
| **Check payments** | The default value displayed is **Computerized <br/> Check**. If the reference number in a document payment is left blank,  it is presumed to be a Computerized Check.<br/><br/><br/>To make a manual check payment, the check  number has to be entered.<br/><br/><br/>If the same check number is duplicated for  a bank, **Everest** displays the **Confirm** window. Click **Yes**  if you want to use the same check to pay the vendor. Click **No**  to enter another check number. |
| **Cash, Credit Card and Others** | The reference number for cash payments is  normally the cash voucher number. The reference for credit card payments  may be the approval number. For other payment methods like wire transfers,  the reference number would be the appropriate authorization for the payment. |
| **Refunds** | The reference for refunds is the document  on the basis of which the refund is being accounted.<br/><br/><br/>![]({{site.acc_baseurl}}/img/example.gif)  Reference  for refund checks would be the check number issued by the vendor. |

: This field displays the following values when one  document is applied to another from the **Payment**  dialog box. For such a transaction, the check is automatically marked  as printed.


| : **Value** | : **This value is displayed <br/> when:** |
| DO Applied | The deposit on a debit order is applied to  a debit memo. |
| PO Applied | The deposit on a purchase order is applied  to a purchase invoice or a debit memo. |
| PI Applied | The amount payable on a purchase invoice is  set off against the amount due on a debit memo. |
| DM Applied | The amount receivable on a debit memo is set  off against the amount payable on a purchase invoice or purchase order. |



{:.see_also}
See also
: [Transactions]({{site.acc_baseurl}}/misc/transactions_manpmtjrnl.html)
