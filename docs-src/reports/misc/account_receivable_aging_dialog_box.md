---
title: Account Receivable Aging Dialog Box
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.rpt_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
If there are only Unposted sales Journals and no receipt journals, then  none of these sales documents appear in the report when the **Posted 
 Transactions Only** option is selected.

Similarly if there are Unposted sales Journals with corresponding receipt  journals that are still Unposted, then the report will still not display  these sales journals.


{:.example}
Create a sales receipt for $200 but do not  post the corresponding sales journal in **Everest**.  Make a $100 receipt and do not post the receipt journal. If you select  the option **Posted Transactions Only**,  then neither the sales journal nor the receipt journal appears in **Everest**.


If you select the option **Show Payment 
 Details**, the details of the Unposted receipt transaction are not  displayed.

Where a sales journal is yet to be posted, but the corresponding receipt  journals have been posted, then the report will display the document amount  as zero. In this situation, the document **Paid**  column will show the paid amount from the receipt journal and the document  balance will be displayed as negative since Document Amount (0) - Document  Paid (xxx) = Document Balance (-xxx).


{:.example}
Create a sales receipt for $200 but do not  post the corresponding sales journal in **Everest**.  Make a $100 receipt and post the receipt journal. If you select the option  **Posted Transactions** Only, the  posted receipt journal is displayed but the document amount is zero, the  document paid shows the paid amount ($100) and the document balance is  negative (-$100).


If you select the option **Show Payment 
 Details**, the details of the posted receipt transaction are displayed.

If there are posted sales journals without any corresponding posted  receipt journals, then the sales journal appears in the report with the  document amount displayed, however the **Paid**  column is zero and the document **Balance**  column displays the document amount (which means the document is still  outstanding).


{:.example}
Create a sales receipt for $200 and post it  in **Everest**. Make a $100 receipt  but do not post the receipt journal. If you select the option **Posted 
 Transactions Only**, the posted sales journal is displayed with the  document amount as $200.00; the document **Paid**  shows the paid amount as $0.00 (since it is not posted) and the document  balance is $200.00 (the entire amount displayed still outstanding).


If you select the option **Show Payment 
 Details**, the details of the Receipt transaction are not displayed,  since the receipt transactions are not posted.

If there are posted sales journals and the corresponding receipt journals  have been posted, then the sales journal appears in the report with the  document amount displayed. The document **Paid**  column displays the actual value from the Posted receipt journal and the  document **Balance** column displays  the correct balance that is still outstanding (if any).


{:.example}
Create a sales receipt for $200 and post it  in **Everest**. Make a $100 receipt  and post the receipt journal. If you select the option **Posted 
 Transactions Only**, the posted receipt journal is displayed, with  the document amount as $200.00; the document **Paid**  column shows the paid amount as $100 and the document **Balance**  is $100 (since only $100.00 is still outstanding).


If you select the option **Show Payment 
 Details**, the details of the posted receipt transaction are displayed.

If the user has created only manual receipt journals without a corresponding  sales journal and the receipt journal is yet to be posted, you will not  find these receipt journals in this report.


{:.example}
Create only a receipt for $200 but do not  post it in **Everest**. If you select  the option **Posted Transactions Only**,  the posted receipt journal is not displayed.

If the user has created only manual receipt journals without a corresponding  sales journal and the receipt journal has been posted, then these receipt  journals appear in this report and the document amount is shown as zero.  In this situation, the document **Paid**  column will show the paid amount from the receipt journal and the document  balance will be displayed as negative since Document Amount (0) - Document  Paid (xxx) = Document Balance (-xxx).


{:.example}
Create only a receipt for $200 and post it  in **Everest**.  If  you select the option **Posted Transactions 
 Only**, the posted receipt journal is displayed but the document  amount is zero, the document paid shows the paid amount ($100) and the  document balance is negative (-$100).


If you select the option **Show Payment 
 Details**, the details of the posted receipt transaction are displayed.

# Account Receivable Aging Dialog Box


**Group By**
: Group the report based on the customer name, code  or balance. The options available in this field are as follows.

- **Account 
 Name** - Select this option to view the customers by their names  as specified in the **Account Name**  field of the customers’ profiles.
- **Account 
 Code** - Select this option to view the customers by their codes  as displayed in the **Account Code**  field of the customers’ profiles.
- **Account 
 Balance** - Select this option to view the customers by their balances.



**Sort By**
: Sort the report by any of the three options:

- **Document 
 Date** - Select this option to sort the report in the ascending order  of the documents’ dates.
- **Due 
 Date** - Select this option to sort the report in the ascending order  of the due dates of the documents.
- **Discount 
 Date** - Select this option to sort the report in the ascending order  of the Discount Date. This option appears only if you select **Show 
 Document Details** checkbox.



