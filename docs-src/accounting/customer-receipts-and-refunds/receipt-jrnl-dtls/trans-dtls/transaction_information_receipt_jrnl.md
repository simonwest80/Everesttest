---
title: Transaction Information
---

# Transaction Information


**Transaction #**
: Transaction # is the unique number used to identify  the transaction. The transaction number is generated automatically by  **Everest**.
: You can have one or more transactions per journal.  You can navigate between transactions in the same journal by clicking  on the drop-down arrow and selecting the required transaction number.  After creating a transaction, select **Options 
 &gt; New Transaction** to create the next transaction.


**Date**
: This field denotes the transaction date for the  receipt or refund. In the case of system entries made for document payments,  the date displays the login date when the payment/refund was entered.


**Source**
: This field identifies the source type of the transaction.  The source types used when a system entry is made are:


| **Source Type** | Description |
| RCT | Receipt for Sales Invoice (when payments are received against a sales  invoice, either as a payment or by applying deposits/credit memos). |
| DRC | Deposit for Sales Order (when deposits are received against a sales  order, either as a payment or by applying deposits/credit memos). |
| DRT | Deposit returned for Sales Order. |
| RRT | Payment refunded for Sales Invoice. |
| CCT | Payment for Credit Memo (when a credit memo is refunded). |

: When creating a manual receipt journal:

- The default  source type displayed is **MRE**(**Manual Receipt**)
- You can select  any other manual source type for the transaction



{:.example}
While accounting for the receipt on the sales  of recycled paper, you can select a source type that identifies miscellaneous  income.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Source  types]({{site.sc_chm}}/options/acc-info/source-types/source_types.html)


**Payment Type**
: This field identifies the payment method for the  transaction. The payment method is used to identify the entry type for  the bank account in the **Transaction Entries**  section.
: If you apply one sales document to another, a transaction  is automatically created in a receipt journal (for the amount applied).
: ![]({{site.acc_baseurl}}/img/lens.gif) [Receipt  Dialog Box - Apply Deposits/Refunds Tab]({{site.sp_chm}}/sales-docs/sales-orders/so-proc/pmts-refunds/pmts-on-so/rcpt-dlg/the_payment_dialog_box_apply_deposits_refunds_tab.html)
: The **Payment Type** field defaults to the payment method selected in the **Workstation Settings** dialog box > **Default Payment Method for Applied Payments** field (path: **File** >  **Setup** > **Preferences** > **Workstation Settings**).  If a payment method is not defined in the **Workstation 
 Settings** dialog box, the payment method selected in the **Default 
 Payment Method for Applied Payments** field (path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Miscellaneous** tab) will be  used.
: **Manual Entries**
: This field defaults to the payment method specified  in the **Default payment method for Collections** field of the **Accounting** dialog  box (path: **File** > **Setup**  > **Preferences** > **Defaults** > **Accounting** > **Miscellaneous** tab).
: **Subsequent Entries**
: For subsequent entries in the journal, you can only  select payment methods that are attached to the account selected in the  **Bank** field. The payment method  for a new transaction defaults to the one selected in the previous transaction.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Account  - Payment Method Profile]({{site.sc_chm}}/options/payment-information/payment-methods/payment-method-details/general_information_payment_method.html)


**The check display section**
: The receipt amount, date and payee's name are specified  in this section. Click [here]({{site.acc_baseurl}}/misc/the_check_display_section_manrptjrnl.html)  for details relating to this section.


{:.see_also}
See also
: [Transactions]({{site.acc_baseurl}}/misc/transactions_manrptjrnl.html)
