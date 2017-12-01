---
title: Account Payable Aging Dialog Box
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.rpt_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
If there are only Unposted purchase Journals and no payment journals,  then none of these purchase documents appear in the report when the **Posted Transactions Only** option is selected.

Similarly if there are Unposted purchase Journals with corresponding  payment journals that are still Unposted, then the report will still not  display these purchase journals.


{:.example}
Create a purchase invoice for $200 but do  not post the corresponding purchase journal in **Everest**.  Make a $100 payment and do not post the payment journal. If you select  the option **Posted Transactions Only**,  then neither the purchase journal nor the payment journal appears in **Everest**.


If you select the option **Show Payment 
 Details**, the details of the payment transaction are not displayed.

Where a purchase journal is yet to be posted, but the corresponding  payment journal has been posted, then the report will display the document  amount as zero. In this situation, the document **Paid**  column will show the paid amount from the payment journal and the document  balance will be displayed as negative since Document Amount (0) - Document  Paid (xxx) = Document Balance (-xxx).


{:.example}
Create a purchase invoice for $200 but do  not post the corresponding purchase journal in **Everest**.  Make a $100 payment and post the payment journal. If you select the option  **Posted Transactions Only**, the  posted payment journal is displayed but the document amount is zero, the  document paid shows the paid amount ($100) and the document balance is  negative (-$100).


If you select the option **Show Payment 
 Details**, the details of the posted payment transaction are displayed.

If there are posted purchase journals without any corresponding posted  payment journals, then the purchase journal appears in the report with  the document amount displayed, however the **Paid**  column is zero and the document **Balance**  column displays the document amount (which means the document is still  outstanding).


{:.example}
Create a purchase invoice for $200 and post  it in **Everest**. Make a $100 payment  but do not post the payment journal. If you select the option **Posted 
 Transactions Only**, the posted purchase journal is displayed with  the document amount as $200.00; the document Paid shows the paid amount  as $0.00 (since it is not posted) and the document balance is $200.00  (the entire amount displayed is still outstanding).


Even if you check the **Show Payment 
 Details** option, the payment details are not shown, as the payment  transaction is not posted.

If there are posted purchase journals and the corresponding payment  journals have been posted, then the purchase journal appears in the report  with the document amount displayed. The document **Paid**  column displays the actual value from the Posted payment journal and the  document **Balance** column displays  the correct balance that is still outstanding (if any).


{:.example}
Create a purchase invoice for $200 and post  it in **Everest**. Make a $100 payment  and post the payment journal. If you select the option **Posted 
 Transactions Only**, the posted payment journal is displayed, with  the document amount as $200.00; the document **Paid**  column shows the paid amount as $100 and the document **Balance**  is $100 (since only $100.00 is still outstanding).


However, if the document is paid in full, the transaction does not appear  in the report.

If the user has created only manual payment journals without a corresponding  purchase journal and the payment journal is yet to be posted, you will  not find these payment journals in this report.


{:.example}
Create only a payment receipt for $200 but  do not post it in **Everest**. If  you select the option **Posted Transactions 
 Only**, the posted payment journal is not displayed.

If the user has created only manual payment journals without a corresponding  purchase journal and the payment journal has been posted, then these payment  journals appear in this report and the document amount is shown as zero.  In this situation, the document **Paid**  column will show the paid amount from the payment journal and the document  balance will be displayed as negative since Document Amount (0) - Document  Paid (xxx) = Document Balance (-xxx).


{:.example}
Create only a payment receipt for $200 and  post it in **Everest**. If you select  the option **Posted Transactions Only**,  the posted payment journal is displayed but the document amount is zero,  the document paid shows the paid amount ($100) and the document balance  is negative (-$100).


If you select the option **Show Payment 
 Details**, the details of the posted payment transaction are displayed.

# Account Payable Aging Dialog Box


**Group By**
: Group the report based on the vendor name, code  or balance. The options available are:

- **Account 
 Name** - Select this option to view the vendors by their names as  specified in the **Account Name**  field of the vendors’ profiles.
- **Account 
 Code** - Select this option to view the vendors by their codes as  displayed in the **Account Code**  field of the vendors’ profiles.
- **Account 
 Balance** - Select this option to view the vendors by their balances.



**Sort By**

- **Document 
 Date** - Select this option to sort the report in the ascending order  of the documents’ dates.
- **Due 
 Date** - Select this option to sort the report in the ascending order  of the due dates of the documents.
- **Discount 
 Date** - Select this option to sort the report in the ascending order  of the Discount Date. This option appears only if you select **Show 
 Document Details** checkbox.



{:.note}
If there is no **Discount 
 Date** available, **Everest**  sorts data for those records based on Document Date.

