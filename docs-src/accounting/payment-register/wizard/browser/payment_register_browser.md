---
title: Payment Register Browser
---

# Payments Register Browser


The **Payment Register** browser  displays a detailed list of payments issued during the specified period,  based on the selection criteria specified in the **Payment 
 Register Wizard**.


{:.note}
- If you edit the  check number in Payment/Receipt journal, **Everest**  verifies the check number in the respective journals and also in **Voided Transaction** browser and **Payment Register** browser.
- The options Purge,  Void, Reverse, Print Check, and Change Payment Status will be disabled  for all payroll transactions in **Payment 
 Register** screen.
- When you purge  or reverse a payroll transaction it will be reflected on **Payment 
 Journal** browser and **Payment Register**  screen.


This browser is displayed when the **Finish**  button is pressed in the **Payment Register 
 Wizard**.


**Dates**
: Specify the date range of the payments or receipts  to view in this field. All payments or receipts within the selected period  will be included in the browser.
: Select **Custom**  to enter a specific date range.


**From**
: Specify the start date of payments or receipts to  be included in the browser. This field is enabled only if you select **Custom** in the **Dates**  field.


**To**
: Specify the end date of payments or receipts to  be included in the browser. This field is enabled only if you select **Custom** in the **Dates**  field.


**Include reconciled transactions**
: Select this check box to view transactions that  are reconciled with the bank account.


The **Payments Register** browser  has the following columns:

- **Reference 
 # / Check # -** The reference number or check number specified for  the payment or receipt is displayed in this column. If the payment is  through credit card the reference # appears or if the payment is through  check the check # appears. Credit card numbers in the Reference # column  are masked using the format XXXXXXXXXXXX<last four digits of the card>  when the **Enable Extended Mode**  check box is cleared (path: **File**  > **Setup** > **Preferences**  > **Workstation Settings** >  **Company Settings** tab). This column  is editable if the transaction is unposted or the payment status is **Outstanding** or **To 
 be Printed**.



{:.note}
If you want to edit the data then you have  to blank out the entire data, which is possible only for transactions  that have **Outstanding** status.


{:.example}
Suppose the Check # assigned to Transaction  #1 in **Outstanding** status is 1234.  If you want to change the Check # to 1238 you have to blank out the Check  # column for this transaction. As you blank out the Check # the payment  status changes to **To-be-printed**.  After keying in the Check # the payment status automatically changes to  **Outstanding**.

- **Date** - The date that the payment was issued or received is displayed  in this column.
- **Amount**  - The amount of the payment is displayed in this column.
- **Payment****Method** - The payment method by  which the vendor was paid or the payment was received from the customer  was paid is displayed in this column.
- **Payment****Status** - This column displays  the status of the payment. Click [here]({{site.acc_baseurl}}/payment-register/wizard/browser/payment_status_payment_register_column.html)  for further details.
- **Account 
 Type** - The account type, Customer or Vendor is displayed in this  column. The account type depends upon your selections in the wizard.
- **Code**  - The vendor or customer code is displayed in this column.
- **Name**  - The name of the customer or vendor is displayed in this column.
- **Narration**  - This column is updated with the reason provided for voiding/reversing  a check in the **Narration** section  of the **Void** dialog box (path:  **Accounting &gt;** **&nbsp;Payment 
 Register** browser > **Options 
 &gt; Void**).
- Transaction  Status - This field indicates whether  the transaction used is a Normal transaction, Voided transaction, Reversed  transaction or Reversal transaction.



{:.note}
Transactions recreated after voiding or reversing  are marked as Normal transaction.

- **Deposited**  - You can add this column to the Payments Register from the Field Chooser.  The **Deposited** column displays  a checkmark if a payment has been deposited. Change the deposit status  by selecting **Options** > **Change Deposit Status** > **Mark 
 Deposit/Clear Deposit** from the right-click menu or from the **Options** menu.



{:.warn}
Warning: If the deposit status is marked **'Deposited'**  in the Payments Register browser, the receipt will not be listed in the  **Bank Deposit Wizard** even if the  receipt is still undeposited and vice versa. Be extremely cautious while  marking a payment as deposited in the **Payments 
 Register** browser; it is a good practice to restrict security rights  for changing the deposit status in this browser only to authorized personnel.


{:.see_also}
See also
: [Payment  Register Browser Options]({{site.acc_baseurl}}/payment-register/wizard/browser/payment_register_browser_options.html)
: <font style="color: #008000;" color="#008000"><a href="{{site.wwe_chm}}/everest-client/ui/browsers/standard_browser_options.html">Standard 
 Browser Options</a></font>
: [Void  a Transaction from the Payment Register]({{site.acc_baseurl}}/payment-register/wizard/browser/voiding-transactions-payment-register/void_a_transaction_payment_register.html)
: [Information  Available - Payment Register Browser]({{site.acc_baseurl}}/payment-register/wizard/browser/information_available_payment_register_browser.html)
