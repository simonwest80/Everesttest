---
title: Enter Negative Quantities in Purchase Return Documents
---

# Enter Negative Quantities in Purchase Return Documents


Negative quantities can be entered in all Purchase Return documents.  Entering a negative quantity in a purchase return document is exactly  like creating a purchase document. **Everest**  processes line items with negative quantities on purchase return documents  as an entry in a purchase document. Entering a negative quantity will  cause the amount of that line item to become negative.


The total amount of the purchase return is the sum of the positive amounts  and the negative amounts. Although you are allowed to enter negative quantities,  the total amount of the purchase return document after adding the positive  and negative amounts on each line item must be positive. In other words,  the document is not allowed to change its character as the result of entering  negative quantities.


{:.example}
If the total amount of a purchase return document  becomes negative, it in effect becomes a purchase return document, which  is not allowed to change its character as the result of entering negative  quantities.


Entering negative quantities are useful when purchase and purchase returns  are made on the same document.


{:.example}
Exchange of items sold.


Debit Quote


You can enter negative quantities directly in the **Quantity**  column of a debit quote.


Debit Order


You can enter negative quantities directly in the **Requested** column of a debit order.


Debit Memo

- **Non-inventoried 
 Items** - Enter the quantity prefixed with a negative (-) sign.
- **Inventoried 
 Items** - You can directly enter the quantity prefixed with a negative  sign only if the option **Use default stock 
 area to assign quantity for non-serialized items in debit documents**  (path: **File &gt; Setup &gt; Accounting 
 &gt; Location/Sub-Location &gt; Options &gt; Edit &gt; In New Window &gt; 
 Stock Transfer &gt; Miscellaneous** tab) is selected for the logged  in location/sub-location.



If this option is NOT selected, you must  enter the quantities in the **Attach Quantity**  profile (path: **Debit Memo** profile  > **Options &gt; Attach/Retrieve Serial 
 # &gt; Show/Attach area wise stock**).

- **Serialized/Auto-serialized/Inventoried 
 Items** - Negative quantities CANNOT be automatically assigned for  serialized/auto-serialized type of items. The serial numbers have to be  manually retrieved from 'Out' type of stock area (path: **Debit 
 Memo** profile > **Options &gt; 
 Attach/Retrieve Serial &gt; Serial Number/Serial # Range** > select  a serial number from ‘Out’ type of stock area).

