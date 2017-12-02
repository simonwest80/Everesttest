---
title: Document Information
---

# Document Information


**Document alias**
: The default document alias for sales invoices is  displayed in this field. The default document aliases for sales invoices  are defined in the **Document Alias**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Document****Alias** > **Sales 
 Invoice** field). If the customer is credited in the transaction,  select the required alias for credit memos. The document alias cannot  be modified once the journal is saved.


| **Document Alias For:** | **Description** |
| Sales Invoice | Used when your company is providing goods or services to a customer.  Selecting this option will allow you to specify a debit amount for the  Accounts Receivable Control account. |
| Credit Memo | Used when your company is providing the customer an allowance for return  of goods or services. **Everest**  will only allow you to enter a credit amount for the Accounts Receivable  Control account when this option is selected. |



{:.note}
If you select **Sales 
 Invoice** and then credit the customer, **Everest**  will change the type to **Credit Memo**  after getting your confirmation.


**Document #**
: The document number is the unique identifier for  locating this document. **Everest** automatically  generates this number from the sequence number for manual documents specified  in the **Location**  profile (path: **File** > **Setup** > **Accounting**  > **Location**/**Sub-Location**  > **Options** > **Edit**  > **In** **New 
 Window** > **Invoicing** tab  > **Manual** **Invoice****#**/**Manual 
 Memo #** field) of the login location/sub-location.
: If sequence numbers are not defined for the login  location/sub-location, the sequence number assigned to the default location  is assigned to the document. The default location is defined in the **Accounting** dialog box (path: **File 
 &gt; Setup &gt; Preferences &gt; Defaults &gt; Accounting &gt; Miscellaneous** tab **&gt; Default Location**  field).
: ![]({{site.acc_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)
: The document number is automatically prefixed with  the letter 'M'  to indicate that it is a manual document. Manual sales documents may be  viewed in the **Sales Invoices** browser  by selecting the **View &gt; Summary** option  from the browser.


{:.see_also}
See also
: [Document  Details]({{site.acc_baseurl}}/misc/document_details_mansaljrnl.html)
: [Sales  Journal Profile - General]({{site.acc_baseurl}}/sales/manual-sales/creating-a-manual-sales-journal/sales_journal_profile_general.html)
