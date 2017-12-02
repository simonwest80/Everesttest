---
title: The Sales Document Lines Dialog Box - Item Details Tab
---

# The Sales Document Lines Dialog Box - Item Details Tab


**Line No**
: The line number of the item in the Item Details  Grid is displayed. All lines are printed in order of their line numbers.


**Hide**
: This check box is selected if the highlighted item  has been hidden.


**Service**
: This check box is selected if the line item is a  “Service” type. These are items received for service or repair.


**Item Code**
: **Item Code**  identifies the selected item in the sales document. The description of  the item as entered in the **Item** profile  is displayed beside the item code.


**![]({{site.sp_baseurl}}/img/lens.gif)<font style="color: #000000;" color="#000000"> 
 </font>[Item Code]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/details/item_code_item_details_grid_sales_content.html)**


[Description]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/details/descr-notes/description_notes_item_details_grid_sales_content.html)


**Loc/Sub-Loc**
: The document's location or sub-location is displayed.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Loc/Sub-Loc]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/acnt-dtls/department_item_details_grid_sales_content.html)


**Vendor**
: The **Vendor**  field displays the default vendor for the selected item. This field also  identifies the vendor on whom a drop ship purchase order has been created  for this item.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Item  Profile]({{site.mi_chm}}/create-regular-items-kits-and-assemblies/creating-an-item/setting_up_an_item.html)


**UM**
: The UM  (Unit of Measure) of an item is automatically updated with the sales measure  specified in the **Item** profile.


**![]({{site.sp_baseurl}}/img/lens.gif) [Measure]({{site.mi_chm}}/item-profile-details/measure/measure_profile_general_tab.html)**
: [Item  Profile]({{site.mi_chm}}/create-regular-items-kits-and-assemblies/creating-an-item/setting_up_an_item.html)


**Ordered Quantity**
: The quantity of the item ordered or to be ordered  by the customer is displayed.


**Shipped Quantity**
: This field displays the total quantity that is delivered  and invoiced. The **Shipped Quantity** field  displays a value only for sales invoices/credit memos and sales/credit  orders that are partially shipped.


**Committed Quantity**
: The **Committed Quantity**  field displays the quantity of an inventoried item that is reserved for  delivery against the sales order. The quantity displayed also represents  the items in transit as well as the items that have been physically delivered  but are not reduced from stock until customer approval is obtained.
: Committed quantities issued on sales orders are  assigned to an 'In type' of Stock Area. The committed quantity cannot  exceed the ordered quantity.


**Picked**
: On a sales order, a check mark for Picked indicates  that a pick ticket was created for the particular line item.


**Item Price**
: The price at which the item is sold to the customer  is displayed.


**![]({{site.sp_baseurl}}/img/lens.gif) [Item  Price]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/details/item_price_item_details_grid_sales_content.html)**


**Discount Value**
: The value of discount, if any, allowed on the item  is displayed.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Discount  Value and Discount Percent]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/disc-dtls/discount_value_discount_percent_item_details_grid_sales_content.html)


**Discount %**
: The discount percentage, if any, allowed on the  item is displayed.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Discount  Value and Discount Percent]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/disc-dtls/discount_value_discount_percent_item_details_grid_sales_content.html)


**Amount**
: The **Amount** field  displays the net sales amount for the items sold.
: Amount = (Quantity of items sold x the price of  the item) - discount value.


**![]({{site.sp_baseurl}}/img/lens.gif) [Amount]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/other/amount_item_details_grid_sales_content.html)**


**Tax Code**
: The tax code applicable to the line item is displayed.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Tax  Code]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/tax-details/tax_code_item_details_grid_sales_content.html)


**Tax Amount**
: The total tax applicable to the line item is displayed.  For a foreign currency document, the tax amount in the document currency  mode is expressed in terms of the foreign currency.


**User Defined Cost**
: This field displays the user defined cost of the  item. The cost can be average cost or the last cost, depending on the  preference set for **Default value for 
 the user defined cost column in a document** option in the **Other Flow Control** dialog box (path:  **File** > **Setup**  > **Preferences** > **Flow 
 Control** > **Other Flow Control**  > **Item Cost / Sales Summary**  tab).


**![]({{site.sp_baseurl}}/img/lens.gif) [Cost]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/details/cost_item_details_grid_sales_content.html)**


**Job Code**
: The job to which the revenues and expenses for the  item must be allocated is displayed.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Job  Costing]({{site.sc_chm}}/options/job-costing/job_costing.html)


**Delivery Date**
: On a sales quote or sales order, this field displays  the expected delivery date of the line item. On sales invoices, it indicates  the date on which the items were actually shipped.


**Drop Ship**
: A check mark for **Drop 
 Ship** indicates that the line item is marked for drop shipment in  the **Item** profile (path: **Inventory** > **Items**  > **Options** > **Edit**  > **In New Window** > **Purchases** tab). A check mark also appears  if you have created a drop ship purchase order for the line item.


**Critical**
: A check mark for Critical means that other items  on the sales order cannot be sold without this item. You can define an  item as critical by selecting the **Critical**  field in the Item profile (path: **Inventory**  > **Items** > **Item**  profile > **Inventory** tab). You  can also mark a line item critical by selecting the check box in the **Critical** column in the sales order.  If you mark an item as critical in the sales order, you cannot save the  order until you define another item that is dependent on it.
: ![]({{site.sp_baseurl}}/img/lens.gif)[Critical  and Dependent On]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/other/critical_and_dependent_on_columns_sales_contents.html)


**Dependent On**
: For dependent items, the **Dependent 
 On** field identifies the critical item that this line item depends  on. When shipping the items, you cannot ship dependent items until the  critical item is shipped. To define a dependent item, you need to select  the critical item in the **Dependent On**  column in the line item.
: ![]({{site.sp_baseurl}}/img/lens.gif)[Critical  and Dependent On]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/other/critical_and_dependent_on_columns_sales_contents.html)


**Weight**
: The weight of the item is computed using the quantity  and the weight per sales unit defined in the **Item**  profile (path: **Inventory** >  **Items** > **Options**  > **Edit** > **In 
 New Window** > **Freight**  > **Sales** tab).
: ![]({{site.sp_baseurl}}/img/lens.gif) [Weight]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/other/weight_item_details_grid_sales_content.html)


**Third-party Table**
: The name of the third-party catalog that has been  defined in the **Catalog Code** field  of the **Third-Party** profile (path:  **Inventory** > **Third-Party****Catalogs** > **Options**  > **New** > **In 
 New Window**) is displayed for third-party items that are sold from  your **Everest** **eStorefront** store.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Items  - Third Party Catalogs]({{site.mi_chm}}/third-party-speciality-catalogs/third_party_speciality_catalogs.html)


**Third-party Item**
: The code of the third-party item is displayed for  third-party items sold on your **Everest****eStorefront** store.


{:.see_also}
See also
: [The  Sales Document Lines Dialog Box]({{site.sp_baseurl}}/sales-docs/docs-profile/options/line-items/the_sales_document_lines_dialog_box.html)
: [Line  Items]({{site.sp_baseurl}}/sales-docs/docs-profile/options/line-items/line_items_common_sales_documents_options.html)
