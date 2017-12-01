---
title: Inventory Summary
---

# Inventory Summary


Use the **Inventory Summary** report  to display a summarized list of your inventory. You can group this report  by category, brand, or manufacturer.  If  you decide not to group the report, the inventory summary is listed by  item code. This report includes the item code and description, the items  in stock, the available quantity as on date, the quantity on DO, on SO,  and on PO, and the last and total cost of the item.


{:.steps}
To generate the Inventory Summary report, do the following:

- From the main  menu bar, select **Reports &gt; Inventory 
 &gt; Inventory Summary**. You will see the **Inventory****Summary** dialog box.
- Specify the  report parameters and click:


- **Preview**,  to preview the report in the **Report Preview** dialog box
- **Print**,  to print the report
- **Export**,  to save the report in text, Excel, HTML or Crystal Report file formats



Inventory Summary Dialog Box
: Select the following parameters to view the **Inventory** **Summary**  report.


**Group By**
: Select a grouping in the drop-down list to use to  group your items.  Items  can be grouped by Category, Brand, or Manufacturer. You can also select  **No Grouping** if you decide not  to group the report.  If  you select No Grouping, the Inventory Summary report is listed by item  code. Your selection determines the fields that you can view. No Grouping  is selected by default.


{:.note}
Inventory reports show values in the stock  measure. Sub-totals do not display if the quantities are not in the same  measure.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Categories]({{site.mi_chm}}/item-profile-details/item-categories/item_categories.html)
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Brands]({{site.mi_chm}}/item-profile-details/item-specification/brand/brand.html)
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Manufacturers]({{site.mi_chm}}/item-profile-details/item-specification/manufacturer/manufacturer.html)


**Item Code From**
: Specify the starting code for the range of items  to be included in the report.


**Item Code To**
: Specify the ending code for the range of items to  be included in the report.


{:.note}
If the **Item Code From** and the  **Item Code To** fields are left blank,  all items are included in the report.


**Category Code From**
: Specify the starting code for the range of categories  to be included in the report. If you leave this field blank and select  a category in the **Category Code To**  field, the report generates all categories from the beginning to the specified  category code.


**Category Code To**
: Specify the ending code for the range of categories  to be included in the report.


{:.note}
If both the **Category 
 Code From** and the **Category Code 
 To** fields are left blank, by default all the item categories are  included in the report.


**Include Sub-Categories**
: If you are grouping by category, you can select  the **Include Sub-Categories** check  box to show the sub-categories at every level of all the categories in  the selected range in the report. **Include 
 Sub-Categories** is selected by default. If this box is cleared,  only the items in the parent categories display in the report.


**Brand Code From**
: Specify the starting brand code for the range of  brands to be included in the report.


**Brand Code To**
: Specify the ending brand code for the range of brands  to be included in the report.


{:.note}
If the **Brand 
 Code From** and the **Brand Code To**  fields are left blank, all the brands are included in the report.


**Manufacturer From**
: Specify the starting manufacturer for the range  of manufacturers to be included in the report.


**Manufacturer To**
: Specify the ending manufacturer for the range of  manufacturers to be included in the report.


{:.note}
If the **Manufacturer 
 From** and the **Manufacturer To**  fields are left blank, all the manufacturers are included in the report.


**Include items with zero quantity**
: Select this check box to include items that are  currently out of stock in the report. This option is unchecked by default.


{:.see_also}
See also
: [Inventory]({{site.rpt_baseurl}}/everest-reports/inventory/inventory.html)
