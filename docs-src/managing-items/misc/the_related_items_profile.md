---
title: The Related Items Profile
---

# The Related Items Profile


Use the **Related Items** profile  to define an upgrade/ downgrade for an item.


**Related Item Code**
: Specify the code of the related item for the selected  item. This field is mandatory.


**Web-Enabled**
: Select this check box to enable the item to be displayed  as an upgrade/ downgrade on your online store.


**Description**
: The description of the item selected in the **Related Item Code** field will be displayed  here. You can edit this field if required. The **Related 
 Items** browser is updated with any change made to the description  of a related item.


{:.note}
If the description of the related item is changed in the **Related 
 Items** tab of an **Item** profile,  it will be used only when that item is retrieved into a document and is  replaced with the related item. It does not update the description in  the **Related** **Items**  tab for all those items where this item is specified as a related item.  You will have to manually edit such item descriptions if required.


{:.example}
Item code X with a description "80GB Hard Drive" is a related  item for items Y  and Z. Changing  the description of item code X  in  the Related items tab of ITEM Y  to "80GB Hard Drive (7500RPM)" will not automatically change  the description in the Related Items tab of items Z.   Also, the  item profile for Item code X will still display "80GB Hard Drive".


If required, you can manually change the description in the Related  Items tab by opening the Item profile of item Z and accessing  the **Related Items** tab.


**Sales Measure**
: Specify the sales measure of the item from the list  of allowed sales measures for the related item. Any sales measures of  the related item that exist in the original item display in the list.  Price differentials will apply when selecting the related item in the  sales document.
: This **Sales Measure**  field applies only to desktop transactions. Your online store displays  the default sales measure or the stock measure based on your web sales  preference (Path: **Item** profile  > **E-Commerce** tab > **Web Sales** tab > Select or clear the  **Allow Sales in Stock Measure** field).


**Price Differential**
: The price differential is the difference between  the selling price of the original item and its upgrade. When defining  a price differential, you can:

- Enter a flat  amount or
- Use a formula  to calculate the price differential.



{:.example}
Selling Price of Item A +/- Price Differential = Selling Price of Item  B (the related item).
: In order to specify a flat amount, enter the amount  in the **Price Differential** field.  To specify the price differential for a downgrade item, prefix the amount  by a ‘-’ (minus) sign to indicate that the price differential must be  subtracted from the selling price.
: To specify a formula for calculating the price difference,  click the button ![mi_price_diff_icon.gif]({{site.mi_baseurl}}/img/mi_price_diff_icon.gif) beside the **Price differential** field.<font style="font-family: Verdana;" face="Verdana"> </font>You will see the [**Price Differential**]({{site.mi_baseurl}}/misc/price_differential_dialog_box.html) dialog box.
: The price differential option is disabled for kits  and matrix groups.
: On the **Everest 
 eStorefront**, the Price Differential only works for related items  when they are part of a kit.


**Use Item’s Price**
: Check this option to use the related item's price  in the sales document, instead of calculating any price differential.  The **Price Differential** field is  disabled when you check this option.
: Leave this box unchecked **Everest**  to apply the price difference between the related item and the original  item calculated according to the formula you have specified. If you have  not checked this option and have not specified any price difference between  the original item and the related item, **Everest**  displays the price of the original item in the sales document.
: The **Use****Item’s** **Price**  option helps you to arrive at the price dynamically. You need not update  the price differential during fluctuations.


{:.example}
You have  chosen Intel P II, priced at $305 (Original item), but since it is out  of stock you decide on the related item Intel P III priced at $415. The  sales document will take $415 as the item price if you have CHECKED the  option **Use Item's Price** in the  **Related Items** profile.


If you have the option UNCHECKED the price displayed in the sales document  is $305 (When no price differential is specified).


When a price differential is specified, the price displayed is adjusted  based on the price difference formula you have specified in the **Price Differential** dialog box.


