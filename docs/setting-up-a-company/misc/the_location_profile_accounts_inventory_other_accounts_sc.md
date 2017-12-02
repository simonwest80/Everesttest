---
title: The Location Profile - Accounts – Inventory – Other Accounts
---

# The Location Profile – Accounts – Inventory – Other Accounts


Use this grid to define Posting Groups for the different  categories of items for this location. This helps you account for the  inventory of specific item categories based on their location.


If you want to know the value of inventory on hand in three categories  of items, you can specify different Posting Groups for them with unique  inventory control accounts defined in each of them as shown in the example  in the table below.


| Category | Posting Group |
| Raw Materials | Inv-RM |
| Consumables | Inv-Con |
| Finished Goods | Inv-FG |



The assignment of Inventory control accounts to the Posting Groups are  shown in the example in the table below:


| Posting Group | Inventory Control account |
| Inv-RM | A1400 |
| Inv-Con | A1500 |
| Inv-FG | A1600 |



By summing up the values of the account A1400, you can ascertain the  total value of the raw material category  in  the specific location. Similarly, you can determine the values of Consumables  and Finished Goods category . It also provides you a precise figure of  stock of each category in the location.


The sum of the values of all the ‘child’ accounts for each category  in the location would give you the value of the parent account; this would  be displayed in the Balance sheet.

- To enter the data  in this grid, press the **Insert**  key to add a row to the grid and select a category from the **Categories**  browser. Specify the Posting Group that you want to associate with the  category.



The Posting Group defined for each line item in a transaction is the  first preference. If no Posting Group is assigned to the item, the Posting  Group assigned to the category to which the item belongs is used. In case  the category has no Posting Group associated with it, the inventory account  specified in the **Location Category**  grid is used for all the items in this category.


If the category is not specified in the grid, the default Inventory  Control Account for the location is considered in the transaction.


{:.note}
**Exclusive Inventory Control Accounts for item  categories provide an accurate stock status of each category in the particular  location. It also serves to provide precise information on the total amount  of inventory in a location at a given time.**


{:.warn}
**When you select a Posting Group for which  an Inventory Control Account is defined in the **Location 
 – Category** grid, this account will override the default Inventory  control account for the location. This would lead to an aberration in  the accounting entries and the stock balances for the location. You will  receive a message alerting you to the above situation. Click **Yes**  to proceed, or click **No** and select  a different Posting Group.**


{:.see_also}
See also
: [The  Location Profile - Accounts]({{site.sc_baseurl}}/options/locations-and-sub-locations/set-up-locations/location_profile_posting_group.html)
