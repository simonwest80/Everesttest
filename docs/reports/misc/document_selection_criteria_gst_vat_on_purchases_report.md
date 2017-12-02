---
title: Document Selection Criteria - Purchase Tax Details Report
---

# Document Selection Criteria - Purchase Tax Details Report


The tax details for purchase invoices are displayed in the report based  on the following:

- If you do NOT  select the **Vendor Tax Invoice Date** check  box, documents that bear a date within the date range specified in the  **Date From** and **Date 
 To** fields are selected and displayed in the report.

: ![]({{site.rpt_baseurl}}/img/lens.gif) [Document  Date - Purchase]({{site.pp_chm}}/purc-proc/doc-profile/contents/document-information/document_date.html)

- If you select  the **Vendor Tax Invoice Date** check  box and NOT the **Consider Payment Date** check box, documents which have a tax invoice date falling within  the report period are considered.

: ![]({{site.rpt_baseurl}}/img/lens.gif) [Vendor  Tax Invoice Date]({{site.pp_chm}}/misc/other_information_step_by_step_pr.html)

- If you select  both the **Vendor Tax Invoice Date** and  **Consider Payment Date** check boxes:


- All purchase invoices  which have the vendor tax invoice date or the payment date within the  report period are considered.
- If the payment date  of the document is during an earlier reporting period, the purchase invoice  date is considered.
- If the payment date  and the vendor tax invoice date fall in a subsequent reporting period  (when compared to the purchase invoice date), the earlier of the two dates  is considered.



![]({{site.rpt_baseurl}}/img/example.gif) The  purchase invoices considered in this report are illustrated by the following  example:


| : **Purchase Invoice Date** | : **Date of Payment** | : **Vendor Tax Invoice Date** | : **Vendor Tax Invoice Not <br/> Selected** | : **ONLY Vendor Tax Invoice <br/> Selected** | : **Vendor Tax Invoice AND <br/> Payment Date Selected** |
| : Feb | : Jan | : Feb | : Feb | : Feb | : Feb |
| : Feb | : Jan | : Mar | : Feb | : Mar | : Feb |
| : Feb | : Feb | : Feb | : Feb | : Feb | : Feb |
| : Feb | : Mar | : Mar | : Feb | : Mar | : Mar |
| : Feb | : Feb | : Mar | : Feb | : Mar | : Feb |
| : Feb | : Mar | : Apr | : Feb | : Apr | : Mar |



In the case of debit memos, all memos created during the reporting period  are selected and displayed.


{:.see_also}
See also
: [Purchase Tax  Details]({{site.rpt_baseurl}}/everest-reports/purchasing/gst_vat_on_purchases.html)
