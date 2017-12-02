---
title: Flow Control Preference Settings - Job Codes
---

# Flow Control Preference Settings - Job Codes


You can set a flow control preference based on which the **Job 
 Costings**  browser is displayed when a customer is selected in a new sales return  document. Select an option in the **Prompt 
 method for displaying the Job Codes browser in sales and credit documents** field in the **Documents**  dialog box (path: **File &gt; Setup &gt; 
 Preferences &gt; Flow Control &gt; Documents &gt; Prompts &gt; Sales Documents 
 &gt; Sales Documents 2** tab).


| Option | Description |
| Automatic | When this option is selected, the **Job <br/> Costings**  browser is automatically displayed. |
| Prompt | When this option is selected, you will be prompted with  a message that informs you that an active job code exists for the customer.  You will also be asked if you want to select a job code for the sales  return document. If you click **Yes**,  the **Job** **Costings**  browser is displayed. If you click **No**,  you will return to the sales return document. |
| None | If you select this option, the **Job <br/> Costings**browser  will not be displayed. |



{:.note}
The **Job Costings**  browser is displayed only if:


The customer has been specified in the **Customer**  field of the **Job Costing** profile  (path: **File &gt; Setup &gt; Miscellaneous 
 &gt; Job Explorer &gt; Options &gt; Edit &gt; In New Window &gt; General**  tab).


The job code is active and has an **Open**  status as defined in the **Status**  field of the **Job Costing** profile.


The job code has not expired. Whether a job code has  expired or not is determined by the login date and the date specified  in the **End Date** field of the **Job Costing** profile (path: **File**  > **Setup** > **Miscellaneous**  > **Job Explorer** > **Options**  > **Edit** > **In 
 New Window** > **Status**  tab).


{:.see_also}
See also
: [Job  Costing]({{site.sc_chm}}/options/job-costing/job_costing.html)
: [Job  Code]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/contents/item-info/other/job_code_item_detail_grid_sales_return_document_content.html)