{:.note}
If there is no **Discount Date**  available, **Everest** sorts data  for those records based on Document Date.

- **Document 
 Balance** - Select this option to sort the report in the descending  order of the documents’ balances.



{:.note}
The **Sort By** field is enabled  only when you select the **Show Document 
 Details** check box.


**Aging Details**
: Specify how you want to arrive at the age of the  outstanding amount. The options available in this field are as follows.

- **Age 
 using due date** - Select this option if you want to use the payment  due date of the document for arriving at the age of the outstanding amount.
- **Age 
 using document date** - Select this option if you want to use the  document date for arriving at the age of the outstanding amount.
- **Do 
 not show aging** - Select this option if you do not want the aging  details based on the document date to be included in the report.



**Transactions to Include**
: Specify whether you want to include all documents  or only posted documents having outstanding amounts in the report. The  options available in this field are as follows.

- **All 
 Transactions** - Select this option to include both posted and unposted  documents in the report.
- **Posted 
 Transactions Only** - Select this option to include all posted transactions  irrespective of whether the corresponding documents are posted or not  in the report. There could be several scenarios as follows:

: [Scenario 1 - Unposted Sales Journals  and no Receipt Journals](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>
: [Scenario 2 - Unposted Sales Journals  with Corresponding Unposted Receipt Journals](javascript:kadovTextPopup(this)){:id="a2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a2');
//--></script>
: [Scenario 3 - Unposted Sales Journal  with Corresponding Posted Receipt Journal](javascript:kadovTextPopup(this)){:id="a3"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a3');
//--></script>
: [Scenario 4 - Posted Sales Journals  without Corresponding Posted Receipt Journals](javascript:kadovTextPopup(this)){:id="a4"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a4');
//--></script>
: [Scenario 5 - Posted Sales Journals  with Corresponding Posted Receipt Journals](javascript:kadovTextPopup(this)){:id="a5"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a5');
//--></script>
: [Scenario 6 - Only Manual Unposted  Receipt Journals without a Corresponding Sales Journal](javascript:kadovTextPopup(this)){:id="a6"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a6');
//--></script>
: [Scenario 7 - Only Manual Posted  Receipt Journals without a Corresponding Sales Journal](javascript:kadovTextPopup(this)){:id="a7"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a7');
//--></script>


**As of Date**
: Specify the date as on which the aging details are  displayed in the report. Depending on the date selected, only posted documents  (payment entries and sales journals) are included in the report. Select  the date on which the documents were created.


Currency
: You can choose whether to view the information in  base currency or the currencies used by your customers.

- **Base 
 Currency** - This is the default; the report information displays  in your base currency.
- **Customer 
 Currency** - The report information displays in the currencies of  your customers if different from your own base currency. Each line item  indicates the currency code in use by that customer.



Options


**Show Document Details**
: Select this check box if you want to display details  of documents with balances outstanding for each customer. The report displays  details of all document types such as sales orders, sales invoices, credit  orders and credit memos including manual documents. All amounts are displayed  in the base currency.
: If this check box is not selected, the report displays  only the sum of the outstanding amounts for each customer.


**Show Payment Details**
: Select this check box if you want to display receipt  details made against each document created for the customer.


{:.note}
When both **Show Document Details** and  **Show Payment Details** options are  selected, then for each outstanding document, payment details are displayed.  The **Show Payment Details** check  box is enabled only when the **Show Document 
 Details** check box is selected. The payment details are sorted by  payment date, in ascending order. Credit card numbers are displayed as  ‘xxxx <last four digits of the card>’.


**Exclude Credit Memos**
: Select this check box if you do not want to display  credit memos created for the customers in the report.


**Exclude Advances**
: Select this check box to exclude advances received  against sales orders or credit orders to be considered for aging calculation  in the report.
: Sales orders are displayed only if any advances  have been received against them. The **Paid**  column in the report output displays the amount received. The **Balance**  column displays the received amount as a negative value. When the balance  amounts are summed up for the customer, then the advance amounts received  against sales orders are subtracted from the overall balance amount.
: The age is determined using the current date and  the date on which the payment has been received. In case of multiple receipts  against the same sales order, then all amounts falling in the same time  bucket are summed and displayed in the respective time bucket as a negative  amount.


**![]({{site.rpt_baseurl}}/img/advanced options button.gif) [Advanced  Options]({{site.rpt_baseurl}}/misc/advanced_options_account_receivable_aging_dialog.html)**
: You can view the advance options by clicking the  toggle button. Click the advanced button again to hide the **Advanced 
 Options.**


{:.see_also}
See also
: [Accounts  Receivable Aging]({{site.rpt_baseurl}}/everest-reports/invoicing/account_receivable_aging_rep.html)
: [Invoicing]({{site.rpt_baseurl}}/everest-reports/invoicing/invoicing.html)
