---
title: Job Costing Dialog Box
---

# Job Costing Dialog Box


**Sort By**
: Select whether the report must be grouped by the  job code or date. If you select **Job Code**,  the report is grouped first by the job codes and then by the document  dates. If you select **Date**, the  report is grouped first by date and then by each job code.


**Job Code From**
: Specify the starting code for the range of job codes  to be included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Job Code To**
: Specify the ending code for the range of job codes  to be included in the report.


{:.note}
If the **Job 
 Code From** and **Job Code To** fields  are left blank, the details of all jobs are included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Date From**
: Specify the start date of the report period. The  date you specify here is the document date. By default, the login date  is displayed.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Document  Date - Purchase]({{site.pp_chm}}/purc-proc/doc-profile/contents/document-information/document_date.html)
: [Document  Date - Sales]({{site.sp_chm}}/sales-docs/docs-profile/contents/doc-info/document_date_document_information_sales_content.html)


**Date To**
: Specify the end date of the report period. The date  you specify here is the document date. By default, the login date is displayed.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Document  Date - Purchase]({{site.pp_chm}}/purc-proc/doc-profile/contents/document-information/document_date.html)
: [Document  Date - Sales]({{site.sp_chm}}/sales-docs/docs-profile/contents/doc-info/document_date_document_information_sales_content.html)


**Status**
: Select the status of the jobs for which you want  to print the report.


| : **Option** | : **Select this option <br/> to view:** |
| : All | : Details of all the jobs. |
| : Open | : Details of jobs that are marked "Open". |
| : Closed | : Details of jobs that are marked "Closed". |

: ![]({{site.rpt_baseurl}}/img/lens.gif) [Status  Information]({{site.sc_chm}}/options/job-costing/job-costing-details/status_information.html)


**Include Documents**
: Select the documents for which you want to print  the job costing report.


| **Option** | **Select this option <br/> to:** |
| SI,  CM, PR, DM | Include only final sales, purchase and return documents  (both customer and vendor returns) in the report. |
| SI,  CM, PR, DM, SO, CO | Include final sales, purchase and return documents.  sales and credit orders are also included in the report. |
| SI,  CM, SO, CO | Include only sales and sales return documents (other  than quotes). |
| PR, DM, PO, DO | Include only purchase and purchase return documents  (other than quotes). |
| SI,  CM | Include only the final sales and sales return documents. |
| PR, DM | Include only the final purchase and purchase return  documents. |

: ![]({{site.rpt_baseurl}}/img/lens.gif) [System  Documents]({{site.bp_chm}}/docs/documents_used_in_everest.html)


**Include Child Job Details**
: Select this option to include details of child job  codes that are under a parent job code, in the report. These details include  quantity, revenue, revenue amount, expense, expense amount and margin.


**Include General Journal Entries**
: Select this option to include General Journal entries  (posted and unposted) in the report.
: If the above option is checked, the report displays  the revenue and expenditure in the total cost and total price columns  as below:


| Account Type | Debit | Credit | Treatment |
| Revenue | Yes |  | Displayed in Total Cost column |
| Revenue |  | Yes | Displayed in Total Price column |
| Expenditure | Yes |  | Displayed in Total Cost column |
| Expenditure |  | Yes | Displayed in Total Price column |



{:.see_also}
See also
: [Job Costing Report]({{site.rpt_baseurl}}/everest-reports/financial/job_costing_rep.html)