- **Document 
 Balance** - Select this option to sort the report in the descending  order of the documents’ balances.



{:.note}
The **Sort By** field is enabled  only when you select the **Show Document 
 Details** check box.


**Aging Details**
: Specify how you want to arrive at the age of the  outstanding amount. The options available are:

- **Age 
 using due date** - Select this option if you want to use the payment  due date of the document for arriving at the age of the outstanding amount.
- **Age 
 using document date** - Select this option if you want to use the  document date for arriving at the age of the outstanding amount.
- **Do 
 not show aging** - Select this option if you do not want the aging  details based on the document date to be included in the report.



**Transactions to Include**
: Specify whether you want to include all documents  or only posted documents having outstanding amounts in the report. The  options available in this field are as follows:

- **All 
 Transactions** - Select this option to view both posted and unposted  documents in the report.
- **Posted 
 Transactions Only** - Select this option to include all posted transactions  irrespective of whether the corresponding documents are posted or not  in the report. There could be several scenarios as follows:

: **Scenario 1** - Unposted Purchase Journals and no Payment  Journals<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>
: **Scenario 2** - Unposted Purchase Journals with Corresponding  Unposted Payment Journals<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a2');
//--></script>
: **Scenario 3** - Unposted Purchase Journal with Corresponding  Posted Payment Journal<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a3');
//--></script>
: **Scenario 4** - Posted Payment Journals without Corresponding  Posted Payment Journals<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a4');
//--></script>
: **Scenario 5** - Posted Purchase Journals with Corresponding  Posted Payment Journals<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a5');
//--></script>
: **Scenario 6** - Only Manual Unposted Payment Journals without  a Corresponding Purchase Journal<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a6');
//--></script>
: **Scenario 7** - Only Manual Posted Payment Journals without  a Corresponding Purchase Journal<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a7');
//--></script>


**As of Date**
: Specify the date as on which the aging details are  displayed in the report. Depending on the date selected, only posted documents  (payment entries and purchase journals) are included in the report. Select  the date on which the documents were created.


Currency
: You can choose whether to view the information in  base currency or the currencies used by your vendors.

- **Base 
 Currency** - This is the default; the report information displays  in your base currency.
- **Vendor 
 Currency** - The report information displays in the currencies of  your vendors if different from your own base currency. Each line item  indicates the currency code in use by that vendor.



Options


**Show Document Details**
: Select this check box if you want to display details  of documents with balances outstanding for each vendor. The report displays  details of all document types such as purchase orders, purchase invoices,  debit orders and debit memos including manual documents. All amounts are  displayed in the base currency.
: If this check box is not selected, the report displays  only the sum of the outstanding amounts for each vendor.


**Show Payment Details**
: Select this check box if you want to display payment  details made against each document created for the vendor.


{:.note}
When both **Show Document Details** and  **Show Payment Details** options are  selected, then for each outstanding document, payment details are displayed.  The **Show Payment Details** check  box is enabled only when the **Show Document 
 Details** check box is selected. The payment details are sorted by  payment date, in ascending order. Credit card numbers are displayed as  ‘xxxx <last  four digits of the card>’.


**Exclude Debit Memos**
: Select this check box if you do not want to display  debit memos created for the vendors in the report.


**Exclude Advances**
: Select this check box to exclude advances paid against  purchase orders or debit orders to be considered for aging calculation  in the report.
: Purchase orders are displayed only if any advances  are paid. The **Paid** column in the  report output for purchase orders displays the amount paid. The **Balance** column displays the paid amount  as a negative value. When the balance amounts are summed up for the vendor,  then the advance amounts paid against purchase orders are subtracted from  the overall balance amount. The age is determined using the current date  and the date on which the payment has been made. In case of multiple receipts  against the same purchase order, then all amounts falling in the same  time bucket are summed and displayed in the respective time bucket as  a negative amount.


**Include Employee Vendors**
: Select this check box to include employee vendors,  who meet the criteria specified in the parameters of this dialog box,  in the report. This field is not selected by default so as not to make  available sensitive information pertaining to employees.


**![]({{site.rpt_baseurl}}/img/advanced options button.gif) [Advanced  Options]({{site.rpt_baseurl}}/misc/advanced_options_for_account_payable_aging_dialog_box.html)**
: You can view the advance options by clicking the  toggle button. Click this button again to hide the **Advanced 
 Options.**


{:.see_also}
See also
: [Accounts  Payable Aging]({{site.rpt_baseurl}}/everest-reports/purchasing/account_payable_aging_rep.html)
: [Purchasing]({{site.rpt_baseurl}}/everest-reports/purchasing/purchasing_reports.html)
