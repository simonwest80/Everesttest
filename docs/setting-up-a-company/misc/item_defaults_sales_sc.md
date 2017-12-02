---
title: Item Defaults - Sales
---

# Item Defaults - Sales


Use the **Item Defaults-Sales**  tab to configure the default settings for sales information such as Default  Sales measure, Weight measure, Size measure, Volume measure, Price type  and Commission rate.


{:.note}
: All the fields are optional.


Default Sales measure and Price Type details


**Default Sales measure**
: Specify the sales measure of the item to be displayed  by default in the **Default Sales measure**  field, when you create a new item. The sales measures displayed here are  derived from Measures browser (path: **Inventory**  > **Measures**). The **Default 
 Sales measure** displayed here is depends on the **Stock 
 measure** value configured in the **Item 
 Defaults-Inventory** tab, as given in the table below:


| Stock measure type (Item Defaults-Inventory) | Default Sales measure |
| Decimal | Decimal |
| Fractional | Fractional |
| Blank | Any type |



{:.note}
: Only measures with a conversion factor to the stock  measure are available in the drop-down list. If the **Stock 
 measure** and **Default sales measure**  are of the same type but different values, then a conversion factor will  retrieve the sales measure.


**Weight measure**
: Specify the Weight measure to be displayed by default  in the **Weight measure** field, when  you create a new item.


**Size measure**
: Specify the size measure to be displayed by default  in the **Size measure** field, when  you create a new item.


**Volume measure**
: Specify the volume measure to be displayed by default  in the **Volume measure** field, when  you create a new item.


**Price Type**
: Specify the price type to be displayed by default  in the **Price Type** field, when  you create a new item. You can choose from Fixed or % Markup options.


Other sales information


**Commission rate %**
: Enter the rate % of the commission to be displayed  by default in **Commission rate %**  field, when you create a new item.


**Include in commission report calculation**
: Check this box to ensure that the **Include 
 in commission report calculation** field is checked by default.


**Tax inclusive selling price**
: Check this box to ensure that the **Tax 
 inclusive selling price** field is checked by default, when you create  a new item.


**Include in freight calculation**
: Check this box to ensure that the **Include 
 in freight calculation** field is checked by default, when you create  a new item.


**Pack Separately**
: Check this box to ensure that the **Pack Separately** option is checked by default, when you create a  new item.


**Sales price decimal accuracy**
: Specify the number of decimals between 0 and 6 to  be used for the sales price and to ensure that the number of decimals  specified here is displayed in **Sales 
 price decimal accuracy** field by default, when you create a new  item.


{:.see_also}
See also
: [The  Location profile - Item Defaults]({{site.sc_baseurl}}/options/locations-and-sub-locations/set-up-locations/the_location_profile_item_defaults_sc.html)
: [The Location  Profile]({{site.sc_baseurl}}/options/locations-and-sub-locations/set-up-locations/the_location_profile.html)
