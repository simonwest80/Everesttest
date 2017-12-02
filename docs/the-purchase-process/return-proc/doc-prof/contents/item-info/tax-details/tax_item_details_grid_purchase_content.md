---
title: Tax
---

# Tax


The **Tax** column indicates whether  the purchase price of the item selected in the purchase document is Inclusive  of Tax (I) or Exclusive of Tax (E).


Tax is included in the purchase price of an item if the **Tax****inclusive** **cost**  check box is selected (path: **Inventory**  > **Items** > **Options** > **Edit** > **In 
 New Window** > **Purchases**  tab).


When the purchase price of an item includes tax, this column displays  ‘I’. The **Amount** column displays  the purchase price of the item excluding the tax amount. When the purchase  price of an item excludes tax, this column displays ‘E’.


{:.example}
The item cost, which is tax **inclusive**,  is $110 and the tax is 10%. When you select this item in a purchase document,  the **Tax Amount** column in the item  details grid displays $10 and the **Amount**  column shows $100.


The item cost, which is tax **exclusive**,  is $110 and the tax is 10%. When you select this item in a purchase document,  the **Tax Amount** column in the item  grid displays $11 and the **Amount**  column shows $110.


**Everest** calculates the discount  exclusive of tax, for an item whose price includes tax.


{:.note}
Tax cannot be computed properly if an item  is tax inclusive and the tax code associated with that item has one or  more tax components with tax base limit. If the tax component has a base  limit, items should be set with tax exclusive price wherever possible.  In case a tax component with a tax limit base is associated with a tax  inclusive priced item, Everest clears the tax code and amount fields for  that item. You may manually select a valid tax code for such items if  desired.


{:.see_also}
See also
: [Recoverable  Tax]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/item-info/tax-details/recoverable_tax_item_details_grid_purchase_content.html)
: [Modify  Tax/Recoverable Tax Amounts]({{site.pp_baseurl}}/misc/modify_tax_recoverable_tax_amounts_purchase_process.html)
