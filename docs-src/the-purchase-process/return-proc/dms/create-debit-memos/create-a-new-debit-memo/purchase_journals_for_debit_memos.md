---
title: Purchase Journals for Debit Memos
---

# Purchase Journals for Debit Memos


Purchase returns are entered in an open system purchase journal that  fulfills the following conditions:

- The journal  should belong to the same accounting period as the login date.
- The journal  should have the same journal group as the one selected in **Workstation 
 Settings** of the user creating the debit memo.
- The journal  should have the same location/sub-location as the login location/sub-location  of the user creating the debit memo.
- The journal  should have the same account for Accounts Payable Control as the one selected  in the **Accounting** dialog box (path:  **File &gt; Setup &gt; Preferences &gt; 
 Defaults &gt; Accounting &gt; Control Accounts** tab **&gt; Accounts payable** field).



If no such open journal exists, a new purchase journal is created.


The sequence number for the purchase journal is assigned based on the  settings in the **Location** profile  (path: **File** > **Setup**  > **Accounting** > **Location**/**Sub-Location** > **Options**  > **Edit** > **In 
 New Window**) of the login location/sub-location.


If no sequence number is assigned for the logged in location/sub-location,  the sequence number assigned for the default location (path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Accounting** > **Miscellaneous** tab  > **Default Location** field) is  used.


![]({{site.pp_baseurl}}/img/lens.gif) [Default  location]({{site.sc_chm}}/misc/default_location.html)


{:.see_also}
See also
: [System  Journals]({{site.acc_chm}}/accounting-structure-in-everest/journals/system_journals.html)
