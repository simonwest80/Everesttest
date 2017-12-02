---
title: Prompt method for displaying Job Codes browsers in Sales and Credit Documents
---

# Prompt method for displaying Job Codes browsers in Sales and Credit  Documents


The **Job Costings**  browser is displayed when a customer is selected in a new sales or sales  return document based on the settings made in this field.


| **Option** | **Description** |
| Automatic | Automatically displays the **Job <br/> Costings**browser  when a customer is selected on a sales/sales return document. |
| Prompt | Informs you that an active job code exists for the customer. You must  then confirm whether you want to assign a job code to the sales/sales  return document. |
| None | The **Job Costings**  browser will not be displayed. If you want to assign a job code to the  sales/sales return document, you must manually do so. |



{:.note}
The **Job Costings**browser is displayed only in the following cases:

- A job has been  defined for the selected customer (path: **File**  > **Setup** > **Miscellaneous**  > **Job Explorer &gt; Options &gt; Edit 
 &gt; In New Window &gt;** **Job****Costing** > **Options**  > **Edit** > **In****New** **Window**  > **General** tab > **Customer**  field).
- The job code  does not have a **Closed** status  as defined in the **Status** field  of the **Job Costing** profile.
- The job code  has NOT expired. Whether a job code has expired or not is determined by  the login date and the date specified in the **End 
 Date** field of the [**Job Costing** profile]({{site.sc_chm}}/options/job-costing/set-up-a-job-code/job_costing_profile_status_tab.html) (path: **File** > **Setup**  > **Miscellaneous** > **Job Explorer &gt; Options &gt; Edit &gt; In 
 New Window** > **Job Costing** >  **Options &gt; Edit &gt; In New Window 
 &gt; Status** tab).


{:.see_also}
See also
: [Prompts  - Sales Document - Sales Document 1]({{site.bp_baseurl}}/flow-ctrl/ctrl/doc-frm/prompts/sales-prompts/prompts_sales_document_sales_document_1.html)
