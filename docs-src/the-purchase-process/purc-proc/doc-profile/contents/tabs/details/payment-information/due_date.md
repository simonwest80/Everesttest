---
title: Due Date - Purchase Quotes, Orders, and Invoices
---

# Due Date - Purchase Documents


Use this field to specify the date on which you expect to pay the vendor.  This field defaults from the **Due Date 
 Information** specified in the **Payment 
 Terms** profile (path: **File**  > **Setup** > **Accounting**  > **Payment Terms** > **Options** > **Edit**  > **In New Window**).


To specify another due date, check the **Override**  option which enables the **Due date**  field for editing and disables the **Terms**  field.

- If the **Vendor's 
 Invoice #** and **Date** are  entered and the **Terms from purchase invoice 
 date** check box is NOT checked, the **Due 
 date** is calculated based on the vendor's invoice date.
- However, if the  option is checked, the purchase invoice date takes precedence over the  specified vendor invoice date.
- If both the **Vendor's Invoice Date** and **Terms****from purchase invoice date** are  cleared, the **Due date** for payment  calculates based on the Purchase Invoice date.



{:.note}
**You can modify this field even after saving  the purchase document and posting the journal entries.**


**If you select the **Terms 
 from purchase invoice** date check box, the due date cannot be earlier  than the document date.**


**If you do NOT select this check box, the due  date cannot be earlier than the vendor’s invoice date.**


**Override**
: This check box allows you to override the due date  computed based on the document’s payment term, and specify the last date  of payment manually in the **Due Date**  field. If this check box is not selected the **Due 
 Date** option is disabled.


{:.see_also}
See also
: [Purchase  Document's Due Date]({{site.pp_baseurl}}/misc/purchase_document_s_due_date.html)
