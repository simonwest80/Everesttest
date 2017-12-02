---
title: Columns in the Batch Payment Process Browser
---

# Columns in the Batch Payment Process Browser


The **Batch** **Payment 
 Process** browser displays the following information:


| **Column** | **Displays** |
| Select | Check this box to select a transaction for processing. |
| Document # | The number of the sales or sales return document against which you must  receive/refund payment. |
| Payment Description | Description specified for the selected payment method (path: **File <br/> &gt; Setup &gt; Accounting &gt; Payment Method &gt; Options &gt; Edit <br/> &gt; In New Window &gt; Description** field). |
| Processor | The description of the processor if any, attached to the payment method. |
| Credit Card # | Credit card number in an encrypted format. Credit card numbers are masked  using the format XXXXXXXXXXXX<last  four digits of the card> when the **Enable <br/> Extended Mode** check box is cleared (path: **File <br/> &gt; Setup &gt; Preferences &gt; Workstation Settings &gt; Company****Settings** tab). You can view and  edit the credit card number in this column for a transaction that has  not been authorized if you have adequate security rights. |
| Expiry | Expiry date for the credit card. You can enter another expiry date in  this column for a transaction that has not been authorized, if you have  adequate security rights. |
| CC Transaction | Type of credit card transaction:<br/><br/>- Sale<br/>- Refund<br/>- Sale or Authorize<br/>- Book<br/>- Authorize<br/>- Capture<br/>- Ship<br/>- Voice<br/>- Pre-paid<br/><br/><br/><br/>![]({{site.acc_baseurl}}/img/lens.gif) [CC  Transaction Types]({{site.acc_baseurl}}/misc/cc_transaction_types_batch_credit_card_process_browsers.html) |
| Reference Number | Reference number specified in the **Payment/Refund** dialog box. This column is applicable where the payment is made  by check. You can enter another reference number, if required before you  process the transaction.<br/><br/><br/>This column is mandatory. |
| Reference Date | Reference date specified in the **Payment/Refund** dialog box. This column is applicable where the payment is made  by check. You can select another reference date, if required before you  process the transaction.<br/><br/><br/>This column is mandatory. |
| Account | The account code of the customer |
| Customer | The customer's account name |
| Balance | The balance amount receivable/payable on the document without considering  the current payment amount. You cannot edit this field. |
| Transaction Response | The transaction responses received from the payment processors (IC Verify,  Payflow Pro etc) are displayed in this column.<br/><br/><br/>![]({{site.acc_baseurl}}/img/note.gif) This column is NOT displayed in the **Batch <br/> Payment Process - Others** browser. |
| Payment Amount | The amount for which you are processing the payment. This column defaults  to the amount you specify in the **Receipt/Refund/Collection**  dialog box. You cannot enter an amount here that will cause the **Balance** to become less that zero. |
| Payment Currency | The currency is which the transaction was carried out. |
| Approve Code | The code assigned by the merchant bank approving the payment. |



The following columns are displayed only for new authorization and new  sale or refund transactions.


| **Column** | **Displays** |
| Address | The customer's address as specified in the **Card****Verification** dialog box.<br/><br/><br/>You can specify another address if required before you process the transaction,  if you have adequate security rights. |
| Zip | The zip code as specified in the **Card <br/> Verification** dialog box.<br/><br/><br/>You can specify another zip code if required before you process the  transaction, if you have adequate security rights. |
| AVS  Prompt | The processing option as selected in the **Payment <br/> Method** profile for the processor.<br/><br/><br/>![]({{site.acc_baseurl}}/img/lens.gif) [AVS  - Payment Method Profile]({{site.sc_chm}}/options/payment-information/payment-methods/payment-method-details/credit_card_information.html)<br/><br/><br/>AVS verifies  the cardholder's billing address in order to help combat fraud in card-not-present  transactions (e.g. mail order, telephone order, internet, etc.).<br/><br/><br/>You can select the desired processing option by clicking on this column  if you have adequate security rights. |
| AVS  Response | The current processing status with respect to address verification.  The AVS responses  that may be displayed in this column are:<br/><br/>- Not Processed<br/>- Address and  Zip do not match<br/>- Address and  Zip match<br/>- Address matches;  Zip does not match<br/>- Address does  not match; Zip matches<br/>- Address matches;  Zip could not be verified<br/>- Address could  not be verified; Zip matches<br/>- Address does  not match; Zip could not be verified<br/>- Address could  not be verified; Zip does not match<br/>- AVS  information could not be verified |
| CVV2 | The Credit Verification Value (CVV2) number entered in the **Card <br/> Verification** dialog box in an encrypted format. CVV2 numbers are  masked using the format XXX  or XXXX.<br/><br/><br/>![]({{site.acc_baseurl}}/img/note.gif)  For  American Express, the code is a four-digit number that appears on the  front of the credit card above the card number. For Visa and MasterCard,  the code is a three-digit number that appears at the end of the card number  on the back of the credit card.<br/><br/><br/>You can view the CVV2 number only if the workstation setting is in extended  mode.<br/><br/><br/>You can specify another CVV2 number if required, before you process  the transaction, if you have adequate security rights. |
| CVV2 Prompt | The processing option as selected in the **Payment <br/> Method** profile for the processor.<br/><br/><br/>![]({{site.acc_baseurl}}/img/lens.gif) [CVV2  - Payment Method Profile]({{site.sc_chm}}/options/payment-information/payment-methods/payment-method-details/credit_card_information.html)<br/><br/><br/>You can use card security codes while processing to reduce the risk  of fraudulent transactions.<br/><br/><br/>Select the desired processing option by clicking on this column, if  you have adequate security rights. If you select this option, **Everest** compares the security code entered on the **Card <br/> Verification** dialog box with the code as per the credit card company  records. If there is a mismatch, **Everest** prompts you to confirm that you want to proceed, based on the option  that you choose. |
| CVV2 Response | The current processing status with respect to credit verification value.  The responses that may be displayed in this column are:<br/><br/>- Not Processed<br/>- Matches<br/>- Does not match<br/>- Not Available |



{:.see_also}
See also
: [Batch  Payment Process Browser]({{site.acc_baseurl}}/customer-receipts-and-refunds/batch-payment-processing/batch_credit_card_process_browsers.html)
