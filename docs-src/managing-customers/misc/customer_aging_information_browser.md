---
title: Customer Aging Information Browser
---

# Customer Aging Information Browser


**Customer**
: The code of the customer selected in the **Customers**  browser is displayed.


**Name**
: The name of the customer as defined in the **Account Name** field of the **Customer**  profile is displayed.


**Location/Sub-Location**
: The location/sub-location that the customer is assigned  to is displayed.


**Terms**
: The payment term defined for the customer in the  **Terms** field is displayed (path:  **Customer** profile > **Payment 
 Information** tab).


**Credit Limit**
: The credit limit, if any, defined for the customer  in the **Credit Limit** field (path:  **Customer** profile > **Payment 
 Information** tab) is displayed.


**Available Credit**
: The available credit for the customer is calculated  by deducting the effective balance from the customer’s credit limit.
: The settings you make in the **Customers**  dialog box (path: **File &gt; Setup &gt; 
 Preferences &gt; Flow Control &gt; Customers**) determine whether  the effective balance or the net balance is considered.
: Both posted and unposted  amounts are considered for calculating available credit.


**![]({{site.mc_baseurl}}/img/example.gif)  The  outstanding amount of a sales invoice is reduced from the available credit  limit even if the document is not posted.**


**![]({{site.mc_baseurl}}/img/lens.gif) [Balance Information]({{site.mc_baseurl}}/customer-details/accounting-information/balance_information.html)**


Aging Period


The aging analysis is displayed for the outstanding amounts based on  the total days outstanding. The number of days for which a document is  outstanding is calculated from the document's due date. The default time-blocks  for the aging analysis are 1-30 days, 31-60 days, 61-90 days, and greater  than 90 days.


You can change these time blocks by selecting **Options**  > **Aging Options**.


![]({{site.mc_baseurl}}/img/lens.gif) [Aging  Options]({{site.sp_chm}}/sales-docs/docs-profile/options/customer/quick-aging-opts/aging_options_quick_aging_customer_information_sales.html)


**On Credit Hold**
: The **On Credit Hold** check box displays the credit hold status of the customer. This  check box is selected by default, if the **On 
 Credit Hold** check box in the **Customer** profile is selected (path: **Invoicing 
 &gt; Customers &gt; Edit &gt; In New Window &gt; Payment information tab**).


![]({{site.mc_baseurl}}/img/note.gif)  You  cannot modify the credit hold status from here. You can change it manually  from the **Customer** profile.
: ![]({{site.mc_baseurl}}/img/lens.gif)[Payment  Information]({{site.mc_baseurl}}/customer-details/payment-information/payment_information_content.html)


Document Details


Sales invoices, credit memos, credit orders and sales orders against  which deposits have been received are displayed in the documents section.


Deposits outstanding on sales orders, or amounts outstanding on credit  memos are displayed as negative amounts.


{:.see_also}
See also
: [Customer  Aging Information Browser Options]({{site.mc_baseurl}}/misc/customer_aging_information_browser_options.html)
: [Quick Aging]({{site.mc_baseurl}}/customers-browser/information-available/quick_aging_customers.html)
