---
title: Payment Reference Details
---

# Payment Reference Details


**Pay by**
: All the payment methods set up for customers for  the particular cash register are available for selection in this column.  The default payment method for receipts specified for the cash register  in the **Cash Register** profile (path:  **File &gt; Setup &gt; Miscellaneous &gt; 
 Cash Register** > **Options &gt; 
 Edit &gt; In New Window** > **Payment****Type** > **Receipts**  tab) is displayed by default in this field.
: The default payment method displayed in the **Pay by** column is based on different  options selected in the **Point of Sale****(sales invoice)** profile:


| Options Selected | ‘Pay by’  Column Defaults To: |
| **Save** | The payment method specified in the **Default <br/> payment method for receipts** field of the **Cash <br/> Register** profile. |
| **Payments &gt; Cash**  or clicking the **Cash** ![]({{site.pos_baseurl}}/img/pos_cash_icon_payment_method.gif) icon. | The payment method specified as the default payment  method in the **Cash Payment methods allowed**  section of the **Cash Register** profile. |
| **Payments &gt; Check**  or clicking the **Check** ![]({{site.pos_baseurl}}/img/pos_check_icon_outlook_bar.gif) icon. | The payment method specified as the default payment  method in the **Check Payment methods allowed**  section of the **Cash** **Register**  profile. |
| **Payment &gt; Credit <br/> Card** or clicking the **Credit****Card** ![]({{site.pos_baseurl}}/img/pos_credit_card_icon_payment_method.gif) icon. | The payment method specified as the default payment  method in the **Credit** **Card <br/> Payment** **methods allowed**  section of the **Cash** **Register**  profile. |
| **Payment &gt; <br/> Others** or clicking the **Others**![]({{site.pos_baseurl}}/img/pos_others_icon_payment_method.gif) icon. | The payment method specified as the default payment method in the **Other Payment methods allowed** section  of the **Cash** **Register**  profile. |

: ![]({{site.pos_baseurl}}/img/lens.gif) [The  Cash Register Profile - Payment Tab]({{site.pos_baseurl}}/pos-setup/cash-registers/setup/profile/the_cash_register_profile_payment_type_tab.html)


{:.note}
If the defaults are not specified in the **Payment 
 Type** tab of the **Cash Register**  profile, no payment type is displayed in the **Pay 
 by** column. You have to select a payment method.
: The bank account associated with the payment method  is debited with the payment received from the customer. When the payment  is made by credit card, you can process it by right-clicking in the **Payment Details** dialog box and selecting  **Verify Payment**. The **Card Verification** dialog  box is displayed.
: ![]({{site.pos_baseurl}}/img/lens.gif) [Payment  Methods]({{site.sc_chm}}/options/payment-information/payment-methods/payment_methods.html)


**<font color="#000000" class="hcp10">Type</font>**
: This column displays the type of payment method  used to receive payments from customers, as selected in the **Type**  field of the [**Payment Method** profile]({{site.sc_chm}}/options/payment-information/payment-methods/set-up-a-payment-method/payment_method_profile_general_tab.html). You cannot  modify this field.


**<font color="#000000" class="hcp10">Ref. 
 #/ Card #</font>**
: <font color="#000000" class="hcp10">Enter a reference for the payment 
 in this column. </font>

- **Check**  - When you receive a check from the customer you can enter the check number  here. This number appears in the receipt journal.
- **Credit****Card** - You can enter the credit  card number in this column. When you swipe a customer's credit card, the  card number is populated in this field. If the card swiped is different  from the default payment method set in the **Payment Type**  tab of the **Cash** **Register**  profile, the corresponding payment method is displayed in the **Pay 
 by/Type** column.



{:.note}
Thus, the payment method displayed on swiping the credit  card overrides the payment method selected by the user/set as a default  in the **Payment Type** tab of the  **Cash Register** profile.

- **Cash**  - Enter the cash voucher number for cash payment in this field.
- **Others**  - Enter a suitable reference for any other type of payment.



{:.example}
In case of wire transfers, enter the transfer reference.


**Date**
: This column displays the date of payment. By default,  the date in this column is the login date. This date is displayed on the  receipt journal.


**<font color="#000000" class="hcp10">Approval </font>**
: Enter the approval code received from the credit  card company for the credit card payment in this column. This information  must be specified in case the credit card payments are manually processed.  This field is disabled when the credit card payment is processed online.


**Amount (BC)**
: This column displays the amount of payment that  you are receiving from the customer in base currency. By default, this  column displays the amount receivable on the document. You can edit this  amount.


**Bank Rate**
: The current rate of exchange between the bank currency  and the base currency defined in the **Exchange 
 Rate** profile (path: **File &gt; 
 Setup &gt; Accounting &gt; Multicurrency &gt; Exchange Rates**) is  displayed.
: **Everest**  determines whether the Buy Rate/Sell Rate should be used depending on  the setting in the **Rate for Receipts**  field (path: **File &gt; Setup &gt; Preferences 
 &gt; Defaults &gt; Accounting &gt; Multicurrency &gt; Exchange Rates**).


**Bank Currency**
: The currency of the bank account selected in the  **Payment Method** field is displayed.


