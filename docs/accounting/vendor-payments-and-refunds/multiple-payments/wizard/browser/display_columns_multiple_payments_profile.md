---
title: Display Columns - Multiple Payments Browser
---

# Display Columns - Multiple Payments Browser


The columns contained in the **Multiple 
 Payments** browser that cannot be edited are detailed in this topic.


**Doc No**
: The document number is displayed in this column.  Document numbers for purchase invoices are prefixed with the alphabets  'PI' while debit memos are prefixed with 'DM'.


**Vendor Code**
: The account code of the vendor is displayed in this  column.


**Vendor's Invoice #**
: The vendor's invoice number, if any, specified in  the document is displayed in this column.


**Vendor's Invoice Date**
: The vendor's invoice date, if any, specified in  the document is displayed in this column.


**Due Date**
: The due date for payment is displayed in this column.


**Balance**
: The balance payable on the document is displayed  in this column. Prior payments, if any, on the document are considered  while arriving at this balance. Deposits applied on the documents are  also considered.


**Qualified for Discount**
: This displays either Yes or No indicating whether  the document has a discount available.


**Disc Available**
: Based on the payment terms, if any discount is applicable  for the document, the total amount of discount available is displayed  in this column. The number of days considered for calculating discounts  is computed from the login date to the vendor's invoice date or purchase  receipt date if the option 'Calculate due date from purchase invoice date'  is selected.
: The discount is computed when payment is made before  the due date. The payment date is the date of the check specified in the  **Check Date** column. If a date is  not mentioned in this column, the date of the database server on the day  of processing the invoice is considered as the payment date.


**Terms**
: The payment term specified for the document is displayed  in this column.


**Doc Date**
: The date on which the document was created is displayed  in this column.


**Disc. Date**
: The date before which the payment must be made (to  the vendor) in order to be eligible for a discount is displayed. This  date is computed only if the document's payment term allows discounts.  This date is determined based on the **Discount 
 Type** specified on the [**Payment Terms** profile]({{site.sc_chm}}/options/payment-information/payment-terms/set-up-a-payment-term/payment_terms_profile_general_tab.html) (of the document's  payment term).


**Days Due**
: The number of remaining days within which the payment  must be made in order to be eligible for discount is displayed. The number  of days from the document date to the discount date is displayed here.


**Check Total**
: The total amount selected for payment is displayed  in this column. If a manual and computer check is being used to pay a  document, the total of these checks is displayed in this column.


**Paid Amt**
: The amount already paid on the document is displayed  in this column. Deposits applied to the purchase invoice are considered.  Deposits available, but not applied, are not displayed or considered while  arriving at this amount.


**Doc Amt**
: The total amount of the document, including the  paid and unpaid amounts is displayed in this column. Debit memos are displayed  with negative amounts.


{:.see_also}
See also
: [Multiple  Payments Browser - Entry Columns]({{site.acc_baseurl}}/vendor-payments-and-refunds/multiple-payments/wizard/browser/entry_columns_multiple_payments_profile.html)
: [The  multiple payments browser]({{site.acc_baseurl}}/vendor-payments-and-refunds/multiple-payments/wizard/browser/the_multiple_payments_profile.html)<font style="color: #008000;" color="#008000"> </font>
