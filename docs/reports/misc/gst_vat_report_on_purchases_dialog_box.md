---
title: Purchase Tax Details Dialog Box
---

# Purchase Tax Details Dialog Box


Select the following parameters to view the **Purchase 
 Tax Details** report.


**Group By**
: This field allows you to determine the order in  which the documents in the report must be grouped.


| **Option Name** | **Select this option to view:** |
| Jurisdiction/Location/Sub-location/Tax | The purchase tax details summed first by the jurisdiction, then by each  location/sub-location and finally by each tax code. |
| Jurisdiction/Tax/Location/Sub-location | The purchase tax details summed by each jurisdiction, then by each tax  code and finally by each selected location/sub-location. |
| Location/Sub-location/Jurisdiction/Tax | The purchase tax details summed by each location/sub-location, then  by each tax jurisdiction and finally by each tax code. |



{:.note}
In the case of manual journals where you have  not assigned any tax codes, the report displays manual documents using  the journal’s jurisdiction tax code and tax component. If you have assigned  a tax code to some but not all taxable and exempt entries, entries with  a tax code appear under the appropriate tax code and tax component while  entries without a tax code appear under the tax code and tax component  “No GST (exempt) Acquisitions.”


**Summary/Detail**
: This option allows you to specify whether you want  to see a summarized or detailed report of the taxes. In both report types  the dates are organized as indicated in the Grouped By option. Select  **Summary** to see just the tax totals  for each date. Select **Detail** to  display the tax details for every item contained on each purchase or purchase  return document.
: Because manual documents do not include line items,  the Detail report represents the tax values of manual documents using  the **Item used for displaying manual documents 
 in tax reports** setting (path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Items**).


**Country**
: Select the country for which you want to view the  tax details. This field defaults to the country of the login location  or the location of the login location/sub-location.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**State**
: Select the state for which you want to view the  tax details. The states belonging to the selected country are available  for selection. If you do not select a state, tax details for all states  in the selected country are displayed in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Jurisdiction**
: Select the jurisdiction for which you want to view  the tax details. The jurisdictions created for the country and/or state  specified are available for selection.
: If you do not select a jurisdiction, tax details  for all jurisdictions belonging to the country and/or state selected are  displayed. This field defaults to the login jurisdiction.


| ![]({{site.rpt_baseurl}}/img/lens.gif) | [Login Location/Sub-Location]({{site.wwe_chm}}/everest-client/logging-in/login_department.html)<br/><br/><br/>[Drop-Down List - Right-Click  Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html) |



**Location/Sub-Locaiton**
: Select the location/sub-location for which you want  to view the tax details. This field defaults to the login location or  sub-location.


| ![]({{site.rpt_baseurl}}/img/lens.gif) | [Login  Location/Sub-Location]({{site.wwe_chm}}/everest-client/logging-in/login_department.html)<br/><br/><br/>[Drop-Down List - Right-Click  Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html) |

: The locations/sub-locations created for the country  and/or state specified are available for selection. If you do not select  a location/sub-location, tax details for all locations/sub-locations that  belong to the country and/or state selected are displayed.


**Date From**
: Select the start date of the report period. This  field defaults to the login date.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Login  Date and Time]({{site.wwe_chm}}/everest-client/logging-in/time_zone.html)


**Date To**
: Select the end date of the report period. This field  defaults to the login date.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Login  Date and Time]({{site.wwe_chm}}/everest-client/logging-in/time_zone.html)


**Show Capital Acquisitions**
: Select this check box to display tax details for  capital acquisitions in the report. Any account in the item details grid  associated to a Fixed Asset is considered a capital acquisition.


{:.note}
You can associate accounts to Fixed Assets  by including them in the Fixed Asset Posting Group in the accounting preferences  (path: **File** > **Setup**  > **Preferences** > **Defaults**  > **Accounting** > **Posting 
 Group** tab).
: The report lists the capital acquisition accounts  first and lists all other accounts under “Other Acquisitions.”


{:.example}
**The reporting requirements in Australia require  that capital acquisitions should be disclosed separately while reporting  GST.**
: If this check box remains unselected, only tax details  for purchases not considered capital acquisitions display in the report.


**Vendor Tax Invoice Date**
: Select this check box to select and display documents  based on the date of the vendors’ tax invoices.


{:.example}
**In Australia, you can claim input tax credits  (GST credit  on Purchase) if you have a tax invoice from your supplier.**


**Consider Payment Date**
: Select this check box to select and display documents  based on the payment date. This check box is enabled only if you select  the **Vendor Tax Invoice Date** check  box


{:.example}
While accounting for GST on a non-cash basis in Australia, you can claim  input tax credits (GST credit on Purchase) when your supplier has issued  an invoice or when you have paid them, whichever is earlier.


However, if an advance is paid against  a purchase order during a reporting period and the items are not invoiced  (i.e., the purchase order is not converted to a purchase invoice), the  input tax credit on this purchase order cannot be claimed in that period.


**Show Documents**
: Select this check box to view the document numbers  associated with the taxes. In a Summary report, each document date is  totaled and lists the documents (with totals) created on each of those  dates. The Detail report is the same except that each document also lists  all of its items and their own totals.


**Group by Tax Component**
: Select this check box to view the tax details with  the original grouping further broken down by tax components within each  tax code. In a Summary report, each tax component lists the tax details  for both system and manual documents by date. The Detail report is the  same except that each date also lists the items for that date and their  own totals.


| ![]({{site.rpt_baseurl}}/img/note.gif) | When a selected tax code has multiple tax  components, the Taxable column only displays the values for the first  tax component. The column displays a line of  asterisks  (\*) for all other tax components that make up the tax code. The top of  the report shows the message “Taxable amounts are displayed as ‘\*’ when  multiple tax components are assigned to a single tax code. Taxable amount  is displayed against the first tax component only.”<br/><br/><br/>For example, if a single tax code has a 5%,  an 8%, and a 9% component the report displays the following:<br/><br/><br/>|  |  | Taxable |<br/>| Tax Code #1 |  |<br/>|  | 5% Component | 500 |<br/>|  | 8% Component | \*\*\*\*\* |<br/>|  | 9% Component | \*\*\*\*\* |<br/>| Tax Code #1 Summary | 500 | |



**When you Select both Show Documents and Group  by Tax Component**
: In a Summary report, each tax component lists the  tax details for both system and manual documents by date and includes  the appropriate document numbers with totals. The Detail report is the  same except that each document number also lists the items for that document  and their own totals.


**Claim**
: Click the **Claim** button to mark the purchase invoices contained in the report as  claimed in respect of the selected reporting period. When you click the  **Claim** button, the [**Input Claim PI Browser**]({{site.rpt_baseurl}}/misc/input_claim_pr_browser.html) is displayed.


{:.see_also}
See also
: [Purchase Tax  Details]({{site.rpt_baseurl}}/everest-reports/purchasing/gst_vat_on_purchases.html)
