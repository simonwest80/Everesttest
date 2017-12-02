---
title: The Vendor Profile - Replenishment
---

# The Vendor Profile - Replenishment


This tab allows you to view and specify replenishment planning details  for the items associated with a particular vendor.


**Item Code**
: Select the item purchased from the vendor. You cannot  select an item more than once in this grid.


**Item Description**
: This field will automatically get populated when  you select an item.


**Primary Vendor**
: Indicates whether the vendor is the primary vendor  for the item with which it is associated or not. If the item already has  a primary vendor associated to it and you mark another vendor as primary  vendor a message will appear asking whether you want to change the primary  vendor or not. Select Yes to change the primary vendor or No to keep the  current vendor as primary vendor. This field will be non-editable, if  the vendor is marked primary vendor in the Item profile.


**Purchase Measure**
: Select the measure in which the item is purchased  from the vendor. You can edit this field at any point of time. However,  after updating this field you should also update standard cost and vendor  last cost.


**Standard Cost**
: Specify the cost at which the item is purchased  from the vendor. This is an editable field and by default it shows the  line item’s standard cost.


**Last Landed Cost**
: Specify the last landed cost at which you purchased  the item from the vendor. This includes the item cost, any add-on costs,  and any other costs associated with bringing the item into your possession.  This field updates every time you purchase an item from the vendor in  the measure associated with the vendor. By default this field shows the  line item's last landed cost, but you may edit the field.
: This field updates whenever you receive items on  a purchase receipt, purchase invoice, or debit memo.


**Last Cost**
: Specify the last cost at which you purchased the  item from the vendor. This cost considers just the actual cost (cost minus  discounts) of the item and excludes any additional costs. This field updates  every time you purchase an item in the measure associated with the vendor.  By default this field shows the line item's last cost, but you may edit  the field.
: This field updates whenever you receive items on  a purchase receipt, purchase invoice, or debit memo.


**Last Add-on Cost**
: This displays the last add-on cost at which you  purchased the item from the vendor. Add-on costs refer to all the additional  costs (other than the item’s last cost) that you incurred to bring the  items into your possession such as custom duties, transportation insurance,  etc. You may not edit this field.
: This field updates whenever you receive items on  a purchase receipt, purchase invoice, or debit memo.


**EOQ**
: Specify the minimum quantity that you want to order  from the vendor. This field will be in the purchase measure selected for  the vendor. This is an editable field and by default it will show zero  value.


**Vendor Part Number**
: Specify the part number supplied by the vendor.  This is an editable field.


**Lead Time**
: Specify the time required by the vendor to deliver  the goods in number of days. The default value is Unknown and is used  just for information. You need not use the value of this field to calculate  the delivery date or select vendor with minimum lead time. You can edit  this field at any point of time.


{:.note}
- The details as  and when updated in the **Vendor**  profile will reflect in the **Item** profile and vice versa.
- You cannot associate  a vendor twice with the same item.


{:.see_also}
See also
: [The  Vendor Profile]({{site.mv_baseurl}}/creating/the_vendor_profile_steps_by_steps.html)
