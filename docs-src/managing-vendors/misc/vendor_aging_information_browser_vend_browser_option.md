---
title: Vendor Aging Information Browser
---

# Vendor Aging Information Browser


**Vendor**
: The code of the vendor as defined in the **Vendor** profile is displayed.


**Name**
: The name of the vendor as defined in the **Account 
 Name** field of the **Vendor** profile  is displayed.


**Location/Sub-Location**
: The location/sub-location that the vendor is assigned  to is displayed.


**Terms**
: The payment term defined for the vendor in the **Payment** **Terms** field is displayed (path: **Vendor** profile > **Accounting** tab).


**Credit Limit**
: The credit limit, if any, defined by the vendor  and entered in the **Credit Limit**  field (path: **Vendor** profile >  **Accounting** tab) is displayed.


**Available Credit**
: The available credit for the vendor is calculated  by deducting the net amount outstanding from the credit limit. Both posted  and unposted  amounts are considered for calculating available credit.


![]({{site.mv_baseurl}}/img/example.gif)  The  outstanding amount of a purchase invoice is reduced from the available  credit limit even if the document has not been posted.


Aging Period


The aging analysis is displayed for the outstanding amounts based on  the total days outstanding. The number of days for which a document is  outstanding is calculated from the document's due date.


The default time blocks for the aging analysis are 1-30 days, 31-60  days, 61-90 days, and greater than 90 days. You can change these time  blocks by clicking **Options** >  **Aging Options**.


**On Credit Hold**
: This check box displays the credit hold status of  the vendor. It is checked if the **On Credit 
 Hold** check box in the **Vendor** profile  is selected (path: **Purchasing &gt; Vendors 
 &gt; Edit &gt; In New Window &gt; Accounting** tab).


{:.note}
You cannot modify the credit hold status from  here. You can change it manually only from the **Vendor** profile.


Document Details


Purchase invoices, debit memos, purchase orders and debit orders against  which deposits are made are displayed in the documents section.


Deposits outstanding on purchase orders or amounts outstanding on debit  memos are displayed as negative amounts.


{:.see_also}
See also
: [Vendor  Aging Information Browser Options]({{site.mv_baseurl}}/misc/vendor_aging_information_browser_options.html)
: [Quick  Aging]({{site.mv_baseurl}}/vendors-browser/info/quick_aging_additional_browser_options_vendor_profile.html)
