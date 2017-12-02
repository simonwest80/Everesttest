---
title: Enter Negative Quantities in Purchase Documents
---

# Enter Negative Quantities in Purchase Documents


You can enter negative item quantities in all purchase documents. When  you enter negative item quantities in a purchase document:

- It is exactly  like creating a purchase return document.
- **Everest**  processes these quantities as entries on a purchase return document.
- The amount  in the amount column also becomes negative.



The total amount of the purchase document is the sum of the positive  and negative amounts. Although you are allowed to enter negative quantities,  the total amount of the purchase document after adding the positive and  negative amounts on each line item must be positive. In other words, the  document is not allowed to change its character as the result of entering  negative quantities.


{:.note}
If the total amount of a purchase document  becomes negative, it, in effect, becomes a purchase return document and  changes the character of the document which is not allowed.


Entering negative quantities is useful when purchase and purchase returns  are made on the same document.


{:.example}
Exchange of items sold.


**Purchase Quote**


Negative quantities can be entered directly in the **Quantity**  column.


**Purchase Order**


Negative quantities can be entered directly in the **Ordered** column.


**Purchase Receipts and Invoices**


Negative quantities can be entered depending on the item type:

- **Non-Inventoried 
 Items** - Enter the quantity prefixed with a negative (-) sign.
- **Inventoried 
 Items** - You can directly enter the quantity prefixed with a negative  sign only if the option **Use default stock 
 area to receive items when creating a purchase receipt/invoice**  (path: **File &gt; Setup &gt; Accounting 
 &gt; Location/Sub-Location &gt; Options &gt; Edit &gt; In New Window &gt; 
 Stock Transfer &gt; Miscellaneous** tab) is selected for the logged  in location/sub-location. The stock is automatically retrieved from the  default stock area specified for purchase documents in the **Location**  profile of the logged in location/sub-location. If no stock areas are  defined for this location, the stock area defined for the default location  is used. If adequate stock of the item does not exist in the default stock  area, **Everest** prompts you that  quantity was NOT attached to the document. You must then attach the quantity  from another stock area.



If the option **Use 
 default stock area to receive items when creating a purchase receipt/invoice**  is NOT selected, you must enter the quantities in the **Attach 
 Quantity** profile (path: **Purchase 
 Receipt/Invoice** profile > **Options**  > **Attach/Retrieve Serial #**  > **Show/Attach area wise stock**).

- **Serialized/Auto-serialized 
 Items** - Negative quantities CANNOT be automatically assigned for  auto-serialized type of items. The serial numbers have to be manually  retrieved from 'Stock' type of stock area (path: **Purchase****Receipt/Invoice** profile > **Options** > **Attach**/**Retrieve** **Serial**  > **Serial** **Number**  / **Serial # Range** > select a  serial number from ‘stock’ type of stock area).

