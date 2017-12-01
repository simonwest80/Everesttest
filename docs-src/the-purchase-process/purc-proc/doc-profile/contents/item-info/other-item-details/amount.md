---
title: amount
---

# Amount


The non-editable **Amount** column  displays the total payable for each line item. The system calculates the  Amount using the purchase document columns depending on whether the document  FOB Type is set to Origin or Destination:

- FOB Origin:
Amount = Cost after Discount \* Quantity
- FOB Destination:
Amount = (Cost after Discount \* Quantity) + Add-on Amount



The system uses the following quantities in the calculation:

- Ordered quantity  on a purchase order
- Received quantity  on a purchase receipt
- Received on  Invoice quantity on a purchase invoice using the Received view (in the  options menu)
- Invoiced quantity  on a purchase invoice using the Invoice view (in the options menu)



Purchase Documents


The Amount column displays the net purchase amount for the item purchased.


Purchase Return Documents


The Amount column displays the net value of the item returned.


View in Document Currency


The amount is displayed, by default, in the currency defined for the  selected vendor. If the vendor's currency is different from the base currency,  use the **View in Document Currency**  option to view the amount (path: **Options** > **View in Document Currency**)  in the base currency.


Select the same option to view the amount in foreign currency.


{:.see_also}
See also
: [Foreign  Currency Documents]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/tabs/details/for-cur-info/foreign_currency_document.html)
: [Item Information]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/item-info/item_information_pp.html)
: [Measure]({{site.mi_chm}}/item-profile-details/other-items-information/purchase/measure_pur.html)
