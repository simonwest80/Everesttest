---
title: Posting group
---


By default the Posting Group assigned to the category to which the item  belongs is associated with the item. You can change the Posting Group  in the **Item** profile.


For existing items, this field is blank, indicating that the Posting  Group for the category to which the item belongs would be considered.  To override the Posting Group of the category, select a Posting Group  in this field. You can define a Posting Group in the **Item**  profile as well as in the **Category**  profile.


The selection of the Posting Group for an item is based on the following  hierarchy:


The Posting Group defined in the **Item**  profile is the first preference, followed by the Posting Group specified  in the **Category** profile. If no  Posting Group is defined in these two profiles, the Posting Group selected  in the **Location-Category** grid  of the **Location** profile is used.  If the **Location-category** grid  does not contain the category to which this item belongs, the Inventory  Posting Group for the location of the stock area is considered. In case  the **Inventory Posting Group Type**  field for the location of the stock area is also left blank, the Posting  Group defined in the company defaults is used.


{:.warn}
: It is not recommended to select a Posting Group  for which an Inventory control account is defined. This account would  override the account specified in the location of the document’s location/sub-location.  As a result discrepancies would occur in the financial and inventory reports.  You may choose to continue, or select another Posting Group in this field.


{:.note}
: The **Sales documents**  and **Purchase documents** sections  will be displayed only for the Non-inventoried items.
