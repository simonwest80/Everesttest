---
title: The Items Dialog Box - Item Details
---

# The Items Dialog Box - Item Details


Use this tab to specify the flow control preferences for retrieving  an item into a document.


Alternative Search Sequence when an item code is not found
: Specify the search methods that **Everest**  would use when trying to match an item code entered by the user.
: The fields to be searched can include: Model, Serial  #, Manufacturer's Serial #, Vendor Part #, and Aliases. If you select  **None** in any one field, the remaining  fields automatically change to **None**.


**Prompt user before retrieving an item by alternative  search**
: If this option is selected, **Everest**  prompts the user whether the item that was found using another alternative  search, should be used in the document. If the option is not selected,  **Everest** will automatically retrieve  the matching item into the document.


Stock Status Indicators


**Display Stock Availability Indicators based on**
: Select a preference in this dialog box to indicate  the availability of stock in the sales documents. You can base your preference  on the options available in the drop down.

- **Entire 
 company** - This option indicates the availability of stock for the  entire company. This is the default selection.
- **Logged-in 
 location** - Select this option to indicate the availability of stock  for the logged-in location.
- **Document 
 location** - Select this option to indicate the availability of stock  for the location of the document. The location of the line item overrides  the location of the document when you select this option.



**Quantity type used for stock status indicators**
: Select the quantity type to be used for determining  the color indicator and displaying the stock value for the line items  for all the sales documents. The following options are available:

- Total Quantity
- Available quantity
- Net Free Stock
- Free Stock



![Lens.gif]({{site.mi_baseurl}}/img/lens.gif)[Stock  Status]({{site.sp_chm}}/sales-docs/docs-profile/contents/item-info/details/stock_item_details_grid_sales_content.html)


**Automatically display stock status indicators**
: When you select this option, the system automatically  calculates and displays stock status indicators (color and quantity) when  an item is retrieved into a customer document (Sales Quote, Sales Order,  Sales Invoice, Credit Quote, Credit Order, and Credit Memo). This option  is unchecked (NOT selected) by default when a new company is created.
: To improve performance when adding line items to  sales documents, we recommend that you NOT select (disable) this option  and use the **Stock Status Indicator**  shortcuts available in the sales documents to view this information only  when required. To access this information from a sales document, highlight  a line item and press **F10** to view  the Stock Status Indicator (path: From a sales document, select **Options** > **Item**  > **Stock Status Indicator**).   Press **Shift + F10** to view the Stock Status  Indicator for all line items (path: From a sales document, select **Options** > **All 
 Items** > **Stock Status Indicator 
 (All)**.


**![]({{site.mi_baseurl}}/img/sales_order_ no_stock_status_mi.gif)**


**Figure: Sales Order with “Automatically Display  Stock Status Indicators” NOT Selected**
: To view the stock status for a line item, select  the line item and press **F10**. You  will see the **Stock** column indicating  stock status color and quantity for the selected line item.


**![]({{site.mi_baseurl}}/img/sales_order_ f10_stock_status_for_one_item_mi.gif)**


**Figure: Sales Order - Press F10 to View the Stock  Status for the Highlighted Line Item**
: To view the stock status for all of the line items  in the sales document, press **Shift + 
 F10**. You will see the **Stock**  column populated for all stocked line items.


**![]({{site.mi_baseurl}}/img/sales_order_ shift_f10_stock_status_for_all_items_mi.gif)**


**Figure: Sales Order - Press Shift + F10 to View  the Stock Status for All Line Items**


Markup Calculations Cost


Use this section to indicate the cost that should be used while calculating  the sales price of an item as a markup percent of the cost.


**Last Landed Cost**
: Choose this **** option  to calculate the selling price of an item based on the last landed cost  of the item.


**Average Cost**
: Choose this **** option  to calculate the selling price of an item based on the average cost of  the item.
: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Percent  Markup on Cost]({{site.mi_baseurl}}/item-profile-details/item-pricing/pricing-calculations/percent_markup_on_cost.html)


**Bar Code Type**
: Select the bar code standard to be used for printing  bar codes.


{:.example}
If you select UPC as the bar code type, the  items created in **Everest** have  to meet the 12 digit UPC standards for bar codes.
: You can force items created to have only UPC codes  by selecting the UPC option in the **Bar 
 Code** **Type** field in the  **Items** dialog box (path: **File** > **Setup**  > **Preferences** > **Flow 
 Control** > **Items**).


{:.see_also}
See also
: [The  Items Dialog Box]({{site.mi_baseurl}}/item-preferences/item-flow-control/the_flow_control_setup_dialog_box_wm.html)
