---
title: Quantity Discounts
---

# Quantity Discounts


Define discount structures based on quantities purchased by customers.  Each discount structure can have discount rates for five quantity levels.  To apply these discounts for an item, the discount scheme has to be associated  with a customer level in the **Discount 
 Code** column of the **Customer Level 
 Pricing** dialog box (path: Item profile > Sales tab > Double-click  Level Pricing field). All customers in this level become eligible for  the discount, if the quantity ordered exceeds or is equal to one of the  minimum quantities in the scheme.


Quantity discounts must be created in an ascending order as shown in  the example below.


{:.example}
You can  create a discount scheme with the following structure


Minimum Quantity  Discount rate (%)


100    5


150    6


200    7


250     10


300     12


You can associate this scheme with Customer Level 1 for Item A and with  Customer Level 5 for Item B. If a customer in level 1 orders 100 of item  A, the customer is eligible for a discount rate of 5% and if a customer  in level 5 orders 100 of item B, the customer is eligible for a discount  of 5%.


{:.note}
- It is not mandatory  to associate a discount scheme with every customer level.
- Discounts are applicable  to each unit of measure.


If the customer purchases a quantity that falls between two quantity  levels that have been defined, the discount for the previous level is  applied.


{:.example}
Based on the discount scheme defined in the  previous example, if a customer buys 125 (between 100 and 150); the customer’s  discount rate will be 5 % (i.e. what is applicable for 100 quantity).


Discounts available are automatically calculated if you select the option  **Automatically apply item discounts applicable 
 to a customer when retrieving the item on a document** in the **Flow** **Control**  preferences (path: **File** > **Setup** > **Preferences**  > **Flow Control** > **Documents**  > **Miscellaneous** tab > **Document Payments** tab). If this is not  selected, you can still apply discounts to a sales document by using the  **Apply Discounts** menu option (path:  **Options** > **Customer**  > **Apply Discounts**).


If the quantity of an item is changed in a sales document and another  price becomes applicable to the item, the price may change automatically  or you may receive a prompt depending upon your preference selection in  the **Behavior for price column if quoted/ordered 
 quantity is changed and a new price is available** field (path: **File** > **Setup**  > **Preferences** > **Flow 
 Control** > **Documents**  > **Pricing/Discounts** tab).


{:.see_also}
See also
: [Define  Quantity Discounts]({{site.mi_baseurl}}/item-profile-details/item-pricing/discounts-and-special-pricing/quantity-discounts/setting_up_a_quantity_discount_scheme.html)
: [Item Pricing]({{site.mi_baseurl}}/item-profile-details/item-pricing/item_pricing.html)
