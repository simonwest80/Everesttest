---
title: Special_order_item_code_to_be_used_should_be_non_inventoried_third_party
---


Specify a suitable non-inventoried item for the third party.


When you select an item from a third party catalog in a sales order, **Everest** uses the item code mentioned here in the order since the item does not exist in your database and is available only in the third party catalog. The item code pertaining to the third party catalog is displayed in the **Third Party Code** column of the Item Details Grid in the **Sales Order** profile.


When a Third Party Item is added to a sales document, the Model of the Third Party Item is compared to the Model of all the items in the company’s ITEMS table. If an item is found in the company’s ITEMS table with a matching Model that item is added to the document as a company item. If no item with a matching Model is found the Third Party Item is added to the sales document.
