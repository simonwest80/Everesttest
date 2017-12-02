---
title: Payment on Purchase Invoice
---

# Payment on Purchase Invoice


Select this option if you are making partial payment or complete settlement  on an existing purchase invoice.


When this entry type is selected:

- The **Purchase 
 Invoice** number should be specified in the **Document 
 #** column of the **Transaction Entries**  section.
- The **Account**  listed is the **Accounts Payable**  account used in the document and it can only be debited. This account  defaults from the **Accounts Payable**  field (path: **File** > **Setup**  > **Accounting** > **Posting 
 Groups** > **Posting Group**  profile) of the Vendor Posting Group type for the vendor specified in  the document, but it can be changed in the document. To change the Accounts  Payable account used in the document, from the Purchase Invoice profile,  select **Options** > **Document**  > **Posting Accounts Information**.  On the **Posting Accounts** **Information** window, in the **Accounts 
 Related to Vendor** section, click Accounts Payable and select a  new account from the drop-down list.
- The **Debit** column automatically displays the outstanding amount on the selected  document.



{:.example}
**The Vendor on Purchase Invoice 30087 is Fast  Heels Shoes and there is a $25 balance due on this invoice. No posting  groups are defined at the Vendor, Vendor Class or Location/Sub-Location  levels. The **Accounts Payable** field  of the default Vendor Posting Group type is **ap-con**.  If you click on the Transactions tab in the document, you can see that  this account is used. This is the account listed in the **Transactions 
 Entries** section of the Payments Journal for the **Payment 
 on Purchase** **Invoice** entry  type for document number 30087. In this example, the following values  are listed:**


****Document 
 #**:    **300287****


****Account**:            **ap-con****


****Debit**:                **$25.00****


{:.see_also}
See also
: [Entry Types -  Details]({{site.acc_baseurl}}/vendor-payments-and-refunds/payment-jrnl-dtls/transaction-entries/entry_types_details.html)
