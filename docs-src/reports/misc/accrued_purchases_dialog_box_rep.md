---
title: Accrued Purchases Dialog Box
---

# Accrued Purchases Dialog Box


**Vendor**
: You can filter the report to see only those documents  that are created for specific vendors. The options available in this field  are as follows.

- **All**  - This default option includes all the vendors in the report.
- **Specific**  - Select this option to include only documents created for a specific  vendor in the report. Click the button beside the selection field and  select the required vendor.
- **Range**  - Select this option to specify the starting and ending vendor codes for  the range of vendors for whom documents must be included in the report.  You can use the Accounts From and Accounts To fields to specify the vendor  codes.



**Transactions to Include**
: Specify whether you want to include all documents  or only posted documents having outstanding amounts in the report. The  options available in this field are as follows:

- **Posted 
 Transactions Only** - This default option includes all posted transactions  in the report, regardless of whether the corresponding documents are posted  or not in the report.
- **All 
 Transactions** - Select this option to view both posted and unposted  documents in the report.



**As of Date**
: This field allows you to specify the date as on  which the transaction details are displayed in the report. The report  defaults to the current date.


**Account Selection Method**
: Select the report filter method to filter the report.  You can choose either Range (a range of accounts, the default) or Smart  Filter. The Smart Filter allows you to use wildcards to select accounts  based on your segments.


**Smart Filter**
: Use the **Smart Filter**  to select accounts based on your segments. Wildcards can be used in this  field and up to 250 characters can be entered. **Segment 
 separators** must be entered between segments. Enter a semi-colon  (;) to separate accounts in the **Smart 
 Filter**.


| Smart Filter Wildcard | Meaning |
| ? | One Character |
| \* | Multiple Characters |

: ![]({{site.rpt_baseurl}}/img/lens.gif)[Smart Filter]({{site.rpt_baseurl}}/misc/smart_filter.html)
: ![]({{site.rpt_baseurl}}/img/lens.gif)[Segmented\_Chart\_of\_Accounts]({{site.sc_chm}}/options/acc-info/coa/chart-of-accounts-details/segmented_chart_of_accounts.html)


**Accounts From**
: You can filter the report to see only one account  or a range of accounts. Select the first account in the range.


**Accounts To**
: You can filter the report to see only one account  or a range of accounts. Select the same account or the second account  in the range.


**Document Aliases**
: This field allows you to specify the document alias  for the purchase documents. The options available in this field are as  follows.

- **All**  - This default option includes all the document aliases for purchase documents  in the report.
- **Specific**  - Select this option to display only a specific purchase document alias  to be included in the report. Click the button beside the selection field  and select the required document alias. If you select more than one document  alias, the display in the selection field changes to "Multiple."



**Purchase Rep.**
: You can filter the report to see only those documents  assigned to specific purchase representatives. The options available in  this field are as follows.

- **All**  - This default option includes all the purchase representatives in the  report.
- **Specific**  - Select this option to include only documents created by the selected  purchase representative in the report. Click the button beside the selection  field and select the purchase representative.
- **Range**  - Select this option to specify the starting and ending purchase representative  codes for the range of purchase representatives whose documents must be  included in the report.



**Location/Sub-Location**
: This field allows you to specify the location/sub-location  names to be included in the report. The options available in this field  are as follows.

- **All**  - This default option includes all locations/sub-locations for aging calculating  in the report.
- **Specific**  - Select this option to include the aging details only for specific locations/sub-locations  in the report. Click the button beside the selection field and select  the required locations/sub-locations. If you select more than one location/sub-location,  the display in the selection field changes to "Multiple." The  documents displayed will be for the main location/sub-location selected  and not its child sub-locations.



**Exclude line items where invoiced and received  amounts match**
: This box, checked by default, excludes balanced  purchase orders; the report only considers purchase orders which have  a difference between the Accrued Purchases account for the invoiced quantity  on the purchase invoices and the Accrued Purchases account for the received  quantity on the purchase receipts associated with the purchase order/receipt.


**Report Type**
: Specify the type of report you want to generate.


| Summary | Select this option to view summarized amount information for each purchase  order. This is the report default. |
| Detail | Select this option to view the amount information by line item within  each purchase order. |



{:.see_also}
See also
: [Accrued  Purchases Report]({{site.rpt_baseurl}}/everest-reports/purchasing/accrued_purchases_report_rep.html)
