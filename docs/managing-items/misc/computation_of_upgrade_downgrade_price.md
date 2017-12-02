---
title: Computation of Upgrade/Downgrade Price
---

# Computation of Upgrade/Downgrade Price


When a customer orders for an Upgrade/Downgrade item, the price of the  upgraded/downgraded item is determined using the following rules:

- If no customer  level is assigned to the customer, the base differential price (the price  differential that is applicable to customers who do not belong to any  customer level) is added to the computed price (as the least of the base  price, quantity pricing and special pricing).



{:.example}
**You specify a flat price differential of $2  in general to upgrade item A to B. Item A's price is $10. If no customer  level is assigned to the customer, the price of item B is $12 (10+2).**

- If a customer  level has been assigned to the customer:


- If a price differential  has been defined for the customer level, the price differential defined  for that customer level is added to the computed price (which is the least  of the base price, the customer level’s price, quantity pricing and special  pricing).



{:.example}
**You specify a price differential of $1.75  for level 1 customers for whom the price of item A is $8. The upgraded  item B will cost these customers $9.75 (8+1.75).**

- If no price differential  has been defined for the customer level, the base price differential is  added to the computed price (which is the least of the base price, the  customer level’s price, quantity pricing and special pricing).



{:.example}
**You specify a flat price differential of $2  in general to upgrade item A to B. Item A's price is $10, but the price  for level 1 is $8. For a customer of level 1, item B will cost $10(8+2).**


{:.note}
If the quantity of the upgraded item is changed, the price changes to  whatever quantity pricing is defined for the upgraded item, proving the  following conditions are satisfied:

- New prices are  applicable for the quantity and
- The **Automatically 
 apply item discounts applicable to a customer when retrieving the item 
 on a document** option is selected in the **Flow 
 Control Setup** dialog box (path: **File**  > **Setup** > **Preferences**  > **Flow** **Control**  > **Documents** > **Miscellaneous**  > **Document** **P****ayments** tab)



The upgrade price, in this case, is lost.


Click [here]({{site.mi_baseurl}}/misc/computation_of_item_upgrade_downgrade_price_flowchart.html)  to view this decision tree.


{:.see_also}
See also
: [Update  Price Differentials]({{site.mi_baseurl}}/misc/update_price_differentials.html)
: [Related Items]({{site.mi_baseurl}}/the-items-browser/other-options/related_items.html)
