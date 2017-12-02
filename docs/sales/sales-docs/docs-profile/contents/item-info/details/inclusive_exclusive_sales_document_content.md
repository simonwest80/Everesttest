---
title: Tax
---

# Tax


The **Tax** column indicates whether  the selling price of the item selected in a sales document is 'Inclusive  of Tax' (I)  or 'Exclusive of Tax'  (E).


Tax is included in the selling price of an item if the **Tax 
 inclusive selling price** check box is selected in the **Sales**  tab of the **Item** profile.


![]({{site.sp_baseurl}}/img/lens.gif) [Item  Profile - Sales Tab]({{site.mi_chm}}/create-regular-items-kits-and-assemblies/creating-an-item/the_item_profile_-_sales_tab.html)


When the selling price of an item includes tax, this column displays  '**I'**. This indicates that tax is  included in the selling price. The **Amount**  column displays the selling price of the item excluding the tax amount.


![]({{site.sp_baseurl}}/img/example.gif) The  item price, which is tax **inclusive**,  is $ 110 and the sales tax is 10%. When you select this item in a sales  document, the **Tax** column in the  item details grid displays $ 10 and the **Amount**  column will show $ 100.  The  document balance is $110.


The item price, which is tax **exclusive**,  is $ 110 and the sales tax is 10%. When you select this item in a sales  document the **Tax** column in item  grid displays $ 11 and the **Amount**  column will show $ 110. The balance in the document displays $(110 + 11)  = $121.


{:.note}
The Tax amount is has a decimal accuracy of  six.


Discount is computed differently for items whose price includes tax.


![]({{site.sp_baseurl}}/img/lens.gif) [Discounts  on Items whose Price Includes Tax]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/disc-dtls/discount_value_discount_percent_item_details_grid_sales_content.html)


{:.note}
Tax cannot be computed properly if an item is tax inclusive  and the tax code associated with that item has one or more tax components  with tax base limit. If the tax component has a base limit, items should  be set with tax exclusive price wherever possible. In case a tax component  with a tax limit base is associated with a tax inclusive priced item,  **Everest** clears the tax code and  amount fields for that item. You may manually select a valid tax code  for such items if desired.


{:.see_also}
See also
: [Item  Details]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/details/item_details_item_details_grid_sales_process_content.html)