**Bank Amount**
: The balance amount payable on the document in terms  of the bank currency is displayed in this field by default.


**Pay Rate**
: The current rate of exchange defined in the [**Exchange Rate**  profile]({{site.sc_chm}}/options/multicurrency/exchange-rates/set-up-exchange-rates/exchange_rates_profile.html) (path: **File &gt; Setup &gt; 
 Accounting &gt; Multicurrency &gt; Exchange Rates**), between payment  currency and the base currency is displayed. You can change this rate  if required.
: **Everest**  determines whether the Buy Rate/Sell Rate should be used depending on  the setting in the **Rate for Receipts**  field (path: **File &gt; Setup &gt; Preferences 
 &gt; Defaults &gt; Accounting &gt; Multicurrency &gt; Exchange Rates**).


**Currency**
: This field is used to specify the currency in which  you are receiving the payment. The customer's currency is displayed by  default in this field.


{:.note}
The columns **Pay Rate** and **Currency** are displayed only when you  select the preference option **Allow split 
 payments in multiple currencies** in the **Miscellaneous**  tab of the **Cash Register** profile  - **Payment Type** tab.


**Amount**
: This is the amount of payment that you still have  to receive from the customer. The amount shown here is the amount in payment  currency if the preference option **Allow 
 split payments in multiple currencies** in the **Miscellaneous**  tab of the **Cash Register** profile  - **Payment Type** tab is checked.  If unchecked, the amount is in document currency.
: If the payment currency is changed in the **Currency** column of the Payment grid,  the **Amount** column displays the  equivalent value in the selected currency as per the exchange rate defined.
: When a customer makes an overpayment, you can specify  that amount here. The change due to the customer is shown in the **Change In** field in the document’s currency.  **Everest** displays the **Overpayment** dialog box  as you click **OK**.
: This dialog box has two options:

- **Give 
 the Customer &lt; &nbsp;&gt; 
 Change** - This option allows you to return the change due to the  customer. When you click **OK**, the  change due is displayed after the POS processing is complete.



{:.note}
If your preferences are set to print receipts (path:  **File** > **Setup** > **Preferences** > **Flow Control** > **Documents** > **Miscellaneous**  tab > **Others** tab > **Others 1** tab - **Auto-print 
 invoice in point of sale document** selected), the receipt prints  before the change due is displayed.

- **Apply 
 the overpayment as a customer deposit** - This option allows you  to apply the overpayment as a customer deposit. **Everest**  credits the Customer Deposit Account specified in your **Accounting 
 Defaults** (path: **File** >  **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Control Accounts** tab) with  the amount of overpayment. The POS internal report displays this amount  as a credit to the customer.



{:.note}
The following reports display the overpayment applied as customer deposit  and change due to the customer separately:

- POS Internal Report
- POS Receipt 1 (Sales  Invoice)
- POS Receipt 1 (Sales  Invoice-Dot matrix)
- POS Receipt 2 (Sales  Invoice)
- POS Receipt 2 (Sales  Invoice-Dot matrix)
- POS Receipt 3 (Sales  Invoice)
- POS Receipt 3 (Sales  Invoice-Dot matrix)
: When you save the Point of Sale (sales invoice)  document, the [**Payment Details** dialog box]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-receipts/payment-dlg/the_payment_details_dialog_box_pos_receipts.html) is automatically  displayed. You can account for payment through more than one type of tender  in this dialog box.
: You CANNOT receive **partial 
 payments** from Point of Sale customers (POS\_CUST). You can save  the Point of Sale document only after you receive full payment from such  customers.
: However, if any other customer is selected in the  **Customer** field, you can receive  partial payments and even make a credit sale. When you receive a partial  amount from the customer, **Everest**  prompts you that there is a balance to be received on the document. You  can take any of the two actions:

- **Let 
 me apply additional payments** - If you select this option, you will  return to the **Payment** **Details**  dialog box. This option ensures that you receive full payment from your  customer. You cannot collect partial payment from your customer.
- **Forward 
 balance of &lt; &gt; to the customer’s account with payment terms**  - If you select this option, the balance amount receivable from the customer  is transferred to the customer’s account. The default payment term for  the customer is retrieved from the **Customer**  profile (path: **Invoicing &gt; Customer 
 &gt; Options &gt; New &gt; In New Window &gt; Payment Information**  tab). You can modify the payment term. Click **OK**  to receive the payment from the customer.



{:.note}
**If the customer is put on credit hold, **Everest** prompts you of the same and  asks if you would like to proceed.**


**If the credit limit of the customer has exceeded,  another prompt informs you of that. You are asked if you would still like  to complete the transaction.**


**Narration**
: Click the **Notes**  icon ![]({{site.pos_baseurl}}/img/pos_note_icon.gif) to enter a note for the transaction. The narration  can also be viewed from the [Receipt  Journal]({{site.acc_chm}}/customer-receipts-and-refunds/creating-a-manual-receipt-journal/the_receipt_journal_profile.html) in which this transaction is recorded.


{:.see_also}
See also
: [The  Payment Details Dialog Box]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-receipts/payment-dlg/the_payment_details_dialog_box_pos_receipts.html)
