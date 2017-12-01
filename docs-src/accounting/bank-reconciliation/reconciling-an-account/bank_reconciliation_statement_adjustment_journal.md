---
title: Bank Reconciliation Statement Adjustment Journal
---

# Bank Reconciliation Statement Adjustment Journal


The adjusting entries are created in a system general journal with the  description 'Bank Reconciliation Adjustments'. The login date is the transaction  date for adjusting entries. The login date must fall within the active  period, if an active period is defined. If no active period exists, the  login date must fall within any one of the open periods.


Accounting entries for adjusting entries for bank reconciliation are  entered in an open general journal that fulfills the following conditions:

- The journal's  accounting period must coincide with the period of the login date.
- The journal  must have the same journal group as the one selected in the **Workstation 
 Settings** dialog box (path: **File**  > **Setup** > **Preferences**  > **Workstation Settings** >  **Company Settings** tab > **Journal** **Group**  field) of the user entering the adjusting entries for reconciliation.
- The journal  must have the same location/sub-location as the login location/sub-location  of the user entering the adjusting entries for reconciliation.
- The journal  must have the description 'Bank Reconciliation Adjustments'.



If no such **open** journal exists,  a new general journal is created. The general journal number for the new  journal is taken from the sequence number specified for general journals  in the login location or the parent location of the login sub-location.


![]({{site.acc_baseurl}}/img/lens.gif) [Location  Profile - Accounting Tab]({{site.sc_chm}}/options/locations-and-sub-locations/set-up-locations/location_profile_accounting.html)


If sequence numbers are not defined for the login location or the parent  location of the login sub-location, the sequence number assigned to the  default location (path: **File &gt; Setup 
 &gt; Preferences &gt; Defaults &gt; Accounting &gt; Miscellaneous** tab **&gt; Default Location** field) is assigned  to the document.


![]({{site.acc_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)
