---
title: Quick Aging
---

# Quick Aging


The **Quick Aging** option (path:  **Sales Return Document** profile  > **Options** > **Customer****&gt; Quick Aging**) brings up the  **Customer Aging Information** browser  for sales return documents that have outstanding payments or deposits.  All outstanding documents are grouped by their document type.


![]({{site.sp_baseurl}}/img/example.gif) Outstanding  credit memos and its aliases are grouped under credit memos.


Deposits outstanding on sales orders or amounts outstanding on credit  memos are shown as negative amounts.


An aging analysis is displayed for the outstanding amounts based on  the total days outstanding. The number of days for which a document is  outstanding is calculated from the document's due date.


The available credit is checked against the effective balance and the  customer is put on automatic hold, if the effective balance is over the  credit limit.


Effective Balance = Net Balance (in customer currency) + Amount of deposit  available on system sales orders with "Prepay" and "COD"  terms (in customer currency).


Available Credit = Credit Limit - Effective Balance


![]({{site.sp_baseurl}}/img/example.gif) The  amount outstanding against a sales invoice is reduced from the available  credit limit even if the document has not been posted.


In case of foreign currency customers, all amounts are displayed in  the customer's currency even if the deposit on a sales order is received  in a different currency.


{:.see_also}
See also
: [Browser  Column Filters]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/common-opts/customers/quick-aging/browser_column_filters.html)
: [Document  Payment Information]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/common-opts/customers/quick-aging/document_payment_information.html)
: Aging  Option
: [Aging  Chart]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/common-opts/customers/quick-aging/aging_chart.html)
: [Print  Preview]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/common-opts/customers/quick-aging/print_preview.html)
