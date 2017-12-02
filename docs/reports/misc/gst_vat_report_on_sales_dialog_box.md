---
title: Sales Tax Details Dialog Box
---

# Sales Tax Details Dialog Box


**Group By**
: Specify the order in which the documents in the  report must be grouped.


| **Option Name** | **Select this option to view:** |
| Jurisdiction/Location/Tax | The sales tax details summed first by the jurisdiction, then by each  location/sub-location and finally by each tax code. |
| Jurisdiction/Tax/Locations | The sales tax details summed by each jurisdiction, then by each tax  code and finally by each selected location/sub-location. |
| Location/Jurisdiction/Tax | The sales tax details summed by each location/sub-location, then by  each tax jurisdiction and finally by each tax code. |



{:.note}
In the case of manual journals where you have  not assigned any tax codes, the report displays manual documents using  the journal’s jurisdiction tax code and tax component. If you have assigned  a tax code to some but not all taxable and exempt entries, entries with  a tax code appear under the appropriate tax code and tax component while  entries without a tax code appear under the tax code and tax component  “No GST (exempt) Acquisitions Sales.”


**Summary/Detail**
: This option allows you to specify whether you want  to see a summarized or detailed report of the taxes. In both report types  the dates are organized as indicated in the Grouped By option. Select  **Summary** to see just the tax totals  for each date. Select **Detail** to  display the tax details for every item contained on each sales or return  document.
: Because manual documents do not include line items,  the Detail report represents the tax values of manual documents using  the **Item used for displaying manual documents 
 in tax reports** setting (path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Items**).


**Country**
: Select the country for which you want to view the  tax details. This field defaults to the country of the login location  or the parent location of the login sub-location.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**State**
: Select the state for which you want to view the  tax details. The states belonging to the selected country are available  for selection. If you do not select a state, tax details for all states  in the selected country are displayed in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Jurisdiction**
: Select the jurisdiction for which you want to view  the tax details. The jurisdictions created for the country and/or state  specified are available for selection.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)
: If you do not select a jurisdiction, tax details  for all jurisdictions belonging to the country and/or state selected are  displayed. This field defaults to the login jurisdiction.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Login  Jurisdiction]({{site.wwe_chm}}/everest-client/logging-in/jurisdiction.html)


**Location/Sub-Location**
: Select the location/sub-location for which you want  to view the tax details. This field defaults to the login location or  sub-location.


| ![]({{site.rpt_baseurl}}/img/lens.gif) | [Login Jurisdiction]({{site.wwe_chm}}/everest-client/logging-in/jurisdiction.html)<br/><br/><br/>[Drop-Down List - Right-Click  Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html) |

: The locations/sub-locations created for the country  and/or state specified are available for selection. If you do not select  a location or sub-location, tax details for all locations/sub-locations  that belong to the country and/or state selected are displayed.


**Date From**
: Select the start date of the documents to be included  in the report. This field defaults to the login date.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Login  Time and Date]({{site.wwe_chm}}/everest-client/logging-in/time_zone.html)
: The date you specify here is the document date.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Document  Date - Sales Documents]({{site.sp_chm}}/sales-docs/docs-profile/contents/doc-info/document_date_document_information_sales_content.html)


**Date To**
: Select the end date of the documents to be included  in the report. This field defaults to the login date.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Login  Time and Date]({{site.wwe_chm}}/everest-client/logging-in/time_zone.html)
: The date you specify here is the document date.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Document  Date - Sales Documents]({{site.sp_chm}}/sales-docs/docs-profile/contents/doc-info/document_date_document_information_sales_content.html)


**Show Documents**
: Select this check box to view the document numbers  associated with the taxes. In a Summary report, each document creation  date is totaled and lists the documents (with totals) created on each  of those dates. The Detail report is the same except that each document  also lists all of its items and their own totals. For manual documents  in a Detail report, the tax values will only display at the document number  level.


**Group by Tax Component**
: Select this check box to view the tax details with  the original grouping further broken down by tax components within each  tax code. In a Summary report, each tax component lists the tax details  for both system and manual documents by date. The Detail report is the  same except that each date also lists the items for that date and their  own totals.


**When you select both Show Documents and Group  by Tax Component**
: In a Summary report, each tax component lists the  tax details for both system and manual documents by date and includes  the appropriate document numbers with totals. The Detail report is the  same except that each document number also lists the items for that document  and their own totals.


| ![]({{site.rpt_baseurl}}/img/note.gif) | When a selected tax code has multiple tax  components, the Taxable column only displays the values for the first  tax component. The column displays a line of  asterisks  (\*) for all other tax components that make up the tax code. The top of  the report shows the message “Taxable amounts are displayed as ‘\*’ when  multiple tax components are assigned to a single tax code. Taxable amount  is displayed against the first tax component only.”<br/><br/><br/>For example, if a single tax code has a 5%,  an 8%, and a 9% component the report displays the following:<br/><br/><br/>|  |  | Taxable |<br/>| Tax Code #1 |  |<br/>|  | 5% Component | 500 |<br/>|  | 8% Component | \*\*\*\*\* |<br/>|  | 9% Component | \*\*\*\*\* |<br/>| Tax Code #1 Summary | 500 | |



{:.see_also}
See also
: [Sales Tax Details]({{site.rpt_baseurl}}/everest-reports/invoicing/gst_vat_on_sales.html)
