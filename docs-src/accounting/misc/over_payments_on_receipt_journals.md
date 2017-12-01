---
title: Overpayment on a Receipt Journal
---

# Overpayment on a Receipt Journal


The total value of the payment is entered in the **Amount** field of the [Check  Display Section]({{site.acc_baseurl}}/misc/the_check_display_section_manrptjrnl.html). If you enter an amount greater than the value of  the documents selected in the **Transaction 
 Entries** section of the **Receipt 
 Journal** profile, it becomes an overpayment. This overpayment can  automatically be converted to a deposit.


When you try to save such a transaction, you will be prompted to confirm  whether the overpayment has to be treated as a deposit.

- Click **Yes** to add a line entry for **Miscellaneous 
 Deposits** in the **Transaction Entries**  section. The document number for this entry is automatically generated  based on the sequence numbers defined for the login location or the parent  location of the login sub-location. The sequence numbers for the location  are specified in the **Location** profile  (path: **File** > **Setup**  > **Accounting** > **Location/Sub-Location** > **Options** > **Edit** > **In 
 New Window** > **Invoicing**  tab > **Manual Order #** field).

: If sequence numbers are not defined for  the login location or the parent location of the login sub-location, the  sequence number assigned to the default location is assigned to the document.  The default location is specified in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Miscellaneous** tab > **Default Location** field).
: ![]({{site.acc_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)

- Click **No** if you do not want to treat the overpayment  as a deposit.



**Everest**  then informs you that the entry is not balanced. Click **Yes** if you want to try to balance the journal entry. Click **No** to save the journal without balancing it.


{:.see_also}
See also
: [Receipts from  Customers]({{site.acc_baseurl}}/customer-receipts-and-refunds/receipts_from_customers.html)
