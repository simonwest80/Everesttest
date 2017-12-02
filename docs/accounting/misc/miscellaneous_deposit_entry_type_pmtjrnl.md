---
title: Miscellaneous Deposit
---

# Miscellaneous Deposit


Select this option if you are making a miscellaneous payment (not on  any existing document) to the vendor.


![]({{site.acc_baseurl}}/img/example.gif)  Rent  deposit made to your landlord may be categorized as miscellaneous deposits.


When this entry type is selected:

- The **Vendor 
 deposit** account specified in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**)  is automatically displayed in the **Account** column. This account can only be debited.
- A manual **Purchase Order** is created to track this  deposit.



**Everest** does not allow you to  manually enter the document number in the **Document 
 #** column of the **Transaction Entries**  section.


The document number is automatically generated based on the sequence  numbers set up for the login location or the parent location of the login  sub-location and is  prefixed  with an “M”.


If sequence numbers are not defined for the login location or the parent  location of the login sub-location, the sequence number assigned to the  default location is assigned to the document. The default location is  specified in the **Accounting** dialog  box (path: **File** > **Setup** > **Preferences** > **Defaults &gt; Accounting** > **Miscellaneous** tab > **Default Location** field).


![]({{site.acc_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)


{:.see_also}
See also
: [Entry Types -  Details]({{site.acc_baseurl}}/vendor-payments-and-refunds/payment-jrnl-dtls/transaction-entries/entry_types_details.html)
