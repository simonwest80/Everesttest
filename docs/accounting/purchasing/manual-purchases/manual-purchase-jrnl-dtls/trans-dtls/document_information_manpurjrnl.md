---
title: Document Information
---

# Document Information


**Document alias**
: The default document alias for purchase invoices  is displayed. The default document aliases for purchase invoices is defined  in the **Document Alias** dialog box  (path: **File** > **Setup**  > **Preferences** > **Defaults**  > **Document Alias** > **Purchase Invoice** field). If the vendor  is debited in the transaction, select the required alias for debit memos.  The document alias cannot be modified once the journal is saved.


| Document Alias For | **Description** |
| **Purchase Invoice** | Used to pay vendors when your company receives goods or services. Select  this option to specify a credit amount for the Accounts Payable Control  account. |
| **Debit Memo** | Used when your company receives an allowance for return of goods or  services to a vendor. **Everest**  will only allow you to enter a debit amount for the Accounts Payable Control  account when this option is selected. |



{:.note}
If you select a document alias for purchase  invoices and then debit the vendor, **Everest** changes the alias to the default document alias for debit memos  after getting your confirmation.


**Document #**
: The document number is a unique identifier for a  document. **Everest** automatically  generates this number based on the sequence numbers specified for manual  documents in the **Location**  profile (path: **File** > **Setup** > **Accounting**  > **Location**/**Sub-Location**  > **Options** > **Edit**  > **In** **New****Window** > **Purchasing** tab > **Manual** **Invoice 
 #**/**Manual Memo #** field)  of the login location/sub-location.
: If sequence numbers are not defined for the login  location/sub-location, the sequence number of the **Default 
 Location** (path: **File &gt; Setup 
 &gt; Preferences &gt; Defaults &gt; Accounting &gt; Miscellaneous tab**)  is used.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)
: The document number is automatically prefixed with  the letter 'M'  to indicate that it is a manual document. Manual purchase and purchase  return documents may be viewed in the **Purchase 
 Invoices** browser by selecting the **Options 
 &gt; Include manual** option from the browser.


{:.see_also}
See also
: [Document  Details]({{site.acc_baseurl}}/misc/document_details_manpurjrnl.html)
: [Purchase  Journal Profile - General]({{site.acc_baseurl}}/purchasing/manual-purchases/creating-a-manual-purchase-journal/purchase_journal_profile_general.html)
