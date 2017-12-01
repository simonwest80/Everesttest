---
title: Related Items
---

# Related Items


The **Related Items** option (path:  Sales Return Document profile > **Options 
 &gt; Items &gt; Related Items**) allows you to sell an item as a  substitute or upgrade/downgrade the selected item on the document. When  you select this option the **Related****Items** browser is displayed.


{:.note}
This option is not enabled for a line item which has  the item type 'Kit'.


![]({{site.sp_baseurl}}/img/example.gif) A  customer may return an item in order to exchange the same. If the same  item is not available in stock, you can verify if there are any related  items available. If required, you can retrieve the related item as a negative  quantity in a sales return document.


![]({{site.sp_baseurl}}/img/lens.gif) [Related  Items]({{site.mi_chm}}/the-items-browser/other-options/related_items.html)


{:.steps}
To upgrade/downgrade an item contained in  a sales return document, do the following:

- From the Sales  Return Document profile, highlight the required item and select **Options** > **Item**  > **Related I**tems. You will see  the **Related** **Item**s  browser.
- From the **Related** **Item**s  browser, select the related item.
- Click **OK**. The related item replaces the existing  line item.



The price of the related item is calculated by adding/deducting the  price differential from the price displayed in the **Price**  column for the original item.


If the price differential is defined for the customer's level, this  differential is added/deducted from the price in the **Price**  column for the original item to arrive at the price of the related item.


You can also use the price of the related item instead of calculating  a price differential by selecting the **Use 
 Item's Price** check box in the **Related Item** profile.


![]({{site.sp_baseurl}}/img/lens.gif)<font style="color: #000000;" color="#000000"> </font>[Related  Items profile]({{site.mi_chm}}/misc/the_related_items_profile.html) ****


You can set a preference in the [**Documents** dialog box]({{site.bp_chm}}/misc/prompt_user_to_select_related_item_for_items_not_available_in_stock_doc_flow_control_sales2.html) by selecting  the **Prompt user to select related item 
 for items not available in stock** check box (path: **File 
 &gt; Setup &gt; Preferences &gt; Flow Control &gt; Documents &gt; Prompts 
 &gt; Sales Document &gt; Sales Document 2** tab). If you set this  preference and retrieve an item that does not have ANY stock, **Everest**  prompts you whether you want to select a related item to replace it. Select  **Yes** to display the **Related 
 Items** browser. All items that have been defined as related items  for the selected item will be available for selection. Select the related  item and click **OK** to retrieve  the item into the sales return document.


{:.see_also}
See also
: [Item  Information]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/common-opts/items/item_information_common_sales_document_options_sales_return_document_content.html)
