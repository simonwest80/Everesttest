---
title: Fixed Asset Register
---

# Fixed Asset Register


The **Fixed Asset Register** report  displays details of the original/salvage values and the accumulated depreciation  for all assets owned by your company. The report helps in planning your  fixed asset base, taxes and depreciation, and aids in decisions regarding  the replacement of assets whose useful life span is coming to an end.  The report displays the following information:

- The Fixed Asset  code and description.
- Status of the fixed  asset, whether active or inactive.
- Date when the fixed  asset was acquired, and the last generation date of the asset.
- Type of depreciation  method applied.
- Useful life span  of the asset in months.
- Original value,  salvage value, depreciation amount per month, total accumulated depreciation  till date, and the current book value.
- Original asset  account, accumulated depreciation account and the depreciation expense  accounts.



{:.steps}
To generate a Fixed Asset Register report,  do the following:

- From the main  menu bar, select **Reports &gt; Masters 
 &gt; Fixed Asset Register**. You will see the **Fixed 
 Asset Register** dialog box.
- Specify the  report parameters and click:


- **Preview**,  to preview the report in the **Report Preview** dialog box
- **Print**,  to print the report
- **Export**,  to save the report in text, Excel, HTML or Crystal Report file formats



Fixed Asset Register Dialog Box


**Account Selection Method**
: Select the report filter method to filter the report.   You can  choose either **Range** (choose an  account) or **Smart Filter**. The  **Smart Filter** allows you to use  wildcards to select accounts based on your segments.


**Account Code**
: Enter the **Chart 
 of Account** Code for which the report is to be generated.


{:.note}
If you do not select an account, fixed assets  for all account codes are included in the report.


![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Smart Filter**
: Use the **Smart Filter**  to select accounts based on your segments. Wildcards can be used in this  field and up to 250 characters can be entered. **Segment 
 separators** must be entered between segments. Enter a semi-colon  (;) to separate accounts in the **Smart 
 Filter**.


| Smart Filter Wildcard | Meaning |
| ? | One Character |
| \* | Multiple Characters |

: ![]({{site.rpt_baseurl}}/img/lens.gif)[Smart Filter]({{site.rpt_baseurl}}/misc/smart_filter.html)
: ![]({{site.rpt_baseurl}}/img/lens.gif)[Segmented\_Chart\_of\_Accounts]({{site.sc_chm}}/options/acc-info/coa/chart-of-accounts-details/segmented_chart_of_accounts.html)


**Fixed Asset Code From**
: Specify the starting code for the range of fixed  asset codes to be included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Fixed Asset Code To**
: Specify the ending code **** for the range of fixed asset codes to be included in the report.


{:.note}
If values are not specified in the **Fixed 
 Asset Code From** and **Fixed Asset 
 Code To** fields, all fixed assets are included in the report.


![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down List - Right-Click  Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


{:.see_also}
See also
: [Masters]({{site.rpt_baseurl}}/everest-reports/masters/master_reports.html)
