---
title: Display Columns - Multiple Receipts Browser
---

# Display Columns - Multiple Receipts Browser


The columns contained in the **Multiple 
 Receipts** browser that cannot be edited are detailed in this topic.


**Doc No**
: The document number is displayed in this column.  Document numbers for sales invoices are prefixed with the alphabets 'SI'  while credit memos are prefixed with 'CM'.


**Customer Code**
: The account code of the customer is displayed in  this column.


**Customer's PO #**
: The purchase order reference of the customer, if  any, specified in the document is displayed in this column.


**Customer's PO Date**
: The customer's purchase order date, if any, specified  on the document profile is displayed in this column.


**Due Date**
: The due date for payment is displayed in this column.


**Balance**
: The balance payable on the document is displayed  in this column. This balance is arrived at after considering prior payments,  if any, on the document. Deposits applied on the documents are also considered  while arriving at this balance.


****Qualified 
 for Discount****
: This displays either Yes or No indicating whether  the document has a discount available.


**Disc Available**
: Discounts may be available for prompt payment based  on the payment terms for the sales invoice. The discount available for  the current payment is calculated and displayed in this column. Discounts  are automatically calculated only on sales invoices.
: The discount is computed when payment is received  before the due date. The payment date is the check date (specified in  the **Check Date** column). If a date  is not mentioned in this column, the date of the database server on the  day of processing the receipt is considered as the payment date.


**Terms**
: The payment terms specified for the document is  displayed in this column.


**Doc Date**
: The date on which the document was created is displayed  in this column.


**Disc. Date**
: The date before which the payment must be received  (from the customer) in order to be eligible for a discount is displayed.  This date is computed only if the document's payment term allows discounts.  This date is determined based on the **Discount 
 Type** specified on the [**Payment Terms** profile]({{site.sc_chm}}/options/payment-information/payment-terms/set-up-a-payment-term/payment_terms_profile_general_tab.html) (of the document's  payment term).


**Days Due**
: The number of remaining days within which the payment  must be received in order to be eligible for discount is displayed. The  number of days from the document date to the discount date is displayed  here.


**Check Total**
: The total amount of receipt is displayed in this  column.


**Paid Amt**
: The amount already paid on the document is displayed  in this column. Deposits applied to the sales invoices are considered  while deposits available but not applied are not considered in arriving  at this amount.


**Doc Amt**
: The total amount of the document, including the  paid and unpaid amounts, is displayed in this column. Credit memos are  displayed with negative amounts.


{:.see_also}
See also
: [Multiple  Receipts Browser - Entry Columns]({{site.acc_baseurl}}/customer-receipts-and-refunds/multiple-receipts/wizard/browser/entry_columns_multiple_receipts_browser.html)
: [The  Multiple Receipts Browser]({{site.acc_baseurl}}/customer-receipts-and-refunds/multiple-receipts/wizard/browser/the_multiple_receipts_browser.html)
: [Document  Details Grid - Multiple Receipts Wizard]({{site.acc_baseurl}}/misc/document_details_grid_multiple_receipts_browser.html)
