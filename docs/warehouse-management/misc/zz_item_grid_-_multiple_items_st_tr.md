---
title: Item Grid
---


The **Item Grid** comprises the  following columns:


**Line Number**
: This column displays the line number of the Item  Details Grid.


**Item Code**
: Specify the code of the item for which you want  to make stock transfers. Once you save the document, you cannot modify  this field. This field is mandatory.


**Description**
: This field displays the item description. You cannot  modify this field.


**Type**
: This field displays the inventory type of the item.


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Item Information]({{site.wm_baseurl}}/misc/item_information_stck_trsfr.html)


**UM**
: This column displays the stock measure for the item.  You cannot modify the unit of measure.


**From Invt Acnt**
: This field displays the Inventory Control Account  from where the stock is selected.


{:.note}
The Inventory Control Account defined in the  Posting Group assigned to the line item is considered first. If no Inventory  Control Account is defined for the item, the control account defined for  the category to which the line item belongs is used. If the Inventory  Control Account is not defined for either the item or the category, the  Inventory Control Account of the stock area’s location from where the  item is transferred is taken into consideration.


If the line item in a stock transfer document  is transferred from several stock areas pertaining to different locations  with different inventory control accounts the **From 
 Invt Acnt** column for this line item will be blank unless the user  overrides it.


The user may override the Inventory control  account by selecting one control account in the From Inventory account  column before the document is saved. However, there will be multiple rows  for such line item with multiple inventory control accounts in the journal.


**Cost**
: In the case of non-serialized items, this field  displays the average cost of the item. In the case of serialized items,  it displays the weighted average of the actual cost of the serial numbers  transferred. Average cost is the average cost of the item in the stock  unit of measure.


**To Bin**
: Select the stock bin to which you want to transfer  the items.


**To Invt Acnt**
: The Inventory Control Account defined in the Posting  Group assigned to the line item is considered first. If no Inventory Control  Account is defined for the item, the control account defined for the category  to which the line item belongs is used. If the Inventory Control Account  is not defined for either the item or the category, the Inventory Control  Account of the stock area’s location to where the item is transferred  is taken into consideration.


{:.note}
If a Posting Group with an Inventory control  account has been assigned to either the **Item**  profile or **Category** profile the  **From Invt Acnt** and the **To 
 Invt Acnt** inventory control accounts will be similar.


Irrespective of how the inventory control  account has been resolved, you can edit the **From 
 Invt Acnt** or the **To Invt Acnt**  inventory control accounts to any other account of the type Inventory  Control Account. However, a message appears warning the user of the possible  mismatch between the financial and inventory reports.


**Quantity**
: Enter the quantity of items to be transferred. This  column displays the total quantity of the items available for transfer  from a particular stock bin. The quantity is shown in the stock measure.  The quantity defaults to 1 with the decimal accuracy of the measure. With  the appropriate security rights, you can increase the quantity decimal  accuracy up to 6.


{:.example}
Your default purchase measure is KG and the  KG decimal accuracy is 2. The quantity is shown as 1.00, but you can enter  1.123 or 1.12345.
: You will have to attach the serial numbers of the  item for which the stock transfer is carried out, if the item selected  is serialized or auto-serialized.


**Amount**
: The total value of the quantity transferred in a  line is displayed in this field. It is in the decimal accuracy defined  in the currency profile. The value of the stock transferred is the average  cost multiplied by the quantity transferred.
