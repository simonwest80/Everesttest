---
title: Item List Tab
---

# Item List Tab


The **Item List** tab allows you  to specify the items that are part of the kit being defined.


Kit specifications grid


This grid lists the details of the items contained in the kit.


{:.steps}
To add an item to the kit, do the following:

- In the **Item List** tab, right-click anywhere  on the grid.
- Select **Items** > **Selection**  from the right-click menu. You will see the **Items**  browser.
- Select the  required items and click **OK**.



When you add an item to the kit, details such as item category, description,  cost, price and discount value will also be displayed. The sales and purchase  quantity columns default to 1 with the quantity decimal accuracy of the  selected items. You can change the sales and purchase quantity, description/notes,  price and discount values, if required.


The price retrieved into the **Kit specifications 
 grid** considers quantity pricing if any, defined for the item. When  an item is added to a kit, it shows the default purchase and sales measures  for the item. These measures can be changed to any other purchase or sales  measure of the kit component.


{:.note}
The stock, purchase, and sales measures are  all **Each** and cannot be edited.


The Price and Discount Values are for the sales measure in the sales  price decimal accuracy. The cost displayed in the **Unit 
 Average Cost/Unit Last Cost** column depends on the markup calculation  cost type specified in the flow control preferences (path: **File 
 &gt; Setup &gt; Preferences &gt; Flow Control &gt; Items &gt; Item Details**  tab). The **Average Cost/Last Cost**  for a kit component is shown in the purchase measure using the cost decimal  accuracy. The **Total Cost** column  shows the purchase quantity multiplied by the average cost. The **Amount** column shows the sales quantity  multiplied by the price, less the discount.


The last cost in the **Purchases**  tab of the **Item** profile is not  automatically updated as you modify the kit by adding or deleting items.  **Everest** displays a message asking  if you would like to update the last and average costs of the kit with  the new total cost of its components.


Based on your preference here, the last cost of the kit is displayed  in the Item Details Grid when you retrieve the kit into a document.


When you add an item to the **Kit specifications 
 grid** or change the quantity of a kit component and attempt to save  the profile, a message prompts you to confirm if you want to update the  last and average costs with the new total cost of the kit.


{:.note}
• When kit components are retrieved into purchase documents, they will  show the purchase measure defined in the **Details****– Item List** tab. The purchase  measure of a kit component can be changed to any other purchase measure  of that kit component.


• When kit components are retrieved into sales documents, they will  show the sales measures defined in the **Details-Item 
 List** tab. The sales measure of a kit component can be changed to  any other sales measure of that kit component.


The right-click menu options available from the Item  List tab:


**Insert**
: Use this option to insert a row into the grid.


**Delete**
: Use this option to delete a row from the grid.


**Items**
: The **Items**  menu has the following sub-menu options:

- **Selection**  - Use this option to view the **Items**  browser from where you can select the items to be included in the kit.
- **Profile**  - Use this option to view the profile of the item selected in the **Item List** tab.



**Inline Notes**
: Use this option to specify additional information  for the selected item. When you select this option, you will see the **Description** dialog box wherein you can  enter the additional information.


**Pricing Analysis**
: The **Pricing Analysis**  menu has the following sub-menu options:

- **Pricing 
 Analysis - Current Item** - Select this option to view the pricing  analysis for the selected item.
- **Pricing 
 Analysis - Kit** - Select this option to view the pricing analysis  for all the items included in the kit



![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Pricing  Analysis]({{site.sp_chm}}/sales-docs/sqs/sq-proc/pricing-analysis/pricing_analysis.html)


**Retrieve**


The **Retrieve** menu has the following  sub-menu options:

- **Category**  - Select this option to retrieve all items belonging to a particular category.
- **Kit**  - Select this option to retrieve all items belonging to a particular kit.



**Move Up**


Select this option to move the selected item up the grid. Use the ![mi_up_arrow.gif]({{site.mi_baseurl}}/img/mi_up_arrow.gif) button also to move the selected item up. The order of the  items in this tab, is the order in which they are:

- Retrieved into  sales or purchase documents.
- Displayed on  your online store.



**Move Down**
: Select this option to move the selected item down  the grid. The ![mi_down_arrow.gif]({{site.mi_baseurl}}/img/mi_down_arrow.gif) button also allows you to move the selected  item down


{:.note}
You can set up inventoried or serialized items,  received for service or repair, as a ‘service item’.  To do this, change the item type to ‘service’ by clicking the **Type**  column for the line item, and pressing the **Spacebar** key.
: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Service  Items and Repairs]({{site.pp_chm}}/purc-proc/pos/po-processes/service_items_purchase_content.html)
: ![]({{site.mi_baseurl}}/img/lens.gif) [How  do I Set Kit Components or Related Items as Recommended Items?](building-an-online-store.chm::/How_do_I_set_Kit_Components_or_Related_Items_as_Recommended_Items_bos.htm)


{:.see_also}
See also
: [Item Profile  - Details Tab]({{site.mi_baseurl}}/create-regular-items-kits-and-assemblies/creating-an-item-kit/the_item_profile_details.html)
