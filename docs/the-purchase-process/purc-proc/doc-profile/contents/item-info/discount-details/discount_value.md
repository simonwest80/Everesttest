---
title: Discount Value
---

# Discount Value


Enter the discount available on an item in the **Discount****Value** column. Enter the discount  value in the cost decimal accuracy of the item. You can modify the discount  value even after saving the purchase document.


![]({{site.pp_baseurl}}/img/lens.gif) [Measure]({{site.mi_chm}}/item-profile-details/other-items-information/purchase/measure_pur.html)


When you enter the discount value, the discount percent is computed  automatically and displayed in the **Discount 
 %** column and vice-versa. The discount value cannot be greater than  the price of item.


**Discounts on Items Whose Cost Includes Tax**


Discount is computed differently for items whose cost includes tax.  You must define whether the item’s cost includes tax in the **Tax 
 inclusive cost** field (path: **Item**  profile > **Purchase** tab).


If the cost of an item is inclusive of tax, discount is calculated on  the item cost after excluding tax while discount is directly computed  on the item cost for an item whose price does NOT include tax. In the  case of an item with 'Tax inclusive cost', the cost is computed in the  following manner:

- The cost of the  item excluding tax is computed.
- The discount applicable  to the item is computed on this cost.
- The amount of discount  is deducted from the item's cost.
- The tax is then  computed on the discounted cost.
- The item cost including  tax is displayed in the Item Cost column of the Item Details Grid.



{:.example}
Case 1: Tax inclusive cost


An item's cost is $100 which is inclusive of tax at 5%. Discount of  10 percent is allowed on the item.


Cost = 100/1.05 = 95.24


Discount = 95.24x10% = 9.524


Tax = (95.24 - 9.524) X 5% = 4.29


Amount = 100 - 9.524 - 4.29 = 86.19


Case 2: Tax exclusive cost


An item's cost is $100 which is exclusive of tax at 5%. Discount of  10 percent is allowed on the item.


Discount = 100x10% = 10


Tax = (100 - 10) X 5% = 4.5


Amount = 100 - 10 = 90


{:.note}
Tax that can be recovered is deducted from the item's cost when calculating  the discount.


{:.see_also}
See also
: [Item Information]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/item-info/item_information_pp.html)
: [Discount Percent]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/item-info/discount-details/discount_percent.html)
