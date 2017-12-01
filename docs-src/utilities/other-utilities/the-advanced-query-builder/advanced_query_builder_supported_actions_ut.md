---
title: Advanced Query Builder Supported Actions
---

# Advanced Query Builder Supported Actions


The following tables show the supported actions in the Advanced  Query Builder.


**Supported Browser / Filter Actions in the Advanced  Query Builder**


| Action | Type | Action Parameter 1 |
| Open Assembly Browser | Browser | N/A |
| Open Brand Browser | Browser | N/A |
| Open Category Browser | Browser | N/A |
| Open Credit Memo Browser | Browser | N/A |
| Open Credit Order Browser | Browser | N/A |
| Open Credit Quote Browser | Browser | N/A |
| Open Customer Browser | Browser | N/A |
| Open Debit Memo Browser | Browser | N/A |
| Open Debit Order Browser | Browser | N/A |
| Open Debit Quote Browser | Browser | N/A |
| Open Documents Browser | Browser | Document Type |
| Open Item Browser | Browser | N/A |
| Open Point Of Sale Browser | Browser | N/A |
| Open Purchase Invoice Browser | Browser | N/A |
| Open Purchase Order Browser | Browser | N/A |
| Open Purchase Quote Browser | Browser | N/A |
| Open Purchase Receipt Browser | Browser | N/A |
| Open Sales Invoice Browser | Browser | N/A |
| Open Sales Opportunity Browser | Browser | N/A |
| Open Sales Order Browser | Browser | N/A |
| Open Sales Quote Browser | Browser | N/A |
| Open Serial No Browser | Browser | N/A |
| Open Vendor Browser | Browser | N/A |
| Open Filter<Any AQB Browser> | Filter | N/A |



N/A  = Not Applicable


**Supported Profile Actions in the Advanced Query  Builder**


| Action | Type | Action Parameter 1 | Action Parameter 2 |
| Open Brand Profile | Profile | Brand Code |  |
| Open Category Profile | Profile | Category Code |  |
| Open Customer Profile | Profile | Customer Code |  |
| Open Documents Profile | Profile | Document Type | Document # |
| Open Item Profile | Profile | Item Code |  |
| Open Sales Opportunity Profile | Profile | Opportunity ID |  |
| Open Serial No Profile | Profile | Serial # |  |
| Open Vendor Profile | Profile | Vendor Code |  |



For each Action Parameter, refer to the **Data 
 Dictionary** or the **Everest Case 
 Tool**  to  get the exact name of the column to use in the Advanced Query Builder  for the field drill-down action. To access the Data Dictionary, from the  **Everest** main menu, select **Reports** > **Miscellaneous**  > **Data Dictionary**.


{:.example}
If you select the INVOICES table and want  to open a document profile, the field for storing Action Parameter 1 "Document  Type" is "Status". In this case, select "Status" from the drop-down list  for Action Parameter 1. Likewise, in the INVOICES table, the field for  storing Action Parameter 2  "Document  #"is "DOC\_NO"; select "DOC\_NO" from the drop-down list for Action Parameter  2.


{:.see_also}
See also
: [Query  Details Section - Filters Tab]({{site.utl_baseurl}}/misc/query_details_section_filters.html)
: [Example:  Associate Actions with the Query]({{site.utl_baseurl}}/other-utilities/the-advanced-query-builder/example_associate_actions_with_the_query_ut.html)