**Sequence**
: Enter the order in which the item selected in the  **Related Item Code** has to be listed  among other item upgrades and downgrades. The items are available for  selection in the order specified here. The sequence number should be unique  for the original item.


{:.example}
If you specify upgrades A, B and C  for item 1000 A and B cannot have the sequence 2 when being defined for  item 1000. But if A is defined for item 1000 and B for item 1002, both  can have the same sequence number.


**Available for selection on**
: Specify the availability of this item as a related  item for the original item when the original item is retrieved as a component  of a kit. The following options are available:


| Option | Description |
| No Kits | The related item is not available on any kit of which the original item  is a component |
| All Kits | The related item is available on all kits of which the original item  is a component |
| Selected Kits | The related item is available on specific kits of which the original  item is a component |

: Related Items for kits and matrix groups do not  have these options available and they default to the “No Kits” option.


{:.note}
If **Selected Kits** is selected  from the drop-down list, a selection grid is displayed below this field.  Select the kit item on which you want this item to be available as a related  item.


{:.example}
Kit item Intermediate Computer Series 1 has three kit components:

- 17 700 monitor
- Logitech  mouse
- Intel printer



Kit item Intermediate Computer Series 2 has three kit components:

- 17 700 monitor
- IBM mouse
- IBM printer



Original item 17 700 monitor has three related items:

- 17 Crt  monitor
- 17 Black bezel
- 17 Multisynch



In the **Related Item** profile  of 17 Crt monitor,  select the option **No Kits**.


In the **Related Item** profile  of 17 Black bezel, select the option **All 
 Kits**.


In the **Related Item** profile  of Multisynch,  select the option **Selected Kits**  and select Intermediate Computer Series 1 in the selection grid.


If 17 700 monitor is retrieved as part of Intermediate Computer Series  1, the following related items are displayed in the **Related 
 Items** browser:

- 17 Black bezel
- 17 Multisynch



If 17 700 monitor is retrieved as part of Intermediate Computer Series  2, the following related items are displayed in the **Related 
 Items** browser:

- 17 Black bezel


**Recommended Item**
: This field pertains only to kits when the option  for **Available for Selection On**  is either “All Kits” or “Selected Kits”. Select this check box to flag  a related item as a recommended item. Recommended items are highlighted  in blue on the web store. If “All Kits” is selected in the **Available 
 for Selection On** field, this will be a recommended item for all  kits. If “Selected Kits” is chosen, this will be a recommended item for  the selected kits listed.


{:.example}
A computer kit contains an “HP DeskJet Printer”  component and related items “HP LaserJet Printer” and “HP 2500C Printer”.  The related item “HP LaserJet Printer” can be flagged as a recommended  item for this kit so that it is highlighted on the web store to upsell  this item.
: ![]({{site.mi_baseurl}}/img/eet_recommended_item_highlighted_in_blue_mi.gif)


**Figure: Recommended Item Highlighted in Blue**


{:.note}
If an item is marked as a recommended item  for a kit component on the **Item**  profile – **Details** tab of a kit  and another related item is marked as a recommended item in the related  item profile, the web page will display both the items as recommended  items for the kit component.


![]({{site.mi_baseurl}}/img/lens.gif)[How  do I set Kit Components or Related Items as Recommended Items?](building-an-online-store.chm::/How_do_I_set_Kit_Components_or_Related_Items_as_Recommended_Items_bos.htm)


{:.see_also}
See also
: [Update  Price Differentials]({{site.mi_baseurl}}/misc/update_price_differentials.html)
: [Related Items]({{site.mi_baseurl}}/the-items-browser/other-options/related_items.html)
: [Set up Related  Items]({{site.mi_baseurl}}/misc/set_up_related_items.html)
: [Computation  of Upgrade/Downgrade Price]({{site.mi_baseurl}}/misc/computation_of_upgrade_downgrade_price.html)
