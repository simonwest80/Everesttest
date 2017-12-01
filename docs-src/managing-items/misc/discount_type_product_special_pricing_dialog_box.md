---
title: Discount Type - Product
---

# Discount Type - Product


**Discount Type**
: Select **Product 
 – All Measure** if you want the discount to be applicable to all  sales measures selected in sales documents for items belonging to the  category, brand, or tracking selection defined in the **Special 
 Pricing** dialog box. When you select this option, the **Available 
 On** field is displayed.
: Select **Product 
 – Specific Measure** if you want the discount to be applicable to  only one measure. When you select this option, the **Sales 
 Measure** and **Available On**  fields are displayed.


{:.note}
The special price will be in the sales price  decimal accuracy for the item. If you enter more decimal places than the  sales price accuracy of the item, the special price rounds off to the  sales price decimal accuracy of the item.


**Measure**
: Specify the specific sales measure that this discount  applies to. This field is enabled when **Product 
 – Specific Measure** is selected. The special pricing specified only  applies if this sales measure is selected in sales documents for items  belonging to the category, brand, or tracking selection defined in the  **Special Pricing** dialog box.


When you select either of the Product Discount Type options, the **Available On** field is displayed.


**Available On**


Choose the items of your choice in this field. The options available  are:


| **Options** | **Description** |
| All Items | Select this option if you want the Special Pricing rule  to be applicable to all active items in your inventory. |
| Specific Item | Select this option to make the special pricing applicable  to a specific item.<br/><br/><br/>Select the code of the specific item in the **Item**  field.<br/><br/><br/>{:.note}<br/>**The **Item**  field is displayed only when you select the **Specific <br/> Item** option.** |
| Items of a specific tracking selection | Select this option if you want the special pricing to  be applicable to all items that are tagged to a specific tracking choice.<br/><br/><br/>Specify the item tracking group code and the choice  by clicking on the drop down buttons.<br/><br/><br/>{:.note}<br/>**The **Specify <br/> the item tracking group** and **selection**  fields are displayed only when you select **Items <br/> of a specific tracking selection** option in the **Available**  on field.**<br/><br/><br/>{:.example}<br/>**You may want to apply a special pricing scheme  to all items that are tagged as ‘Best Buys’ with the tracking choice ‘New  Arrivals’.** |
| Items in a Category | Select this option the special pricing to be applicable  to all items belonging to a specific category.<br/><br/><br/>Select the category code for which the special pricing  will be applicable.<br/><br/><br/>{:.note}<br/>**The **Category**  field appears only when you select the **Items <br/> in a Category** option in the **Available <br/> on** field.** |
| Items of a specific brand | Select this option the special pricing to be applicable  to all items belonging to a specific brand.<br/><br/><br/>Select the brand code for which the special pricing  rule will be applicable.<br/><br/><br/>{:.note}<br/>**The **Brand**  field is displayed only when you select the **Items <br/> of a Specific Brand** in the **Available <br/> on** field.** |
| Items in a Category and of a specific brand | Select this option the special pricing to be applicable  to all items belonging to a specific category and brand.<br/><br/><br/>Select the category code and the brand code for which  the special pricing rule will be applicable.<br/><br/><br/>{:.note}<br/>**The **Brand**  and **Category** fields appear only  when you select the **Items in a Category <br/> and of a specific brand** option in the **Available <br/> on** field.** |



**Pricing Method**
: Specify the pricing method to be applicable for  customers or customer groups.


The different Pricing Methods available are:


| **Option** | **Description** |
| Fixed Price | Select this option to charge a fixed price to the customer. |
| Discount Percent From Least Price | Select this option to specify a discount percentage  on the least price of items retrieved into the sales document.<br/><br/><br/>{:.note}<br/>**If you edit the price of an item in the sales  document, the discount is calculated on the modified price and not on  the least price.** |
| Discount Fixed Amount From Least Price | Select this option to specify a discount amount on the  least price of items retrieved into the sales document.<br/><br/><br/>{:.note}<br/>**If you edit the price of an item in the sales  document, the discount is calculated on the modified price and not on  the least price.** |
| Markup Over Last Landed Cost | Select this option to calculate the selling price by  marking up the last landed cost of the item (defined in the **Item**  profile) by a specified percentage. |
| Markup Over Average Cost | Select this option to calculate the selling price by  marking up the average cost of the item by a specified percentage. |
| Fixed Amount Over Cost | Select this option to calculate the selling price by  adding a fixed amount to the cost of the item defined in the **Item**  profile. |
| Level Pricing | Select this option to charge the level price of the  item as defined in the **Item** profile,  to the selected customer or customers. |



{:.note}
The **Discount percent from least price**  or **Discount fixed amount from least price**  is applied to items on your online store if you select the option **Use list price if lower than customer price**  (path: **File &gt; Setup &gt; E-Commerce 
 &gt; Preferences &gt; Settings &gt; Pricing** tab).


**Amount/Percentage**
: Based on the pricing method selected, this field  toggles between amount and percentage. Enter the amount or percentage  to be used.
: The option ‘**Level 
 Pricing**’  in the **Pricing Method** field replaces  the **Amount** field with **Level 
 Code**.


**Level Code**
: Enter the customer level in this field. **Everest**  assigns the price fixed for items for the selected customer level.


{:.see_also}
See also
: [Special  Pricing Details]({{site.mi_baseurl}}/misc/special_pricing_details_section_special_pricing_db.html)
