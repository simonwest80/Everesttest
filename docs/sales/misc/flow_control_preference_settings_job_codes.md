---
title: Flow Control Preference Settings - Job Codes
---

# Flow Control Preference Settings - Job Codes


You can set a flow control preference based on which the **Job 
 Costings**  browser is displayed when you select a customer in a new sales document.  Select the option **Prompt method for displaying 
 the Job Codes browser in sales and credit documents** field in the  **Documents** dialog box (path: **File &gt; Setup &gt; Preferences &gt; Flow 
 Control &gt; Documents &gt; Prompts &gt; Sales Document &gt; Sales Document 
 2** tab).


| Option | Description |
| Automatic | The **Job Costings**  browser is automatically displayed. |
| Prompt | You are informed that an active job code exists for  the customer and asked if you want to select a job code for the sales  document. If you click **Yes**, the  **Job** **Costings**  browser is displayed. |
| None | The **Job Costings**browser is not displayed. |



{:.note}
The **Job Costings**  browser is displayed in the following scenarios:

- The customer  is specified in the **Customer** field  of the **Job Costing** profile (path:  **File &gt; Setup &gt; Miscellaneous &gt; 
 Job Explorer &gt; Options &gt; Edit &gt; In New Window &gt; General**  tab).
- The job code  is active and has an **Open** status  as defined in the **Status** field  of the **Job Costing** profile.
- The job code  has not expired. Whether a job code has expired or not is determined by  the login date and the date specified in the **End 
 Date** field of the **Job Costing**  profile (path: **File** > **Setup** > **Miscellaneous**  > **Job Explorer** > **Options**  > **Edit** > **In 
 New Window** > **Status**  tab).


![]({{site.sp_baseurl}}/img/lens.gif) [Job  Costing Profile]({{site.sc_chm}}/options/job-costing/set-up-a-job-code/the_job_costing_profile.html)


{:.see_also}
See also
: [Job  Code]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/other/job_code_item_details_grid_sales_content.html)
: [Job  Costing]({{site.sc_chm}}/options/job-costing/job_costing.html)
: [Other  Item Information]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/other/other_item_information_item_details_grid_sales_process_content.html)
