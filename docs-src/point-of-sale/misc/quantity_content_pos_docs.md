---
title: Quantity
---

# Quantity


The **Quantity** column displays  the quantity of the item being sold. Quantity is expressed in terms of  the sales measure. You can scan or enter the required quantity in this  column.


![]({{site.pos_baseurl}}/img/lens.gif) [Measures]({{site.mi_chm}}/item-profile-details/measure/measure.html)


In case of auto serialized and non-serialized items the default value  displayed in the **Quantity** column  is one, if there is adequate stock in the default stock area.


The default stock area for auto-serialized and non-serialized items  is determined by the following rules:

- If a stock  area from which items must be auto-serialized on a **Point 
 of Sale (sales invoice)** profile is specified in the **Point 
 of Sale** field of the **Work Station 
 Settings** dialog box (path: **File**  > **Setup** > **Preferences**  > **WorkStation 
 Settings** > **Stock** **Areas** > **Auto****Serialize** **Items**  /**Inventory** **Adjustments**  tab), quantities are transferred from this stock area.
- If a default  stock area is not defined in the **Work****Station** **Settings**,  the items are transferred from the stock area defined in the **Purchase****Receipt/Invoice** field of the **Location** profile (path: **File**  > **Setup** > **Accounting**  > **Location**/ **Sub-Location**  > **Options** > **Edit**  > **In** **New****Window** ><font style="color: #800000;" color="#800000"> 
 </font>**Stock** **Transfer**  > **Purchase** **Document**  tab) for the login location or the parent location of the login sub-location.
- If a stock  bin is not defined in the **Workstation 
 Settings** and the **Location**  profile, the items are transferred to the stock area defined in the Purchase  Receipt/Invoice.



![]({{site.pos_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)


{:.note}
If stock is not available for the selected item in the  default stock area, by default the quantity displayed in the **Quantity** column is zero.


If serialized items are retrieved into the document, the default value  in the **Quantity** column is set  to zero. You have to enter these quantities manually.


The quantity entered in this column depends on the **Quantity 
 Entry Method** specified for the item in the **Item**  profile (path: **Inventory** >  **Items** > **Item****profile** > **Purchases**  tab).


{:.example}
The sales measure  of an item is kilograms. This measure comprises 1000 grams.


Therefore two and  a half kilograms at a cost of $2 a gram would be expressed as:


Fractional Method


The quantity is  expressed in the fractional format as 2:500 units.


The value of the  quantity is calculated as follows:


$2 \* 2000 + $2 \*  500


Decimal Method


The quantity 2 kilograms,  500 grams and 15 milligrams is expressed in the decimal


format as 2500.15.


The value of the  quantity is calculated as follows:


$2  \*(2500)\* +$2 \*0.015


{:.see_also}
See also
: [Quantity  Entry Methods]({{site.mi_chm}}/item-profile-details/other-items-information/purchase/quantity_entry_method.html)
: [Item  Details]({{site.pos_baseurl}}/misc/item_details_iten_info_pos_docs_content.html)
: [Item Kit]({{site.mi_chm}}/item-profile-details/item-types/kits/kits.html)
: [Item  Matrix]({{site.mi_chm}}/creating-matrix-group-and-matrix-items/item_matrix.html)
: [Stock  Adjustments in POS Invoice]({{site.pos_baseurl}}/misc/stock_adjustments_in_point_of_sale_documents.html)
: [Add  an Item Kit/Matrix to a POS Document]({{site.pos_baseurl}}/misc/add_an_item_kit_item_matrix_to_a_point_of_sale_document.html)
