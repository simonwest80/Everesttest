---
title: How Do I Discount a Kit?
---

# How do I Discount a Kit?


**Everest** allows you  to create numerous pricing schemes for your line items. But did you know  that you can also provide quantity discounts on your kits?  For  example, suppose you wanted to give your customers a 20% discount if they  purchase one kit and a 25% discount if they purchase two kits. You can  do this in **Everest**.


{:.steps}
To discount a kit, do the following:


Setting up a Quantity Discount for a Kit


Setting up a Quantity Discount for a kit involves the following  tasks:

- Define a Customer  Level
- Define a Quantity  Discount
- Set the Kit Pricing  Details
- Associate the Discount  Code to the Customer Level



Follow the procedures below for a step-by-step example on  how to discount a kit.


Define a Customer Level


Follow the steps below to create a customer level:

- From the **Everest** main menu, select **Inventory**  > **Discounts** > **Customer 
 Levels**.
- Select **Options**  > **New** > **In 
 New Window**. You will see the **Customer 
 Levels** profile.
- Enter a unique  **Customer Level Code** and a **Description**. In this example, we use  LVL-X but you can use any defined customer level.
- Save the new customer  level.



![]({{site.mi_baseurl}}/img/customer_levels_profile_discount_kit_mi.gif)


**Figure: Customer Levels Profile - Discount Kit  Example**


Define a Quantity Discount


Follow the steps below to create the quantity discount for  your kit:

- From the **Everest** main menu, select **Inventory**  > **Discounts** > **Quantity 
 Discounts**.
- Select **Options**  > **New** > **In 
 New Window**. You will see the **Quantity 
 Discount** profile.
- Enter the Code  and Description for the quantity discount profile. In this example, we  use **QD-X**.
- Select the **EA** Sales Measure.
- Enter the appropriate  discount levels for your kit. In this example, we use:


- Minimum Quantity  = **1**, Discount % = **20.00**
- Minimum Quantity  = **2**, Discount % = **25.00**


- Save your changes.



![]({{site.mi_baseurl}}/img/quantity_discount_profile_discount_kit_mi.gif)


**Figure: Quantity Discount Profile - Discount  Kit Example**


Set the Kit Pricing Details


Follow the steps below to set up the pricing details for  your kit:

- Open the Item profile  for the kit you want to discount.
- Select the **Details - Pricing** tab.
- In the **Type**  field, select **Reset item prices to zero 
 and display the total price of the kit on a total line**. This option  resets all individual item prices in the kit to zero, and displays the  total price of the kit according to the options displayed.
- Select the **Use pricing defined in the Sales Tab to determine 
 the total price** option. This option displays the sales price of  the item kit as specified in the **Sales**  tab of the Item profile. When retrieved in a sales document, the kit is  the first line item with the prices defined in its profile. The system  displays zero prices for the individual items.



![]({{site.mi_baseurl}}/img/kit_item_profile_details_pricing_tab_discount_kit_mi.gif)


**Figure: Kit Item Profile Details-Pricing Tab  - Discount Kit Example**

- Keep the Kit Item  profile open for the next procedure.



Associate the Discount Code to the Customer Level

- Select the **Sales** tab of the Item profile of the  kit you want to discount.



![]({{site.mi_baseurl}}/img/kit_item_profile_sales_tab_discount_kit_mi.gif)


**Figure: Kit Item Profile Sales Tab - Discount  Kit Example**

- Scroll to the right  and double-click the **Level Pricing**  field.



![]({{site.mi_baseurl}}/img/kit_item_profile_sales_tab_level_pricing_selected_discount_kit_mi.gif)


**Figure: Kit Item Profile Sales Tab - Level Pricing  Selected - Discount Kit Example**

- In the **Customer 
 Level Pricing** dialog box Discount Code field for your customer  level (LVL-X in this example), select your **Discount 
 Code** (QD-X in this example) to associate it with the customer level.



![]({{site.mi_baseurl}}/img/customer_level_pricing_dialog_box_discount_kit_mi.gif)


**Figure: Customer Level Pricing Dialog Box - Discount  Kit Example**

- Click **OK**.
- Save the Item profile.



When you create a sales order for a customer with the defined  customer level, the kit price decreases by the appropriate discount depending  upon the quantity purchased.


In the following sales order example, the customer purchased  two kits.


Kit Discount = ($1,000 per kit x 2 kits) x .25 discount (25%)  = $2,000 x .25 = **$500**


Kit Price with Discount = $2,000 - $500 = **$1,500**


![]({{site.mi_baseurl}}/img/sales_order_example_discount_kit_mi.gif)


**Figure: Sales Order - Discount Kit Example**


Notice that the Kit shows the discounted amount.


{:.see_also}
See also
: [Create an Item  Kit]({{site.mi_baseurl}}/create-regular-items-kits-and-assemblies/creating-an-item-kit/create_an_item_kit.html)
