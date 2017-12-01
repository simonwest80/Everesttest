---
title: Accounting for Purchase/Purchase Return Documents
---

# Accounting for Purchase/Purchase Return Documents


Accounting entries are created for purchase and purchase returns in  system purchase journals when purchase invoices or debit memos are created.


![]({{site.acc_baseurl}}/img/lens.gif) [Create  a Purchase Receipt]({{site.pp_chm}}/purc-proc/prs/create-pr/create-new-pr/creating_a_purchase_receipt.html)
: [Create  a Purchase Invoice]({{site.pp_chm}}/purc-proc/pis/create-pi/create_a_purchase_invoice_pur.html)
: [Create  a Debit Memo]({{site.pp_chm}}/return-proc/dms/create-debit-memos/create-a-new-debit-memo/creating_a_new_memo.html)


Purchase entries are entered in an **open**  system purchase journal that fulfills the following conditions:

- The journal  should belong to the same accounting period as the login date.
- The journal  should have the same journal group as the one selected in the **Workstation 
 Settings** dialog box (path: **File** > **Setup** > **Preferences** > **Workstation Settings**)  of the user creating the purchase/purchase return document.
- The journal  should have the same location/sub-location as the location/sub-location  to which the purchase receipt/ invoice or debit memo belongs.
- The journal  should have the same Accounts Payable Control account as the current **Accounts Payable account** that is selected  in **Accounting** dialog box (path: **File &gt; Setup &gt; Preferences &gt; Defaults 
 &gt; Accounting &gt; Control Accounts** tab).



If such an open journal does not exist, a new purchase journal is created.  The number for the new journal is assigned based on the sequence number  defined for purchase journals in **Location**  profile of the login location or the parent location of the login sub-location.  If the login and document location/sub-location are different, the location/sub-location  of the new journal will be the same as that of the document, but the sequence  number for this journal will be generated as per the login location/sub-location.


![]({{site.acc_baseurl}}/img/lens.gif) [Location  Profile - Accounting Tab]({{site.sc_chm}}/options/locations-and-sub-locations/set-up-locations/location_profile_accounting.html)<font style="color: #008000;" color="#008000"> </font>


If sequence numbers are not defined in the **Location**  profile, the sequence number specified for the default location is assigned  to the document. The default location is defined in the **Accounting** dialog box (path: **File &gt; Setup 
 &gt; Preferences &gt; Defaults &gt; Accounting &gt; Miscellaneous** tab  **&gt; Default Location** field).


![]({{site.acc_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)


{:.see_also}
See also
: [System Purchase  Journals]({{site.acc_baseurl}}/purchasing/purchasing-through-documents/system-purchase-journals/system_purchase_journals.html)
: [Purchasing]({{site.acc_baseurl}}/purchasing/purchasing_accounting.html)
