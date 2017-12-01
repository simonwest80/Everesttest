---
title: The Price Differential Dialog Box
---

# The Price Differential Dialog Box


Use the **Price** **Differential**  dialog box to define a formula to create the price difference.


**Original Item**
: The original item is the item for which the upgrade/downgrade  is being defined. This field displays the Item Code, Sales Measure, Average  cost, Last cost and Selling price of the original item. These are display  fields and cannot be edited.


{:.note}
The Average Cost and Last Cost are picked  up from the **Purchases** tab of the  **Item** profile while the selling  price is picked up from the **Sales**  tab of the **Item** profile.


**Related Item**
: This section displays the Item Code, Sales Measure,  Average cost, Last cost and Selling price of the upgrade/downgrade item.  These are display fields and cannot be edited.


**Average cost of original item**
: To calculate the price difference as a percentage  of the average cost of the original item, select this option and enter  the percentage in the **Percentage/Amount**  field. The average cost includes the factor cost, if any.
: The result of applying the percentage on the base  value is displayed in the **Result**  field. You can also mention a negative percentage (in case of downgraded  items).


{:.example}
If the average cost of the original item is $10 and the percentage differential  is mentioned as -10%, the **Result**  field (i.e. the price differential amount) displays ($1.00). The price  for the downgraded item would be the selling price of the original item.  If the differential is negative, the formula automatically takes care  of it.


**Last cost of original item**
: To calculate the price difference as a percentage  of the last cost of the original item, select this option and enter the  percentage in the **Percentage/Amount**  field.
: The result of applying the percentage on the base  value will be displayed in the **Result**  field. You can also mention a negative percentage (in case of downgraded  items).


{:.example}
If the last cost of the original item is $20  and the percentage differential is mentioned as 10%, the **Result**  field (i.e. the price differential amount) displays $2. The price for  the upgraded item would be the selling price of the original item + price  differential amount. If the differential is negative, the formula automatically  takes care of it.


**(Average cost of related item - Average cost  of the original item)**
: To calculate the price difference as a percentage  of the difference between the average cost of the related item and the  average cost of the original item, select this option and enter the percentage  in the **Percentage/Amount** field.  The average cost includes the factor cost, if any.
: The result of applying the percentage on the base  value will be displayed in the **Result**  field. You can also give a negative percentage (in case of downgraded  items).


{:.example}
If the average cost of the original item is  $200 and that of the related item is $300, and the percentage differential  is 10%, the **Result** field (i.e.  the price differential amount) displays $10. The price for the upgraded  item would be the selling price of the original item + price differential  amount. If the differential is negative, the formula automatically takes  care of it.


**(Last cost of related item - last cost of original  item)**
: To calculate the price difference as a percentage  of the difference between the last cost of the related item and the last  cost of the original item, select this option, and enter the percentage  in the **Percentage/Amount** field.
: The result of applying the percentage on the base  value will be displayed in the **Result** field. You can also give a negative percentage (in case of downgraded  items).


{:.example}
If the last cost of the original item is $200  and that of the upgraded item is $300, and the percentage differential  is 10%, the **Result** field (i.e.  the price differential amount) displays $10. The price for the upgraded  item would be the selling price of the original item + price differential  amount. If the differential is negative, the formula automatically takes  care of it.


**(Selling price of related item - Selling price  of original item)**
: If the price difference has to be calculated as  a percentage of the difference between the selling price of the upgrade/downgrade  item and the selling price of the original item select this option and  enter the percentage in the **Percentage**/**Amount** field.
: The result of applying the percentage on the base  value will be displayed in the **Result**  field. You can also mention a negative percentage (in case of downgraded  items).


{:.example}
If the selling price of the original item  is $200 and the selling price of the related item is $300, and the percentage  differential is given as 10%, the **Result**  field (i.e. the price differential amount) displays $10. The price for  the upgraded item would be the selling price of the original item + price  differential amount. If the differential is negative, the formula automatically  takes care of it.


{:.note}
The selling price of the original item is  listed in the sales measure defined in the Item profile. This is also  true for the related item. The **Average 
 Cost**, **Last Cost**, and **Selling Price** fields are listed in the  sales price decimal accuracy of the respective items. The **Amount**  and price differential **Amount**  are listed in the sales price decimal accuracy.


**Flat amount (+ or -)**
: If you wish to specify a flat amount as the price  difference choose this option and enter the flat amount in the **Percentage/Amount** field.


{:.note}
The price difference is positive by default,  and hence is always added to the selling price of the item being upgraded.  Prefix the percentage or amount with a '-' (minus) sign to subtract the  price difference from the selling price of a downgraded item.


**Percentage/Amount**
: Enter the percentage to be applied on the base value  for any of the first five options. For the last option, enter a flat amount.


{:.note}
You can enter a percentage of 0 - 999.99.


**Result**
: The result of applying the percentage on the base  value is displayed in this field. In case of a flat amount, the amount  entered will be displayed here.


Price Differential for Customer Levels


Price Differential is defined as a percentage or a flat amount. By default,  this percentage or flat amount is applicable to all the customers who  purchase the item. You can specify the price differential (as a percentage  or a flat amount) for each customer level separately. All customer levels  that have been defined are displayed in the **Price 
 Differential for Customer Levels** section. Since you cannot specify  the markup percentage for the customer level **None**,  this level is not available in this grid.


The price differential for each customer level is different from the  price to which the differential is applied.


{:.example}
You specify a price differential of flat $2 in general to upgrade item  A to B. Item A's price is $10 but the price for level 1 is $8. For customers  in level 1, the upgrade price is $10 (8+2). For customers at level none,  the upgrade price is $12 (10+2).


Now, if you specify a price differential of $1.75 for level 1 only,  the upgrade price would be 9.75 (8+1.75).

- If you have  selected any of the first five options in the **Percentage/Amount**  field, the **Percent** and **Amount**  columns will be displayed in this section.



**Percent**
: Enter a percentage for each customer level in the  **Percent** column. It is not mandatory  to enter a percentage for every customer level.


**Amount**
: The amount of price differential is calculated and  displayed in the **Amount** field  for each customer level. You cannot edit this column.

- If you have  selected the **Flat Amount (+ or -)**  option, only the **Amount** column  is displayed.



**Amount**
: Enter a flat amount for each customer level.


{:.see_also}
See also
: [Computation  of Upgrade/Downgrade Price]({{site.mi_baseurl}}/misc/computation_of_upgrade_downgrade_price.html)
