---
title: The Lot Number Profile - General
---

# The Lot Number Profile - General


The **General** tab of this profile  allows you to specify the lot number details.


**Lot ID**
: The **Lot ID**  is automatically generated, when you save the profile.


**Lot Number**
: Enter a unique lot number in this field. Manually  generated lot numbers must start with an alphabet. Auto-generated lot  numbers are numeric and takes the number from the **Location**  profile. Lot numbers can be auto generated for items from the **Item**  profile by checking the option **Auto-generate 
 Lot Numbers** (path: **Item**  profile > **Inventory** tab).


**Item Code**
: Specify the item to which you want to assign the  lot number. You can assign lot numbers only to inventoried items and not  to non-inventoried items. If you attach a lot number from a purchase receipt  or invoice, the item code will be the same as specified in the document  and cannot be edited.


**Vendor Code**
: Specify the vendor of the item you have selected  in the **Item Code** field. If you  attach a lot number from a purchase receipt or invoice the vendor code  will be the same as specified in the document and cannot be edited.


**Manufacture Date**
: Enter the date of manufacture for the lot. This  helps you to find out the aging of item quantities by tracking lot numbers.


**Purchase Date**
: Specify the date of purchase of items in this field.  When the items belonging to the same lot have different purchase dates,  **Everest** will prompt you that the  purchase date in the lot is different from that of the purchase document.  By default, the purchase date is the same as the date on the purchase  invoice.


Expiry  details


**Expiry  From**
: Specify whether the expiry  is counted from the manufacturing date or the date of purchase.


{:.example}
**In the case of medicines, you may consider  the manufacturing date. The expiry  date denotes the date until which the item is safe to use.**


**In the case of consumer goods like a refrigerator,  you may consider the purchase date. The expiry date denotes the date when  the warranty on the item expires.**


**Expiry  Type**
: Specify the expiry  type in this field. The following options are available:

- **Not 
 required** - Select this option if you do not want to specify an  expiry period.
- **By 
 Date** - This option allows you to specify a date on which the expiry  period ends.
- **Period 
 Number of Days** - This option allows you to specify the expiry period  in terms of days.
- **Period 
 Number of Months** - This option allows you to specify the expiry  period in terms of months.
- **Period 
 Number of Years** - This option allows you to specify the expiry  period in terms of years.



**Expiry  Period**
: Expiry  period may be specified as a date, a number of months or days or years  from the date of manufacture or purchase. This field is disabled, when  you specify expiry type as ‘Not Required’  or ‘By Date’  in the Expiry type field.


**Expiry  Date**
: Date of expiry  will be automatically displayed based on the expiry  period specified.
: You can specify the date you want, only if you select  the expiry  type as ‘By Date’  in the **Expiry 
 Type** field.


**Warranty Details**
: Enter any additional warranty details that may be  provided in this field.


{:.see_also}
See also
: [The  Lot Number Profile - Custom Fields Tab ]({{site.wm_baseurl}}/lot-number-tracking/assigning-a-lot-number/option_available_in_the_lot_number_profile_wm.html)
: [Modify a Lot  Number]({{site.wm_baseurl}}/lot-number-tracking/assigning-a-lot-number/modify_a_lot_number_wm.html)
: [The Lots Browser]({{site.wm_baseurl}}/lot-number-tracking/assigning-a-lot-number/the_lots_browser_wm.html)
