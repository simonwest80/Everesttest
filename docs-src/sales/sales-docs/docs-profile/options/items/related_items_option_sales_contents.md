---
title: Related Items
---

# Related Items


The **Related Items** option (path:  Document profile > **Options &gt; Items 
 &gt; Related Items**) allows you to upgrade or downgrade the selected  item on the document. When you select this option for a line item that  is part of a kit, items that have the same kit code selected in the [Related Items]({{site.mi_chm}}/misc/the_related_items_profile.html)  profile are displayed in the **Related 
 Items** browser.


{:.note}
This option is not enabled for a line item which has  the item type 'Kit'.


![]({{site.sp_baseurl}}/img/lens.gif) [Related  Items]({{site.mi_chm}}/the-items-browser/other-options/related_items.html)


{:.steps}
To upgrade/downgrade an item contained in  a sales document, do the following:

- From the Sales  Document profile, highlight the required item and select **Options**  > **Item** > **Related 
 Items**. You will see the **Related 
 Items** browser.
- From the **Related Items** browser, select the related  item.
- Click **OK**. The related item replaces the existing  line item.



The price of the related item is calculated by adding/deducting the  price differential from the price displayed in the **Price**  column for the original item.


If the price differential is defined for the customer's level, this  differential is added/deducted from the price in the **Price**  column for the original item to arrive at the price of the related item.


You can also use the price of the related item, instead of calculating  a price differential, by selecting the **Use 
 Item's Price** check box in the [**Related Items** profile]({{site.mi_chm}}/misc/the_related_items_profile.html).


You can set a preference in the [**Documents** dialog box]({{site.bp_chm}}/misc/prompts_sales_document_sales_document_2_steps.html) by selecting  the **Prompt user to select related item 
 for items not available in stock** check box (path**: 
 File &gt; Setup &gt; Preferences &gt; Flow Control &gt; Documents &gt; 
 Prompts &gt; Sales Document &gt; Sales Document 2** tab). If you  set this preference and retrieve an item that does not have ANY stock,  **Everest** prompts you if you want  to select a related item to replace it. Select **Yes**  to display the **Related Items** browser.  All items defined as related items for the selected item are available  for selection. Select the related item and click **OK**  to retrieve it into the sales document.


{:.see_also}
See also
: [Item  Information]({{site.sp_baseurl}}/sales-docs/docs-profile/options/items/item_information_items_option_sales_contents.html)
