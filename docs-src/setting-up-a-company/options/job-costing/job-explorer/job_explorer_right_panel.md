---
title: Job Explorer - Right Panel
---

# Job Explorer - Right Panel


The right panel includes a header section and a grid section, and displays  the details of the job code selected in the left panel.


The header section contains the following fields:


**Job Start Date/Job End Date**
: These fields display the start and end dates of  the selected job code.


**Status**
: This field displays the status of the selected job  code.


**Estimated Revenue**
: This field displays the estimated revenue for the  selected job code, as specified in the **Job 
 Costing** profile.


**Revenue Surplus/Deficit**
: This field displays the revenue surplus or deficit  for the job code. This value is the difference between the Total Actual  Revenue and the Estimated Revenue. A positive value indicates surplus  revenue and a negative value means it is a deficit.


**Estimated Cost**
: This field displays the estimated expense for the  selected job code as specified in the **Job 
 Costing** profile.


**Cost Saving/Overrun**
: This field displays the difference between the Estimated  Cost and the Total Actual Expense. If the result is a positive value,  it is a saving. A negative value indicates an overrun.


The grid on the right panel displays the list of all documents associated  with a job code in the document. The Quantity field for a purchase invoice  refers to the invoiced quantity; for a purchase order it refers to the  ordered less the invoiced quantity. The Net Amount is calculated as follows:


**For Sales and Credit Documents**


Net Amount = (Item Price/Unit - Discount value - Cost/Unit) \* Quantity


**For Purchase and Debit Documents**


Net Amount = (Cost/Unit - Discount per unit) \* Quantity


{:.see_also}
See also
: [Job Explorer]({{site.sc_baseurl}}/options/job-costing/job-explorer/job_explorer.html)
