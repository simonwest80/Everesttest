---
title: Determining Inventory Control Account
---

# Determining Inventory Control Account


Rule 2

1. Always first consider the inventory control account  defined in the Posting Group assigned to the item in the **Item**  profile.
- Where no inventory control account is assigned  to the item, then consider the control account assigned to the item category.
- Where no inventory control account has been assigned  either to the item or the item category, then consider the inventory control  account of the stock area TO which the item is assigned in the document.



Whenever **Everest** looks into  the location, check the **Location–Category**  grid first. If the category is not available here, then look into the  Inventory control account of the **Location**  profile. (This condition also applies to the Rule specified in [Determining  Inventory Control Account for Sales Documents]({{site.sp_chm}}/misc/determining_inventory_control_account_for_sales_documents.html))


The Rules for determining the other accounts will be as follows:


Rule 3: All accounts other than inventory control  account

1. Always first consider the accounts defined in  the Posting Group assigned to the item in the **Item**  profile.
- Where the account is not assigned to the item,  then consider the account assigned to the item category
- Where the account has not been assigned either  to the item or the item category, then consider the account of the document  location.

