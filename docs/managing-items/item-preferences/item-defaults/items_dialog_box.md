---
title: The Items Dialog Box
---

# The Items Dialog Box


Use this dialog box to specify default settings for items.


{:.note}
These setting can be changed at the item level.


The **Items** dialog box has the  **Item** tab.


**Default item used for shipping charges**
: Specify the default item to be used to charge freight  charges on a document. When you compute freight using the freight estimator  utility, and include the charges on the document, this item is retrieved  by default into the document to account for the shipping charges.
: This item is also used to account for the undistributed  portion of the freight on freight distribution.


**Item used for commissions on manual documents**
: If a manual sales journal is created and the entry  type selected in the commission report is either

- Taxable commissionable  revenue, or
- Non-taxable  commissionable  revenue, or
- COGS commissionable,

: the commission due on this sale is calculated at  the percentage defined in this **Item**  profile on the revenue amount.


**Item used for displaying manual documents in  tax reports**
: If you run a tax report with the **Detailed**  option selected and **Show Documents**  unselected, documents will display the line item details without their  corresponding document numbers. However manual documents do not contain  line entries. In this case, manual documents display against the item  specified here.
: This preference defaults to COMM although you may  change it to any other non-inventoried item.


**Items to be used for document discounts**
: Specify the default item to be used for computing  discounts in documents.


{:.see_also}
See also
: [Item Defaults]({{site.mi_baseurl}}/item-preferences/item-defaults/item_defaults.html)
