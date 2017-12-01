---
title: Quick Aging
---

# Quick Aging


The **Quick Aging** option (path:  **Sales Document** profile > **Options** > **Customer**  > **Quick Aging**) brings up the  **Customer Aging Information** browser  for sales documents that have outstanding payments or deposits. All outstanding  documents are grouped by their document type.


![]({{site.sp_baseurl}}/img/example.gif) Outstanding  sales invoices and their aliases are grouped under sales invoices.


Deposits outstanding on sales orders or amounts outstanding on credit  memos are displayed as negative amounts. An aging analysis is displayed  for the outstanding amounts due from the customer. The aging analysis  is based on the total number of days for which amounts from the customer  is outstanding. The number of days for which a document is outstanding  is calculated from the document's due date.


The available credit is checked against  the effective balance and the customer is put on automatic hold, if the  effective balance is over the credit limit.


Effective Balance = Net Balance (in customer  currency) + Amount of deposit available on system sales orders with "Prepay"  and "COD" terms (in customer currency).


Available Credit = Credit Limit - Effective  Balance


![]({{site.sp_baseurl}}/img/example.gif) A sales invoice's outstanding  amount is reduced from the available credit limit even if the document  has not been posted.


In case of foreign currency customers, all amounts are displayed in  the customer's currency even if the deposit on a **** sales order is received in a different currency.


**![]({{site.sp_baseurl}}/img/lens.gif) **** [<font style="font-family: Verdana, sans-serif;" face="verdana">Quick Aging</font>]({{site.mc_chm}}/customers-browser/the_customer_browser.html) ******


{:.see_also}
See also
: [Browser  Column Filters]({{site.sp_baseurl}}/sales-docs/docs-profile/options/customer/quick-aging-opts/browser_column_filters_browser_options_quick_aging_sales_content.html)
: [Customer  Aging Information Browser]({{site.mc_chm}}/misc/customer_aging_information_browser.html)
: [Customer  Aging Information Browser Options]({{site.mc_chm}}/misc/customer_aging_information_browser_options.html)
